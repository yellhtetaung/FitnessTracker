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
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Please fill username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else
                {
                    ClsMember memberData = new ClsMember();
                    memberData.MemberUsername = txtUsername.Text;
                    memberData.MemberPassword = txtPassword.Text;

                    memberDta = objMember.LoginMember(memberData.MemberUsername, memberData.MemberPassword);

                    Console.WriteLine(memberDta.Rows.Count);
                    Console.WriteLine(memberData.MemberPassword);
                    Console.WriteLine(memberData.MemberUsername);

                    if (memberDta.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginUsername = memberDta.Rows[0][1].ToString();
                        loginMemberID = memberDta.Rows[0][0].ToString();
                    }
                }
            }
        }
    }
}
