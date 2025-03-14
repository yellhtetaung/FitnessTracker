using System;
using System.Data;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class GoalUpdate : Form
    {
        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();

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

        private void GoalUpdate_Load(object sender, EventArgs e)
        {
            lblUserID.Text = UserLogin.loginUserID;
            lblUsername.Text = UserLogin.loginUsername;
            lblActID.Text = ActivityID;
            txtSetGoal.Text = SetGoal.ToString();
            txtTrackName.Text = TrackerName;
            dtpGoalDate.Value = TrackDate;

            activityDta = objActivity.GetData();
            cboAct.DataSource = activityDta;
            cboAct.ValueMember = "ActID";
            cboAct.DisplayMember = "ActName";

            activityDta = objActivity.GetData();
            for (var index = 0; index < activityDta.Rows.Count; index++)
            {
                if (string.Equals(activityDta.Rows[index]["ActID"].ToString(), ActivityID))
                {
                    Console.WriteLine(index);
                    cboAct.SelectedIndex = index;
                }
            }

            ActivityChangeHandler();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                int countRecord = objTracker.UpdateTracker(lblActID.Text, UserID, txtTrackName.Text, Convert.ToInt32(txtSetGoal.Text), TotalCalBurn, dtpGoalDate.Value.ToString(), TrackStatus == "Complete" || TrackStatus == "Fail" ? TrackStatus : null, TrackerID);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityChangeHandler();
        }
    }
}
