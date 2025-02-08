﻿using System;
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
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTraniner = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
        DataTable trainerDta = new DataTable();

        public Register()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            trainerDta = objTraniner.GetData();

            if (trainerDta.Rows.Count == 0)
            {
                lblID.Text = "T0001";
            }
            else
            {
                int size = trainerDta.Rows.Count - 1;
                string oldID = trainerDta.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    lblID.Text = "T000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblID.Text = "T00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblID.Text = "T0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    lblID.Text = "T" + (newID + 1);
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
                    clsTrainer trainerData = new clsTrainer();
                    trainerData.ID = lblID.Text;
                    trainerData.Fullname = txtFullName.Text;
                    trainerData.Username = txtUsername.Text;
                    trainerData.Email = txtEmail.Text;
                    trainerData.Password = txtPassword.Text;
                    trainerData.DateOfBirth = dtpDOB.Value;
                    trainerData.Gender = rdoMale.Checked ? 'M' : rdoFemale.Checked ? 'F' : 'O';
                    trainerData.Address = txtAddress.Text;
                    trainerData.Phone = txtPhone.Text;

                    DataTable getTrainerDataByUsername = objTraniner.GetTrainerByUsername(trainerData.Username);
                    DataTable getTrainerDataByEmail = objTraniner.GetTrainerByEmail(trainerData.Email);

                    if (getTrainerDataByUsername.Rows.Count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }

                    if(getTrainerDataByEmail.Rows.Count > 0)
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

                            Login login = new Login();
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
    }
}
