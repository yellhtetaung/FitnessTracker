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
            if (WindowState == FormWindowState.Maximized)
            {
                changeSizePanel(3, 9);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Console.WriteLine(flowLayoutPanel.Width);
                changeSizePanel(2, 20);
            }
        }

        private void Benefits_Load(object sender, EventArgs e)
        {
            changeSizePanel(2, 20);
        }
    }
}
