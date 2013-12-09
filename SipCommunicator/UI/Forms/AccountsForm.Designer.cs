namespace SipCommunicator.UI.Forms
{
    partial class AccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsForm));
            this.sipAccountsDataGrid = new VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid();
            this.addNewAccountButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSourceSipAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.isDefaultColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sipAccountsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSipAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // sipAccountsDataGrid
            // 
            this.sipAccountsDataGrid.AccessibleDescription = null;
            this.sipAccountsDataGrid.AccessibleName = null;
            this.sipAccountsDataGrid.AllowUserToAddRows = false;
            this.sipAccountsDataGrid.AllowUserToResizeRows = false;
            resources.ApplyResources(this.sipAccountsDataGrid, "sipAccountsDataGrid");
            this.sipAccountsDataGrid.AutoGenerateColumns = false;
            this.sipAccountsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.sipAccountsDataGrid.BackgroundImage = null;
            this.sipAccountsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sipAccountsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sipAccountsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sipAccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sipAccountsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isDefaultColumn,
            this.indexDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.hostNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.displayNameDataGridViewTextBoxColumn,
            this.domainNameDataGridViewTextBoxColumn,
            this.regStateDataGridViewTextBoxColumn,
            this.proxyAddressDataGridViewTextBoxColumn,
            this.transportModeDataGridViewTextBoxColumn});
            this.sipAccountsDataGrid.DataSource = this.bindingSourceSipAccounts;
            this.sipAccountsDataGrid.Font = null;
            this.sipAccountsDataGrid.MultiSelect = false;
            this.sipAccountsDataGrid.Name = "sipAccountsDataGrid";
            this.sipAccountsDataGrid.ReadOnly = true;
            this.sipAccountsDataGrid.RowHeadersVisible = false;
            this.sipAccountsDataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sipAccountsDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(244)))));
            this.sipAccountsDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.sipAccountsDataGrid.RowTemplate.Height = 32;
            this.sipAccountsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sipAccountsDataGrid.ShowDeleteColumn = true;
            this.sipAccountsDataGrid.ShowEditColumn = true;
            this.sipAccountsDataGrid.DeleteDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.sipAccountsDataGrid_DeleteDataRow);
            this.sipAccountsDataGrid.EditDataRow += new System.EventHandler<VisualAsterisk.Manager.Controls.DataRowEventArgs>(this.sipAccountsDataGrid_EditDataRow);
            this.sipAccountsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sipAccountsDataGrid_CellContentClick);
            // 
            // addNewAccountButton
            // 
            this.addNewAccountButton.AccessibleDescription = null;
            this.addNewAccountButton.AccessibleName = null;
            resources.ApplyResources(this.addNewAccountButton, "addNewAccountButton");
            this.addNewAccountButton.BackgroundImage = null;
            this.addNewAccountButton.Font = null;
            this.addNewAccountButton.Name = "addNewAccountButton";
            this.addNewAccountButton.UseVisualStyleBackColor = true;
            this.addNewAccountButton.Click += new System.EventHandler(this.addNewAccountButton_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = null;
            this.button2.AccessibleName = null;
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = null;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = null;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bindingSourceSipAccounts
            // 
            this.bindingSourceSipAccounts.DataSource = typeof(SipCommunicator.Sip.SipAccountConfig);
            // 
            // isDefaultColumn
            // 
            this.isDefaultColumn.DataPropertyName = "IsDefault";
            resources.ApplyResources(this.isDefaultColumn, "isDefaultColumn");
            this.isDefaultColumn.Name = "isDefaultColumn";
            this.isDefaultColumn.ReadOnly = true;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            resources.ApplyResources(this.indexDataGridViewTextBoxColumn, "indexDataGridViewTextBoxColumn");
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            resources.ApplyResources(this.accountNameDataGridViewTextBoxColumn, "accountNameDataGridViewTextBoxColumn");
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            this.accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostNameDataGridViewTextBoxColumn
            // 
            this.hostNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hostNameDataGridViewTextBoxColumn.DataPropertyName = "HostName";
            resources.ApplyResources(this.hostNameDataGridViewTextBoxColumn, "hostNameDataGridViewTextBoxColumn");
            this.hostNameDataGridViewTextBoxColumn.Name = "hostNameDataGridViewTextBoxColumn";
            this.hostNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            resources.ApplyResources(this.userNameDataGridViewTextBoxColumn, "userNameDataGridViewTextBoxColumn");
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            resources.ApplyResources(this.passwordDataGridViewTextBoxColumn, "passwordDataGridViewTextBoxColumn");
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            resources.ApplyResources(this.displayNameDataGridViewTextBoxColumn, "displayNameDataGridViewTextBoxColumn");
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            this.displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domainNameDataGridViewTextBoxColumn
            // 
            this.domainNameDataGridViewTextBoxColumn.DataPropertyName = "DomainName";
            resources.ApplyResources(this.domainNameDataGridViewTextBoxColumn, "domainNameDataGridViewTextBoxColumn");
            this.domainNameDataGridViewTextBoxColumn.Name = "domainNameDataGridViewTextBoxColumn";
            this.domainNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regStateDataGridViewTextBoxColumn
            // 
            this.regStateDataGridViewTextBoxColumn.DataPropertyName = "RegState";
            resources.ApplyResources(this.regStateDataGridViewTextBoxColumn, "regStateDataGridViewTextBoxColumn");
            this.regStateDataGridViewTextBoxColumn.Name = "regStateDataGridViewTextBoxColumn";
            this.regStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proxyAddressDataGridViewTextBoxColumn
            // 
            this.proxyAddressDataGridViewTextBoxColumn.DataPropertyName = "ProxyAddress";
            resources.ApplyResources(this.proxyAddressDataGridViewTextBoxColumn, "proxyAddressDataGridViewTextBoxColumn");
            this.proxyAddressDataGridViewTextBoxColumn.Name = "proxyAddressDataGridViewTextBoxColumn";
            this.proxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transportModeDataGridViewTextBoxColumn
            // 
            this.transportModeDataGridViewTextBoxColumn.DataPropertyName = "TransportMode";
            resources.ApplyResources(this.transportModeDataGridViewTextBoxColumn, "transportModeDataGridViewTextBoxColumn");
            this.transportModeDataGridViewTextBoxColumn.Name = "transportModeDataGridViewTextBoxColumn";
            this.transportModeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccountsForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addNewAccountButton);
            this.Controls.Add(this.sipAccountsDataGrid);
            this.Font = null;
            this.Icon = null;
            this.Name = "AccountsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.sipAccountsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSipAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualAsterisk.Manager.Controls.VisualAsteriskEditDataGrid sipAccountsDataGrid;
        private System.Windows.Forms.BindingSource bindingSourceSipAccounts;
        private System.Windows.Forms.Button addNewAccountButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDefaultColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportModeDataGridViewTextBoxColumn;
    }
}