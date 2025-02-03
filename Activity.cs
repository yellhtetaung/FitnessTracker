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
    public partial class Activity : Form
    {
        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        public Activity()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            activityDta = objActivity.GetData();

            if (activityDta.Rows.Count == 0)
            {
                lblID.Text = "A0001";
            }
            else
            {
                int size = activityDta.Rows.Count - 1;
                String oldID = activityDta.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    lblID.Text = "A000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblID.Text = "A00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblID.Text = "A0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    lblID.Text = "A" + (newID + 1);
                }
            }
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataset.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataset.Activities);
            AutoID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtActivityName.Text == "")
            {
                MessageBox.Show("Please enter activity name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActivityName.Focus();
            }
            else if (txtMetricOne.Text == "")
            {
                MessageBox.Show("Please enter Metric One.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetricOne.Focus();
            }
            else if (txtMetricTwo.Text == "")
            {
                MessageBox.Show("Please enter Metric Two.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetricTwo.Focus();
            }
            else if (txtMetricThree.Text == "")
            {
                MessageBox.Show("Please enter Metric Three.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetricThree.Focus();
            }
            else
            {
                ClsActivity activity = new ClsActivity();
                activity.ActivityID = lblID.Text;
                activity.ActivityName = txtActivityName.Text;
                activity.MetricOne = txtMetricOne.Text;
                activity.MetricTwo = txtMetricTwo.Text;
                activity.MetricThree = txtMetricThree.Text;

                int insertActivity = objActivity.InsertActivity(activity.ActivityID, activity.ActivityName, activity.MetricOne, activity.MetricTwo, activity.MetricThree);

                if (insertActivity > 0)
                {
                    MessageBox.Show("Activity has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvActData.DataSource = objActivity.GetData();
                    dgvActData.Refresh();
                }
                else
                {

                }
            }
        }
    }
}
