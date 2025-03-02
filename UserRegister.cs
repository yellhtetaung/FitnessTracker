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
    public partial class UserRegister : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();


        public UserRegister()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            userDta = objUser.GetData();
            lblID.Text = Constant.AutoID(userDta, 'U');
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your full name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
                else if (txtUsername.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtUsername.Text.Length < 3)
                {
                    MessageBox.Show("Username must be more than 3 characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (dtpDOB.Value == null)
                {
                    MessageBox.Show("Please choose you date of birth.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDOB.Focus();
                }
                else if (txtNationalID.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your national registration card number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNationalID.Focus();
                }
                else if (txtWeight.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your weight.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWeight.Focus();
                }
                else if (txtHeight.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your height.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeight.Focus();
                }
                else if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your phone number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else if (txtAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter your address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAddress.Focus();
                }
                else
                {
                    clsUser userData = new clsUser();
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
                            AutoID();

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
            AutoID();
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
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtFullName.Focus();
        }
    }
}
