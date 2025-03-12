
namespace FitnessTracker
{
    partial class UserSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearch));
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSearchText = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.fitnessTrackerDataset = new FitnessTracker.FitnessTrackerDataset();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrackStatus = new System.Windows.Forms.ComboBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelSearchText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).BeginInit();
            this.panelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuUser
            // 
            this.menuUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.trackerToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuUser.Location = new System.Drawing.Point(0, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.Padding = new System.Windows.Forms.Padding(12);
            this.menuUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuUser.Size = new System.Drawing.Size(994, 44);
            this.menuUser.TabIndex = 2;
            this.menuUser.Text = "menuAdmin";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walkingToolStripMenuItem,
            this.swimmingToolStripMenuItem});
            this.activitiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activitiesToolStripMenuItem.Image")));
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
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
            // trackerToolStripMenuItem
            // 
            this.trackerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trackerToolStripMenuItem.Image")));
            this.trackerToolStripMenuItem.Name = "trackerToolStripMenuItem";
            this.trackerToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.trackerToolStripMenuItem.Text = "Tracker";
            this.trackerToolStripMenuItem.Click += new System.EventHandler(this.trackerToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dgvTrack
            // 
            this.dgvTrack.AllowUserToAddRows = false;
            this.dgvTrack.AllowUserToDeleteRows = false;
            this.dgvTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Location = new System.Drawing.Point(0, 195);
            this.dgvTrack.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTrack.MultiSelect = false;
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.ReadOnly = true;
            this.dgvTrack.Size = new System.Drawing.Size(994, 392);
            this.dgvTrack.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelSearchText);
            this.groupBox1.Controls.Add(this.cboActivity);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cboFilterBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTrackStatus);
            this.groupBox1.Controls.Add(this.panelDate);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 135);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Tracker";
            // 
            // panelSearchText
            // 
            this.panelSearchText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSearchText.Controls.Add(this.txtFilter);
            this.panelSearchText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearchText.Location = new System.Drawing.Point(146, 22);
            this.panelSearchText.Name = "panelSearchText";
            this.panelSearchText.Size = new System.Drawing.Size(390, 30);
            this.panelSearchText.TabIndex = 56;
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.Location = new System.Drawing.Point(12, 8);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(375, 15);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.WordWrap = false;
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            // 
            // cboActivity
            // 
            this.cboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(146, 25);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(121, 24);
            this.cboActivity.TabIndex = 59;
            this.cboActivity.ValueMember = "ActID";
            // 
            // fitnessTrackerDataset
            // 
            this.fitnessTrackerDataset.DataSetName = "FitnessTrackerDataset";
            this.fitnessTrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(464, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(326, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 35);
            this.btnReset.TabIndex = 55;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboFilterBy
            // 
            this.cboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterBy.FormattingEnabled = true;
            this.cboFilterBy.Items.AddRange(new object[] {
            "Track Name",
            "Activity Name",
            "Goal",
            "Track Date",
            "Track Status",
            "Created Date"});
            this.cboFilterBy.Location = new System.Drawing.Point(19, 25);
            this.cboFilterBy.Name = "cboFilterBy";
            this.cboFilterBy.Size = new System.Drawing.Size(121, 24);
            this.cboFilterBy.TabIndex = 52;
            this.cboFilterBy.SelectedIndexChanged += new System.EventHandler(this.cboFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 50;
            // 
            // cboTrackStatus
            // 
            this.cboTrackStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrackStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrackStatus.FormattingEnabled = true;
            this.cboTrackStatus.Items.AddRange(new object[] {
            "Progress",
            "Completed",
            "Failed"});
            this.cboTrackStatus.Location = new System.Drawing.Point(146, 25);
            this.cboTrackStatus.Name = "cboTrackStatus";
            this.cboTrackStatus.Size = new System.Drawing.Size(121, 24);
            this.cboTrackStatus.TabIndex = 58;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.SystemColors.Control;
            this.panelDate.Controls.Add(this.dtpEndDate);
            this.panelDate.Controls.Add(this.dtpStartDate);
            this.panelDate.Controls.Add(this.label2);
            this.panelDate.Controls.Add(this.label3);
            this.panelDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDate.Location = new System.Drawing.Point(146, 15);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(438, 39);
            this.panelDate.TabIndex = 57;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(294, 8);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(136, 22);
            this.dtpEndDate.TabIndex = 63;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(83, 8);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 22);
            this.dtpStartDate.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(226, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "End Date";
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTrack);
            this.Controls.Add(this.menuUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(881, 626);
            this.Name = "UserSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Search";
            this.Load += new System.EventHandler(this.UserSearch_Load);
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSearchText.ResumeLayout(false);
            this.panelSearchText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataset)).EndInit();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboFilterBy;
        private System.Windows.Forms.Panel panelSearchText;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrackStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDate;
        private FitnessTrackerDataset fitnessTrackerDataset;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}