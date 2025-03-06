using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FitnessTracker
{
    public partial class UpdateTrainer : Form
    {
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTrainer = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
        DataTable trainerDta = new DataTable();

        private readonly string enterYourFullName = "Enter your full name";
        private readonly string enterUsername = "Enter username";
        private readonly string enterEmail = "Enter your email address";
        private readonly string enterYourPassword = "Enter your password";
        private readonly string enterPhoneNumber = "Enter your phone number";
        private readonly string enterAddress = "Enter your address";

        public string TrainerID;
        public string FullName;
        public string Username;
        public string Email;
        public string Password;
        public DateTime DOB;
        public char Gender;
        public string PhoneNumber;
        public string Address;

        private Trainers trainerForm;

        public UpdateTrainer()
        {
            InitializeComponent();
        }

        public UpdateTrainer(Trainers trainers)
        {
            InitializeComponent();
            trainerForm = trainers;
        }

        private void UpdateTrainer_Load(object sender, EventArgs e)
        {
            if (TrainerID != null)
            {
                lblID.Text = TrainerID;
            }
            else
            {
                lblID.Text = "";
            }

            if (FullName != null)
            {
                txtFullName.Text = FullName;
            }
            else
            {
                TextBoxController.Placeholder(txtFullName, enterYourFullName);
            }

            if (Username != null)
            {
                txtUsername.Text = Username;
            }
            else
            {
                TextBoxController.Placeholder(txtUsername, enterUsername);
            }

            if (Email != null)
            {
                txtEmail.Text = Email;
            }
            else
            {
                TextBoxController.Placeholder(txtEmail, enterEmail);
            }

            if (Password != null)
            {
                txtPassword.Text = Password;
                txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
            }
            else
            {
                TextBoxController.Placeholder(txtPassword, enterYourPassword);
            }

            if (PhoneNumber != null)
            {
                txtPhone.Text = PhoneNumber;
            }
            else
            {
                TextBoxController.Placeholder(txtPhone, enterPhoneNumber);
            }

            if (Address != null)
            {
                txtAddress.Text = Address;
            }
            else
            {
                TextBoxController.Placeholder(txtAddress, enterAddress);
            }

            if (DOB != null)
            {
                dtpDOB.Value = DOB;
            }
            else
            {
                dtpDOB.Value = DateTime.Today;
            }

            switch (Gender)
            {
                case (char)Constant.Gender.Male:
                    rdoMale.Checked = true;
                    break;
                case (char)Constant.Gender.Female:
                    rdoFemale.Checked = true;
                    break;
                case (char)Constant.Gender.Other:
                    rdoOther.Checked = true;
                    break;
                default:
                    rdoMale.Checked = false;
                    rdoFemale.Checked = false;
                    rdoOther.Checked = false;
                    break;
            }
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
            string usernamePattern = @"^[a-z][a-zA-Z0-9]*\d[a-zA-Z0-9]*$";
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            try
            {
                if (txtFullName.Text == enterYourFullName || txtFullName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your full name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
                else if (txtUsername.Text == enterUsername || txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtUsername.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Username must be more than 3 characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (!Regex.IsMatch(txtUsername.Text, usernamePattern))
                {
                    string errorMessageFirstUpperCase = new Regex(@"^[A-Z]").IsMatch(txtUsername.Text) ? "Username must be start with lower character.\n" : "";
                    string errorMessageFirstCharacter = new Regex(@"^[0-9]").IsMatch(txtUsername.Text) ? "Username must be start with character.\n" : "";
                    string errorMessageContainerNumber = !new Regex(@"^(?=.*\d)[a-z0-9]").IsMatch(txtUsername.Text) ? "Username must be contain at least one number.\n" : "";

                    string errorMessage = $"{errorMessageFirstUpperCase}{errorMessageFirstCharacter}{errorMessageContainerNumber}";
                    MessageBox.Show(errorMessage, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtEmail.Text == enterEmail || txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (!Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    MessageBox.Show("Invalid your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (txtPassword.Text == enterYourPassword || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (txtPhone.Text == enterPhoneNumber || txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your phone number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else if (txtAddress.Text == enterAddress || txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
                else if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOther.Checked == false)
                {
                    MessageBox.Show("Please choose your gender!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ClsTrainer trainerData = new ClsTrainer();
                    trainerData.ID = lblID.Text;
                    trainerData.Fullname = txtFullName.Text;
                    trainerData.Username = txtUsername.Text;
                    trainerData.Email = txtEmail.Text;
                    trainerData.Password = txtPassword.Text;
                    trainerData.DateOfBirth = dtpDOB.Value;
                    trainerData.Gender = rdoMale.Checked ? 'M' : rdoFemale.Checked ? 'F' : 'O';
                    trainerData.Address = txtAddress.Text;
                    trainerData.Phone = txtPhone.Text;

                    objTrainer.UpdateTrainer(trainerData.Fullname, trainerData.Username, trainerData.Email, trainerData.Password, trainerData.DateOfBirth.ToString(), trainerData.Gender.ToString(), trainerData.Phone, trainerData.Address, trainerData.ID);

                    this.Hide();
                    trainerForm.DataGridViewReload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
