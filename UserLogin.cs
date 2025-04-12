using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class UserLogin : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        int loginCount = 0;
        public static string loginUsername;
        public static string loginUserID;

        private readonly string enterUsername = "Enter username";
        private readonly string enterPassword = "Enter password";

        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginCount == 2)
                {
                    MessageBox.Show("Something went wrong!");
                    Application.Exit();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.Equals(txtUsername.Text, enterUsername))
                    {
                        MessageBox.Show("Username must be provide.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    else if (string.IsNullOrWhiteSpace(txtPassword.Text) || string.Equals(txtPassword.Text, enterPassword))
                    {
                        MessageBox.Show("Password must be provide.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                    }
                    else
                    {
                        ClsUser userData = new ClsUser();
                        userData.Username = txtUsername.Text;
                        userData.Password = txtPassword.Text;

                        userDta = objUser.LoginUser(userData.Username, userData.Password);

                        if (userDta.Rows.Count > 0)
                        {
                            loginUsername = userDta.Rows[0][1].ToString();
                            loginUserID = userDta.Rows[0][0].ToString();
                            this.Hide();
                            UserDashboard dashboard = new UserDashboard();
                            dashboard.Show();
                        }
                        else
                        {
                            loginCount += 1;
                            MessageBox.Show("Incorrect username or password!", "Login in Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegister register = new UserRegister();
            this.Hide();
            register.Show();
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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtPassword.Text, enterPassword))
            {
                TextBoxController.Placeholder(txtPassword, "", Color.Black);
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                TextBoxController.Placeholder(txtPassword, enterPassword);
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.Equals(txtPassword.Text, enterPassword) || string.IsNullOrWhiteSpace(txtPassword.Text))
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

        private void UserLogin_Load(object sender, EventArgs e)
        {
            TextBoxController.Placeholder(txtUsername, enterUsername);
            TextBoxController.Placeholder(txtPassword, enterPassword);
            chkPassword.Enabled = false;
        }
    }
}
