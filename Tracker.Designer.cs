
namespace FitnessTracker
{
    partial class Tracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tracker));
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblCalBurn = new System.Windows.Forms.Label();
            this.cmsTrack = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.panelFullName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsTrack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.trackerToolStripMenuItem,
            this.addGoalToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Padding = new System.Windows.Forms.Padding(12);
            this.menuAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuAdmin.Size = new System.Drawing.Size(994, 44);
            this.menuAdmin.TabIndex = 2;
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
            // trackerToolStripMenuItem
            // 
            this.trackerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trackerToolStripMenuItem.Image")));
            this.trackerToolStripMenuItem.Name = "trackerToolStripMenuItem";
            this.trackerToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.trackerToolStripMenuItem.Text = "Tracker";
            // 
            // addGoalToolStripMenuItem
            // 
            this.addGoalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addGoalToolStripMenuItem.Image")));
            this.addGoalToolStripMenuItem.Name = "addGoalToolStripMenuItem";
            this.addGoalToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.addGoalToolStripMenuItem.Text = "Add Goal";
            this.addGoalToolStripMenuItem.Click += new System.EventHandler(this.addGoalToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activitiesToolStripMenuItem.Image")));
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.activitiesToolStripMenuItem.Text = "Benefits";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
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
            this.dgvTrack.Location = new System.Drawing.Point(0, 381);
            this.dgvTrack.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTrack.MultiSelect = false;
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.ReadOnly = true;
            this.dgvTrack.Size = new System.Drawing.Size(994, 197);
            this.dgvTrack.TabIndex = 48;
            this.dgvTrack.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrack_CellDoubleClick);
            this.dgvTrack.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTrack_CellMouseClick);
            // 
            // lblTrackIDLabel
            // 
            this.lblTrackIDLabel.AutoSize = true;
            this.lblTrackIDLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackIDLabel.Location = new System.Drawing.Point(6, 28);
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
            this.lblTrackID.Location = new System.Drawing.Point(84, 28);
            this.lblTrackID.Name = "lblTrackID";
            this.lblTrackID.Size = new System.Drawing.Size(12, 16);
            this.lblTrackID.TabIndex = 50;
            this.lblTrackID.Text = "-";
            this.lblTrackID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrackID.TextChanged += new System.EventHandler(this.lblTrackID_TextChanged);
            // 
            // lblGoalLabel
            // 
            this.lblGoalLabel.AutoSize = true;
            this.lblGoalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalLabel.Location = new System.Drawing.Point(27, 80);
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
            this.lblGoal.Location = new System.Drawing.Point(84, 80);
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
            this.label1.Location = new System.Drawing.Point(372, 28);
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
            this.label2.Location = new System.Drawing.Point(363, 81);
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
            this.label3.Location = new System.Drawing.Point(271, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Average Heart Rate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFullName
            // 
            this.panelFullName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFullName.Controls.Add(this.txtMet);
            this.panelFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFullName.Location = new System.Drawing.Point(423, 21);
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
            this.txtMet.TextChanged += new System.EventHandler(this.txtMet_TextChanged);
            this.txtMet.Enter += new System.EventHandler(this.txtMet_Enter);
            this.txtMet.Leave += new System.EventHandler(this.txtMet_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(423, 74);
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
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.Enter += new System.EventHandler(this.txtTime_Enter);
            this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txtAHR);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(423, 126);
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
            this.txtAHR.TextChanged += new System.EventHandler(this.txtAHR_TextChanged);
            this.txtAHR.Enter += new System.EventHandler(this.txtAHR_Enter);
            this.txtAHR.Leave += new System.EventHandler(this.txtAHR_Leave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(619, 297);
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
            this.btnCalculate.Location = new System.Drawing.Point(476, 297);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.TabIndex = 60;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Burned total calories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalBurn
            // 
            this.lblCalBurn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalBurn.Location = new System.Drawing.Point(414, 209);
            this.lblCalBurn.Name = "lblCalBurn";
            this.lblCalBurn.Size = new System.Drawing.Size(300, 16);
            this.lblCalBurn.TabIndex = 62;
            this.lblCalBurn.Text = "0";
            this.lblCalBurn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCalBurn.TextChanged += new System.EventHandler(this.lblCalBurn_TextChanged);
            // 
            // cmsTrack
            // 
            this.cmsTrack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.cmsTrack.Name = "cmsTrack";
            this.cmsTrack.Size = new System.Drawing.Size(135, 70);
            this.cmsTrack.Opened += new System.EventHandler(this.cmsTrack_Opened);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(333, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTrackIDLabel);
            this.groupBox1.Controls.Add(this.lblGoal);
            this.groupBox1.Controls.Add(this.lblCalBurn);
            this.groupBox1.Controls.Add(this.lblGoalLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTrackID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelFullName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 304);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tracker Information";
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 587);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvTrack);
            this.Controls.Add(this.menuAdmin);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 626);
            this.Name = "Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Track_Load);
            this.Resize += new System.EventHandler(this.Track_Resize);
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cmsTrack.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackerToolStripMenuItem;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCalBurn;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTrack;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGoalToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}