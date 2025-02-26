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
    public partial class GoalUpdate : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();


        public string TrackerID { set; get; }
        public string UserID { set; get; }
        public string ActivityID { set; get; }
        public string TrackerName { set; get; }
        public int? SetGoal { set; get; }
        public int? TotalCalBurn { set; get; }
        public DateTime TrackDate { set; get; }
        public string TrackStatus { set; get; }

        private readonly Track trackForm;


        public GoalUpdate(Track track)
        {
            InitializeComponent();
            trackForm = track;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSetGoal.Text == "")
                {
                    MessageBox.Show("Please enter your goal.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSetGoal.Focus();
                }

                int countRecord = objTracker.UpdateTracker(ActivityID, UserID, TrackerName, Convert.ToInt32(txtSetGoal.Text), TotalCalBurn, dtpGoalDate.Value.ToString(), TrackStatus, TrackerID);

                if (countRecord > 0)
                {
                    MessageBox.Show("Goal has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    trackForm.RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoalUpdate_Load(object sender, EventArgs e)
        {

            lblUserID.Text = UserLogin.loginUserID;
            lblUsername.Text = UserLogin.loginUsername;
            lblActID.Text = ActivityID;
            txtSetGoal.Text = SetGoal.ToString();

            DataTable activityDta = objActivity.GetData();

            for (int index = 0; index < activityDta.Rows.Count; index++)
            {
                if (String.Equals(activityDta.Rows[index]["ActID"], ActivityID))
                {
                    cboAct.SelectedIndex = index;
                }
            }
            ActivityChangeHandler();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
