
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
            this.menuUser.SuspendLayout();
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
            this.menuUser.Size = new System.Drawing.Size(800, 44);
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
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "UserSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Search";
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
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
    }
}