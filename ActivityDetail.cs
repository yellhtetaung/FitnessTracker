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
    public partial class ActivityDetail : Form
    {
        public string ActivityID { set; get; }
        public string ActivityName { set; get; }
        public string MetricOne { set; get; }
        public string MetricTwo { set; get; }
        public string MetricThree { set; get; }

        private readonly Activity activityForm;

        public ActivityDetail(Activity activity)
        {
            InitializeComponent();
            activityForm = activity;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtActivityName.Text == "")
                {
                    MessageBox.Show("Please enter activity name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtActivityName.Focus();
                }
                else if (txtMetricOne.Text == "")
                {
                    MessageBox.Show("Please enter Metric One.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricOne.Focus();
                }
                else if (txtMetricTwo.Text == "")
                {
                    MessageBox.Show("Please enter Metric Two.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricTwo.Focus();
                }
                else if (txtMetricThree.Text == "")
                {
                    MessageBox.Show("Please enter Metric Three.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricThree.Focus();
                }
                else
                {
                    clsActivity activity = new clsActivity();
                    activity.ActivityID = lblID.Text;
                    activity.ActivityName = txtActivityName.Text;
                    activity.MetricOne = txtMetricOne.Text;
                    activity.MetricTwo = txtMetricTwo.Text;
                    activity.MetricThree = txtMetricThree.Text;

                    activityForm.UpdateActivity(activity.ActivityID, activity.ActivityName, activity.MetricOne, activity.MetricTwo, activity.MetricThree);
                    MessageBox.Show("Activity has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this activity?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                activityForm.DeleteActivity(lblID.Text);
                MessageBox.Show("Activity has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ActivityDetail_Load(object sender, EventArgs e)
        {
            lblID.Text = ActivityID;
            txtActivityName.Text = ActivityName;
            txtMetricOne.Text = MetricOne;
            txtMetricTwo.Text = MetricTwo;
            txtMetricThree.Text = MetricThree;
        }
    }
}
