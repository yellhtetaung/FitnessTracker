﻿using System;
using System.Data;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class TrainerDashboard : Form
    {
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTrainer = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
        DataTable trainerDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        public TrainerDashboard()
        {
            InitializeComponent();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            this.Hide();
            activity.Show();
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainers trainers = new Trainers();
            this.Hide();
            trainers.Show();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.Logout(this, Constant.Authorization.Admin);
        }

        private void GetTrainerData()
        {
            trainerDta = objTrainer.GetTrainerByTrainerID(Login.loginTrainerID);
            if (trainerDta.Rows.Count > 0)
            {
                lblID.Text = trainerDta.Rows[0]["TrainerID"].ToString();
                lblFullname.Text = trainerDta.Rows[0]["FullName"].ToString();
                lblUsername.Text = trainerDta.Rows[0]["Username"].ToString();
                lblEmail.Text = trainerDta.Rows[0]["Email"].ToString();
                lblDOB.Text = Convert.ToDateTime(trainerDta.Rows[0]["DOB"].ToString()).ToString("d / MMM / yyyy");
                lblPhone.Text = trainerDta.Rows[0]["Phone"].ToString();
                lblAddress.Text = trainerDta.Rows[0]["Address"].ToString();

                switch (Convert.ToChar(trainerDta.Rows[0]["Gender"].ToString()))
                {
                    case (char)Constant.Gender.Female:
                        lblGender.Text = "Female";
                        break;
                    case (char)Constant.Gender.Male:
                        lblGender.Text = "Male";
                        break;
                    case (char)Constant.Gender.Other:
                        lblGender.Text = "Other";
                        break;
                    default:
                        lblGender.Text = "";
                        break;
                }
            }
            else
            {
                lblID.Text = "";
                lblFullname.Text = "";
                lblUsername.Text = "";
                lblEmail.Text = "";
                lblDOB.Text = "";
                lblGender.Text = "";
                lblPhone.Text = "";
                lblAddress.Text = "";
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            GetTrainerData();

            activityDta = objActivity.GetData();
            lblActivityCount.Text = activityDta.Rows.Count.ToString();

            trainerDta = objTrainer.GetData();
            lblTrainerCount.Text = trainerDta.Rows.Count.ToString();

            userDta = objUser.GetData();
            lblUserCount.Text = userDta.Rows.Count.ToString();
        }
    }
}
