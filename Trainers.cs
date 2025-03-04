using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum FilterByValues
{
    FullName,
    Username,
    Email,
    DOB,
    Phone,
    Address
}

namespace FitnessTracker
{
    public partial class Trainers : Form
    {
        FitnessTrackerDatasetTableAdapters.TrainersTableAdapter objTrainer = new FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
        DataTable trainerDta = new DataTable();

        private readonly string enterFullName = "Enter full name";
        private readonly string enterUsername = "Enter username";
        private readonly string enterEmail = "Enter email";
        private readonly string enterPhone = "Enter phone number";
        private readonly string enterAddress = "Enter address";

        private int rowIndex = 0;

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
            trainerDta = objTrainer.GetTrainerDataNotIncludeCurrentUser(Login.loginTrainerID);
            dgvTrainer.DataSource = trainerDta;
            cboFilterBy.SelectedIndex = 0;
            if (cboFilterBy.SelectedIndex != ((int)FilterByValues.DOB))
            {
                dtpDOB.Hide();
            }
        }

        public void DataGridViewReload()
        {
            dgvTrainer.DataSource = objTrainer.GetTrainerDataNotIncludeCurrentUser(Login.loginTrainerID);
            dgvTrainer.Refresh();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Starter starter = new Starter();
            this.Hide();
            starter.Show();
        }

        private void filterValueChangedHandler(int selectedIndex)
        {
            if (selectedIndex >= 0)
            {
                switch (selectedIndex)
                {
                    case (int)FilterByValues.DOB:
                        panelSearchText.Hide();
                        dtpDOB.Show();
                        dtpDOB.Value = DateTime.Today;
                        break;
                    case (int)FilterByValues.Username:
                        dtpDOB.Hide();
                        panelSearchText.Show();
                        TextBoxController.Placeholder(txtFilter, enterUsername);
                        break;
                    case (int)FilterByValues.Email:
                        dtpDOB.Hide();
                        panelSearchText.Show();
                        TextBoxController.Placeholder(txtFilter, enterEmail);
                        break;
                    case (int)FilterByValues.Phone:
                        dtpDOB.Hide();
                        panelSearchText.Show();
                        TextBoxController.Placeholder(txtFilter, enterPhone);
                        break;
                    case (int)FilterByValues.Address:
                        dtpDOB.Hide();
                        panelSearchText.Show();
                        TextBoxController.Placeholder(txtFilter, enterAddress);
                        break;
                    default:
                        dtpDOB.Hide();
                        panelSearchText.Show();
                        TextBoxController.Placeholder(txtFilter, enterFullName);
                        break;
                }
            }
        }

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterValueChangedHandler(cboFilterBy.SelectedIndex);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvTrainer.DataSource = objTrainer.GetTrainerDataNotIncludeCurrentUser(Login.loginTrainerID);
            dgvTrainer.Refresh();
            cboFilterBy.SelectedIndex = 0;
            filterValueChangedHandler(0);
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == enterFullName || txtFilter.Text == enterUsername || txtFilter.Text == enterEmail || txtFilter.Text == enterPhone || txtFilter.Text == enterAddress)
            {
                TextBoxController.Placeholder(txtFilter, "", Color.Black);
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (txtFilter.Text.Trim() == "")
            {
                filterValueChangedHandler(cboFilterBy.SelectedIndex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboFilterBy.SelectedIndex >= 0)
                {
                    if (cboFilterBy.SelectedIndex != ((int)FilterByValues.DOB))
                    {
                        bool isShowingPlaceholder = txtFilter.Text == enterFullName || txtFilter.Text == enterUsername || txtFilter.Text == enterEmail || txtFilter.Text == enterPhone || txtFilter.Text == enterAddress;
                        if (isShowingPlaceholder || txtFilter.Text.Trim() == "")
                        {
                            MessageBox.Show("Please enter filter value", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtFilter.Focus();
                        }
                        else
                        {
                            switch (cboFilterBy.SelectedIndex)
                            {
                                case (int)FilterByValues.Username:
                                    trainerDta = objTrainer.FilterTrainerByUsername(txtFilter.Text + "%", Login.loginTrainerID);
                                    dgvTrainer.DataSource = trainerDta;
                                    dgvTrainer.Refresh();
                                    break;
                                case (int)FilterByValues.Email:
                                    trainerDta = objTrainer.FilterTrainerByEmail(txtFilter.Text + "%", Login.loginTrainerID);
                                    dgvTrainer.DataSource = trainerDta;
                                    dgvTrainer.Refresh();
                                    break;
                                case (int)FilterByValues.Phone:
                                    trainerDta = objTrainer.FilterTrainerByPhone(txtFilter.Text + "%", Login.loginTrainerID);
                                    dgvTrainer.DataSource = trainerDta;
                                    dgvTrainer.Refresh();
                                    break;
                                case (int)FilterByValues.Address:
                                    trainerDta = objTrainer.FilterTrainerByAddress(txtFilter.Text + "%", Login.loginTrainerID);
                                    dgvTrainer.DataSource = trainerDta;
                                    dgvTrainer.Refresh();
                                    break;
                                default:
                                    trainerDta = objTrainer.FilterTrainerByFullName(txtFilter.Text + "%", Login.loginTrainerID);
                                    dgvTrainer.DataSource = trainerDta;
                                    dgvTrainer.Refresh();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        trainerDta = objTrainer.FilterTrainerByDOB(dtpDOB.Value, Login.loginTrainerID);
                        dgvTrainer.DataSource = trainerDta;
                        dgvTrainer.Refresh();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Trainers_Resize(object sender, EventArgs e)
        {
            for (int key = 0; key < dgvTrainer.ColumnCount; key++)
            {
                if (key > 0)
                {
                    if (WindowState == FormWindowState.Maximized)
                    {
                        dgvTrainer.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    else
                    {
                        dgvTrainer.Columns[key].AutoSizeMode = key == 5 ? DataGridViewAutoSizeColumnMode.DisplayedCells : DataGridViewAutoSizeColumnMode.NotSet;
                        dgvTrainer.Columns[key].Width = key == 5 ? 67 : 150;
                    }
                }
                else
                {
                    dgvTrainer.Columns[key].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTrainer updateTrainer = new UpdateTrainer();
            trainerDta = objTrainer.GetTrainerByTrainerID(dgvTrainer[0, rowIndex].Value.ToString());
            if (trainerDta.Rows.Count > 0)
            {
                updateTrainer.TrainerID = trainerDta.Rows[0]["TrainerID"].ToString();
                updateTrainer.FullName = trainerDta.Rows[0]["FullName"].ToString();
                updateTrainer.Username = trainerDta.Rows[0]["Username"].ToString();
                updateTrainer.Email = trainerDta.Rows[0]["Email"].ToString();
                updateTrainer.Password = trainerDta.Rows[0]["Password"].ToString();
                updateTrainer.DOB = Convert.ToDateTime(trainerDta.Rows[0]["DOB"].ToString());
                updateTrainer.Gender = Convert.ToChar(trainerDta.Rows[0]["Gender"].ToString());
                updateTrainer.PhoneNumber = trainerDta.Rows[0]["Phone"].ToString();
                updateTrainer.Address = trainerDta.Rows[0]["Address"].ToString();
            }
            updateTrainer.Show();
        }

        private void dgvTrainer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvTrainer.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dgvTrainer.CurrentCell = dgvTrainer.Rows[rowIndex].Cells[1];

                if (e.Button == MouseButtons.Right)
                {
                    dgvTrainer.Rows[e.RowIndex].Selected = true;
                    rowIndex = e.RowIndex;
                    dgvTrainer.CurrentCell = dgvTrainer.Rows[rowIndex].Cells[1];
                    this.cmsTrainer.Show(dgvTrainer, e.Location);
                    this.cmsTrainer.Show(Cursor.Position);
                }
            }
        }
    }
}
