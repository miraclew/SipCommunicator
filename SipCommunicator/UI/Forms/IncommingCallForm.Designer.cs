namespace SipCommunicator
{
    partial class IncommingCallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncommingCallForm));
            this.answerButton = new System.Windows.Forms.Button();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.gradientPanel1 = new IC.Controls.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            resources.ApplyResources(this.answerButton, "answerButton");
            this.answerButton.BackColor = System.Drawing.Color.Transparent;
            this.answerButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.answerButton.FlatAppearance.BorderSize = 0;
            this.answerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.answerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.answerButton.Image = global::SipCommunicator.Properties.Resources.phone_pick_up_24;
            this.answerButton.Name = "answerButton";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.BackColor = System.Drawing.Color.Transparent;
            this.ignoreButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ignoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ignoreButton.FlatAppearance.BorderSize = 0;
            this.ignoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ignoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.ignoreButton, "ignoreButton");
            this.ignoreButton.Image = global::SipCommunicator.Properties.Resources.phone_hang_up_24;
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.UseVisualStyleBackColor = false;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel1.BorderWidth = 1F;
            resources.ApplyResources(this.gradientPanel1, "gradientPanel1");
            this.gradientPanel1.DrawBorder = false;
            this.gradientPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(83)))), ((int)(((byte)(177)))));
            this.gradientPanel1.GradientAngle = 90F;
            this.gradientPanel1.Name = "gradientPanel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SipCommunicator.Properties.Resources.gif026;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numberLabel
            // 
            resources.ApplyResources(this.numberLabel, "numberLabel");
            this.numberLabel.Name = "numberLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(127)))), ((int)(((byte)(206)))));
            this.label3.Name = "label3";
            // 
            // IncommingCallForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(200)))), ((int)(((byte)(246)))));
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.answerButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncommingCallForm";
            this.Opacity = 0;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncommingCallForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Button ignoreButton;
        private IC.Controls.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label3;
    }
}