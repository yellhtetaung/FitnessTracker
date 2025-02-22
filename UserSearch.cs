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
    public partial class UserSearch : Form
    {
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
            Track track = new Track();
            this.Hide();
            track.Show();
        }
    }
}
