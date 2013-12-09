using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;

namespace SipCommunicator.Utilities
{
    class IESipProtocolHandlerInstaller
    {
        public static void Install()
        {

            Registry.ClassesRoot.CreateSubKey("sip");
            Registry.ClassesRoot.OpenSubKey("sip", true).SetValue(null, "URL: SIP Protocol handler");
            Registry.ClassesRoot.OpenSubKey("sip", true).SetValue("URL Protocol", "");

            Registry.ClassesRoot.OpenSubKey("sip", true).CreateSubKey("DefaultIcon");
            Registry.ClassesRoot.OpenSubKey("sip", true).OpenSubKey("DefaultIcon", true).SetValue(null, Application.ExecutablePath);

            Registry.ClassesRoot.OpenSubKey("sip", true).CreateSubKey("shell");
            Registry.ClassesRoot.OpenSubKey("sip").OpenSubKey("shell", true).CreateSubKey("open");
            Registry.ClassesRoot.OpenSubKey("sip").OpenSubKey("shell").OpenSubKey("open", true).CreateSubKey("command");
            Registry.ClassesRoot.OpenSubKey("sip").OpenSubKey("shell").OpenSubKey("open").OpenSubKey("command", true).SetValue(null, "\"" + Application.ExecutablePath + "\"" + " -dial=" + "\"%1\"");
        }

        public static void Uninstall()
        {
            Registry.ClassesRoot.OpenSubKey("sip",true).DeleteSubKeyTree("DefaultIcon");
            Registry.ClassesRoot.OpenSubKey("sip", true).DeleteSubKeyTree("shell");
        }
    }
}
