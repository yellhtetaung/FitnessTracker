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
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTrainer = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
        DataTable trainerDta = new DataTable();

        int loginCount = 0;
        public static string loginUsername;
        public static string loginTrainerID;

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
                        clsTrainer trainerData = new clsTrainer();
                        trainerData.Username = txtUsername.Text;
                        trainerData.Password = txtPassword.Text;

                        trainerDta = objTrainer.LoginTrainer(trainerData.Username, trainerData.Password);

                        if (trainerDta.Rows.Count > 0)
                        {
                            loginUsername = trainerDta.Rows[0][1].ToString();
                            loginTrainerID = trainerDta.Rows[0][0].ToString();
                            this.Hide();
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
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

        private void Login_Load(object sender, EventArgs e)
        {
            trainerDta = objTrainer.GetData();
            if (trainerDta.Rows.Count > 0)
            {
                lblRegisterAccountDesc.Hide();
                linkRegister.Hide();
            }
            else
            {
                lblRegisterAccountDesc.Show();
                linkRegister.Show();
            }
        }
    }
}
