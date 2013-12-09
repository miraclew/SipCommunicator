using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SipCommunicator.Sip;

namespace SipCommunicator.UI.Forms
{
    public partial class SipAccountEditorForm : Form
    {
        private SipAccountConfig cfg;

        public SipAccountEditorForm(SipAccountConfig cfg)
        {
            InitializeComponent();
            this.iAccountBindingSource.DataSource = cfg;
        }
    }
}
