using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SipCommunicator
{
    [Serializable]
    public class Contacts
    {
        public class Contact
        {
            private string displayName;
            private string sipAddress;
            private bool subscribePresence;
            private string email;
            private string phone;
            private string address;
            private string group;

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public bool SubscribePresence
            {
                get { return subscribePresence; }
                set { subscribePresence = value; }
            }

            public string SipAddress
            {
                get { return sipAddress; }
                set { sipAddress = value; }
            }


            public string DisplayName
            {
                get { return displayName; }
                set { displayName = value; }
            }

            public string Group
            {
                get { return group; }
                set { group = value; }
            }



        };
        private List<Contact> peoples;

        public string[] GetAllGroups()
        {
            string[] groups= { "Friends", "Work", "Home", "Other" };
            return groups;
        }

        public List<Contact> Peoples
        {
            get { return peoples; }
            set { peoples = value; }
        }
    }
}
