using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sipek.Common;

namespace SipCommunicator.UI.Forms
{
    public partial class CallDetailsForm : Form
    {
        public CallDetailsForm(SipekResources resource)
        {
            InitializeComponent();
            this.bindingSource1.DataSource = resource.CallLogger.getList();
        }
    }
}
