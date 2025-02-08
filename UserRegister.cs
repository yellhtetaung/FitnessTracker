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

            if (userDta.Rows.Count == 0)
            {
                lblID.Text = "U0001";
            }
            else
            {
                int size = userDta.Rows.Count - 1;
                string oldID = userDta.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    lblID.Text = "U000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblID.Text = "U00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblID.Text = "U0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    lblID.Text = "U" + (newID + 1);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "")
                {
                    MessageBox.Show("Please enter your full name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                }
                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Please enter your username.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtUsername.Text.Length < 3)
                {
                    MessageBox.Show("Username must be more than 3 characters.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter your email address.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter your password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please enter your phone number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                }
                else
                {
                    clsUser userData = new clsUser();
                    userData.ID = lblID.Text;
                    userData.Fullname = txtFullName.Text;
                    userData.Username = txtUsername.Text;
                    userData.Email = txtEmail.Text;
                    userData.Password = txtPassword.Text;
                    userData.Phone = txtPhone.Text;

                    DataTable getUserDataByUsername = objUser.GetUserByUsername(userData.Username);
                    DataTable getUserDataByEmail = objUser.GetUserByEmail(userData.Email);

                    if (getUserDataByUsername.Rows.Count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }

                    if (getUserDataByEmail.Rows.Count > 0)
                    {
                        throw new Exception("Email already exists.");
                    }

                    if (getUserDataByUsername.Rows.Count == 0 && getUserDataByEmail.Rows.Count == 0)
                    {
                        int insertUser = objUser.InsertUserData(userData.ID, userData.Fullname, userData.Username, userData.Email, userData.Password, userData.Phone);

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
