using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SipCommunicator.UI.Forms;

namespace SipCommunicator.UI.Controls
{
    public partial class BuddyList : UserControl
    {
        public BuddyList()
        {
            InitializeComponent();
            treeView1.Nodes.Clear();
            Contacts con = new Contacts();
            foreach (string item in con.GetAllGroups())
            {
                treeView1.Nodes.Add(item);
            }
        }

        private void instantMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatForm f = new ChatForm();
            f.Show();
        }

        private void bindingSourceSipAccounts_CurrentChanged(object sender, EventArgs e)
        {
            //bindingSourceSipAccounts
            //treeView1.Nodes.Add
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm form = new AddContactForm();
            form.Show();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Contacts con = new Contacts();
            foreach (string item in con.GetAllGroups())
            {
                if (e.Node.Text == item)
                {
                    this.groupContextMenuStrip.Show();
                    return;
                }
            }

            this.buddyContextMenuStrip.Show();
        }
    }
}
