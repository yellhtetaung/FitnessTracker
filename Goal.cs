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
    public partial class Goal : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        private readonly Track trackForm;

        public Goal(Track track)
        {
            InitializeComponent();
            trackForm = track;
        }

        public void AutoID()
        {
            trackerDta = objTracker.GetData();

            if (trackerDta.Rows.Count == 0)
            {
                lblTrackID.Text = "T0001";
            }
            else
            {
                int size = trackerDta.Rows.Count - 1;
                string oldID = trackerDta.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    lblTrackID.Text = "T000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblTrackID.Text = "T00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblTrackID.Text = "T0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    lblTrackID.Text = "T" + (newID + 1);
                }
            }
        }

        public void ActivityChangeHandler()
        {
            try
            {
                if (cboAct.SelectedValue != null)
                {
                    string id = cboAct.SelectedValue.ToString();
                    lblActID.Text = id;

                    activityDta = objActivity.GetActivityByID(id);

                    if (activityDta.Rows.Count > 0)
                    {
                        lblMetricOne.Text = activityDta.Rows[0]["MetricOne"].ToString();
                        lblMetricTwo.Text = activityDta.Rows[0]["MetricTwo"].ToString();
                        lblMetricThree.Text = activityDta.Rows[0]["MetricThree"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Goal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataset1.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataset1.Activities);
            // TODO: This line of code loads data into the 'fitnessTrackerDataset.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataset.Activities);
            lblUserID.Text = UserLogin.loginUserID;
            lblUsername.Text = UserLogin.loginUsername;
            AutoID();
            ActivityChangeHandler();
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityChangeHandler();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTrackName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter track name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTrackName.Focus();
                }
                else if (txtSetGoal.Text == "")
                {
                    MessageBox.Show("Please enter your goal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSetGoal.Focus();
                }
                else
                {
                    int countRecord = objTracker.InsertTracker(lblTrackID.Text, lblActID.Text, lblUserID.Text, txtTrackName.Text, Convert.ToInt32(txtSetGoal.Text), dtpGoalDate.Value.ToString());

                    if (countRecord > 0)
                    {
                        MessageBox.Show("Goal has been defined successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        trackForm.RefreshDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpGoalDate.Value = DateTime.Today;
            txtSetGoal.Text = "";
            cboAct.SelectedIndex = 0;
        }
    }
}
