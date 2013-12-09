using System;
using System.Collections.Generic;
using System.Text;
using Sipek.Common;
using System.ComponentModel;

namespace SipCommunicator.Sip
{
    [Serializable]
    public class SipAccountConfig : IAccount, IEditableObject
    {
        #region IAccount
        private string accoutName;
        private string displayName;
        private string domainName = "*";
        private string hostName;
        private string id;
        private int index = 0;
        private string password;
        private string proxyAddress = "";
        private int regState;
        private ETransportMode transportMode = ETransportMode.TM_UDP;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public ETransportMode TransportMode
        {
            get { return transportMode; }
            set { transportMode = value; }
        }

        public int RegState
        {
            get { return regState; }
            set { regState = value; }
        }

        public string ProxyAddress
        {
            get { return proxyAddress; }
            set { proxyAddress = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Id
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string HostName
        {
            get { return hostName; }
            set { hostName = value; }
        }
        public string AccountName
        {
            get
            {
                return accoutName;
            }
            set
            {
                accoutName = value;
            }
        }

        public string DisplayName
        {
            get
            {
                return displayName;
            }
            set
            {
                displayName = value;
            }
        }

        public string DomainName
        {
            get
            {
                return domainName;
                    
            }
            set
            {
                domainName = value;
            }
        }
        #endregion

        public SipAccountConfig()
        {
        }
        public SipAccountConfig(SipAccountConfig cfg)
        {
            copy(cfg);
        }

        private bool isDefault = false;

        public bool IsDefault
        {
            get { return isDefault; }
            set { isDefault = value; }
        }

        #region edit
        private SipAccountConfig savedObject;
        private bool addingNew = false;
        protected bool editing = false;
        /// <summary>
        /// true means this item is adding from UI, not commit to server yet
        /// </summary>
        public bool AddingNew
        {
            get { return addingNew; }
            set { addingNew = value; }
        }

        public SipAccountConfig Copy()
        {
            return new SipAccountConfig(this);
        }

        private void copy(SipAccountConfig cfg)
        {
            this.AccountName = cfg.AccountName;
            this.DisplayName = cfg.DisplayName;
            this.DomainName = cfg.DomainName;
            this.HostName = cfg.HostName;
            this.Id = cfg.Id;
            this.Index = cfg.Index;
            this.Password = cfg.Password;
            this.ProxyAddress = cfg.ProxyAddress;
            this.RegState = cfg.RegState;
            this.TransportMode = cfg.TransportMode;
            this.UserName = cfg.UserName;
        }

        #endregion
        #region IEditableObject 成员

        public virtual void BeginEdit()
        {
            if (editing) return;
            savedObject = this.Copy();
            editing = true;
        }

        public virtual void CancelEdit()
        {
            if (!editing) return;

            editing = false;
            copy(savedObject);
            savedObject = null;
        }

        public virtual void EndEdit()
        {
            if (editing)
            {
                editing = false;
            }
        }

        #endregion
    }
}
