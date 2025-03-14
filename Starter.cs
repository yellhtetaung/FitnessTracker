using System;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserLogin login = new UserLogin();
            login.ShowDialog();
        }

        private void Starter_Load(object sender, EventArgs e)
        {

        }
    }
}
