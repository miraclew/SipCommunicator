using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common;
using SipCommunicator.Sip;
using System.Runtime.InteropServices;
using System.Diagnostics;
using SipCommunicator.Utilities;

namespace SipCommunicator.UI.Forms
{
    public partial class MainForm : Form
    {
        #region Properties
        private Timer tmr = new Timer();  // Refresh Call List
        private EUserStatus _lastUserStatus = EUserStatus.AVAILABLE;
        private string HEADER_TEXT;

        private SipekResources _resources = null;
        private SipekResources SipekResources
        {
            get { return _resources; }
        }

        public bool IsInitialized
        {
            get { return SipekResources.StackProxy.IsInitialized; }
        }
        private System.Timers.Timer loginTimer = new System.Timers.Timer(2000);
        #endregion

        public MainForm()
        {
            InitializeComponent();
            this.Text = Program.ProgramWindowText;
            rightPanel.Visible = rightPanelToolStripMenuItem.Checked;
            myStatusButton.DropDownItems.Clear();

            ToolStripItem[] items = new ToolStripItem[statusToolStripMenuItem.DropDownItems.Count];
            statusToolStripMenuItem.DropDownItems.CopyTo(items,0);
            foreach (var item in items)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(item.Text, item.Image, changeStatusToolStripMenuItem_Click);
                menuItem.Tag = item.Tag;
                myStatusButton.DropDownItems.Add(menuItem);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create resource object containing SipekSdk and other Sipek related data
            _resources = new SipekResources(this);
            phoneControl1.SipResource = _resources;

            treeView1.Nodes[0].Nodes.Clear();
            treeView1.Nodes[1].Nodes.Clear();
            treeView1.Nodes[2].Nodes.Clear(); 
            treeView1.Nodes[3].Nodes.Clear();
            Stack<CCallRecord> records = _resources.CallLogger.getList();
            TreeNode node = null;
            foreach (var item in records)
            {
                string nodeText = item.Number + " (" + item.Count.ToString() + ")";
                switch (item.Type)
                {
                    case ECallType.EAll:                       
                        break;
                    case ECallType.EDialed:
                        node = treeView1.Nodes[1].Nodes.Add(nodeText);                       
                        break;
                    case ECallType.EMissed:
                        node = treeView1.Nodes[0].Nodes.Add(nodeText);
                        break;
                    case ECallType.EReceived:
                        node = treeView1.Nodes[2].Nodes.Add(nodeText);
                        break;
                    case ECallType.EUndefined:
                        node = treeView1.Nodes[3].Nodes.Add(nodeText);
                        break;
                    default:
                        break;
                }
                node.Tag = item;
            }

            loginTimer.Elapsed += new System.Timers.ElapsedEventHandler(loginTimer_Elapsed);
            loginTimer.Start();
        }

        public delegate void DLogin();

        void loginTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DLogin(login));
            }
            else
            {
                login();
            }
        }

        private void login()
        {
            login(true);
            loginTimer.Stop();
        }

        #region UI event handlers
        private void settingsButton_Click(object sender, EventArgs e)
        {
            PreferencesForm f = new PreferencesForm();
            f.ShowDialog();
        }

        private void callsDetailsButton_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = true;
            tabControl1.SelectTab(1);
        }

        private void myStatusMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sipAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsForm f = new AccountsForm();
            f.ShowDialog();
        }

        private void rightPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = (sender as ToolStripMenuItem).Checked;
        }

        private void contactsToolStripButton_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = true;
            tabControl1.SelectTab(0);
        }

        private void callsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stack<CCallRecord> records = SipekResources.CallLogger.getList();
            //SipekResources.CallLogger.
            CallDetailsForm f = new CallDetailsForm(_resources);
            f.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMainForm(!this.Visible);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void ShutdownVoIP()
        {
            if (IsInitialized)
            {
                SipekResources.CallLogger.save();
            }
            SipekResources.Configurator.Save();

            // shutdown stack
            SipekResources.CallManager.Shutdown();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case InterProcessCommunication.WM_COPYDATA:
                    string data = InterProcessCommunication.ReciveMessage(ref m);
                    processCopyData(data);
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private void processCopyData(string data)
        {
            string prefix = "-dial=";
            string protocolPrefix = "sip:";
            if (data.StartsWith(prefix+protocolPrefix))
            {
                string sipURL = data.Substring(prefix.Length);
                if (this.IsInitialized && sipStatus == DefaultAccountStatus.Logedin)
                {
                    this.Activate();
                    SipekResources.CallManager.createOutboundCall(sipURL);
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                showMainForm(false);
        }

        private void showMainForm(bool show)
        {
            this.Visible = show;
            if (show)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            else
            {
                notifyIcon.ShowBalloonTip(500);
            }
        }

        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SipAccountManager.Default.DefaultAcrcount == null)
            {
                MessageBox.Show(Properties.LocalizedStrings.Message_CreateAccountBeforeLogin);
                return;
            }

            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            switch (sipStatus)
            {
                case DefaultAccountStatus.Logedout:
                    login(true);
                    break;
                case DefaultAccountStatus.Loging:
                    break;
                case DefaultAccountStatus.Logedin:
                    login(false);
                    break;
                default:
                    break;
            }
        }

        private void login(bool login)
        {
            if (login)
            {
                //login
                if (sipStatus != DefaultAccountStatus.Logedout)
                {
                    return;
                }
                
                List<IAccount> sipAccounts = new List<IAccount>();
                sipAccounts.Add(SipAccountManager.Default.DefaultAcrcount);
                _resources.Configurator.Accounts = sipAccounts;
                userNameToolStripLabel.Text = _resources.Configurator.Accounts[_resources.Configurator.DefaultAccountIndex].DisplayName;

                int status = SipekResources.Registrar.registerAccounts();
                if (status == 1)
                {
                    loginToolStripMenuItem.Text = Properties.LocalizedStrings.MainForm_Logout;
                    sipStatus = DefaultAccountStatus.Logedin;
                    changeStatusToolStripMenuItem_Click(myStatusButton.DropDownItems[0], null);
                }
                else
                {
                    sipStatus = DefaultAccountStatus.Logedout;
                    changeStatusToolStripMenuItem_Click(myStatusButton.DropDownItems[myStatusButton.DropDownItems.Count - 1], null);
                }
            }
            else
            {
                //logoff
                if (sipStatus != DefaultAccountStatus.Logedin)
                {
                    return;
                }
                int status = SipekResources.Registrar.unregisterAccounts();
                if (status == 0)
                {
                    loginToolStripMenuItem.Text = Properties.LocalizedStrings.MainForm_Login;
                    sipStatus = DefaultAccountStatus.Logedout;
                    //callStatusLabel.Text = string.Empty;
                }
            }
        }

        private DefaultAccountStatus sipStatus = DefaultAccountStatus.Logedout;
        enum DefaultAccountStatus
        {
            Logedout, Loging, Logedin
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            ShutdownVoIP();
        }

        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                string tag = (string) item.Tag;
                EUserStatus status = (EUserStatus) int.Parse(tag);

                if (IsInitialized && SipekResources.Configurator.Accounts != null)
                {
                    SipekResources.Messenger.setStatus(SipekResources.Configurator.DefaultAccountIndex, status);
                }
                myStatusButton.Image = item.Image;
                myStatusButton.Text = item.Text;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            phoneControl1.OnCallKeyPress(e.KeyChar);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
