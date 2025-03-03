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

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        private int rowIndex = 0;
        private readonly string enterActivityName = "Enter Activity Name";
        private readonly string enterMetricOne = "Enter Metric One";
        private readonly string enterMetricTwo = "Enter Metric Two";
        private readonly string enterMetricThree = "Enter Metric Three";

        public Activity()
        {
            InitializeComponent();
        }

        private void AutoID()
        {
            activityDta = objActivity.GetData();

            lblID.Text = Constant.AutoID(activityDta, 'A');
        }

        private void ClearAll()
        {
            this.ShowAllTextBoxPlaceholder();
            txtActivityName.Focus();
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
                dgvActData.DataSource = objActivity.GetAllActivities();
                dgvActData.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAllTextBoxPlaceholder()
        {
            TextBoxController.Placeholder(txtActivityName, enterActivityName);
            TextBoxController.Placeholder(txtMetricOne, enterMetricOne);
            TextBoxController.Placeholder(txtMetricTwo, enterMetricTwo);
            TextBoxController.Placeholder(txtMetricThree, enterMetricThree);
        }

        private void Activity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataset.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataset.Activities);
            AutoID();
            ShowAllTextBoxPlaceholder();

            dgvActData.DataSource = objActivity.GetAllActivities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtActivityName.Text == enterActivityName || txtActivityName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter activity name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtActivityName.Focus();
                }
                else if (txtMetricOne.Text == enterMetricOne || txtMetricOne.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Metric One.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricOne.Focus();
                }
                else if (txtMetricTwo.Text == enterMetricTwo || txtMetricTwo.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Metric Two.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricTwo.Focus();
                }
                else if (txtMetricThree.Text == enterMetricThree || txtMetricThree.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Metric Three.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricThree.Focus();
                }
                else
                {
                    clsActivity activity = new clsActivity();
                    activity.ActivityID = lblID.Text;
                    activity.ActivityName = txtActivityName.Text.Trim();
                    activity.MetricOne = txtMetricOne.Text.Trim();
                    activity.MetricTwo = txtMetricTwo.Text.Trim();
                    activity.MetricThree = txtMetricThree.Text.Trim();

                    int insertActivity = objActivity.InsertActivity(activity.ActivityID, activity.ActivityName, activity.MetricOne, activity.MetricTwo, activity.MetricThree);

                    if (insertActivity > 0)
                    {
                        MessageBox.Show("Activity has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvActData.DataSource = objActivity.GetAllActivities();
                        dgvActData.Refresh();

                        ClearAll();
                        ShowAllTextBoxPlaceholder();
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
            this.ClearAll();
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
                    trackerDta = objTracker.GetTrackerByActivityID(dgvActData[0, rowIndex].Value.ToString());

                    if (trackerDta.Rows.Count == 0)
                    {
                        objActivity.DeleteActivity(dgvActData[0, rowIndex].Value.ToString());

                        MessageBox.Show("Activity has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvActData.DataSource = objActivity.GetAllActivities();
                        dgvActData.Refresh();
                        AutoID();
                    }
                    else
                    {
                        MessageBox.Show("Users are already using this activity. You cannot delete this activity.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.Logout(this);
        }

        private void txtActivityName_Enter(object sender, EventArgs e)
        {
            if (txtActivityName.Text == enterActivityName)
            {
                TextBoxController.Placeholder(txtActivityName, "", Color.Black);
            }
        }

        private void txtActivityName_Leave(object sender, EventArgs e)
        {
            if (txtActivityName.Text.Trim() == "")
            {
                TextBoxController.Placeholder(txtActivityName, enterActivityName);
            }
        }

        private void txtMetricOne_Enter(object sender, EventArgs e)
        {
            if (txtMetricOne.Text == enterMetricOne)
            {
                TextBoxController.Placeholder(txtMetricOne, "", Color.Black);
            }
        }

        private void txtMetricOne_Leave(object sender, EventArgs e)
        {
            if (txtMetricOne.Text.Trim() == "")
            {
                TextBoxController.Placeholder(txtMetricOne, enterMetricOne);
            }
        }

        private void txtMetricTwo_Enter(object sender, EventArgs e)
        {
            if (txtMetricTwo.Text == enterMetricTwo)
            {
                TextBoxController.Placeholder(txtMetricTwo, "", Color.Black);
            }
        }

        private void txtMetricTwo_Leave(object sender, EventArgs e)
        {
            if (txtMetricTwo.Text.Trim() == "")
            {
                TextBoxController.Placeholder(txtMetricTwo, enterMetricTwo);
            }
        }

        private void txtMetricThree_Enter(object sender, EventArgs e)
        {
            if (txtMetricThree.Text == enterMetricThree)
            {
                TextBoxController.Placeholder(txtMetricThree, "", Color.Black);
            }
        }

        private void txtMetricThree_Leave(object sender, EventArgs e)
        {
            if (txtMetricThree.Text.Trim() == "")
            {
                TextBoxController.Placeholder(txtMetricThree, enterMetricThree);
            }
        }

        private void Activity_Resize(object sender, EventArgs e)
        {
            for (int key = 0; key < dgvActData.ColumnCount; key++)
            {
                if (key > 0)
                {
                    if (WindowState == FormWindowState.Maximized)
                    {
                        dgvActData.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        dgvActData.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                        dgvActData.Columns[key].Width = 154;
                    }
                }
                else
                {
                    dgvActData.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }
    }
}
