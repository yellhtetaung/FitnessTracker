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

        private void menuAdmin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Activity activity = new Activity();
            this.Hide();
            activity.ShowDialog();
        }
    }
}
