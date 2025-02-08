using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class clsUser
    {
        private string _ID, _Fullname, _Username, _Email, _Password, _Phone;

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Fullname
        {
            get { return _Fullname; }
            set { _Fullname = value; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
    }
}
