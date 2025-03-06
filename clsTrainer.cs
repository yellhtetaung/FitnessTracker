using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsTrainer
    {
        private string _ID, _Fullname, _Username, _Email, _Password, _Phone, _Address;
        private char _Gender;
        private DateTime _DOB, _CreatedDate;

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

        public char Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
    }
}
