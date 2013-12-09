using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common;
using SipCommunicator.Sip;

namespace SipCommunicator.UI.Forms
{
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
            InitializeComponent();
            this.bindingSourceSipAccounts.DataSource = SipAccountManager.Default.SipAccounts;
        }

        private void addNewAccountButton_Click(object sender, EventArgs e)
        {
            SipAccountConfig cfg = new SipAccountConfig();
            SipAccountEditorForm f = new SipAccountEditorForm(cfg);
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (SipAccountManager.Default.DefaultAcrcount == null)
                {
                    cfg.IsDefault = true;
                }
                bindingSourceSipAccounts.Add(cfg);
            }
        }

        private void sipAccountsDataGrid_DeleteDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            SipAccountConfig user = e.DataRow.DataBoundItem as SipAccountConfig;
            if (user == null)
            {
                return;
            }

            if (MessageBox.Show(string.Format(Properties.LocalizedStrings.Message_DeleteSipAccount, user.AccountName),
                Properties.LocalizedStrings.Message_DeleteSipAccount_Caption, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.bindingSourceSipAccounts.RemoveCurrent();
            }

            if (SipAccountManager.Default.DefaultAcrcount == null && SipAccountManager.Default.SipAccounts.Count > 0)
            {
                SipAccountManager.Default.SipAccounts[0].IsDefault = true;
            }
        }

        private void sipAccountsDataGrid_EditDataRow(object sender, VisualAsterisk.Manager.Controls.DataRowEventArgs e)
        {
            SipAccountConfig cfg = e.DataRow.DataBoundItem as SipAccountConfig;
            if (cfg == null)
            {
                return;
            }

            cfg.BeginEdit();
            SipAccountEditorForm f = new SipAccountEditorForm(cfg);
            if (f.ShowDialog() == DialogResult.OK)
            {
                cfg.EndEdit();
                this.Invalidate();
            }
            else
            {
                cfg.CancelEdit();
            }
        }

        private void sipAccountsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SipAccountConfig account = sipAccountsDataGrid.Rows[e.RowIndex].DataBoundItem as SipAccountConfig;
            if (account == null)
            {
                return;
            }
            if (e.ColumnIndex == isDefaultColumn.Index)
            {
                foreach (var item in SipAccountManager.Default.SipAccounts)
                {
                    item.IsDefault = false;
                }
                account.IsDefault = true;
                this.Invalidate(true);
            }
        }
    }
}
