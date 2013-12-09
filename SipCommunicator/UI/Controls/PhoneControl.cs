using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Sipek.Common;
using WaveLib.AudioMixer;
using Sipek.Common.CallControl;
using System.Diagnostics;
using IC.Controls;

namespace SipCommunicator.UI.Controls
{
    public partial class PhoneControl : UserControl
    {
        private SipekResources sipResource;
        private IStateMachine _call = null;
        private const string ReadyForCall = "Ready";

        public SipekResources SipResource
        {
            get { return sipResource; }
            set 
            { 
                sipResource = value; 
                loadSipResource();
            }
        }

        public PhoneControl()
        {
            InitializeComponent();
        }

        private void PhoneControl_Load(object sender, EventArgs e)
        {
            numberPad.NumberKeyPressed += new EventHandler<IC.Controls.NumberPadEventArgs>(numberPad_NumberKeyPressed);
            LoadAudioValues();
            aaToolStripButton.Checked = Properties.Settings.Default.AAFlag;
            //acToolStripButton.Checked = Properties.Settings.Default.AATimeout;
            dndToolStripButton.Checked = Properties.Settings.Default.DNDFlag;
            incommingCallForm.AnswerClick += new DIncomingCallNotification(incommingCallForm_AnswerClick);
            incommingCallForm.IgnoreClick += new DIncomingCallNotification(incommingCallForm_IgnoreClick);
        }

        void incommingCallForm_IgnoreClick(int sessionId, string number, string info)
        {
            sipResource.CallManager.onUserRelease(sessionId);
        }

        void incommingCallForm_AnswerClick(int sessionId, string number, string info)
        {
            _call = sipResource.CallManager.getCall(sessionId);
            if (string.IsNullOrEmpty(info))
            {
                numberLabel.Text = number;
            }
            else
            {
                numberLabel.Text = info + "\n" + number;
            }
            sipResource.CallManager.onUserAnswer(sessionId);
        }

        private void loadSipResource()
        {
            if (sipResource == null)
            {
                return;
            }
            sipResource.CallManager.CallStateRefresh += CallManager_CallStateRefresh;
            sipResource.CallManager.IncomingCallNotification += new DIncomingCallNotification(CallManager_IncomingCallNotification);
            sipResource.Registrar.AccountStateChanged += new DAccountStateChanged(Registrar_AccountStateChanged);
            // Initialize and set factory for CallManager

            int status = sipResource.CallManager.Initialize();
            sipResource.CallManager.CallLogger = sipResource.CallLogger;

            if (status != 0)
            {
                MessageBox.Show(Properties.LocalizedStrings.Message_SipStackInitializeError + "\r\nStatus code " + status, Properties.LocalizedStrings.Message_InitializeError);
                return;
            }

            // set codecs priority...
            // initialize/reset codecs - enable PCMU and PCMA only
            int noOfCodecs = sipResource.StackProxy.getNoOfCodecs();
            for (int i = 0; i < noOfCodecs; i++)
            {
                string codecname = sipResource.StackProxy.getCodec(i);
                if (sipResource.Configurator.CodecList.Contains(codecname))
                {
                    // leave default
                    sipResource.StackProxy.setCodecPriority(codecname, 128);
                }
                else
                {
                    // disable
                    sipResource.StackProxy.setCodecPriority(codecname, 0);
                }
            }

            //if (this.sipUsersBindingSource.Count > 0)
            //{
            //    this.sipUsersComboBox.SelectedIndex = 0;
            //    setCurrentSipAccout();
            //}
        }

        #region Audio control

        private Mixers mMixers;
        private bool mAvoidEvents = false;

        private void LoadAudioValues()
        {
            try
            {
                mMixers = new Mixers();
            }
            catch (Exception e)
            {
                ///report error
                MessageBox.Show(Properties.LocalizedStrings.Message_AudioMixerInitializeError, Properties.LocalizedStrings.Message_InitializeError + e.Message);
                return;
            }
            // set callback
            mMixers.Playback.MixerLineChanged += new WaveLib.AudioMixer.Mixer.MixerLineChangeHandler(mMixer_MixerLineChanged);
            mMixers.Recording.MixerLineChanged += new WaveLib.AudioMixer.Mixer.MixerLineChangeHandler(mMixer_MixerLineChanged);
            MixerLine pbline = mMixers.Playback.UserLines.GetMixerFirstLineByComponentType(MIXERLINE_COMPONENTTYPE.SRC_WAVEOUT);

            this.volumeTrackBar.Tag = pbline;
            this.muteButton.Tag = pbline;
            MixerLine recline = mMixers.Recording.UserLines.GetMixerFirstLineByComponentType(MIXERLINE_COMPONENTTYPE.SRC_MICROPHONE); ;
            micMuteButton.Tag = recline;

            //If it is 2 channels then ask both and set the volume to the bigger but keep relation between them (Balance)
            int volume = 0;
            float balance = 0;
            if (pbline.Channels != 2)
                volume = pbline.Volume;
            else
            {
                pbline.Channel = Channel.Left;
                int left = pbline.Volume;
                pbline.Channel = Channel.Right;
                int right = pbline.Volume;
                if (left > right)
                {
                    volume = left;
                    balance = (volume > 0) ? -(1 - (right / (float)left)) : 0;
                }
                else
                {
                    volume = right;
                    balance = (volume > 0) ? (1 - (left / (float)right)) : 0;
                }
            }

            if (volume >= 0)
                this.volumeTrackBar.Value = volume;
            else
                this.volumeTrackBar.Enabled = false;

            // toolstrip checkboxes
            this.muteButton.ButtonToggled = pbline.Mute;
            this.micMuteButton.ButtonToggled = recline.Volume == 0 ? true : false;
            _lastMicVol = recline.Volume;
        }

        /// <summary>
        /// Callback from Windows Volume Control
        /// </summary>
        /// <param name="mixer"></param>
        /// <param name="line"></param>
        private void mMixer_MixerLineChanged(Mixer mixer, MixerLine line)
        {
            mAvoidEvents = true;

            try
            {
                float balance = -1;
                MixerLine frontEndLine = (MixerLine)volumeTrackBar.Tag;
                if (frontEndLine == line)
                {
                    int volume = 0;
                    if (line.Channels != 2)
                        volume = line.Volume;
                    else
                    {
                        line.Channel = Channel.Left;
                        int left = line.Volume;
                        line.Channel = Channel.Right;
                        int right = line.Volume;
                        if (left > right)
                        {
                            volume = left;
                            // TIP: Do not reset the balance if both left and right channel have 0 value
                            if (left != 0 && right != 0)
                                balance = (volume > 0) ? -(1 - (right / (float)left)) : 0;
                        }
                        else
                        {
                            volume = right;
                            // TIP: Do not reset the balance if both left and right channel have 0 value
                            if (left != 0 && right != 0)
                                balance = (volume > 0) ? 1 - (left / (float)right) : 0;
                        }
                    }

                    if (volume >= 0)
                        volumeTrackBar.Value = volume;

                }

                // adjust toolstrip checkboxes
                if ((MixerLine)micMuteButton.Tag == line)
                {
                    micMuteButton.ButtonToggled = line.Volume == 0 ? true : false;
                }
                else if ((MixerLine)muteButton.Tag == line)
                {
                    muteButton.ButtonToggled = line.Mute;
                }
            }
            finally
            {
                mAvoidEvents = false;
            }
        }

        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (mAvoidEvents)
                return;

            TrackBar tBar = (TrackBar)sender;
            MixerLine line = (MixerLine)tBar.Tag;
            if (line.Channels != 2)
            {
                // One channel or more than two let set the volume uniform
                line.Channel = Channel.Uniform;
                line.Volume = tBar.Value;
            }
            else
            {
                //Set independent volume
                line.Channel = Channel.Uniform;
                line.Volume = volumeTrackBar.Value;
            }
        }

        private int _lastMicVol = 0;

        private void muteButton_Click(object sender, EventArgs e)
        {
            ImageButton chkBox = (ImageButton)sender;
            MixerLine line = (MixerLine)chkBox.Tag;
            if (line.Direction == MixerType.Recording)
            {
                //line.Selected = chkBox.Checked;
                if (chkBox.ButtonToggled == true)
                {
                    _lastMicVol = line.Volume;
                    line.Volume = 0;
                }
                else
                {
                    line.Volume = _lastMicVol;
                }
            }
            else
            {
                line.Mute = chkBox.ButtonToggled;
            }

            if (line.Mute)
            {
                accountLabel.Text = Properties.LocalizedStrings.Speaker_Muted;
            }
            else
            {
                accountLabel.Text = Properties.LocalizedStrings.Speaker_Unmuted;
            }
        }
        #endregion

        #region sipResource event handlers
        void Registrar_AccountStateChanged(int accountId, int accState)
        {

            if (InvokeRequired)
                this.BeginInvoke(new DAccountStateChanged(OnRegistrationUpdate), new object[] { accountId, accState });
            else
                OnRegistrationUpdate(accountId, accState);
        }

        delegate void DIncomingCall(int sessionId, string number, string info);

        void CallManager_IncomingCallNotification(int sessionId, string number, string info)
        {
            if (InvokeRequired)
                this.BeginInvoke(new DIncomingCall(this.OnIncomingCall), new object[] { sessionId, number, info });
            else
                OnIncomingCall(sessionId, number, info);
        }

        void CallManager_CallStateRefresh(int sessionId)
        {
            if (InvokeRequired)
                this.BeginInvoke(new DCallStateRefresh(OnCallStateUpdate), new object[] { sessionId });
            else
                OnCallStateUpdate(sessionId);
        }

        #endregion

        #region Synhronized callbacks
        private void OnRegistrationUpdate(int accountId, int accState)
        {
            Debug.WriteLine(string.Format("OnRegistrationUpdate({0},{1})",accountId.ToString(),accState.ToString()));
            if (accState == 200)
            {
                accountLabel.Text = Properties.LocalizedStrings.Status_YourNameIs + sipResource.Configurator.Accounts[accountId].DisplayName;
                callStatusLabel.Text = Properties.LocalizedStrings.CallState_Null;
                callButton.Enabled = true;
            }
            else if (accState == 0)
            {
                accountLabel.Text = Properties.LocalizedStrings.Status_Registring;
            }
            else
            {
                accountLabel.Text = Properties.LocalizedStrings.Status_RegistrationError +" " + accState.ToString();
            }
        }

        private void OnCallStateUpdate(int sessionId)
        {
            IStateMachine call = this.sipResource.CallManager.getCall(sessionId);
            switch (call.StateId)
            {
                case EStateId.ACTIVE:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Active;
                    holdToolStripButton.Enabled = true;
                    transferToolStripButton.Enabled = true;
                    break;
                case EStateId.ALERTING:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Alerting;
                    break;
                case EStateId.CONNECTING:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Connecting;
                    break;
                case EStateId.HOLDING:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Holding;
                    break;
                case EStateId.IDLE:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Idle;
                    break;
                case EStateId.INCOMING:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Incoming;
                    break;
                case EStateId.NULL:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Null;
                    break;
                case EStateId.RELEASED:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Released;
                    holdToolStripButton.Enabled = false;
                    transferToolStripButton.Enabled = false;
                    break;
                case EStateId.TERMINATED:
                    callStatusLabel.Text = Properties.LocalizedStrings.CallState_Terminated;
                    break;
                default:
                    break;
            }

            if (call.StateId == EStateId.NULL)
            {
                numberLabel.Text = string.Empty;
            }
            else if (call.StateId == EStateId.RELEASED)
            {
                numberLabel.Text = string.Empty;
            }
            else
            {
                if (string.IsNullOrEmpty(numberLabel.Text))
                {
                    numberLabel.Text = call.CallingNumber;
                }
            }
        }
        private IncommingCallForm incommingCallForm = new IncommingCallForm();
        private void OnIncomingCall(int sessionId, string number, string info)
        {
            this.BringToFront();
            incommingCallForm.ShowNotifier(sessionId, info, number);
            //IncommingCallForm form = new IncommingCallForm(number, 15000);
            //DialogResult result = form.ShowDialog();
            ////DialogResult result = MessageBox.Show("Incoming call from " + number + "!" + "\n\nAnswer the call?", "Sip Phone", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    _call = sipResource.CallManager.getCall(SessionId);
            //    this.callDestinationTextBox.Text = number;
            //    this.numberLabel.Text = number;
            //    sipResource.CallManager.onUserAnswer(SessionId);
            //}
            //else
            //{
            //    sipResource.CallManager.onUserRelease(SessionId);
            //}
        }

        #endregion

        #region UI event handlers
        void numberPad_NumberKeyPressed(object sender, IC.Controls.NumberPadEventArgs e)
        {
            //OnCallKeyPress(e.NumberKey);

            if (_call != null && _call.StateId == EStateId.ACTIVE)
            {
                sipResource.CallManager.onUserDialDigit(_call.Session, e.NumberKey, sipResource.Configurator.DtmfMode);
            }

            callDestinationTextBox.Text += e.NumberKey;
            numberLabel.Text += e.NumberKey;
        }

        public void OnCallKeyPress(char keyPressed)
        {
            Debug.WriteLine("KeyPressed: "+ keyPressed);
            if (keyPressed == '\b') // backspace
            {
                clearButton_Click(this, null);
            }
            else if (keyPressed == '\r') // enter
            {
                callButton_Click(this, null);
            }
            else
            {
                if (char.IsLetterOrDigit(keyPressed) || keyPressed == '@' || keyPressed == '.' || keyPressed == ':')
                {
                    numberPad_NumberKeyPressed(this, new IC.Controls.NumberPadEventArgs(new string(keyPressed, 1)));
                }
            }
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(callDestinationTextBox.Text) && isDefaultAccountRegistered())
            {
                switch (action)
                {
                    case ActionToExecute.Call:
                        _call = SipResource.CallManager.createOutboundCall(numberLabel.Text); 
                        break;
                    case ActionToExecute.Transfer:
                        sipResource.CallManager.onUserTransfer(_call.Session, numberLabel.Text);
                        accountLabel.Text = string.Empty;
                        action = ActionToExecute.Call;
                        break;
                    default:
                        break;
                }
                
            }
        }

        private bool isDefaultAccountRegistered()
        {
            if (sipResource.Configurator.Accounts != null && sipResource.Configurator.Accounts[sipResource.Configurator.DefaultAccountIndex].RegState == 200)
            {
                return true;
            }
            else
                return false;
        }

        private void hangupButton_Click(object sender, EventArgs e)
        {
            callDestinationTextBox.Text = string.Empty;
            numberLabel.Text = string.Empty;
            if (_call == null)
            {
                return;
            }
            SipResource.CallManager.onUserRelease(_call.Session);

        }
        
        private void aaToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button.Checked)
            {
                accountLabel.Text = Properties.LocalizedStrings.AutoAnswer_Enabled;
            }
            else
            {
                accountLabel.Text = Properties.LocalizedStrings.AutoAnswer_Disabled;
            }

            Properties.Settings.Default.AAFlag = aaToolStripButton.Checked;
        }

        private void acToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            //Properties.Settings.Default.AAFlag = aaToolStripButton.Checked;
        }

        private void dndToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;
            if (button.Checked)
            {
                accountLabel.Text = Properties.LocalizedStrings.DND_Enabled;
            }
            else
            {
                accountLabel.Text = Properties.LocalizedStrings.DND_Disabled;
            }
            Properties.Settings.Default.DNDFlag = dndToolStripButton.Checked;
        }

        private void flashButton_Click(object sender, EventArgs e)
        {
            numberLabel.Text = string.Empty;
        }

        private void redialButton_Click(object sender, EventArgs e)
        {
            if (_call != null && _call.StateId == EStateId.IDLE)
            {
                CCallRecord record = sipResource.CallLogger.getList().Peek();
                //OnCallKeyPress(record.Number);
                _call = sipResource.CallManager.createOutboundCall(record.Number);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numberLabel.Text))
            {
                numberLabel.Text = numberLabel.Text.Substring(0, numberLabel.Text.Length - 1);
            }
        }

        private void holdToolStripButton_Click(object sender, EventArgs e)
        {
            if (_call.StateId == EStateId.ACTIVE || _call.StateId == EStateId.HOLDING)
            {
                sipResource.CallManager.onUserHoldRetrieve(_call.Session);
            }
        }

        private void transferToolStripButton_Click(object sender, EventArgs e)
        {
            if (_call.StateId == EStateId.ACTIVE)
            {
                accountLabel.Text = Properties.LocalizedStrings.CallState_TransferPrompt;
                numberLabel.Text = string.Empty;
                action = ActionToExecute.Transfer;
                //sipResource.CallManager.onUserTransfer(_call.Session, numberLabel.Text);
            }
        }

        enum ActionToExecute
        {
            Call, Transfer
        }

        private ActionToExecute action = ActionToExecute.Call;

        private void line1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            if (button == null) return;

            if (button.Checked)
            {
                button.Image = Properties.Resources.PI_Diagona_Web_Application_04_06;
            }
            else
            {
                button.Image = Properties.Resources.PI_Diagona_Web_Application_04_09;
            }
        }

        #endregion
    }

}
