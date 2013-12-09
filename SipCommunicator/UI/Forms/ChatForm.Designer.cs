namespace SipCommunicator.UI.Forms
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.toolStripEx1 = new IC.Controls.ToolStripEx();
            this.chatInputRichTextBox = new IC.Controls.RichTextBoxEx();
            this.chatHistoryRichTextBox = new IC.Controls.RichTextBoxEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 3);
            this.toolStripEx1.ShadowColor = System.Drawing.Color.Silver;
            this.toolStripEx1.ShadowHeight = 3;
            this.toolStripEx1.Size = new System.Drawing.Size(444, 28);
            this.toolStripEx1.TabIndex = 4;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // chatInputRichTextBox
            // 
            this.chatInputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatInputRichTextBox.FollowClickedLinks = true;
            this.chatInputRichTextBox.Location = new System.Drawing.Point(0, 28);
            this.chatInputRichTextBox.Name = "chatInputRichTextBox";
            this.chatInputRichTextBox.Size = new System.Drawing.Size(444, 117);
            this.chatInputRichTextBox.TabIndex = 5;
            this.chatInputRichTextBox.Text = "";
            // 
            // chatHistoryRichTextBox
            // 
            this.chatHistoryRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.chatHistoryRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatHistoryRichTextBox.FollowClickedLinks = true;
            this.chatHistoryRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.chatHistoryRichTextBox.Name = "chatHistoryRichTextBox";
            this.chatHistoryRichTextBox.ReadOnly = true;
            this.chatHistoryRichTextBox.Size = new System.Drawing.Size(444, 184);
            this.chatHistoryRichTextBox.TabIndex = 6;
            this.chatHistoryRichTextBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chatHistoryRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chatInputRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripEx1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(444, 368);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 35);
            this.panel1.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(357, 6);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "&Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(267, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 368);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.Text = "Chat";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IC.Controls.ToolStripEx toolStripEx1;
        private IC.Controls.RichTextBoxEx chatInputRichTextBox;
        private IC.Controls.RichTextBoxEx chatHistoryRichTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSend;
    }
}