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
    }
}
