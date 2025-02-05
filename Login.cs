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
    public partial class Login : Form
    {
        FitnessTrackerDatasetTableAdapters.MembersTableAdapter objMember = new FitnessTrackerDatasetTableAdapters.MembersTableAdapter();
        DataTable memberDta = new DataTable();

        int loginCount = 0;
        public static String loginUsername;
        public static String loginMemberID;

        public Login()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
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
                        ClsMember memberData = new ClsMember();
                        memberData.MemberUsername = txtUsername.Text;
                        memberData.MemberPassword = txtPassword.Text;

                        memberDta = objMember.LoginMember(memberData.MemberUsername, memberData.MemberPassword);

                        if (memberDta.Rows.Count > 0)
                        {
                            loginUsername = memberDta.Rows[0][1].ToString();
                            loginMemberID = memberDta.Rows[0][0].ToString();
                            this.Hide();
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password!", "Login in Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUsername.Focus();
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
