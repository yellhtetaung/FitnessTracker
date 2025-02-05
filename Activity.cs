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

        public void ClearAll()
        {
            txtActivityName.Clear();
            txtMetricOne.Clear();
            txtMetricTwo.Clear();
            txtMetricThree.Clear();
        }

        public void UpdateActivity(String id, String name, String metricOne, String metricTwo, String metricThree)
        {
            try
            {
                ClsActivity activity = new ClsActivity();
                activity.ActivityID = id;
                activity.ActivityName = name;
                activity.MetricOne = metricOne;
                activity.MetricTwo = metricTwo;
                activity.MetricThree = metricThree;

                objActivity.UpdateActivity(activity.ActivityName, activity.MetricOne, activity.MetricTwo, activity.MetricThree, activity.ActivityID);
                dgvActData.DataSource = objActivity.GetData();
                dgvActData.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteActivity (String id)
        {
            try
            {
                objActivity.DeleteActivity(id);
                dgvActData.Refresh();
                AutoID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
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

                        ClearAll();

                        AutoID();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvActData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActivityDetail activityDetail = new ActivityDetail(this);
            int row = dgvActData.CurrentRow.Index;

            activityDetail.ActivityID = dgvActData[0, row].Value.ToString();
            activityDetail.ActivityName = dgvActData[1, row].Value.ToString();
            activityDetail.MetricOne = dgvActData[2, row].Value.ToString();
            activityDetail.MetricTwo = dgvActData[3, row].Value.ToString();
            activityDetail.MetricThree = dgvActData[4, row].Value.ToString();

            activityDetail.Show();
        }
    }
}
