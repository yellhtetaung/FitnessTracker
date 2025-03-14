using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Goal : Form
    {
        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        private readonly Track trackForm;
        private readonly string enterTrackName = "Enter track name";
        private readonly string enterSetGoal = "Enter set goal";

        public Goal()
        {
            InitializeComponent();
        }

        public Goal(Track track)
        {
            InitializeComponent();
            trackForm = track;
        }

        public void AutoID()
        {
            trackerDta = objTracker.GetData();
            lblTrackID.Text = Constant.AutoID(trackerDta, 'T');
        }

        public void ActivityChangeHandler()
        {
            try
            {
                if (cboAct.SelectedValue != null)
                {
                    string id = cboAct.SelectedValue.ToString();
                    Console.WriteLine(id);
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
            activityDta = objActivity.GetData();
            cboAct.DataSource = activityDta;
            cboAct.ValueMember = "ActID";
            cboAct.DisplayMember = "ActName";

            lblUserID.Text = UserLogin.loginUserID;
            lblUsername.Text = UserLogin.loginUsername;

            AutoID();
            ActivityChangeHandler();

            dtpGoalDate.MinDate = DateTime.Today;

            TextBoxController.Placeholder(txtTrackName, enterTrackName);
            TextBoxController.Placeholder(txtSetGoal, enterSetGoal);
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityChangeHandler();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Equals(txtTrackName.Text, enterTrackName) || string.IsNullOrWhiteSpace(txtTrackName.Text))
                {
                    MessageBox.Show("Please enter track name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTrackName.Focus();
                }
                else if (string.Equals(txtSetGoal.Text, enterSetGoal) || string.IsNullOrWhiteSpace(txtSetGoal.Text))
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
                        if (trackForm != null)
                        {
                            trackForm.RefreshDataGridView();
                        }
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
            TextBoxController.Placeholder(txtTrackName, enterTrackName);
            TextBoxController.Placeholder(txtSetGoal, enterSetGoal);
            cboAct.SelectedIndex = 0;
        }

        private void txtTrackName_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtTrackName.Text, enterTrackName))
            {
                TextBoxController.Placeholder(txtTrackName, "", Color.Black);
            }
        }

        private void txtTrackName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrackName.Text))
            {
                TextBoxController.Placeholder(txtTrackName, enterTrackName);
            }
        }

        private void txtSetGoal_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtSetGoal.Text, enterSetGoal))
            {
                TextBoxController.Placeholder(txtSetGoal, "", Color.Black);
            }
        }

        private void txtSetGoal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSetGoal.Text))
            {
                TextBoxController.Placeholder(txtSetGoal, enterSetGoal);
            }
        }
    }
}
