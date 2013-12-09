namespace SipCommunicator.UI.Forms
{
    partial class SipAccountEditorForm
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
            System.Windows.Forms.Label accountNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SipAccountEditorForm));
            System.Windows.Forms.Label displayNameLabel;
            System.Windows.Forms.Label domainNameLabel;
            System.Windows.Forms.Label hostNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label proxyAddressLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label transportModeLabel;
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.iAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.domainNameTextBox = new System.Windows.Forms.TextBox();
            this.hostNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.proxyAddressTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.transportModeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            accountNameLabel = new System.Windows.Forms.Label();
            displayNameLabel = new System.Windows.Forms.Label();
            domainNameLabel = new System.Windows.Forms.Label();
            hostNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            proxyAddressLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            transportModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iAccountBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            accountNameLabel.AccessibleDescription = null;
            accountNameLabel.AccessibleName = null;
            resources.ApplyResources(accountNameLabel, "accountNameLabel");
            accountNameLabel.Font = null;
            accountNameLabel.Name = "accountNameLabel";
            // 
            // displayNameLabel
            // 
            displayNameLabel.AccessibleDescription = null;
            displayNameLabel.AccessibleName = null;
            resources.ApplyResources(displayNameLabel, "displayNameLabel");
            displayNameLabel.Font = null;
            displayNameLabel.Name = "displayNameLabel";
            // 
            // domainNameLabel
            // 
            domainNameLabel.AccessibleDescription = null;
            domainNameLabel.AccessibleName = null;
            resources.ApplyResources(domainNameLabel, "domainNameLabel");
            domainNameLabel.Font = null;
            domainNameLabel.Name = "domainNameLabel";
            // 
            // hostNameLabel
            // 
            hostNameLabel.AccessibleDescription = null;
            hostNameLabel.AccessibleName = null;
            resources.ApplyResources(hostNameLabel, "hostNameLabel");
            hostNameLabel.Font = null;
            hostNameLabel.Name = "hostNameLabel";
            // 
            // passwordLabel
            // 
            passwordLabel.AccessibleDescription = null;
            passwordLabel.AccessibleName = null;
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Font = null;
            passwordLabel.Name = "passwordLabel";
            // 
            // proxyAddressLabel
            // 
            proxyAddressLabel.AccessibleDescription = null;
            proxyAddressLabel.AccessibleName = null;
            resources.ApplyResources(proxyAddressLabel, "proxyAddressLabel");
            proxyAddressLabel.Font = null;
            proxyAddressLabel.Name = "proxyAddressLabel";
            // 
            // userNameLabel
            // 
            userNameLabel.AccessibleDescription = null;
            userNameLabel.AccessibleName = null;
            resources.ApplyResources(userNameLabel, "userNameLabel");
            userNameLabel.Font = null;
            userNameLabel.Name = "userNameLabel";
            // 
            // transportModeLabel
            // 
            transportModeLabel.AccessibleDescription = null;
            transportModeLabel.AccessibleName = null;
            resources.ApplyResources(transportModeLabel, "transportModeLabel");
            transportModeLabel.Font = null;
            transportModeLabel.Name = "transportModeLabel";
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleDescription = null;
            this.cancelButton.AccessibleName = null;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.BackgroundImage = null;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = null;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.AccessibleDescription = null;
            this.okButton.AccessibleName = null;
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.BackgroundImage = null;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = null;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.AccessibleDescription = null;
            this.accountNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.accountNameTextBox, "accountNameTextBox");
            this.accountNameTextBox.BackgroundImage = null;
            this.accountNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "AccountName", true));
            this.accountNameTextBox.Font = null;
            this.accountNameTextBox.Name = "accountNameTextBox";
            // 
            // iAccountBindingSource
            // 
            this.iAccountBindingSource.DataSource = typeof(Sipek.Common.IAccount);
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.AccessibleDescription = null;
            this.displayNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.displayNameTextBox, "displayNameTextBox");
            this.displayNameTextBox.BackgroundImage = null;
            this.displayNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "DisplayName", true));
            this.displayNameTextBox.Font = null;
            this.displayNameTextBox.Name = "displayNameTextBox";
            // 
            // domainNameTextBox
            // 
            this.domainNameTextBox.AccessibleDescription = null;
            this.domainNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.domainNameTextBox, "domainNameTextBox");
            this.domainNameTextBox.BackgroundImage = null;
            this.domainNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "DomainName", true));
            this.domainNameTextBox.Font = null;
            this.domainNameTextBox.Name = "domainNameTextBox";
            // 
            // hostNameTextBox
            // 
            this.hostNameTextBox.AccessibleDescription = null;
            this.hostNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.hostNameTextBox, "hostNameTextBox");
            this.hostNameTextBox.BackgroundImage = null;
            this.hostNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "HostName", true));
            this.hostNameTextBox.Font = null;
            this.hostNameTextBox.Name = "hostNameTextBox";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AccessibleDescription = null;
            this.passwordTextBox.AccessibleName = null;
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.BackgroundImage = null;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "Password", true));
            this.passwordTextBox.Font = null;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // proxyAddressTextBox
            // 
            this.proxyAddressTextBox.AccessibleDescription = null;
            this.proxyAddressTextBox.AccessibleName = null;
            resources.ApplyResources(this.proxyAddressTextBox, "proxyAddressTextBox");
            this.proxyAddressTextBox.BackgroundImage = null;
            this.proxyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "ProxyAddress", true));
            this.proxyAddressTextBox.Font = null;
            this.proxyAddressTextBox.Name = "proxyAddressTextBox";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.AccessibleDescription = null;
            this.userNameTextBox.AccessibleName = null;
            resources.ApplyResources(this.userNameTextBox, "userNameTextBox");
            this.userNameTextBox.BackgroundImage = null;
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "UserName", true));
            this.userNameTextBox.Font = null;
            this.userNameTextBox.Name = "userNameTextBox";
            // 
            // transportModeComboBox
            // 
            this.transportModeComboBox.AccessibleDescription = null;
            this.transportModeComboBox.AccessibleName = null;
            resources.ApplyResources(this.transportModeComboBox, "transportModeComboBox");
            this.transportModeComboBox.BackgroundImage = null;
            this.transportModeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iAccountBindingSource, "TransportMode", true));
            this.transportModeComboBox.Font = null;
            this.transportModeComboBox.FormattingEnabled = true;
            this.transportModeComboBox.Name = "transportModeComboBox";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(displayNameLabel);
            this.groupBox1.Controls.Add(transportModeLabel);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.transportModeComboBox);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.proxyAddressTextBox);
            this.groupBox1.Controls.Add(proxyAddressLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.displayNameTextBox);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(domainNameLabel);
            this.groupBox1.Controls.Add(this.hostNameTextBox);
            this.groupBox1.Controls.Add(this.domainNameTextBox);
            this.groupBox1.Controls.Add(hostNameLabel);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SipAccountEditorForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(accountNameLabel);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Font = null;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SipAccountEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.iAccountBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.BindingSource iAccountBindingSource;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.TextBox domainNameTextBox;
        private System.Windows.Forms.TextBox hostNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox proxyAddressTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ComboBox transportModeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}