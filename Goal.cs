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
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityChangeHandler();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTrackName.Text))
                {
                    MessageBox.Show("Please enter track name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTrackName.Focus();
                }
                else if (string.IsNullOrWhiteSpace(txtSetGoal.Text))
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
