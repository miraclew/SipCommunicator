using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SipCommunicator.UI.Forms;
using SipCommunicator.License;
using SipCommunicator.Utilities;

namespace SipCommunicator
{
    static class Program
    {
        public const string ProgramWindowText = "Sip Communicator";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // check license
            if (!LicenseCheck.IsThisCopyLegal())
            {
                MessageBox.Show(LicenseCheck.GetIllegalCopyMessage(), "Sorry, the application can't continue", MessageBoxButtons.OK);
                return;
            }

            // check and process args
            foreach (string arg in args)
            {
                if (arg.StartsWith("-dial=", true, System.Globalization.CultureInfo.InvariantCulture) || arg.StartsWith("/dial-", true, System.Globalization.CultureInfo.InvariantCulture))
                {
                    if (InterProcessCommunication.IsProcessRunning(ProgramWindowText))
                    {
                        InterProcessCommunication.SendMessage(ProgramWindowText, arg);
                        return;
                    }
                    else
                    {
                        // TODO: leave a pending call, when form load complete, place the call
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SipAccountManager.Default.SipAccountsXmlFileFullName = Application.StartupPath + "\\sip_accounts.xml";
            SipAccountManager.Default.Initial();

            Application.Run(new MainForm());

            SipAccountManager.Default.Shutdown();
        }
    }
}
