using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class UpdateTrainer : Form
    {
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTrainer = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();

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
            if (!string.IsNullOrEmpty(TrainerID))
            {
                lblID.Text = TrainerID;
            }
            else
            {
                lblID.Text = "";
            }

            if (!string.IsNullOrEmpty(FullName))
            {
                txtFullName.Text = FullName;
            }
            else
            {
                TextBoxController.Placeholder(txtFullName, enterYourFullName);
            }

            if (!string.IsNullOrEmpty(Username))
            {
                txtUsername.Text = Username;
            }
            else
            {
                TextBoxController.Placeholder(txtUsername, enterUsername);
            }

            if (!string.IsNullOrEmpty(Email))
            {
                txtEmail.Text = Email;
            }
            else
            {
                TextBoxController.Placeholder(txtEmail, enterEmail);
            }

            if (!string.IsNullOrEmpty(Password))
            {
                txtPassword.Text = Password;
                txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
            }
            else
            {
                TextBoxController.Placeholder(txtPassword, enterYourPassword);
            }

            if (!string.IsNullOrEmpty(PhoneNumber))
            {
                txtPhone.Text = PhoneNumber;
            }
            else
            {
                TextBoxController.Placeholder(txtPhone, enterPhoneNumber);
            }

            if (!string.IsNullOrEmpty(Address))
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
            try
            {
                if (string.Equals(txtFullName.Text, enterYourFullName) || string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Please enter your full name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
                else if (string.Equals(txtUsername.Text, enterUsername) || string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please enter your username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtUsername.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Username must be more than 3 characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (!Constant.UsernameValidation(txtUsername.Text))
                {
                    Constant.UsernameValidationAlert(txtUsername.Text);
                    txtUsername.Focus();
                }
                else if (string.Equals(txtEmail.Text, enterEmail) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please enter your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (!Constant.EmailValidation(txtEmail.Text))
                {
                    MessageBox.Show("Invalid your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (string.Equals(txtPassword.Text, enterYourPassword) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter your password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (!Constant.PasswordValidation(txtPassword.Text))
                {
                    Constant.PasswordValidationAlert(txtPassword.Text);
                    txtPassword.Focus();
                }
                else if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOther.Checked == false)
                {
                    MessageBox.Show("Please choose your gender!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.Equals(txtPhone.Text, enterPhoneNumber) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please enter your phone number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else if (string.Equals(txtAddress.Text, enterAddress) || string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please enter your address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
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
