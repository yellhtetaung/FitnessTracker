using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class UserSearch : Form
    {
        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        private enum FilterByValues
        {
            TrackName,
            ActivityName,
            Goal,
            TrackDate,
            TrackStatus,
            CreatedDate
        }

        private enum FilterByTrackStatus
        {
            Progress,
            Completed,
            Failed,
        }

        private readonly string enterTrackName = "Enter track name";
        private readonly string enterGoal = "Enter goal number";

        public UserSearch()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDashboard dashboard = new UserDashboard();
            this.Hide();
            dashboard.Show();
        }

        private void trackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tracker track = new Tracker();
            this.Hide();
            track.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.Logout(this, Constant.Authorization.User);
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

        private void FetchDataGridView(DataTable dataTable)
        {
            try
            {
                DataTable filterDataTable = dataTable.DefaultView.ToTable(false, Constant.TableColumnName.TrackerID.ToString(), Constant.TableColumnName.TrackerName.ToString(), Constant.TableColumnName.ActivityName.ToString(), Constant.TableColumnName.SetGoal.ToString(), Constant.TableColumnName.TrackDate.ToString(), Constant.TableColumnName.TotalCalBurn.ToString(), Constant.TableColumnName.TrackStatus.ToString(), Constant.TableColumnName.CreatedDate.ToString());
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

        private void UserSearch_Load(object sender, EventArgs e)
        {
            this.FetchDataGridView();
            cboFilterBy.SelectedIndex = 0;
            cboTrackStatus.SelectedIndex = 0;

            activityDta = objActivity.GetData();
            cboActivity.DataSource = activityDta;
            cboActivity.ValueMember = "ActID";
            cboActivity.DisplayMember = "ActName";

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

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

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboFilterBy.SelectedIndex)
            {
                case (int)FilterByValues.ActivityName:
                    panelDate.Hide();
                    cboTrackStatus.Hide();
                    panelSearchText.Hide();
                    cboActivity.Show();
                    break;
                case (int)FilterByValues.Goal:
                    panelDate.Hide();
                    cboTrackStatus.Hide();
                    panelSearchText.Show();
                    cboActivity.Hide();
                    TextBoxController.Placeholder(txtFilter, enterGoal);
                    break;
                case (int)FilterByValues.TrackDate:
                    panelDate.Show();
                    cboTrackStatus.Hide();
                    panelSearchText.Hide();
                    cboActivity.Hide();
                    break;
                case (int)FilterByValues.TrackStatus:
                    panelDate.Hide();
                    cboTrackStatus.Show();
                    panelSearchText.Hide();
                    cboActivity.Hide();
                    break;
                case (int)FilterByValues.CreatedDate:
                    panelDate.Show();
                    cboTrackStatus.Hide();
                    panelSearchText.Hide();
                    cboActivity.Hide();
                    break;
                default:
                    panelDate.Hide();
                    cboTrackStatus.Hide();
                    panelSearchText.Show();
                    TextBoxController.Placeholder(txtFilter, enterTrackName);
                    cboActivity.Hide();
                    break;
            }
            this.FetchDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboFilterBy.SelectedIndex >= 0)
                {
                    if (cboFilterBy.SelectedIndex == (int)FilterByValues.Goal || cboFilterBy.SelectedIndex == (int)FilterByValues.TrackName)
                    {
                        var isShowingPlaceholder = string.Equals(txtFilter.Text, enterTrackName) || string.Equals(txtFilter.Text, enterGoal);
                        if (string.IsNullOrWhiteSpace(txtFilter.Text) || isShowingPlaceholder)
                        {
                            if (cboFilterBy.SelectedIndex == (int)FilterByValues.Goal)
                            {
                                MessageBox.Show("Please enter goal number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (cboFilterBy.SelectedIndex == (int)FilterByValues.TrackName)
                            {
                                MessageBox.Show("Please enter track name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            txtFilter.Focus();
                        }
                        else
                        {
                            if (cboFilterBy.SelectedIndex == (int)FilterByValues.Goal)
                            {
                                trackerDta = objTracker.FilterTrackerBySetGoal(UserLogin.loginUserID, Convert.ToInt32(txtFilter.Text));
                                this.FetchDataGridView(trackerDta);
                            }
                            else if (cboFilterBy.SelectedIndex == (int)FilterByValues.TrackName)
                            {
                                trackerDta = objTracker.FilterTrackerByTrackerName(UserLogin.loginUserID, txtFilter.Text + "%");
                                this.FetchDataGridView(trackerDta);
                            }
                        }
                    }
                    else if (cboFilterBy.SelectedIndex == (int)FilterByValues.TrackStatus)
                    {
                        if (cboTrackStatus.SelectedIndex == (int)FilterByTrackStatus.Progress)
                        {
                            trackerDta = objTracker.FilterTrackerByTrackStatusProgress(UserLogin.loginUserID);
                            this.FetchDataGridView(trackerDta);
                        }
                        else
                        {
                            trackerDta = objTracker.FilterTrackerByTrackStatus(UserLogin.loginUserID, cboTrackStatus.SelectedIndex == (int)FilterByTrackStatus.Completed ? Constant.TrackStatus.Complete.ToString() : Constant.TrackStatus.Fail.ToString());
                            this.FetchDataGridView(trackerDta);
                        }
                    }
                    else if (cboFilterBy.SelectedIndex == (int)FilterByValues.ActivityName)
                    {
                        trackerDta = objTracker.FilterTrackerByActivityID(UserLogin.loginUserID, cboActivity.SelectedValue.ToString());
                        this.FetchDataGridView(trackerDta);
                    }
                    else if (cboFilterBy.SelectedIndex == (int)FilterByValues.CreatedDate)
                    {
                        trackerDta = objTracker.FilterTrackerByCreatedDate(UserLogin.loginUserID, dtpStartDate.Value, dtpEndDate.Value);
                        this.FetchDataGridView(trackerDta);
                    }
                    else
                    {
                        trackerDta = objTracker.FilterTrainerByTrackDate(UserLogin.loginUserID, dtpStartDate.Value.ToString("yyyy-MM-dd"), dtpEndDate.Value.ToString("yyyy-MM-dd"));
                        this.FetchDataGridView(trackerDta);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == enterTrackName || txtFilter.Text == enterGoal)
            {
                TextBoxController.Placeholder(txtFilter, "", Color.Black);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.FetchDataGridView();
            cboFilterBy.SelectedIndex = 0;
            TextBoxController.Placeholder(txtFilter, enterTrackName);
            cboActivity.SelectedIndex = 0;
            cboTrackStatus.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today;
            dtpStartDate.MinDate = new DateTime(1753, 1, 1);
            dtpEndDate.Value = DateTime.Today;
            dtpEndDate.MinDate = new DateTime(1753, 1, 1);
            this.ActiveControl = null;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void addGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goal goal = new Goal();
            goal.Show();
        }

        private void UserSearch_Resize(object sender, EventArgs e)
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

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Benefits benefits = new Benefits();
            this.Hide();
            benefits.Show();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (cboFilterBy.SelectedIndex == (int)FilterByValues.Goal)
            {
                Constant.CheckNumberOnly(txtFilter, enterGoal);
            }
        }
    }
}
