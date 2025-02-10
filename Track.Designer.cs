
namespace FitnessTracker
{
    partial class Track
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Track));
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.trackerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setGoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCalBurnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataset = new FitnessTracker.FitnessTrackerDataset();
            this.lblTrackIDLabel = new System.Windows.Forms.Label();
            this.lblTrackID = new System.Windows.Forms.Label();
            this.lblGoalLabel = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.txtMet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAHR = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.trackerTableAdapter = new FitnessTracker.FitnessTrackerDatasetTableAdapters.TrackerTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalBurn = new System.Windows.Forms.Label();
            this.btnGoal = new System.Windows.Forms.Button();
            this.menuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).BeginInit();
            this.panelFullName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activityToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.activityToolStripMenuItem1,
            this.searchToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Padding = new System.Windows.Forms.Padding(12);
            this.menuAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuAdmin.Size = new System.Drawing.Size(865, 44);
            this.menuAdmin.TabIndex = 2;
            this.menuAdmin.Text = "menuAdmin";
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.activityToolStripMenuItem.Text = "Home";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walkingToolStripMenuItem,
            this.swimmingToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // walkingToolStripMenuItem
            // 
            this.walkingToolStripMenuItem.Name = "walkingToolStripMenuItem";
            this.walkingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.walkingToolStripMenuItem.Text = "Walking";
            // 
            // swimmingToolStripMenuItem
            // 
            this.swimmingToolStripMenuItem.Name = "swimmingToolStripMenuItem";
            this.swimmingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.swimmingToolStripMenuItem.Text = "Swimming";
            // 
            // activityToolStripMenuItem1
            // 
            this.activityToolStripMenuItem1.Name = "activityToolStripMenuItem1";
            this.activityToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.activityToolStripMenuItem1.Text = "Tracker";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // dgvTrack
            // 
            this.dgvTrack.AllowUserToAddRows = false;
            this.dgvTrack.AllowUserToDeleteRows = false;
            this.dgvTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackerIDDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.trackerNameDataGridViewTextBoxColumn,
            this.setGoalDataGridViewTextBoxColumn,
            this.totalCalBurnDataGridViewTextBoxColumn,
            this.trackDateDataGridViewTextBoxColumn,
            this.trackStatusDataGridViewTextBoxColumn});
            this.dgvTrack.DataSource = this.trackerBindingSource;
            this.dgvTrack.Location = new System.Drawing.Point(0, 381);
            this.dgvTrack.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.ReadOnly = true;
            this.dgvTrack.Size = new System.Drawing.Size(865, 197);
            this.dgvTrack.TabIndex = 48;
            this.dgvTrack.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrack_CellDoubleClick);
            // 
            // trackerIDDataGridViewTextBoxColumn
            // 
            this.trackerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.trackerIDDataGridViewTextBoxColumn.DataPropertyName = "TrackerID";
            this.trackerIDDataGridViewTextBoxColumn.HeaderText = "TrackerID";
            this.trackerIDDataGridViewTextBoxColumn.Name = "trackerIDDataGridViewTextBoxColumn";
            this.trackerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackerIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            this.activityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn.Width = 77;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // trackerNameDataGridViewTextBoxColumn
            // 
            this.trackerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trackerNameDataGridViewTextBoxColumn.DataPropertyName = "TrackerName";
            this.trackerNameDataGridViewTextBoxColumn.HeaderText = "TrackerName";
            this.trackerNameDataGridViewTextBoxColumn.Name = "trackerNameDataGridViewTextBoxColumn";
            this.trackerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // setGoalDataGridViewTextBoxColumn
            // 
            this.setGoalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.setGoalDataGridViewTextBoxColumn.DataPropertyName = "SetGoal";
            this.setGoalDataGridViewTextBoxColumn.HeaderText = "SetGoal";
            this.setGoalDataGridViewTextBoxColumn.Name = "setGoalDataGridViewTextBoxColumn";
            this.setGoalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCalBurnDataGridViewTextBoxColumn
            // 
            this.totalCalBurnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCalBurnDataGridViewTextBoxColumn.DataPropertyName = "TotalCalBurn";
            this.totalCalBurnDataGridViewTextBoxColumn.HeaderText = "TotalCalBurn";
            this.totalCalBurnDataGridViewTextBoxColumn.Name = "totalCalBurnDataGridViewTextBoxColumn";
            this.totalCalBurnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackDateDataGridViewTextBoxColumn
            // 
            this.trackDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trackDateDataGridViewTextBoxColumn.DataPropertyName = "TrackDate";
            this.trackDateDataGridViewTextBoxColumn.HeaderText = "TrackDate";
            this.trackDateDataGridViewTextBoxColumn.Name = "trackDateDataGridViewTextBoxColumn";
            this.trackDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackStatusDataGridViewTextBoxColumn
            // 
            this.trackStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trackStatusDataGridViewTextBoxColumn.DataPropertyName = "TrackStatus";
            this.trackStatusDataGridViewTextBoxColumn.HeaderText = "TrackStatus";
            this.trackStatusDataGridViewTextBoxColumn.Name = "trackStatusDataGridViewTextBoxColumn";
            this.trackStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackerBindingSource
            // 
            this.trackerBindingSource.DataMember = "Tracker";
            this.trackerBindingSource.DataSource = this.fitnessTrackerDataset;
            // 
            // fitnessTrackerDataset
            // 
            this.fitnessTrackerDataset.DataSetName = "FitnessTrackerDataset";
            this.fitnessTrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTrackIDLabel
            // 
            this.lblTrackIDLabel.AutoSize = true;
            this.lblTrackIDLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackIDLabel.Location = new System.Drawing.Point(12, 67);
            this.lblTrackIDLabel.Name = "lblTrackIDLabel";
            this.lblTrackIDLabel.Size = new System.Drawing.Size(59, 16);
            this.lblTrackIDLabel.TabIndex = 49;
            this.lblTrackIDLabel.Text = "Track ID";
            this.lblTrackIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrackID
            // 
            this.lblTrackID.AutoSize = true;
            this.lblTrackID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackID.Location = new System.Drawing.Point(90, 67);
            this.lblTrackID.Name = "lblTrackID";
            this.lblTrackID.Size = new System.Drawing.Size(30, 16);
            this.lblTrackID.TabIndex = 50;
            this.lblTrackID.Text = "Null";
            this.lblTrackID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoalLabel
            // 
            this.lblGoalLabel.AutoSize = true;
            this.lblGoalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalLabel.Location = new System.Drawing.Point(33, 119);
            this.lblGoalLabel.Name = "lblGoalLabel";
            this.lblGoalLabel.Size = new System.Drawing.Size(38, 16);
            this.lblGoalLabel.TabIndex = 51;
            this.lblGoalLabel.Text = "Goal";
            this.lblGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(90, 119);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(15, 16);
            this.lblGoal.TabIndex = 52;
            this.lblGoal.Text = "0";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Met";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Average Heart Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFullName
            // 
            this.panelFullName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFullName.Controls.Add(this.txtMet);
            this.panelFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFullName.Location = new System.Drawing.Point(449, 67);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(291, 30);
            this.panelFullName.TabIndex = 56;
            // 
            // txtMet
            // 
            this.txtMet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMet.ForeColor = System.Drawing.Color.Black;
            this.txtMet.Location = new System.Drawing.Point(14, 8);
            this.txtMet.Name = "txtMet";
            this.txtMet.Size = new System.Drawing.Size(274, 15);
            this.txtMet.TabIndex = 1;
            this.txtMet.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(449, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 30);
            this.panel1.TabIndex = 57;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Black;
            this.txtTime.Location = new System.Drawing.Point(14, 8);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(274, 15);
            this.txtTime.TabIndex = 1;
            this.txtTime.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtAHR);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(449, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 30);
            this.panel2.TabIndex = 58;
            // 
            // txtAHR
            // 
            this.txtAHR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAHR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAHR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAHR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAHR.ForeColor = System.Drawing.Color.Black;
            this.txtAHR.Location = new System.Drawing.Point(14, 8);
            this.txtAHR.Name = "txtAHR";
            this.txtAHR.Size = new System.Drawing.Size(274, 15);
            this.txtAHR.TabIndex = 1;
            this.txtAHR.WordWrap = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(620, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(478, 302);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.TabIndex = 60;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // trackerTableAdapter
            // 
            this.trackerTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Total Cal Burned";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCalBurn
            // 
            this.txtCalBurn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalBurn.Location = new System.Drawing.Point(440, 255);
            this.txtCalBurn.Name = "txtCalBurn";
            this.txtCalBurn.Size = new System.Drawing.Size(300, 16);
            this.txtCalBurn.TabIndex = 62;
            this.txtCalBurn.Text = "0";
            this.txtCalBurn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGoal
            // 
            this.btnGoal.BackColor = System.Drawing.Color.Gold;
            this.btnGoal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoal.ForeColor = System.Drawing.Color.Black;
            this.btnGoal.Location = new System.Drawing.Point(336, 302);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(120, 35);
            this.btnGoal.TabIndex = 63;
            this.btnGoal.Text = "Add Goal";
            this.btnGoal.UseVisualStyleBackColor = false;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 587);
            this.Controls.Add(this.btnGoal);
            this.Controls.Add(this.txtCalBurn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrackIDLabel);
            this.Controls.Add(this.lblTrackID);
            this.Controls.Add(this.lblGoalLabel);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.dgvTrack);
            this.Controls.Add(this.menuAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(881, 626);
            this.Name = "Track";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track";
            this.Load += new System.EventHandler(this.Track_Load);
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).EndInit();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.Label lblTrackIDLabel;
        private System.Windows.Forms.Label lblTrackID;
        private System.Windows.Forms.Label lblGoalLabel;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox txtMet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAHR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCalculate;
        private FitnessTrackerDataset fitnessTrackerDataset;
        private System.Windows.Forms.BindingSource trackerBindingSource;
        private FitnessTrackerDatasetTableAdapters.TrackerTableAdapter trackerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setGoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCalBurnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCalBurn;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmingToolStripMenuItem;
        private System.Windows.Forms.Button btnGoal;
    }
}