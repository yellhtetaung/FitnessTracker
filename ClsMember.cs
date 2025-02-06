using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsMember
    {
        private string _MemberID, _MemberFullName, _MemberUsername, _MemberEmail, _MemberPassword, _MemberPhone, _MemberAddress;
        private char _MemberGender;
        private DateTime _MemberDOB;

        public string MemberID
        {
            set { _MemberID = value; }
            get { return _MemberID; }
        }

        public string MemberFullName
        {
            set { _MemberFullName = value; }
            get { return _MemberFullName; }
        }

        public string MemberUsername
        {
            set { _MemberUsername = value; }
            get { return _MemberUsername; }
        }

        public string MemberEmail
        {
            set { _MemberEmail = value; }
            get { return _MemberEmail; }
        }

        public string MemberPassword
        {
            set { _MemberPassword = value; }
            get { return _MemberPassword; }
        }

        public Char MemberGender
        {
            set { _MemberGender = value; }
            get { return _MemberGender; }
        }

        public string MemberPhone
        {
            set { _MemberPhone = value; }
            get { return _MemberPhone; }
        }

        public string MemberAddress
        {
            set { _MemberAddress = value; }
            get { return _MemberAddress; }
        }

        public DateTime MemberDOB
        {
            set { _MemberDOB = value; }
            get { return _MemberDOB; }
        }
    }
}
