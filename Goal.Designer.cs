
namespace FitnessTracker
{
    partial class Goal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goal));
            this.lblUserIDLabel = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.cboAct = new System.Windows.Forms.ComboBox();
            this.activitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataset1 = new FitnessTracker.FitnessTrackerDataset();
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataset = new FitnessTracker.FitnessTrackerDataset();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblActIDLabel = new System.Windows.Forms.Label();
            this.lblActID = new System.Windows.Forms.Label();
            this.lblYourGoalTitle = new System.Windows.Forms.Label();
            this.dtpGoalDate = new System.Windows.Forms.DateTimePicker();
            this.lblSetGoalLabel = new System.Windows.Forms.Label();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.txtSetGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMetricOne = new System.Windows.Forms.Label();
            this.lblMetricTwo = new System.Windows.Forms.Label();
            this.lblMetricThree = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrackID = new System.Windows.Forms.Label();
            this.activitiesTableAdapter = new FitnessTracker.FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).BeginInit();
            this.panelFullName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserIDLabel
            // 
            this.lblUserIDLabel.AutoSize = true;
            this.lblUserIDLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIDLabel.Location = new System.Drawing.Point(7, 21);
            this.lblUserIDLabel.Name = "lblUserIDLabel";
            this.lblUserIDLabel.Size = new System.Drawing.Size(53, 16);
            this.lblUserIDLabel.TabIndex = 2;
            this.lblUserIDLabel.Text = "User ID";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(85, 21);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(12, 16);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "-";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(85, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(12, 16);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "-";
            // 
            // lblUsernameLabel
            // 
            this.lblUsernameLabel.AutoSize = true;
            this.lblUsernameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLabel.Location = new System.Drawing.Point(7, 52);
            this.lblUsernameLabel.Name = "lblUsernameLabel";
            this.lblUsernameLabel.Size = new System.Drawing.Size(72, 16);
            this.lblUsernameLabel.TabIndex = 4;
            this.lblUsernameLabel.Text = "Username";
            // 
            // cboAct
            // 
            this.cboAct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activitiesBindingSource1, "ActID", true));
            this.cboAct.DataSource = this.activitiesBindingSource;
            this.cboAct.DisplayMember = "ActName";
            this.cboAct.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAct.FormattingEnabled = true;
            this.cboAct.Location = new System.Drawing.Point(109, 19);
            this.cboAct.Name = "cboAct";
            this.cboAct.Size = new System.Drawing.Size(182, 22);
            this.cboAct.TabIndex = 7;
            this.cboAct.ValueMember = "ActID";
            this.cboAct.SelectedIndexChanged += new System.EventHandler(this.cboAct_SelectedIndexChanged);
            // 
            // activitiesBindingSource1
            // 
            this.activitiesBindingSource1.DataMember = "Activities";
            this.activitiesBindingSource1.DataSource = this.fitnessTrackerDataset1;
            // 
            // fitnessTrackerDataset1
            // 
            this.fitnessTrackerDataset1.DataSetName = "FitnessTrackerDataset";
            this.fitnessTrackerDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(8, 21);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(95, 16);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Activity Name";
            this.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActIDLabel
            // 
            this.lblActIDLabel.AutoSize = true;
            this.lblActIDLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActIDLabel.Location = new System.Drawing.Point(8, 52);
            this.lblActIDLabel.Name = "lblActIDLabel";
            this.lblActIDLabel.Size = new System.Drawing.Size(71, 16);
            this.lblActIDLabel.TabIndex = 9;
            this.lblActIDLabel.Text = "Activity ID";
            this.lblActIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActID
            // 
            this.lblActID.AutoSize = true;
            this.lblActID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActID.Location = new System.Drawing.Point(112, 52);
            this.lblActID.Name = "lblActID";
            this.lblActID.Size = new System.Drawing.Size(12, 16);
            this.lblActID.TabIndex = 10;
            this.lblActID.Text = "-";
            // 
            // lblYourGoalTitle
            // 
            this.lblYourGoalTitle.AutoSize = true;
            this.lblYourGoalTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourGoalTitle.Location = new System.Drawing.Point(14, 52);
            this.lblYourGoalTitle.Name = "lblYourGoalTitle";
            this.lblYourGoalTitle.Size = new System.Drawing.Size(70, 16);
            this.lblYourGoalTitle.TabIndex = 11;
            this.lblYourGoalTitle.Text = "Your Goal";
            this.lblYourGoalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpGoalDate
            // 
            this.dtpGoalDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpGoalDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGoalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGoalDate.Location = new System.Drawing.Point(17, 83);
            this.dtpGoalDate.MinDate = new System.DateTime(2025, 2, 22, 0, 0, 0, 0);
            this.dtpGoalDate.Name = "dtpGoalDate";
            this.dtpGoalDate.Size = new System.Drawing.Size(129, 22);
            this.dtpGoalDate.TabIndex = 13;
            this.dtpGoalDate.Value = new System.DateTime(2025, 2, 22, 21, 22, 7, 0);
            // 
            // lblSetGoalLabel
            // 
            this.lblSetGoalLabel.AutoSize = true;
            this.lblSetGoalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetGoalLabel.Location = new System.Drawing.Point(14, 128);
            this.lblSetGoalLabel.Name = "lblSetGoalLabel";
            this.lblSetGoalLabel.Size = new System.Drawing.Size(63, 16);
            this.lblSetGoalLabel.TabIndex = 14;
            this.lblSetGoalLabel.Text = "Set Goal";
            this.lblSetGoalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFullName
            // 
            this.panelFullName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFullName.Controls.Add(this.txtSetGoal);
            this.panelFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFullName.Location = new System.Drawing.Point(17, 147);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(291, 30);
            this.panelFullName.TabIndex = 15;
            // 
            // txtSetGoal
            // 
            this.txtSetGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSetGoal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSetGoal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetGoal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetGoal.ForeColor = System.Drawing.Color.Black;
            this.txtSetGoal.Location = new System.Drawing.Point(14, 8);
            this.txtSetGoal.Name = "txtSetGoal";
            this.txtSetGoal.Size = new System.Drawing.Size(274, 15);
            this.txtSetGoal.TabIndex = 1;
            this.txtSetGoal.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Metric 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Metric 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Metric 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetricOne
            // 
            this.lblMetricOne.AutoSize = true;
            this.lblMetricOne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricOne.Location = new System.Drawing.Point(382, 19);
            this.lblMetricOne.Name = "lblMetricOne";
            this.lblMetricOne.Size = new System.Drawing.Size(12, 16);
            this.lblMetricOne.TabIndex = 19;
            this.lblMetricOne.Text = "-";
            // 
            // lblMetricTwo
            // 
            this.lblMetricTwo.AutoSize = true;
            this.lblMetricTwo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricTwo.Location = new System.Drawing.Point(382, 52);
            this.lblMetricTwo.Name = "lblMetricTwo";
            this.lblMetricTwo.Size = new System.Drawing.Size(12, 16);
            this.lblMetricTwo.TabIndex = 20;
            this.lblMetricTwo.Text = "-";
            // 
            // lblMetricThree
            // 
            this.lblMetricThree.AutoSize = true;
            this.lblMetricThree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetricThree.Location = new System.Drawing.Point(382, 86);
            this.lblMetricThree.Name = "lblMetricThree";
            this.lblMetricThree.Size = new System.Drawing.Size(12, 16);
            this.lblMetricThree.TabIndex = 21;
            this.lblMetricThree.Text = "-";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(593, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Track ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrackID
            // 
            this.lblTrackID.AutoSize = true;
            this.lblTrackID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackID.Location = new System.Drawing.Point(79, 21);
            this.lblTrackID.Name = "lblTrackID";
            this.lblTrackID.Size = new System.Drawing.Size(12, 16);
            this.lblTrackID.TabIndex = 24;
            this.lblTrackID.Text = "-";
            // 
            // activitiesTableAdapter
            // 
            this.activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblUserIDLabel);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.lblUsernameLabel);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 195);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cboAct);
            this.groupBox2.Controls.Add(this.lblActivity);
            this.groupBox2.Controls.Add(this.lblActIDLabel);
            this.groupBox2.Controls.Add(this.lblMetricThree);
            this.groupBox2.Controls.Add(this.lblActID);
            this.groupBox2.Controls.Add(this.lblMetricTwo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMetricOne);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 148);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.lblTrackID);
            this.groupBox3.Controls.Add(this.dtpGoalDate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblYourGoalTitle);
            this.groupBox3.Controls.Add(this.lblSetGoalLabel);
            this.groupBox3.Controls.Add(this.panelFullName);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(312, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 195);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Track Info";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(456, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Goal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal";
            this.Load += new System.EventHandler(this.Goal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).EndInit();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUserIDLabel;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.ComboBox cboAct;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblActIDLabel;
        private System.Windows.Forms.Label lblActID;
        private System.Windows.Forms.Label lblYourGoalTitle;
        private System.Windows.Forms.DateTimePicker dtpGoalDate;
        private System.Windows.Forms.Label lblSetGoalLabel;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox txtSetGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMetricOne;
        private System.Windows.Forms.Label lblMetricTwo;
        private System.Windows.Forms.Label lblMetricThree;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrackID;
        private FitnessTrackerDataset fitnessTrackerDataset;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private FitnessTrackerDatasetTableAdapters.ActivitiesTableAdapter activitiesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FitnessTrackerDataset fitnessTrackerDataset1;
        private System.Windows.Forms.BindingSource activitiesBindingSource1;
        private System.Windows.Forms.Button btnClear;
    }
}