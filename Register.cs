﻿using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Register : Form
    {
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTraniner = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
        DataTable trainerDta = new DataTable();

        private readonly string enterYourFullName = "Enter your full name";
        private readonly string enterUsername = "Enter username";
        private readonly string enterEmail = "Enter your email address";
        private readonly string enterYourPassword = "Enter your password";
        private readonly string enterPhoneNumber = "Enter your phone number";
        private readonly string enterAddress = "Enter your address";

        private readonly bool isFromLogin = false;
        private readonly Trainers trainerForm;

        public Register()
        {
            InitializeComponent();
        }

        public Register(bool fromLogin)
        {
            InitializeComponent();
            isFromLogin = fromLogin;
        }

        public Register(Trainers trainers)
        {
            InitializeComponent();
            trainerForm = trainers;
        }

        public void AutoID()
        {
            trainerDta = objTraniner.GetData();
            lblID.Text = Constant.AutoID(trainerDta, 'T');
        }

        private void ShowAllPlaceholder()
        {
            TextBoxController.Placeholder(txtFullName, enterYourFullName);
            TextBoxController.Placeholder(txtUsername, enterUsername);
            TextBoxController.Placeholder(txtEmail, enterEmail);
            TextBoxController.Placeholder(txtPassword, enterYourPassword);
            TextBoxController.Placeholder(txtPhone, enterPhoneNumber);
            TextBoxController.Placeholder(txtAddress, enterAddress);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ShowAllPlaceholder();
            dtpDOB.Value = DateTime.Today;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;
            chkPassword.Checked = false;
            chkPassword.Enabled = false;
            txtPassword.UseSystemPasswordChar = false;
            this.ActiveControl = null;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            AutoID();
            ShowAllPlaceholder();
            chkPassword.Enabled = false;
            dtpDOB.MaxDate = DateTime.Today;
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
                    trainerData.Gender = rdoMale.Checked ? (char)Constant.Gender.Male : rdoFemale.Checked ? (char)Constant.Gender.Female : (char)Constant.Gender.Other;
                    trainerData.Address = txtAddress.Text;
                    trainerData.Phone = txtPhone.Text;

                    DataTable getTrainerDataByUsername = objTraniner.GetTrainerByUsername(trainerData.Username);
                    DataTable getTrainerDataByEmail = objTraniner.GetTrainerByEmail(trainerData.Email);

                    if (getTrainerDataByUsername.Rows.Count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }

                    if (getTrainerDataByEmail.Rows.Count > 0)
                    {
                        throw new Exception("Email already exists.");
                    }

                    if (getTrainerDataByUsername.Rows.Count == 0 && getTrainerDataByEmail.Rows.Count == 0)
                    {
                        int insertTrainer = objTraniner.InsertTrainerData(trainerData.ID, trainerData.Fullname, trainerData.Username, trainerData.Email, trainerData.Password, trainerData.DateOfBirth, trainerData.Gender.ToString(), trainerData.Phone, trainerData.Address);

                        if (insertTrainer > 0)
                        {
                            MessageBox.Show("Trainer has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AutoID();

                            if (this.isFromLogin)
                            {
                                Login login = new Login();
                                this.Hide();
                                login.Show();
                            }
                            else
                            {
                                if (trainerForm != null)
                                {
                                    trainerForm.DataGridViewReload();
                                }

                                this.ShowAllPlaceholder();
                                dtpDOB.Value = DateTime.Today;
                                rdoMale.Checked = false;
                                rdoFemale.Checked = false;
                                rdoOther.Checked = false;
                                chkPassword.Checked = false;
                                chkPassword.Enabled = false;
                                txtPassword.UseSystemPasswordChar = false;
                            }
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
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
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
