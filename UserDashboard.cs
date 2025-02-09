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
            this.Hide();
            Track track = new Track();
            track.Show();
        }
    }
}
