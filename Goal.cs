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
        FitnessTrackerDatasetTableAdapters.UsersTableAdapter objUser = new FitnessTrackerDatasetTableAdapters.UsersTableAdapter();
        DataTable userDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter objActivity = new FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
        DataTable activityDta = new DataTable();

        FitnessTrackerDatasetTableAdapters.TrackerTableAdapter objTracker = new FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
        DataTable trackerDta = new DataTable();

        public Goal()
        {
            InitializeComponent();
        }

        public void AutoID()
        {
            trackerDta = objTracker.GetData();

            if (trackerDta.Rows.Count == 0)
            {
                lblTrackID.Text = "T0001";
            }
            else
            {
                int size = trackerDta.Rows.Count - 1;
                string oldID = trackerDta.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    lblTrackID.Text = "T000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    lblTrackID.Text = "T00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    lblTrackID.Text = "T0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    lblTrackID.Text = "T" + (newID + 1);
                }
            }
        }

        private void Goal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataset1.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataset1.Activities);
            // TODO: This line of code loads data into the 'fitnessTrackerDataset.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataset.Activities);
            lblUserID.Text = UserLogin.loginUserID;
            lblUsername.Text = UserLogin.loginUsername;
            AutoID();
            string id = cboAct.SelectedValue.ToString();
            lblActID.Text = id;
        }

        private void cboAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = cboAct.SelectedValue.ToString();
                lblActID.Text = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
