namespace SipCommunicator.UI.Forms
{
    partial class AddContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContactForm));
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label displayNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sipAddressLabel;
            this.peoplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peoplesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.peoplesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sipAddressTextBox = new System.Windows.Forms.TextBox();
            addressLabel = new System.Windows.Forms.Label();
            displayNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sipAddressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peoplesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplesBindingNavigator)).BeginInit();
            this.peoplesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // peoplesBindingSource
            // 
            this.peoplesBindingSource.DataSource = typeof(SipCommunicator.Contacts.Contact);
            // 
            // peoplesBindingNavigator
            // 
            this.peoplesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peoplesBindingNavigator.BindingSource = this.peoplesBindingSource;
            this.peoplesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peoplesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.peoplesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.peoplesBindingNavigatorSaveItem});
            this.peoplesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peoplesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peoplesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peoplesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peoplesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peoplesBindingNavigator.Name = "peoplesBindingNavigator";
            this.peoplesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peoplesBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.peoplesBindingNavigator.TabIndex = 0;
            this.peoplesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // peoplesBindingNavigatorSaveItem
            // 
            this.peoplesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peoplesBindingNavigatorSaveItem.Enabled = false;
            this.peoplesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peoplesBindingNavigatorSaveItem.Image")));
            this.peoplesBindingNavigatorSaveItem.Name = "peoplesBindingNavigatorSaveItem";
            this.peoplesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.peoplesBindingNavigatorSaveItem.Text = "保存数据";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(37, 58);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(53, 12);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peoplesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(137, 58);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 2;
            // 
            // displayNameLabel
            // 
            displayNameLabel.AutoSize = true;
            displayNameLabel.Location = new System.Drawing.Point(37, 88);
            displayNameLabel.Name = "displayNameLabel";
            displayNameLabel.Size = new System.Drawing.Size(83, 12);
            displayNameLabel.TabIndex = 3;
            displayNameLabel.Text = "Display Name:";
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peoplesBindingSource, "DisplayName", true));
            this.displayNameTextBox.Location = new System.Drawing.Point(137, 85);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.displayNameTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(37, 125);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 12);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peoplesBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(137, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 21);
            this.emailTextBox.TabIndex = 6;
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(37, 153);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(41, 12);
            groupLabel.TabIndex = 7;
            groupLabel.Text = "Group:";
            // 
            // groupTextBox
            // 
            this.groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peoplesBindingSource, "Group", true));
            this.groupTextBox.Location = new System.Drawing.Point(137, 143);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(100, 21);
            this.groupTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(37, 182);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 12);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peoplesBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(137, 173);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneTextBox.TabIndex = 10;
            // 
            // sipAddressLabel
            // 
            sipAddressLabel.AutoSize = true;
            sipAddressLabel.Location = new System.Drawing.Point(37, 212);
            sipAddressLabel.Name = "sipAddressLabel";
            sipAddressLabel.Size = new System.Drawing.Size(77, 12);
            sipAddressLabel.TabIndex = 11;
            sipAddressLabel.Text = "Sip Address:";
            // 
            // sipAddressTextBox
            // 
            this.sipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peoplesBindingSource, "SipAddress", true));
            this.sipAddressTextBox.Location = new System.Drawing.Point(137, 203);
            this.sipAddressTextBox.Name = "sipAddressTextBox";
            this.sipAddressTextBox.Size = new System.Drawing.Size(100, 21);
            this.sipAddressTextBox.TabIndex = 12;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 244);
            this.Controls.Add(sipAddressLabel);
            this.Controls.Add(this.sipAddressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(displayNameLabel);
            this.Controls.Add(this.displayNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.peoplesBindingNavigator);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.peoplesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peoplesBindingNavigator)).EndInit();
            this.peoplesBindingNavigator.ResumeLayout(false);
            this.peoplesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource peoplesBindingSource;
        private System.Windows.Forms.BindingNavigator peoplesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton peoplesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox sipAddressTextBox;
    }
}