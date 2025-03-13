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

        private readonly string enterActivityName = "Enter Activity Name";
        private readonly string enterMetricOne = "Enter Metric One";
        private readonly string enterMetricTwo = "Enter Metric Two";
        private readonly string enterMetricThree = "Enter Metric Three";

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
                if (string.Equals(txtActivityName.Text, enterActivityName) || string.IsNullOrWhiteSpace(txtActivityName.Text))
                {
                    MessageBox.Show("Please enter activity name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtActivityName.Focus();
                }
                else if (string.Equals(txtMetricOne.Text, enterMetricOne) || string.IsNullOrWhiteSpace(txtMetricOne.Text))
                {
                    MessageBox.Show("Please enter Metric One.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricOne.Focus();
                }
                else if (string.Equals(txtMetricTwo.Text, enterMetricTwo) || string.IsNullOrWhiteSpace(txtMetricTwo.Text))
                {
                    MessageBox.Show("Please enter Metric Two.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricTwo.Focus();
                }
                else if (string.Equals(txtMetricThree.Text, enterMetricThree) || string.IsNullOrWhiteSpace(txtMetricThree.Text))
                {
                    MessageBox.Show("Please enter Metric Three.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMetricThree.Focus();
                }
                else
                {
                    ClsActivity activity = new ClsActivity();
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
            this.Hide();
        }

        private void ActivityDetail_Load(object sender, EventArgs e)
        {
            lblID.Text = ActivityID;

            if (!string.IsNullOrWhiteSpace(this.ActivityName))
            {
                TextBoxController.Placeholder(txtActivityName, this.ActivityName, Color.Black);
            }
            else
            {
                TextBoxController.Placeholder(txtActivityName, enterActivityName);
            }

            if (!string.IsNullOrWhiteSpace(this.MetricOne))
            {
                TextBoxController.Placeholder(txtMetricOne, this.MetricOne, Color.Black);
            }
            else
            {
                TextBoxController.Placeholder(txtMetricOne, enterMetricOne);
            }

            if (!string.IsNullOrWhiteSpace(this.MetricTwo))
            {
                TextBoxController.Placeholder(txtMetricTwo, this.MetricTwo, Color.Black);
            }
            else
            {
                TextBoxController.Placeholder(txtMetricTwo, enterMetricTwo);
            }

            if (!string.IsNullOrWhiteSpace(this.MetricThree))
            {
                TextBoxController.Placeholder(txtMetricThree, this.MetricThree, Color.Black);
            }
            else
            {
                TextBoxController.Placeholder(txtMetricThree, enterMetricThree);
            }
        }

        private void txtActivityName_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtActivityName.Text, enterActivityName))
            {
                TextBoxController.Placeholder(txtActivityName, "", Color.Black);
            }
        }

        private void txtActivityName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtActivityName.Text))
            {
                TextBoxController.Placeholder(txtActivityName, enterActivityName);
            }
        }

        private void txtMetricOne_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtMetricOne.Text, enterMetricOne))
            {
                TextBoxController.Placeholder(txtMetricOne, "", Color.Black);
            }
        }

        private void txtMetricOne_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMetricOne.Text))
            {
                TextBoxController.Placeholder(txtMetricOne, enterMetricOne);
            }
        }

        private void txtMetricTwo_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtMetricTwo.Text, enterMetricTwo))
            {
                TextBoxController.Placeholder(txtMetricTwo, "", Color.Black);
            }
        }

        private void txtMetricTwo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMetricTwo.Text))
            {
                TextBoxController.Placeholder(txtMetricTwo, enterMetricTwo);
            }
        }

        private void txtMetricThree_Enter(object sender, EventArgs e)
        {
            if (string.Equals(txtMetricThree.Text, enterMetricThree))
            {
                TextBoxController.Placeholder(txtMetricThree, "", Color.Black);
            }
        }

        private void txtMetricThree_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMetricThree.Text))
            {
                TextBoxController.Placeholder(txtMetricThree, enterMetricThree);
            }
        }
    }
}
