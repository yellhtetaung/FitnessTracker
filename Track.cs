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
    public partial class Track : Form
    {
        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        private int rowIndex = 0;
        private readonly string enterMet = "Enter met";
        private readonly string enterTime = "Enter time";
        private readonly string enterAHR = "Enter average heart rate";

        public Track()
        {
            InitializeComponent();
        }

        private void FetchDataGridView()
        {
            try
            {
                trackerDta = objTracker.GetTrackerDataByUserID(UserLogin.loginUserID);
                DataTable filterDataTable = trackerDta.DefaultView.ToTable(false, Constant.TableColumnName.TrackerID.ToString(), Constant.TableColumnName.TrackerName.ToString(), Constant.TableColumnName.ActivityName.ToString(), Constant.TableColumnName.SetGoal.ToString(), Constant.TableColumnName.TrackDate.ToString(), Constant.TableColumnName.TotalCalBurn.ToString(), Constant.TableColumnName.TrackStatus.ToString(), Constant.TableColumnName.CreatedDate.ToString());
                dgvTrack.DataSource = filterDataTable;
                dgvTrack.Columns[(int)Constant.TableColumnName.TrackerID].HeaderText = "Tracker ID";
                dgvTrack.Columns[(int)Constant.TableColumnName.TrackerName].HeaderText = "Tracker Name";
                dgvTrack.Columns[(int)Constant.TableColumnName.ActivityName].HeaderText = "Activity Name";
                dgvTrack.Columns[(int)Constant.TableColumnName.SetGoal].HeaderText = "Set Goal";
                dgvTrack.Columns[(int)Constant.TableColumnName.TrackDate].HeaderText = "Track Date";
                dgvTrack.Columns[(int)Constant.TableColumnName.TotalCalBurn].HeaderText = "Total Cal Burn";
                dgvTrack.Columns[(int)Constant.TableColumnName.TrackStatus].HeaderText = "Track Status";
                dgvTrack.Columns[(int)Constant.TableColumnName.CreatedDate].HeaderText = "Created Date";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RefreshDataGridView()
        {
            FetchDataGridView();
            dgvTrack.Refresh();
        }

        private void ShowAllPlaceholder()
        {
            TextBoxController.Placeholder(txtMet, enterMet);
            TextBoxController.Placeholder(txtTime, enterTime);
            TextBoxController.Placeholder(txtTime, enterAHR);
        }

        private void Track_Load(object sender, EventArgs e)
        {
            this.FetchDataGridView();

            for (int key = 0; key < dgvTrack.ColumnCount; key++)
            {
                if (key > 0)
                {
                    dgvTrack.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dgvTrack.Columns[key].Width = key == (int)Constant.TableColumnName.TrackDate || key == (int)Constant.TableColumnName.CreatedDate || key == (int)Constant.TableColumnName.TrackerName || key == (int)Constant.TableColumnName.ActivityName ? 150 : 100;
                }
                else
                {
                    dgvTrack.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMet.Text))
            {
                MessageBox.Show("Please enter met.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMet.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please enter time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTime.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtAHR.Text))
            {
                MessageBox.Show("Please enter average heart rate.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAHR.Focus();
            }
            else
            {
                int met = Convert.ToInt32(txtMet.Text);
                int AvgHeartRate = Convert.ToInt32(txtAHR.Text);
                int time = Convert.ToInt32(txtTime.Text);

                int result = met * AvgHeartRate * time;
                lblCalBurn.Text = Convert.ToString(result);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int goal = Convert.ToInt32(lblGoal.Text);

            try
            {
                if (Convert.ToInt32(lblCalBurn.Text) >= goal)
                {
                    objTracker.UpdateTrackerStatusAndTotalCal("Complete", Convert.ToInt32(lblCalBurn.Text), lblTrackID.Text);
                    MessageBox.Show("Your goal has been reached.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.RefreshDataGridView();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Your goal has not been reached. Are you sure you want to save with fail?", "Confirm Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        objTracker.UpdateTrackerStatusAndTotalCal("Fail", Convert.ToInt32(lblCalBurn.Text), lblTrackID.Text);
                        this.RefreshDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTrack_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTrack.CurrentRow.Index;

            lblTrackID.Text = dgvTrack[(int)Constant.TableColumnName.TrackerID, row].Value.ToString();
            lblGoal.Text = dgvTrack[(int)Constant.TableColumnName.SetGoal, row].Value.ToString();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDashboard dashboard = new UserDashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GoalUpdate goalUpdate = new GoalUpdate(this);
                DataTable trackerData = objTracker.GetTrackerDataByTrackerID(dgvTrack[(int)Constant.TableColumnName.TrackerID, rowIndex].Value.ToString());

                if (trackerData.Rows.Count > 0)
                {
                    goalUpdate.TrackerID = trackerData.Rows[0]["TrackerID"].ToString();
                    goalUpdate.TrackerName = trackerData.Rows[0]["TrackerName"].ToString();
                    goalUpdate.ActivityID = trackerData.Rows[0]["ActID"].ToString();
                    goalUpdate.UserID = trackerData.Rows[0]["UserID"].ToString();
                    goalUpdate.SetGoal = Convert.ToInt32(trackerData.Rows[0]["SetGoal"].ToString());
                    goalUpdate.TrackDate = Convert.ToDateTime(trackerData.Rows[0]["TrackDate"].ToString());
                    goalUpdate.TrackStatus = trackerData.Rows[0]["TrackStatus"].ToString();

                    if (dgvTrack[5, rowIndex].Value is DBNull)
                    {
                        goalUpdate.TotalCalBurn = null;
                    }
                    else
                    {
                        goalUpdate.TotalCalBurn = Convert.ToInt32(dgvTrack[5, rowIndex].Value.ToString());
                    }

                    if (!(dgvTrack[7, rowIndex].Value is DBNull))
                    {
                        goalUpdate.TrackStatus = dgvTrack[7, rowIndex].Value.ToString();
                    }

                    goalUpdate.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all trackers?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                objTracker.DeleteAllTracker();
                MessageBox.Show("All Trackers have been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshDataGridView();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all trackers?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                objTracker.DeleteTracker(dgvTrack[0, rowIndex].Value.ToString());
                MessageBox.Show("Tracker has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshDataGridView();
            }
        }

        private void Track_Resize(object sender, EventArgs e)
        {
            for (int key = 0; key < dgvTrack.ColumnCount; key++)
            {
                if (key > 0)
                {
                    if (WindowState == FormWindowState.Maximized)
                    {
                        dgvTrack.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        dgvTrack.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                        dgvTrack.Columns[key].Width = key == (int)Constant.TableColumnName.TrackDate || key == (int)Constant.TableColumnName.CreatedDate || key == (int)Constant.TableColumnName.TrackerName || key == (int)Constant.TableColumnName.ActivityName ? 150 : 100;
                    }
                }
                else
                {
                    dgvTrack.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.Logout(this);
        }

        private void dgvTrack_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvTrack.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dgvTrack.CurrentCell = dgvTrack.Rows[rowIndex].Cells[1];

                if (e.Button == MouseButtons.Right)
                {
                    dgvTrack.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    dgvTrack.CurrentCell = dgvTrack.Rows[rowIndex].Cells[1];
                    this.cmsTrack.Show(dgvTrack, e.Location);
                    this.cmsTrack.Show(Cursor.Position);
                }
            }
        }

        private void cmsTrack_Opened(object sender, EventArgs e)
        {
            switch (dgvTrack[(int)Constant.TableColumnName.TrackStatus, rowIndex].Value.ToString())
            {
                case "Complete":
                    updateToolStripMenuItem.Enabled = false;
                    break;
                case "Fail":
                    updateToolStripMenuItem.Enabled = false;
                    break;
                default:
                    updateToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch();
            this.Hide();
            userSearch.Show();
        }

        private void txtMet_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtMet.Text, enterMet))
            {
                TextBoxController.Placeholder(txtMet, "", Color.Black);
            }
        }

        private void txtMet_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMet.Text))
            {
                TextBoxController.Placeholder(txtMet, enterMet);
            }
        }

        private void txtTime_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtTime.Text, enterTime))
            {
                TextBoxController.Placeholder(txtTime, "", Color.Black);
            }
        }

        private void txtTime_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTime.Text))
            {
                TextBoxController.Placeholder(txtTime, enterTime);
            }
        }

        private void txtAHR_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtAHR.Text, enterAHR))
            {
                TextBoxController.Placeholder(txtAHR, "", Color.Black);
            }
        }

        private void txtAHR_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAHR.Text))
            {
                TextBoxController.Placeholder(txtAHR, enterAHR);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTrackID.Text = "-";
            lblGoal.Text = "0";
            lblCalBurn.Text = "0";
            this.ShowAllPlaceholder();
        }

        private void addGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goal goal = new Goal(this);
            goal.Show();
        }
    }
}
