
namespace FitnessTracker
{
    partial class Activity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity));
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtMetricOne = new System.Windows.Forms.TextBox();
            this.lblMetricOne = new System.Windows.Forms.Label();
            this.lblActivityName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMetricTwo = new System.Windows.Forms.TextBox();
            this.lblMetricTwo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMetricThree = new System.Windows.Forms.TextBox();
            this.lblMetricThree = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvActData = new System.Windows.Forms.DataGridView();
            this.actIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataset = new FitnessTracker.FitnessTrackerDataset();
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsActivity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesTableAdapter = new FitnessTracker.FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).BeginInit();
            this.menuAdmin.SuspendLayout();
            this.cmsActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(15, 61);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(79, 16);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Activity ID -";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(100, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 16);
            this.lblID.TabIndex = 1;
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUsername.Controls.Add(this.txtActivityName);
            this.panelUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsername.Location = new System.Drawing.Point(18, 112);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(295, 30);
            this.panelUsername.TabIndex = 1;
            // 
            // txtActivityName
            // 
            this.txtActivityName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtActivityName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivityName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivityName.ForeColor = System.Drawing.Color.Black;
            this.txtActivityName.Location = new System.Drawing.Point(12, 8);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(280, 15);
            this.txtActivityName.TabIndex = 2;
            this.txtActivityName.WordWrap = false;
            this.txtActivityName.Enter += new System.EventHandler(this.txtActivityName_Enter);
            this.txtActivityName.Leave += new System.EventHandler(this.txtActivityName_Leave);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPassword.Controls.Add(this.txtMetricOne);
            this.panelPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPassword.Location = new System.Drawing.Point(18, 173);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(250, 30);
            this.panelPassword.TabIndex = 2;
            // 
            // txtMetricOne
            // 
            this.txtMetricOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMetricOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetricOne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetricOne.ForeColor = System.Drawing.Color.Black;
            this.txtMetricOne.Location = new System.Drawing.Point(11, 8);
            this.txtMetricOne.Name = "txtMetricOne";
            this.txtMetricOne.Size = new System.Drawing.Size(236, 15);
            this.txtMetricOne.TabIndex = 4;
            this.txtMetricOne.WordWrap = false;
            this.txtMetricOne.Enter += new System.EventHandler(this.txtMetricOne_Enter);
            this.txtMetricOne.Leave += new System.EventHandler(this.txtMetricOne_Leave);
            // 
            // lblMetricOne
            // 
            this.lblMetricOne.AutoSize = true;
            this.lblMetricOne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricOne.Location = new System.Drawing.Point(15, 154);
            this.lblMetricOne.Name = "lblMetricOne";
            this.lblMetricOne.Size = new System.Drawing.Size(77, 16);
            this.lblMetricOne.TabIndex = 41;
            this.lblMetricOne.Text = "Metric One";
            // 
            // lblActivityName
            // 
            this.lblActivityName.AutoSize = true;
            this.lblActivityName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityName.Location = new System.Drawing.Point(15, 91);
            this.lblActivityName.Name = "lblActivityName";
            this.lblActivityName.Size = new System.Drawing.Size(95, 16);
            this.lblActivityName.TabIndex = 40;
            this.lblActivityName.Text = "Activity Name";
            this.lblActivityName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtMetricTwo);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(264, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 30);
            this.panel1.TabIndex = 3;
            // 
            // txtMetricTwo
            // 
            this.txtMetricTwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMetricTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetricTwo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetricTwo.ForeColor = System.Drawing.Color.Black;
            this.txtMetricTwo.Location = new System.Drawing.Point(11, 8);
            this.txtMetricTwo.Name = "txtMetricTwo";
            this.txtMetricTwo.Size = new System.Drawing.Size(236, 15);
            this.txtMetricTwo.TabIndex = 4;
            this.txtMetricTwo.WordWrap = false;
            this.txtMetricTwo.Enter += new System.EventHandler(this.txtMetricTwo_Enter);
            this.txtMetricTwo.Leave += new System.EventHandler(this.txtMetricTwo_Leave);
            // 
            // lblMetricTwo
            // 
            this.lblMetricTwo.AutoSize = true;
            this.lblMetricTwo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricTwo.Location = new System.Drawing.Point(261, 107);
            this.lblMetricTwo.Name = "lblMetricTwo";
            this.lblMetricTwo.Size = new System.Drawing.Size(77, 16);
            this.lblMetricTwo.TabIndex = 43;
            this.lblMetricTwo.Text = "Metric Two";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtMetricThree);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(522, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 30);
            this.panel2.TabIndex = 4;
            // 
            // txtMetricThree
            // 
            this.txtMetricThree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMetricThree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMetricThree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetricThree.ForeColor = System.Drawing.Color.Black;
            this.txtMetricThree.Location = new System.Drawing.Point(11, 8);
            this.txtMetricThree.Name = "txtMetricThree";
            this.txtMetricThree.Size = new System.Drawing.Size(236, 15);
            this.txtMetricThree.TabIndex = 4;
            this.txtMetricThree.WordWrap = false;
            this.txtMetricThree.Enter += new System.EventHandler(this.txtMetricThree_Enter);
            this.txtMetricThree.Leave += new System.EventHandler(this.txtMetricThree_Leave);
            // 
            // lblMetricThree
            // 
            this.lblMetricThree.AutoSize = true;
            this.lblMetricThree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricThree.Location = new System.Drawing.Point(519, 107);
            this.lblMetricThree.Name = "lblMetricThree";
            this.lblMetricThree.Size = new System.Drawing.Size(88, 16);
            this.lblMetricThree.TabIndex = 45;
            this.lblMetricThree.Text = "Metric Three";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblMetricTwo);
            this.panel3.Controls.Add(this.lblMetricThree);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(12, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 229);
            this.panel3.TabIndex = 46;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(510, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(655, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvActData
            // 
            this.dgvActData.AllowUserToAddRows = false;
            this.dgvActData.AllowUserToDeleteRows = false;
            this.dgvActData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActData.AutoGenerateColumns = false;
            this.dgvActData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actIDDataGridViewTextBoxColumn,
            this.actNameDataGridViewTextBoxColumn,
            this.metricOneDataGridViewTextBoxColumn,
            this.metricTwoDataGridViewTextBoxColumn,
            this.metricThreeDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn});
            this.dgvActData.DataSource = this.activitiesBindingSource;
            this.dgvActData.Location = new System.Drawing.Point(0, 279);
            this.dgvActData.Margin = new System.Windows.Forms.Padding(0);
            this.dgvActData.Name = "dgvActData";
            this.dgvActData.ReadOnly = true;
            this.dgvActData.Size = new System.Drawing.Size(944, 286);
            this.dgvActData.TabIndex = 47;
            this.dgvActData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvActData_CellMouseClick);
            // 
            // actIDDataGridViewTextBoxColumn
            // 
            this.actIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.actIDDataGridViewTextBoxColumn.DataPropertyName = "ActID";
            this.actIDDataGridViewTextBoxColumn.HeaderText = "Activity ID";
            this.actIDDataGridViewTextBoxColumn.Name = "actIDDataGridViewTextBoxColumn";
            this.actIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.actIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // actNameDataGridViewTextBoxColumn
            // 
            this.actNameDataGridViewTextBoxColumn.DataPropertyName = "ActName";
            this.actNameDataGridViewTextBoxColumn.HeaderText = "Activity Name";
            this.actNameDataGridViewTextBoxColumn.Name = "actNameDataGridViewTextBoxColumn";
            this.actNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.actNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // metricOneDataGridViewTextBoxColumn
            // 
            this.metricOneDataGridViewTextBoxColumn.DataPropertyName = "MetricOne";
            this.metricOneDataGridViewTextBoxColumn.HeaderText = "Metric One";
            this.metricOneDataGridViewTextBoxColumn.Name = "metricOneDataGridViewTextBoxColumn";
            this.metricOneDataGridViewTextBoxColumn.ReadOnly = true;
            this.metricOneDataGridViewTextBoxColumn.Width = 180;
            // 
            // metricTwoDataGridViewTextBoxColumn
            // 
            this.metricTwoDataGridViewTextBoxColumn.DataPropertyName = "MetricTwo";
            this.metricTwoDataGridViewTextBoxColumn.HeaderText = "Metric Two";
            this.metricTwoDataGridViewTextBoxColumn.Name = "metricTwoDataGridViewTextBoxColumn";
            this.metricTwoDataGridViewTextBoxColumn.ReadOnly = true;
            this.metricTwoDataGridViewTextBoxColumn.Width = 180;
            // 
            // metricThreeDataGridViewTextBoxColumn
            // 
            this.metricThreeDataGridViewTextBoxColumn.DataPropertyName = "MetricThree";
            this.metricThreeDataGridViewTextBoxColumn.HeaderText = "Metric Three";
            this.metricThreeDataGridViewTextBoxColumn.Name = "metricThreeDataGridViewTextBoxColumn";
            this.metricThreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.metricThreeDataGridViewTextBoxColumn.Width = 180;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "Created Date";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDateDataGridViewTextBoxColumn.Width = 180;
            // 
            // activitiesBindingSource
            // 
            this.activitiesBindingSource.DataMember = "Activities";
            this.activitiesBindingSource.DataSource = this.fitnessTrackerDataset;
            // 
            // fitnessTrackerDataset
            // 
            this.fitnessTrackerDataset.DataSetName = "FitnessTrackerDataset";
            this.fitnessTrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Padding = new System.Windows.Forms.Padding(12);
            this.menuAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuAdmin.Size = new System.Drawing.Size(944, 44);
            this.menuAdmin.TabIndex = 48;
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
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountListToolStripMenuItem,
            this.addAccountToolStripMenuItem});
            this.accountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountToolStripMenuItem.Image")));
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // accountListToolStripMenuItem
            // 
            this.accountListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountListToolStripMenuItem.Image")));
            this.accountListToolStripMenuItem.Name = "accountListToolStripMenuItem";
            this.accountListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.accountListToolStripMenuItem.Text = "Account List";
            this.accountListToolStripMenuItem.Click += new System.EventHandler(this.accountListToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAccountToolStripMenuItem.Image")));
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
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
            // cmsActivity
            // 
            this.cmsActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsActivity.Name = "contextMenuStrip1";
            this.cmsActivity.Size = new System.Drawing.Size(118, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Remove";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // activitiesTableAdapter
            // 
            this.activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 564);
            this.Controls.Add(this.menuAdmin);
            this.Controls.Add(this.dgvActData);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.lblMetricOne);
            this.Controls.Add(this.lblActivityName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 603);
            this.Name = "Activity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            this.Resize += new System.EventHandler(this.Activity_Resize);
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).EndInit();
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.cmsActivity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtMetricOne;
        private System.Windows.Forms.Label lblMetricOne;
        private System.Windows.Forms.Label lblActivityName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMetricTwo;
        private System.Windows.Forms.Label lblMetricTwo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMetricThree;
        private System.Windows.Forms.Label lblMetricThree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvActData;
        private FitnessTrackerDataset fitnessTrackerDataset;
        private FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter activitiesTableAdapter;
        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsActivity;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn actIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricThreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}