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
    public partial class UserDashboard : Form
    {
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        public UserDashboard()
        {
            InitializeComponent();
        }

        private void trackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Track track = new Track();
            this.Hide();
            track.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch();
            this.Hide();
            userSearch.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.Logout(this);
        }

        private void FetchUserInformation()
        {
            try
            {
                userDta = objUser.GetUserByUserID(UserLogin.loginUserID);

                if (userDta.Rows.Count > 0)
                {
                    lblID.Text = userDta.Rows[0]["UserID"].ToString();
                    lblFullname.Text = userDta.Rows[0]["Fullname"].ToString();
                    lblUsername.Text = userDta.Rows[0]["Username"].ToString();
                    lblEmail.Text = userDta.Rows[0]["Email"].ToString();
                    lblDOB.Text = Convert.ToDateTime(userDta.Rows[0]["DOB"].ToString()).ToString("dd / MMM / yyyy");
                    lblNRC.Text = userDta.Rows[0]["NationalID"].ToString();
                    lblPhone.Text = userDta.Rows[0]["Phone"].ToString();
                    lblAddress.Text = userDta.Rows[0]["Address"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FetchTrackStatus()
        {
            try
            {
                lblCompleteCount.Text = objTracker.GetTotalCountByTrackStatus("Complete").ToString();
                lblFailedCount.Text = objTracker.GetTotalCountByTrackStatus("Fail").ToString();
                lblProgressCount.Text = objTracker.GetTotalCountByProgress().ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            this.FetchUserInformation();
            this.FetchTrackStatus();
        }

        private void addGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goal goal = new Goal();
            goal.Show();
        }
    }
}
