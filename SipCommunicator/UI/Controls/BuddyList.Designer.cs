namespace SipCommunicator.UI.Controls
{
    partial class BuddyList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bob");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("JiYanLi");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("XiaoHong");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("XiaoZha");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Who");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Friends", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Work");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Home");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuddyList));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buddyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instantMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingSourceSipAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.buddyContextMenuStrip.SuspendLayout();
            this.groupContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSipAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.buddyContextMenuStrip;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageKey = "11 - 复制 (2).png";
            treeNode1.Name = "节点2";
            treeNode1.Text = "Bob";
            treeNode2.ImageKey = "11 - 复制 (2).png";
            treeNode2.Name = "节点4";
            treeNode2.Text = "JiYanLi";
            treeNode3.ImageKey = "11 - 复制 (2).png";
            treeNode3.Name = "节点5";
            treeNode3.Text = "XiaoHong";
            treeNode4.ImageKey = "11 - 复制 (2).png";
            treeNode4.Name = "节点6";
            treeNode4.Text = "XiaoZha";
            treeNode5.ImageKey = "04.png";
            treeNode5.Name = "节点7";
            treeNode5.Text = "Who";
            treeNode6.Name = "节点0";
            treeNode6.Text = "Friends";
            treeNode7.Name = "节点1";
            treeNode7.Text = "Work";
            treeNode8.Name = "节点2";
            treeNode8.Text = "Home";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(197, 274);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // buddyContextMenuStrip
            // 
            this.buddyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callToolStripMenuItem,
            this.instantMessageToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.buddyContextMenuStrip.Name = "buddyContextMenuStrip";
            this.buddyContextMenuStrip.Size = new System.Drawing.Size(161, 98);
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.callToolStripMenuItem.Text = "&Call";
            // 
            // instantMessageToolStripMenuItem
            // 
            this.instantMessageToolStripMenuItem.Name = "instantMessageToolStripMenuItem";
            this.instantMessageToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.instantMessageToolStripMenuItem.Text = "&Instant Message";
            this.instantMessageToolStripMenuItem.Click += new System.EventHandler(this.instantMessageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "04.png");
            this.imageList1.Images.SetKeyName(1, "11 - 复制 (2).png");
            this.imageList1.Images.SetKeyName(2, "conference_48.png");
            // 
            // groupContextMenuStrip
            // 
            this.groupContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editGroupToolStripMenuItem,
            this.deleteGroupToolStripMenuItem,
            this.toolStripSeparator2});
            this.groupContextMenuStrip.Name = "groupContextMenuStrip";
            this.groupContextMenuStrip.Size = new System.Drawing.Size(143, 76);
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editGroupToolStripMenuItem
            // 
            this.editGroupToolStripMenuItem.Name = "editGroupToolStripMenuItem";
            this.editGroupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editGroupToolStripMenuItem.Text = "&Edit Group";
            // 
            // deleteGroupToolStripMenuItem
            // 
            this.deleteGroupToolStripMenuItem.Name = "deleteGroupToolStripMenuItem";
            this.deleteGroupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteGroupToolStripMenuItem.Text = "&Delete Group";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // bindingSourceSipAccounts
            // 
            this.bindingSourceSipAccounts.DataSource = typeof(SipCommunicator.Sip.SipAccountConfig);
            this.bindingSourceSipAccounts.CurrentChanged += new System.EventHandler(this.bindingSourceSipAccounts_CurrentChanged);
            // 
            // BuddyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "BuddyList";
            this.Size = new System.Drawing.Size(197, 274);
            this.buddyContextMenuStrip.ResumeLayout(false);
            this.groupContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSipAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip buddyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instantMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip groupContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource bindingSourceSipAccounts;
    }
}
