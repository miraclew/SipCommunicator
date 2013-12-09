using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SipCommunicator.Sip;
using SipCommunicator.Utilities;

namespace SipCommunicator.UI.Forms
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
            this.settingsBindingSource.DataSource = SipCommunicator.Properties.Settings.Default;
            
        }

        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applyChanges();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            applyChanges();
        }

        private void applyChanges()
        {
            SipCommunicator.Properties.Settings.Default.Save();
            if (Properties.Settings.Default.MonitorSipLink)
            {
                IESipProtocolHandlerInstaller.Install();
            }
            else
            {
                IESipProtocolHandlerInstaller.Uninstall();
            }
        }

    }
}
