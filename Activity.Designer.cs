﻿
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvActData = new System.Windows.Forms.DataGridView();
            this.actIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricOneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricTwoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metricThreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataset = new FitnessTracker.FitnessTrackerDataset();
            this.activitiesTableAdapter = new FitnessTracker.FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
            this.panelUsername.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(15, 26);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(79, 16);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Activity ID -";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(100, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(45, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "A0001";
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUsername.Controls.Add(this.txtActivityName);
            this.panelUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsername.Location = new System.Drawing.Point(18, 77);
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
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPassword.Controls.Add(this.txtMetricOne);
            this.panelPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPassword.Location = new System.Drawing.Point(18, 138);
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
            // 
            // lblMetricOne
            // 
            this.lblMetricOne.AutoSize = true;
            this.lblMetricOne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricOne.Location = new System.Drawing.Point(15, 119);
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
            this.lblActivityName.Location = new System.Drawing.Point(15, 56);
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
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lblMetricTwo);
            this.panel3.Controls.Add(this.lblMetricThree);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 229);
            this.panel3.TabIndex = 46;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(370, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(511, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(652, 177);
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
            this.metricThreeDataGridViewTextBoxColumn});
            this.dgvActData.DataSource = this.activitiesBindingSource;
            this.dgvActData.Location = new System.Drawing.Point(12, 244);
            this.dgvActData.Margin = new System.Windows.Forms.Padding(0);
            this.dgvActData.Name = "dgvActData";
            this.dgvActData.ReadOnly = true;
            this.dgvActData.Size = new System.Drawing.Size(813, 197);
            this.dgvActData.TabIndex = 47;
            this.dgvActData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActData_CellDoubleClick);
            // 
            // actIDDataGridViewTextBoxColumn
            // 
            this.actIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.actIDDataGridViewTextBoxColumn.DataPropertyName = "ActID";
            this.actIDDataGridViewTextBoxColumn.DividerWidth = 1;
            this.actIDDataGridViewTextBoxColumn.HeaderText = "ActID";
            this.actIDDataGridViewTextBoxColumn.Name = "actIDDataGridViewTextBoxColumn";
            this.actIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.actIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // actNameDataGridViewTextBoxColumn
            // 
            this.actNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actNameDataGridViewTextBoxColumn.DataPropertyName = "ActName";
            this.actNameDataGridViewTextBoxColumn.DividerWidth = 1;
            this.actNameDataGridViewTextBoxColumn.HeaderText = "ActName";
            this.actNameDataGridViewTextBoxColumn.Name = "actNameDataGridViewTextBoxColumn";
            this.actNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metricOneDataGridViewTextBoxColumn
            // 
            this.metricOneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.metricOneDataGridViewTextBoxColumn.DataPropertyName = "MetricOne";
            this.metricOneDataGridViewTextBoxColumn.DividerWidth = 1;
            this.metricOneDataGridViewTextBoxColumn.HeaderText = "MetricOne";
            this.metricOneDataGridViewTextBoxColumn.Name = "metricOneDataGridViewTextBoxColumn";
            this.metricOneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metricTwoDataGridViewTextBoxColumn
            // 
            this.metricTwoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.metricTwoDataGridViewTextBoxColumn.DataPropertyName = "MetricTwo";
            this.metricTwoDataGridViewTextBoxColumn.DividerWidth = 1;
            this.metricTwoDataGridViewTextBoxColumn.HeaderText = "MetricTwo";
            this.metricTwoDataGridViewTextBoxColumn.Name = "metricTwoDataGridViewTextBoxColumn";
            this.metricTwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metricThreeDataGridViewTextBoxColumn
            // 
            this.metricThreeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.metricThreeDataGridViewTextBoxColumn.DataPropertyName = "MetricThree";
            this.metricThreeDataGridViewTextBoxColumn.DividerWidth = 1;
            this.metricThreeDataGridViewTextBoxColumn.HeaderText = "MetricThree";
            this.metricThreeDataGridViewTextBoxColumn.Name = "metricThreeDataGridViewTextBoxColumn";
            this.metricThreeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // activitiesTableAdapter
            // 
            this.activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.dgvActData);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.lblMetricOne);
            this.Controls.Add(this.lblActivityName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 489);
            this.Name = "Activity";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvActData;
        private FitnessTrackerDataset fitnessTrackerDataset;
        private FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter activitiesTableAdapter;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn actIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricOneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricTwoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metricThreeDataGridViewTextBoxColumn;
    }
}