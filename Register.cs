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
    public partial class Register : Form
    {
        FitnessTrackerDatasetTableAdapters.MembersTableAdapter objMember = new FitnessTrackerDatasetTableAdapters.MembersTableAdapter();
        DataTable memberDta = new DataTable();

        public Register()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            memberDta = objMember.GetData();

            if (memberDta.Rows.Count == 0)
            {
                lblID.Text = "M0001";
            }
            else
            {
                int size = memberDta.Rows.Count - 1;
                string oldID = memberDta.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    lblID.Text = "M000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblID.Text = "M00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblID.Text = "M0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    lblID.Text = "M" + (newID + 1);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            dtpDOB.Value = DateTime.Today;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;
            txtFullName.Focus();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            AutoID();
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
                else if (txtAddress.Text == "")
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
                    ClsMember memberData = new ClsMember();
                    memberData.MemberID = lblID.Text;
                    memberData.MemberFullName = txtFullName.Text;
                    memberData.MemberUsername = txtUsername.Text;
                    memberData.MemberEmail = txtEmail.Text;
                    memberData.MemberPassword = txtPassword.Text;
                    memberData.MemberDOB = dtpDOB.Value;
                    memberData.MemberGender = rdoMale.Checked ? 'M' : rdoFemale.Checked ? 'F' : 'O';
                    memberData.MemberAddress = txtAddress.Text;
                    memberData.MemberPhone = txtPhone.Text;

                    int insertMember = objMember.InsertMemberData(memberData.MemberID, memberData.MemberFullName, memberData.MemberUsername, memberData.MemberEmail, memberData.MemberPassword, memberData.MemberDOB, memberData.MemberGender.ToString(), memberData.MemberPhone, memberData.MemberAddress);

                    if (insertMember > 0)
                    {
                        MessageBox.Show("Member added successfully.");
                        AutoID();

                        Login login = new Login();
                        this.Hide();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
