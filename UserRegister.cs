using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class UserRegister : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        private readonly string enterYourFullName = "Enter your full name";
        private readonly string enterUsername = "Enter username";
        private readonly string enterEmail = "Enter your email address";
        private readonly string enterYourPassword = "Enter your password";
        private readonly string enterYourNRC = "Enter your national ID";
        private readonly string enterYourWeigth = "Enter your weigth";
        private readonly string enterYourHeight = "Enter your height";
        private readonly string enterPhoneNumber = "Enter your phone number";
        private readonly string enterAddress = "Enter your address";


        public UserRegister()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            userDta = objUser.GetData();
            lblID.Text = Constant.AutoID(userDta, 'U');
        }

        private void ShowAllPlaceholder()
        {
            TextBoxController.Placeholder(txtFullName, enterYourFullName);
            TextBoxController.Placeholder(txtUsername, enterUsername);
            TextBoxController.Placeholder(txtEmail, enterEmail);
            TextBoxController.Placeholder(txtPassword, enterYourPassword);
            TextBoxController.Placeholder(txtNationalID, enterYourNRC);
            TextBoxController.Placeholder(txtWeight, enterYourWeigth);
            TextBoxController.Placeholder(txtHeight, enterYourHeight);
            TextBoxController.Placeholder(txtPhone, enterPhoneNumber);
            TextBoxController.Placeholder(txtAddress, enterAddress);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.Equals(txtFullName.Text, enterYourFullName))
                {
                    MessageBox.Show("Please enter your full name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.Equals(txtUsername.Text, enterUsername))
                {
                    MessageBox.Show("Please enter your username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtUsername.Text.Length < 3)
                {
                    MessageBox.Show("Username must be more than 3 characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.Equals(txtEmail.Text, enterEmail))
                {
                    MessageBox.Show("Please enter your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.Equals(txtPassword.Text, enterYourPassword))
                {
                    MessageBox.Show("Please enter your password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (dtpDOB.Value == null)
                {
                    MessageBox.Show("Please choose you date of birth.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDOB.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtNationalID.Text) || string.Equals(txtNationalID.Text, enterYourNRC))
                {
                    MessageBox.Show("Please enter your national registration card number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNationalID.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtWeight.Text) || string.Equals(txtWeight.Text, enterYourWeigth))
                {
                    MessageBox.Show("Please enter your weight.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWeight.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtHeight.Text) || string.Equals(txtHeight.Text, enterYourHeight))
                {
                    MessageBox.Show("Please enter your height.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeight.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtPhone.Text) || string.Equals(txtPhone.Text, enterPhoneNumber))
                {
                    MessageBox.Show("Please enter your phone number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtAddress.Text) || string.Equals(txtAddress.Text, enterAddress))
                {
                    MessageBox.Show("Please enter your address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
                else
                {
                    ClsUser userData = new ClsUser();
                    userData.ID = lblID.Text;
                    userData.Fullname = txtFullName.Text;
                    userData.Username = txtUsername.Text;
                    userData.Email = txtEmail.Text;
                    userData.Password = txtPassword.Text;
                    userData.DOB = dtpDOB.Value;
                    userData.NationalID = txtNationalID.Text;
                    userData.Weight = Convert.ToDecimal(txtWeight.Text);
                    userData.Height = Convert.ToDecimal(txtHeight.Text);
                    userData.Phone = txtPhone.Text;
                    userData.Address = txtAddress.Text;

                    DataTable getUserDataByUsername = objUser.GetUserByUsername(userData.Username);
                    DataTable getUserDataByEmail = objUser.GetUserByEmail(userData.Email);
                    DataTable getUserDataByNationalID = objUser.GetUserByNationalID(userData.NationalID);

                    if (getUserDataByUsername.Rows.Count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }

                    if (getUserDataByEmail.Rows.Count > 0)
                    {
                        throw new Exception("Email already exists.");
                    }

                    if (getUserDataByNationalID.Rows.Count > 0)
                    {
                        throw new Exception("National ID already exists.");
                    }


                    if (getUserDataByUsername.Rows.Count == 0 && getUserDataByEmail.Rows.Count == 0 && getUserDataByNationalID.Rows.Count == 0)
                    {
                        int insertUser = objUser.InsertUserData(userData.ID, userData.Fullname, userData.Username, userData.Email, userData.Password, userData.DOB, userData.NationalID, userData.Weight, userData.Height, userData.Phone, userData.Address);

                        if (insertUser > 0)
                        {
                            MessageBox.Show("User account has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.AutoID();

                            UserLogin login = new UserLogin();
                            this.Hide();
                            login.ShowDialog();
                        }
                        else
                        {
                            throw new Exception("Something Wrong!");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin login = new UserLogin();
            this.Hide();
            login.Show();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            this.AutoID();
            this.ShowAllPlaceholder();
            chkPassword.Enabled = false;
            dtpDOB.MaxDate = DateTime.Today;
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ShowAllPlaceholder();
            dtpDOB.Value = DateTime.Today;
            chkPassword.Checked = false;
            chkPassword.Enabled = false;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtFullName.Text, enterYourFullName))
            {
                TextBoxController.Placeholder(txtFullName, "", Color.Black);
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                TextBoxController.Placeholder(txtFullName, enterYourFullName);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtUsername.Text, enterUsername))
            {
                TextBoxController.Placeholder(txtUsername, "", Color.Black);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                TextBoxController.Placeholder(txtUsername, enterUsername);
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtEmail.Text, enterEmail))
            {
                TextBoxController.Placeholder(txtEmail, "", Color.Black);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                TextBoxController.Placeholder(txtEmail, enterEmail);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtPassword.Text, enterYourPassword))
            {
                TextBoxController.Placeholder(txtPassword, "", Color.Black);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                TextBoxController.Placeholder(txtPassword, enterYourPassword);
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.Equals(txtPassword.Text, enterYourPassword) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                chkPassword.Enabled = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                chkPassword.Enabled = true;
                txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
            }

        }

        private void txtNationalID_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtNationalID.Text, enterYourNRC))
            {
                TextBoxController.Placeholder(txtNationalID, "", Color.Black);
            }
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                TextBoxController.Placeholder(txtNationalID, enterYourNRC);
            }
        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtWeight.Text, enterYourWeigth))
            {
                TextBoxController.Placeholder(txtWeight, "", Color.Black);
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                TextBoxController.Placeholder(txtWeight, enterYourWeigth);
            }
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtHeight.Text, enterYourHeight))
            {
                TextBoxController.Placeholder(txtHeight, "", Color.Black);
            }
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                TextBoxController.Placeholder(txtHeight, enterYourHeight);
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtPhone.Text, enterPhoneNumber))
            {
                TextBoxController.Placeholder(txtPhone, "", Color.Black);
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                TextBoxController.Placeholder(txtPhone, enterPhoneNumber);
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtAddress.Text, enterAddress))
            {
                TextBoxController.Placeholder(txtAddress, "", Color.Black);
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                TextBoxController.Placeholder(txtAddress, enterAddress);
            }
        }
    }
}
