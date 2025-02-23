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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity activity = new Activity();
            this.Hide();
            activity.Show();
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainers trainers = new Trainers();
            this.Hide();
            trainers.Show();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Starter starter = new Starter();
            this.Hide();
            starter.Show();
        }
    }
}
