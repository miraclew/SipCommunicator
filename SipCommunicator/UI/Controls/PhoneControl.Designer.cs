namespace SipCommunicator.UI.Controls
{
    partial class PhoneControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneControl));
            this.callDestinationTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.transferToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.holdToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.aaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.acToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dndToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.numberPad = new IC.Controls.NumberPad();
            this.muteButton = new IC.Controls.ImageButton();
            this.micTrackBar = new IC.Controls.TrackBarEx();
            this.volumeTrackBar = new IC.Controls.TrackBarEx();
            this.hangupButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.micMuteButton = new IC.Controls.ImageButton();
            this.glassPanel1 = new IC.Controls.GlassPanel();
            this.numberLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.callStatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.redialButton = new System.Windows.Forms.Button();
            this.flashButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line3RadioButton = new System.Windows.Forms.RadioButton();
            this.line2RadioButton = new System.Windows.Forms.RadioButton();
            this.line1RadioButton = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.micMuteButton)).BeginInit();
            this.glassPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // callDestinationTextBox
            // 
            this.callDestinationTextBox.AccessibleDescription = null;
            this.callDestinationTextBox.AccessibleName = null;
            resources.ApplyResources(this.callDestinationTextBox, "callDestinationTextBox");
            this.callDestinationTextBox.BackgroundImage = null;
            this.callDestinationTextBox.Font = null;
            this.callDestinationTextBox.Name = "callDestinationTextBox";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = null;
            this.toolStrip1.AccessibleName = null;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = null;
            this.toolStrip1.Font = null;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripButton,
            this.holdToolStripButton,
            this.toolStripButton3,
            this.aaToolStripButton,
            this.acToolStripButton,
            this.dndToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Stretch = true;
            // 
            // transferToolStripButton
            // 
            this.transferToolStripButton.AccessibleDescription = null;
            this.transferToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.transferToolStripButton, "transferToolStripButton");
            this.transferToolStripButton.BackgroundImage = null;
            this.transferToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transferToolStripButton.Image = global::SipCommunicator.Properties.Resources.phone_redirect;
            this.transferToolStripButton.Name = "transferToolStripButton";
            this.transferToolStripButton.Click += new System.EventHandler(this.transferToolStripButton_Click);
            // 
            // holdToolStripButton
            // 
            this.holdToolStripButton.AccessibleDescription = null;
            this.holdToolStripButton.AccessibleName = null;
            resources.ApplyResources(this.holdToolStripButton, "holdToolStripButton");
            this.holdToolStripButton.BackgroundImage = null;
            this.holdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.holdToolStripButton.Image = global::SipCommunicator.Properties.Resources.phone_hold;
            this.holdToolStripButton.Name = "holdToolStripButton";
            this.holdToolStripButton.Click += new System.EventHandler(this.holdToolStripButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AccessibleDescription = null;
            this.toolStripButton3.AccessibleName = null;
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.BackgroundImage = null;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::SipCommunicator.Properties.Resources.media_record_red_16;
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // aaToolStripButton
            // 
            this.aaToolStripButton.AccessibleDescription = null;
            this.aaToolStripButton.AccessibleName = null;
            this.aaToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.aaToolStripButton, "aaToolStripButton");
            this.aaToolStripButton.BackgroundImage = null;
            this.aaToolStripButton.CheckOnClick = true;
            this.aaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aaToolStripButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.aaToolStripButton.Name = "aaToolStripButton";
            this.aaToolStripButton.CheckedChanged += new System.EventHandler(this.aaToolStripButton_CheckedChanged);
            // 
            // acToolStripButton
            // 
            this.acToolStripButton.AccessibleDescription = null;
            this.acToolStripButton.AccessibleName = null;
            this.acToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.acToolStripButton, "acToolStripButton");
            this.acToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.acToolStripButton.BackgroundImage = null;
            this.acToolStripButton.CheckOnClick = true;
            this.acToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.acToolStripButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.acToolStripButton.Name = "acToolStripButton";
            this.acToolStripButton.CheckedChanged += new System.EventHandler(this.acToolStripButton_CheckedChanged);
            // 
            // dndToolStripButton
            // 
            this.dndToolStripButton.AccessibleDescription = null;
            this.dndToolStripButton.AccessibleName = null;
            this.dndToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.dndToolStripButton, "dndToolStripButton");
            this.dndToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.dndToolStripButton.BackgroundImage = null;
            this.dndToolStripButton.CheckOnClick = true;
            this.dndToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dndToolStripButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dndToolStripButton.Name = "dndToolStripButton";
            this.dndToolStripButton.Click += new System.EventHandler(this.dndToolStripButton_Click);
            // 
            // numberPad
            // 
            this.numberPad.AccessibleDescription = null;
            this.numberPad.AccessibleName = null;
            resources.ApplyResources(this.numberPad, "numberPad");
            this.numberPad.BackgroundImage = null;
            this.numberPad.Font = null;
            this.numberPad.KeyPadding = 3;
            this.numberPad.Name = "numberPad";
            // 
            // muteButton
            // 
            this.muteButton.AccessibleDescription = null;
            this.muteButton.AccessibleName = null;
            resources.ApplyResources(this.muteButton, "muteButton");
            this.muteButton.BackgroundImage = null;
            this.muteButton.ButtonToggled = false;
            this.muteButton.Font = null;
            this.muteButton.HoverImage = global::SipCommunicator.Properties.Resources.Volume_Hot;
            this.muteButton.Image = global::SipCommunicator.Properties.Resources.Volume_Normal;
            this.muteButton.ImageLocation = null;
            this.muteButton.MouseDownImage = global::SipCommunicator.Properties.Resources.Volume_Pressed;
            this.muteButton.Name = "muteButton";
            this.muteButton.TabStop = false;
            this.muteButton.ToggleButton = true;
            this.muteButton.ToggleImage = global::SipCommunicator.Properties.Resources.Volume_Disabled;
            this.muteButton.ToggleMouseDownImage = global::SipCommunicator.Properties.Resources.Volume_Disabled;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // micTrackBar
            // 
            this.micTrackBar.AccessibleDescription = null;
            this.micTrackBar.AccessibleName = null;
            resources.ApplyResources(this.micTrackBar, "micTrackBar");
            this.micTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.micTrackBar.BackgroundImage = global::SipCommunicator.Properties.Resources.trkVolume_BackgroundImage;
            this.micTrackBar.Font = null;
            this.micTrackBar.MaxValue = 65535;
            this.micTrackBar.MinValue = 0;
            this.micTrackBar.Name = "micTrackBar";
            this.micTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.micTrackBar.TrackerCursor = System.Windows.Forms.Cursors.Default;
            this.micTrackBar.TrackerImage = global::SipCommunicator.Properties.Resources.trkVolume_TrackerImage;
            this.micTrackBar.Value = 0;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.AccessibleDescription = null;
            this.volumeTrackBar.AccessibleName = null;
            resources.ApplyResources(this.volumeTrackBar, "volumeTrackBar");
            this.volumeTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.BackgroundImage = global::SipCommunicator.Properties.Resources.trkVolume_BackgroundImage;
            this.volumeTrackBar.Font = null;
            this.volumeTrackBar.MaxValue = 65535;
            this.volumeTrackBar.MinValue = 0;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeTrackBar.TrackerCursor = System.Windows.Forms.Cursors.Default;
            this.volumeTrackBar.TrackerImage = global::SipCommunicator.Properties.Resources.trkVolume_TrackerImage;
            this.volumeTrackBar.Value = 0;
            // 
            // hangupButton
            // 
            this.hangupButton.AccessibleDescription = null;
            this.hangupButton.AccessibleName = null;
            resources.ApplyResources(this.hangupButton, "hangupButton");
            this.hangupButton.BackColor = System.Drawing.Color.Transparent;
            this.hangupButton.BackgroundImage = null;
            this.hangupButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hangupButton.Font = null;
            this.hangupButton.Image = global::SipCommunicator.Properties.Resources.phone_hang_up;
            this.hangupButton.Name = "hangupButton";
            this.hangupButton.UseVisualStyleBackColor = false;
            this.hangupButton.Click += new System.EventHandler(this.hangupButton_Click);
            // 
            // callButton
            // 
            this.callButton.AccessibleDescription = null;
            this.callButton.AccessibleName = null;
            resources.ApplyResources(this.callButton, "callButton");
            this.callButton.BackColor = System.Drawing.Color.Transparent;
            this.callButton.BackgroundImage = null;
            this.callButton.FlatAppearance.BorderSize = 0;
            this.callButton.Font = null;
            this.callButton.Image = global::SipCommunicator.Properties.Resources.phone_call;
            this.callButton.Name = "callButton";
            this.callButton.UseVisualStyleBackColor = false;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // micMuteButton
            // 
            this.micMuteButton.AccessibleDescription = null;
            this.micMuteButton.AccessibleName = null;
            resources.ApplyResources(this.micMuteButton, "micMuteButton");
            this.micMuteButton.BackgroundImage = null;
            this.micMuteButton.ButtonToggled = false;
            this.micMuteButton.Font = null;
            this.micMuteButton.HoverImage = global::SipCommunicator.Properties.Resources.Microphone_Hot;
            this.micMuteButton.Image = global::SipCommunicator.Properties.Resources.Microphone_Normal;
            this.micMuteButton.ImageLocation = null;
            this.micMuteButton.MouseDownImage = global::SipCommunicator.Properties.Resources.Microphone_Pressed;
            this.micMuteButton.Name = "micMuteButton";
            this.micMuteButton.TabStop = false;
            this.micMuteButton.ToggleButton = true;
            this.micMuteButton.ToggleImage = global::SipCommunicator.Properties.Resources.Microphone_Disabled;
            this.micMuteButton.ToggleMouseDownImage = global::SipCommunicator.Properties.Resources.Microphone_Disabled;
            // 
            // glassPanel1
            // 
            this.glassPanel1.AccessibleDescription = null;
            this.glassPanel1.AccessibleName = null;
            resources.ApplyResources(this.glassPanel1, "glassPanel1");
            this.glassPanel1.BackColor = System.Drawing.Color.Transparent;
            this.glassPanel1.BackgroundImage = null;
            this.glassPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.glassPanel1.BorderSize = 2;
            this.glassPanel1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.glassPanel1.Controls.Add(this.numberLabel);
            this.glassPanel1.Controls.Add(this.accountLabel);
            this.glassPanel1.Controls.Add(this.callStatusLabel);
            this.glassPanel1.Font = null;
            this.glassPanel1.Name = "glassPanel1";
            this.glassPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // numberLabel
            // 
            this.numberLabel.AccessibleDescription = null;
            this.numberLabel.AccessibleName = null;
            resources.ApplyResources(this.numberLabel, "numberLabel");
            this.numberLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberLabel.ForeColor = System.Drawing.Color.PaleGreen;
            this.numberLabel.Name = "numberLabel";
            // 
            // accountLabel
            // 
            this.accountLabel.AccessibleDescription = null;
            this.accountLabel.AccessibleName = null;
            resources.ApplyResources(this.accountLabel, "accountLabel");
            this.accountLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.accountLabel.Name = "accountLabel";
            // 
            // callStatusLabel
            // 
            this.callStatusLabel.AccessibleDescription = null;
            this.callStatusLabel.AccessibleName = null;
            resources.ApplyResources(this.callStatusLabel, "callStatusLabel");
            this.callStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.callStatusLabel.ForeColor = System.Drawing.Color.Tomato;
            this.callStatusLabel.Name = "callStatusLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.redialButton);
            this.groupBox1.Controls.Add(this.flashButton);
            this.groupBox1.Controls.Add(this.numberPad);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.AccessibleDescription = null;
            this.clearButton.AccessibleName = null;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.BackgroundImage = null;
            this.clearButton.Font = null;
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // redialButton
            // 
            this.redialButton.AccessibleDescription = null;
            this.redialButton.AccessibleName = null;
            resources.ApplyResources(this.redialButton, "redialButton");
            this.redialButton.BackgroundImage = null;
            this.redialButton.Font = null;
            this.redialButton.Name = "redialButton";
            this.redialButton.UseVisualStyleBackColor = true;
            this.redialButton.Click += new System.EventHandler(this.redialButton_Click);
            // 
            // flashButton
            // 
            this.flashButton.AccessibleDescription = null;
            this.flashButton.AccessibleName = null;
            resources.ApplyResources(this.flashButton, "flashButton");
            this.flashButton.BackgroundImage = null;
            this.flashButton.Font = null;
            this.flashButton.Name = "flashButton";
            this.flashButton.UseVisualStyleBackColor = true;
            this.flashButton.Click += new System.EventHandler(this.flashButton_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = null;
            this.panel1.Controls.Add(this.line3RadioButton);
            this.panel1.Controls.Add(this.line2RadioButton);
            this.panel1.Controls.Add(this.line1RadioButton);
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // line3RadioButton
            // 
            this.line3RadioButton.AccessibleDescription = null;
            this.line3RadioButton.AccessibleName = null;
            resources.ApplyResources(this.line3RadioButton, "line3RadioButton");
            this.line3RadioButton.BackgroundImage = null;
            this.line3RadioButton.Font = null;
            this.line3RadioButton.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_09;
            this.line3RadioButton.Name = "line3RadioButton";
            this.line3RadioButton.TabStop = true;
            this.line3RadioButton.UseVisualStyleBackColor = true;
            this.line3RadioButton.CheckedChanged += new System.EventHandler(this.line1RadioButton_CheckedChanged);
            // 
            // line2RadioButton
            // 
            this.line2RadioButton.AccessibleDescription = null;
            this.line2RadioButton.AccessibleName = null;
            resources.ApplyResources(this.line2RadioButton, "line2RadioButton");
            this.line2RadioButton.BackgroundImage = null;
            this.line2RadioButton.Font = null;
            this.line2RadioButton.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_09;
            this.line2RadioButton.Name = "line2RadioButton";
            this.line2RadioButton.TabStop = true;
            this.line2RadioButton.UseVisualStyleBackColor = true;
            this.line2RadioButton.CheckedChanged += new System.EventHandler(this.line1RadioButton_CheckedChanged);
            // 
            // line1RadioButton
            // 
            this.line1RadioButton.AccessibleDescription = null;
            this.line1RadioButton.AccessibleName = null;
            resources.ApplyResources(this.line1RadioButton, "line1RadioButton");
            this.line1RadioButton.BackgroundImage = null;
            this.line1RadioButton.Font = null;
            this.line1RadioButton.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_09;
            this.line1RadioButton.Name = "line1RadioButton";
            this.line1RadioButton.TabStop = true;
            this.line1RadioButton.UseVisualStyleBackColor = true;
            this.line1RadioButton.CheckedChanged += new System.EventHandler(this.line1RadioButton_CheckedChanged);
            // 
            // PhoneControl
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.micMuteButton);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.micTrackBar);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.glassPanel1);
            this.Controls.Add(this.hangupButton);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.callDestinationTextBox);
            this.Font = null;
            this.Name = "PhoneControl";
            this.Load += new System.EventHandler(this.PhoneControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.micMuteButton)).EndInit();
            this.glassPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox callDestinationTextBox;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button hangupButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton transferToolStripButton;
        private System.Windows.Forms.ToolStripButton holdToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton aaToolStripButton;
        private System.Windows.Forms.ToolStripButton acToolStripButton;
        private System.Windows.Forms.ToolStripButton dndToolStripButton;
        private global::IC.Controls.NumberPad numberPad;
        private global::IC.Controls.TrackBarEx volumeTrackBar;
        private global::IC.Controls.TrackBarEx micTrackBar;
        private IC.Controls.ImageButton muteButton;
        private IC.Controls.ImageButton micMuteButton;
        private IC.Controls.GlassPanel glassPanel1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label callStatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button redialButton;
        private System.Windows.Forms.Button flashButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton line1RadioButton;
        private System.Windows.Forms.RadioButton line3RadioButton;
        private System.Windows.Forms.RadioButton line2RadioButton;

    }
}
