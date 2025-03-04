using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class UpdateTrainer : Form
    {
        public string TrainerID;
        public string FullName;
        public string Username;
        public string Email;
        public string Password;
        public DateTime DOB;
        public char Gender;
        public string PhoneNumber;
        public string Address;

        public UpdateTrainer()
        {
            InitializeComponent();
        }

        private void UpdateTrainer_Load(object sender, EventArgs e)
        {
            lblID.Text = TrainerID;
            txtFullName.Text = FullName;
            txtUsername.Text = Username;
            txtEmail.Text = Email;
            txtPassword.Text = Password;
            txtPhone.Text = PhoneNumber;
            txtAddress.Text = Address;
            dtpDOB.Value = DOB;

            switch (Gender)
            {
                case 'M':
                    rdoMale.Checked = true;
                    break;
                case 'F':
                    rdoFemale.Checked = true;
                    break;
                case 'O':
                    rdoOther.Checked = true;
                    break;
                default:
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;
                    rdoOther.Checked = false;
                    break;
            }
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
