
namespace FitnessTracker
{
    partial class Trainers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainers));
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTrainer = new System.Windows.Forms.DataGridView();
            this.cmsTrainers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataset1 = new FitnessTracker.FitnessTrackerDataset();
            this.fitnessTrackerDataset = new FitnessTracker.FitnessTrackerDataset();
            this.trainersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainersTableAdapter = new FitnessTracker.FitnessTrackerDatasetTableAdapters.TrainersTableAdapter();
            this.trainerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainer)).BeginInit();
            this.cmsTrainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Padding = new System.Windows.Forms.Padding(12);
            this.menuAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuAdmin.Size = new System.Drawing.Size(944, 44);
            this.menuAdmin.TabIndex = 1;
            this.menuAdmin.Text = "menuAdmin";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activityToolStripMenuItem.Image")));
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountListToolStripMenuItem,
            this.addAccountToolStripMenuItem});
            this.accountsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountsToolStripMenuItem.Image")));
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.accountsToolStripMenuItem.Text = "Account";
            // 
            // accountListToolStripMenuItem
            // 
            this.accountListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountListToolStripMenuItem.Image")));
            this.accountListToolStripMenuItem.Name = "accountListToolStripMenuItem";
            this.accountListToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.accountListToolStripMenuItem.Text = "Account List";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAccountToolStripMenuItem.Image")));
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addAccountToolStripMenuItem.Text = "Create Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dgvTrainer
            // 
            this.dgvTrainer.AllowUserToAddRows = false;
            this.dgvTrainer.AllowUserToDeleteRows = false;
            this.dgvTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainer.AutoGenerateColumns = false;
            this.dgvTrainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainerIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.CreatedDate});
            this.dgvTrainer.DataSource = this.trainersBindingSource1;
            this.dgvTrainer.Location = new System.Drawing.Point(0, 186);
            this.dgvTrainer.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTrainer.Name = "dgvTrainer";
            this.dgvTrainer.ReadOnly = true;
            this.dgvTrainer.Size = new System.Drawing.Size(944, 378);
            this.dgvTrainer.TabIndex = 48;
            // 
            // cmsTrainers
            // 
            this.cmsTrainers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.cmsTrainers.Name = "cmsTrainers";
            this.cmsTrainers.Size = new System.Drawing.Size(157, 48);
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            // 
            // trainersBindingSource1
            // 
            this.trainersBindingSource1.DataMember = "Trainers";
            this.trainersBindingSource1.DataSource = this.fitnessTrackerDataset1;
            // 
            // fitnessTrackerDataset1
            // 
            this.fitnessTrackerDataset1.DataSetName = "FitnessTrackerDataset";
            this.fitnessTrackerDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fitnessTrackerDataset
            // 
            this.fitnessTrackerDataset.DataSetName = "FitnessTrackerDataset";
            this.fitnessTrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainersBindingSource
            // 
            this.trainersBindingSource.DataMember = "Trainers";
            this.trainersBindingSource.DataSource = this.fitnessTrackerDataset;
            // 
            // trainersTableAdapter
            // 
            this.trainersTableAdapter.ClearBeforeFill = true;
            // 
            // trainerIDDataGridViewTextBoxColumn
            // 
            this.trainerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.trainerIDDataGridViewTextBoxColumn.DataPropertyName = "TrainerID";
            this.trainerIDDataGridViewTextBoxColumn.HeaderText = "TrainerID";
            this.trainerIDDataGridViewTextBoxColumn.Name = "trainerIDDataGridViewTextBoxColumn";
            this.trainerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainerIDDataGridViewTextBoxColumn.Width = 76;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 564);
            this.Controls.Add(this.dgvTrainer);
            this.Controls.Add(this.menuAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 603);
            this.Name = "Trainers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainers";
            this.Load += new System.EventHandler(this.Trainers_Load);
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainer)).EndInit();
            this.cmsTrainers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private FitnessTrackerDataset fitnessTrackerDataset;
        private System.Windows.Forms.BindingSource trainersBindingSource;
        private FitnessTrackerDatasetTableAdapters.TrainersTableAdapter trainersTableAdapter;
        private System.Windows.Forms.DataGridView dgvTrainer;
        private System.Windows.Forms.ToolStripMenuItem accountListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTrainers;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private FitnessTrackerDataset fitnessTrackerDataset1;
        private System.Windows.Forms.BindingSource trainersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
    }
}