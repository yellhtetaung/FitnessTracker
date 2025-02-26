using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class clsUser
    {
        private string _ID, _Fullname, _Username, _Email, _Password, _Phone, _Address, _NationalID;
        private DateTime _DOB;
        private decimal _Weight, _Height;

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

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string NationalID
        {
            get { return _NationalID; }
            set { _NationalID = value; }
        }

        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public decimal Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public decimal Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
    }
}
