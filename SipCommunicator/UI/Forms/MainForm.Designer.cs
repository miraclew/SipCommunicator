namespace SipCommunicator.UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.phonePanel = new System.Windows.Forms.Panel();
            this.phoneControl1 = new SipCommunicator.UI.Controls.PhoneControl();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buddyList1 = new SipCommunicator.UI.Controls.BuddyList();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.callLogContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.userNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.myStatusButton = new System.Windows.Forms.ToolStripSplitButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sipAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.callsButton = new System.Windows.Forms.ToolStripButton();
            this.contactsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onThePhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beRightBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundPanel.SuspendLayout();
            this.phonePanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.callLogContextMenuStrip.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            resources.ApplyResources(this.backgroundPanel, "backgroundPanel");
            this.backgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPanel.Controls.Add(this.phonePanel);
            this.backgroundPanel.Controls.Add(this.rightPanel);
            this.backgroundPanel.Name = "backgroundPanel";
            // 
            // phonePanel
            // 
            this.phonePanel.BackColor = System.Drawing.Color.Transparent;
            this.phonePanel.Controls.Add(this.phoneControl1);
            resources.ApplyResources(this.phonePanel, "phonePanel");
            this.phonePanel.Name = "phonePanel";
            // 
            // phoneControl1
            // 
            resources.ApplyResources(this.phoneControl1, "phoneControl1");
            this.phoneControl1.Name = "phoneControl1";
            this.phoneControl1.SipResource = null;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Controls.Add(this.tabControl1);
            this.rightPanel.Controls.Add(this.toolStrip2);
            resources.ApplyResources(this.rightPanel, "rightPanel");
            this.rightPanel.Name = "rightPanel";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buddyList1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buddyList1
            // 
            resources.ApplyResources(this.buddyList1, "buddyList1");
            this.buddyList1.Name = "buddyList1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.callLogContextMenuStrip;
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes2"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeView1.Nodes3")))});
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // callLogContextMenuStrip
            // 
            this.callLogContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callToolStripMenuItem,
            this.saveToContactsToolStripMenuItem});
            this.callLogContextMenuStrip.Name = "callLogContextMenuStrip";
            resources.ApplyResources(this.callLogContextMenuStrip, "callLogContextMenuStrip");
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            resources.ApplyResources(this.callToolStripMenuItem, "callToolStripMenuItem");
            // 
            // saveToContactsToolStripMenuItem
            // 
            this.saveToContactsToolStripMenuItem.Name = "saveToContactsToolStripMenuItem";
            resources.ApplyResources(this.saveToContactsToolStripMenuItem, "saveToContactsToolStripMenuItem");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "contacts.png");
            this.imageList1.Images.SetKeyName(1, "telephone_16.png");
            this.imageList1.Images.SetKeyName(2, "phone_call.png");
            this.imageList1.Images.SetKeyName(3, "phone_pick_up.png");
            this.imageList1.Images.SetKeyName(4, "phone_recall.png");
            this.imageList1.Images.SetKeyName(5, "phone_redirect.png");
            this.imageList1.Images.SetKeyName(6, "phone_reject.png");
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameToolStripLabel,
            this.myStatusButton});
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Name = "toolStrip2";
            // 
            // userNameToolStripLabel
            // 
            this.userNameToolStripLabel.Name = "userNameToolStripLabel";
            resources.ApplyResources(this.userNameToolStripLabel, "userNameToolStripLabel");
            // 
            // myStatusButton
            // 
            this.myStatusButton.Image = global::SipCommunicator.Properties.Resources.user2_16;
            resources.ApplyResources(this.myStatusButton, "myStatusButton");
            this.myStatusButton.Name = "myStatusButton";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.sipAccountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            resources.ApplyResources(this.loginToolStripMenuItem, "loginToolStripMenuItem");
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sipAccountToolStripMenuItem
            // 
            this.sipAccountToolStripMenuItem.Name = "sipAccountToolStripMenuItem";
            resources.ApplyResources(this.sipAccountToolStripMenuItem, "sipAccountToolStripMenuItem");
            this.sipAccountToolStripMenuItem.Click += new System.EventHandler(this.sipAccountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightPanelToolStripMenuItem,
            this.toolStripSeparator3,
            this.contactsToolStripMenuItem,
            this.callsToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            resources.ApplyResources(this.viewToolStripMenuItem1, "viewToolStripMenuItem1");
            // 
            // rightPanelToolStripMenuItem
            // 
            this.rightPanelToolStripMenuItem.CheckOnClick = true;
            this.rightPanelToolStripMenuItem.Name = "rightPanelToolStripMenuItem";
            resources.ApplyResources(this.rightPanelToolStripMenuItem, "rightPanelToolStripMenuItem");
            this.rightPanelToolStripMenuItem.Click += new System.EventHandler(this.rightPanelToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            resources.ApplyResources(this.contactsToolStripMenuItem, "contactsToolStripMenuItem");
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripButton_Click);
            // 
            // callsToolStripMenuItem
            // 
            this.callsToolStripMenuItem.Name = "callsToolStripMenuItem";
            resources.ApplyResources(this.callsToolStripMenuItem, "callsToolStripMenuItem");
            this.callsToolStripMenuItem.Click += new System.EventHandler(this.callsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            resources.ApplyResources(this.onlineHelpToolStripMenuItem, "onlineHelpToolStripMenuItem");
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsButton,
            this.toolStripSeparator2,
            this.callsButton,
            this.contactsToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::SipCommunicator.Properties.Resources.settings;
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // callsButton
            // 
            resources.ApplyResources(this.callsButton, "callsButton");
            this.callsButton.Name = "callsButton";
            this.callsButton.Click += new System.EventHandler(this.callsDetailsButton_Click);
            // 
            // contactsToolStripButton
            // 
            this.contactsToolStripButton.Image = global::SipCommunicator.Properties.Resources.contacts;
            resources.ApplyResources(this.contactsToolStripButton, "contactsToolStripButton");
            this.contactsToolStripButton.Name = "contactsToolStripButton";
            this.contactsToolStripButton.Click += new System.EventHandler(this.contactsToolStripButton_Click);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.toolStripMenuItem1});
            this.notifyIconContextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.notifyIconContextMenuStrip, "notifyIconContextMenuStrip");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            resources.ApplyResources(this.registerToolStripMenuItem, "registerToolStripMenuItem");
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.availableToolStripMenuItem,
            this.busyToolStripMenuItem,
            this.onThePhoneToolStripMenuItem,
            this.idleToolStripMenuItem,
            this.awayToolStripMenuItem,
            this.beRightBackToolStripMenuItem,
            this.offlineToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            resources.ApplyResources(this.statusToolStripMenuItem, "statusToolStripMenuItem");
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_02;
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            resources.ApplyResources(this.availableToolStripMenuItem, "availableToolStripMenuItem");
            this.availableToolStripMenuItem.Tag = "0";
            this.availableToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // busyToolStripMenuItem
            // 
            this.busyToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_01;
            this.busyToolStripMenuItem.Name = "busyToolStripMenuItem";
            resources.ApplyResources(this.busyToolStripMenuItem, "busyToolStripMenuItem");
            this.busyToolStripMenuItem.Tag = "1";
            this.busyToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // onThePhoneToolStripMenuItem
            // 
            this.onThePhoneToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_04;
            this.onThePhoneToolStripMenuItem.Name = "onThePhoneToolStripMenuItem";
            resources.ApplyResources(this.onThePhoneToolStripMenuItem, "onThePhoneToolStripMenuItem");
            this.onThePhoneToolStripMenuItem.Tag = "2";
            this.onThePhoneToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // idleToolStripMenuItem
            // 
            this.idleToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_03;
            this.idleToolStripMenuItem.Name = "idleToolStripMenuItem";
            resources.ApplyResources(this.idleToolStripMenuItem, "idleToolStripMenuItem");
            this.idleToolStripMenuItem.Tag = "3";
            this.idleToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_05;
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            resources.ApplyResources(this.awayToolStripMenuItem, "awayToolStripMenuItem");
            this.awayToolStripMenuItem.Tag = "4";
            this.awayToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // beRightBackToolStripMenuItem
            // 
            this.beRightBackToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_08;
            this.beRightBackToolStripMenuItem.Name = "beRightBackToolStripMenuItem";
            resources.ApplyResources(this.beRightBackToolStripMenuItem, "beRightBackToolStripMenuItem");
            this.beRightBackToolStripMenuItem.Tag = "5";
            this.beRightBackToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.Image = global::SipCommunicator.Properties.Resources.PI_Diagona_Web_Application_04_10;
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            resources.ApplyResources(this.offlineToolStripMenuItem, "offlineToolStripMenuItem");
            this.offlineToolStripMenuItem.Tag = "6";
            this.offlineToolStripMenuItem.Click += new System.EventHandler(this.changeStatusToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SipCommunicator.Properties.Resources.bg02;
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.backgroundPanel.ResumeLayout(false);
            this.phonePanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.callLogContextMenuStrip.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel backgroundPanel;
        private System.Windows.Forms.Panel phonePanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripButton callsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private SipCommunicator.UI.Controls.PhoneControl phoneControl1;
        private SipCommunicator.UI.Controls.BuddyList buddyList1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sipAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton contactsToolStripButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onThePhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beRightBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip callLogContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSplitButton myStatusButton;
        private System.Windows.Forms.ToolStripLabel userNameToolStripLabel;
    }
}