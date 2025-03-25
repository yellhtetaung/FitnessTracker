using System;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Benefits : Form
    {
        public Benefits()
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
            Track track = new Track();
            this.Hide();
            track.Show();
        }

        private void addGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goal goal = new Goal();
            goal.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSearch userSearch = new UserSearch();
            this.Hide();
            userSearch.Show();
        }

        private void changeSizePanel(int layout, int margin)
        {
            panel1.Width = (flowLayoutPanel.Width / layout) - margin;
            panel2.Width = (flowLayoutPanel.Width / layout) - margin;
            panel3.Width = (flowLayoutPanel.Width / layout) - margin;
            panel4.Width = (flowLayoutPanel.Width / layout) - margin;
            panel5.Width = (flowLayoutPanel.Width / layout) - margin;
            panel6.Width = (flowLayoutPanel.Width / layout) - margin;
        }

        private void Benefits_Resize(object sender, EventArgs e)
        {
            if (flowLayoutPanel.Width >= 1536)
            {
                changeSizePanel(4, 9);
            }
            else if (flowLayoutPanel.Width >= 1280 && flowLayoutPanel.Width < 1536)
            {
                changeSizePanel(3, 9);
            }
            else
            {
                changeSizePanel(2, 20);
            }
        }

        private void Benefits_Load(object sender, EventArgs e)
        {
            changeSizePanel(2, 20);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Constant.Logout(this, Constant.Authorization.User);
        }
    }
}
