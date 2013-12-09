using System;
using System.Collections.Generic;
using System.Text;
using SipCommunicator.Sip;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;

namespace SipCommunicator
{
    class SipAccountManager
    {
        #region default instance
        private static SipAccountManager instance;
        static SipAccountManager()
        {
            instance = new SipAccountManager();
        }
        private SipAccountManager()
        {

        }
        public static SipAccountManager Default
        {
            get { return instance; }
        }
        #endregion

        private List<SipAccountConfig> sipAccounts = null;
        private string sipAccountsXmlFileFullName;
        private SipAccountConfig defaultAcrcount = null;

        public SipAccountConfig DefaultAcrcount
        {
            get 
            {
                foreach (var item in sipAccounts)
                {
                    if (item.IsDefault)
                    {
                        return item;
                    }
                }
                return null; 
            }
            
            set { defaultAcrcount = value; }
        }

        public string SipAccountsXmlFileFullName
        {
            get { return sipAccountsXmlFileFullName; }
            set { sipAccountsXmlFileFullName = value; }
        }

        public List<SipAccountConfig> SipAccounts
        {
            get { return sipAccounts; }
            set { sipAccounts = value; }
        }

        public void Initial()
        {
            LoadSipAccounts();
        }

        private void LoadSipAccounts()
        {
            sipAccounts = readSipAccounts(sipAccountsXmlFileFullName);
            if (sipAccounts == null)
            {
                sipAccounts = new List<SipAccountConfig>();
            }
        }

        private List<SipAccountConfig> readSipAccounts(string sipAccountsXmlFileFullName)
        {
            List<SipAccountConfig> accounts = null;
            try
            {
                FileStream fs = new FileStream(sipAccountsXmlFileFullName, FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(List<SipAccountConfig>));
                accounts = xs.Deserialize(fs) as List<SipAccountConfig>;
                fs.Close();
            }
            catch (FileNotFoundException e)
            {
                Trace.TraceWarning("File not found: {0}", e.Message);
            }
            catch (IOException)
            {
                throw;
            }
            catch (InvalidOperationException e)
            {
                Trace.TraceError("Xml read error: {0}", e.Message);
            }
            return accounts;
        }

        public void Shutdown()
        {
            SaveSipAccounts();
        }

        private void SaveSipAccounts()
        {
            writeSipAccounts(sipAccounts, sipAccountsXmlFileFullName);
        }

        private void writeSipAccounts(List<SipAccountConfig> sipAccounts, string sipAccountsXmlFileFullName)
        {
            try
            {
                FileStream fs = new FileStream(sipAccountsXmlFileFullName, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(List<SipAccountConfig>));
                xs.Serialize(fs, sipAccounts);
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void ImportSipAccounts(string file)
        {
            List<SipAccountConfig> accounts = readSipAccounts(file);
            if (accounts != null)
            {
                sipAccounts.AddRange(accounts);
                SaveSipAccounts();
            }
        }

        public void ExportSipAccounts(string file)
        {
            SaveSipAccounts();
            File.Copy(sipAccountsXmlFileFullName, file);
        }

    }
}
