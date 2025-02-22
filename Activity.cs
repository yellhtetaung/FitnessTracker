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

        private int rowIndex = 0;

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
                string oldID = activityDta.Rows[size][0].ToString();
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

        public void UpdateActivity(string id, string name, string metricOne, string metricTwo, string metricThree)
        {
            try
            {
                clsActivity activity = new clsActivity();
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
                    clsActivity activity = new clsActivity();
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
                        txtActivityName.Focus();

                        AutoID();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            this.Hide();
            dashboard.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtActivityName.Text = "";
            txtMetricOne.Text = "";
            txtMetricTwo.Text = "";
            txtMetricThree.Text = "";
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

        private void dgvActData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvActData.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dgvActData.CurrentCell = dgvActData.Rows[rowIndex].Cells[1];

                if (e.Button == MouseButtons.Right)
                {
                    dgvActData.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    dgvActData.CurrentCell = dgvActData.Rows[rowIndex].Cells[1];
                    this.cmsActivity.Show(dgvActData, e.Location);
                    this.cmsActivity.Show(Cursor.Position);
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this activity?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    objActivity.DeleteActivity(dgvActData[0, rowIndex].Value.ToString());

                    MessageBox.Show("Activity has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvActData.DataSource = objActivity.GetData();
                    dgvActData.Refresh();
                    AutoID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove all activities?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    objActivity.DeleteAllActivity();

                    MessageBox.Show("All Activities have been removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvActData.DataSource = objActivity.GetData();
                    dgvActData.Refresh();
                    AutoID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
