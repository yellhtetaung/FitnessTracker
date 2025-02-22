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
    public partial class Trainers : Form
    {
        public Trainers()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            this.Hide();
            dashboard.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            this.Hide();
            activity.Show();
        }

        private void Trainers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataset.Trainers' table. You can move, or remove it, as needed.
            this.trainersTableAdapter.Fill(this.fitnessTrackerDataset.Trainers);

        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
