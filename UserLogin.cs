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
    public partial class UserLogin : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        int loginCount = 0;
        public static string loginUsername;
        public static string loginUserID;

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
                    if (txtUsername.Text == "")
                    {
                        MessageBox.Show("Username must be provide.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    else if (txtPassword.Text == "")
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
    }
}
