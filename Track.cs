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

        public Track()
        {
            InitializeComponent();
        }

        public void RefreshDataGridView ()
        {
            dgvTrack.DataSource = objTracker.GetTrackerDataByUserID(UserLogin.loginUserID);
            dgvTrack.Refresh();
        }

        private void Track_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataset.Tracker' table. You can move, or remove it, as needed.
            this.trackerTableAdapter.Fill(this.fitnessTrackerDataset.Tracker);

            trackerDta = objTracker.GetData();
            dgvTrack.DataSource = trackerDta;

            trackerDta = objTracker.GetTrackerDataByUserID(UserLogin.loginUserID);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtMet.Text == "")
            {
                MessageBox.Show("Please enter met.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMet.Focus();
            }
            else if (txtTime.Text == "")
            {
                MessageBox.Show("Please enter time.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTime.Focus();
            }
            else if (txtAHR.Text == "")
            {
                MessageBox.Show("Please enter average heart rate.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAHR.Focus();
            }
            else
            {
                int met = Convert.ToInt32(txtMet.Text);
                int AvgHeartRange = Convert.ToInt32(txtAHR.Text);
                int time = Convert.ToInt32(txtTime.Text);

                int result = met * AvgHeartRange * time;
                txtCalBurn.Text = Convert.ToString(result);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int goal = Convert.ToInt32(lblGoal.Text);

            try
            {
                if (Convert.ToInt32(txtCalBurn.Text) >= goal)
                {
                    objTracker.UpdateTrackerData("Complete", Convert.ToInt32(txtCalBurn.Text), lblTrackID.Text);
                    MessageBox.Show("Your goal has been reached.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.RefreshDataGridView();
                }
                else
                {

                    DialogResult result = MessageBox.Show("Your goal has not been reached. Are you sure you want to save with fail?", "Confirm Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        objTracker.UpdateTrackerData("Fail", Convert.ToInt32(txtCalBurn.Text), lblTrackID.Text);
                        this.RefreshDataGridView();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            Goal goal = new Goal(this);
            goal.Show();
        }

        private void dgvTrack_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTrack.CurrentRow.Index;

            lblTrackID.Text = dgvTrack[0, row].Value.ToString();
            lblGoal.Text = dgvTrack[4, row].Value.ToString();

            dgvTrack.Refresh();
        }
    }
}
