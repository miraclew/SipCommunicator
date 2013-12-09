using System;
using System.Collections.Generic;
using System.Text;
using IC.Utilities;
using SipCommunicator.UI.Forms;

namespace SipCommunicator.License
{
    public class LicenseCheck
    {
        public const string AuthorEmail = "wanwei_ncu@msn.com";
        private const string Message_IncorrectLicenseSerialNo = "Your Serial Number is incorrect";
        private const string Message_LicenseExpire = "Your license is expired";
        private const int demoLicenseDays = 10;

        public static bool IsThisCopyLegal()
        {
            DateTime date = AssemblyBuildDateHelper.GetAssemblyBuildDate(typeof(MainForm).Assembly);
            if (DateTime.Now.Subtract(date).Days > demoLicenseDays)
            {
                return false;
            }
            else
                return true;
        }

        public static string GetIllegalCopyMessage()
        {
            return Message_LicenseExpire + ". \n\nPlease contact author: " + AuthorEmail;
        }
    }
}
