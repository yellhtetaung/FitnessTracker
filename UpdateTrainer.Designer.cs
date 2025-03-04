
namespace FitnessTracker
{
    partial class UpdateTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTrainer));
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.panelAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panDivider = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelAddress.SuspendLayout();
            this.panelPhone.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.panelFullName.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPassword
            // 
            this.chkPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(20, 373);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(102, 17);
            this.chkPassword.TabIndex = 70;
            this.chkPassword.Text = "Show Password";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDOB.CustomFormat = "dd/MMM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(20, 418);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(129, 22);
            this.dtpDOB.TabIndex = 52;
            // 
            // lblMemberID
            // 
            this.lblMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(17, 108);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(78, 16);
            this.lblMemberID.TabIndex = 54;
            this.lblMemberID.Text = "Trainer ID :";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegister.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(221, 634);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(193, 40);
            this.btnRegister.TabIndex = 61;
            this.btnRegister.Text = "UPDATE";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(17, 634);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 40);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "CANCEL";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdoOther
            // 
            this.rdoOther.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoOther.AutoSize = true;
            this.rdoOther.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOther.Location = new System.Drawing.Point(155, 469);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(58, 20);
            this.rdoOther.TabIndex = 57;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(80, 469);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(69, 20);
            this.rdoFemale.TabIndex = 56;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(20, 469);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(54, 20);
            this.rdoMale.TabIndex = 53;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(17, 449);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 16);
            this.lblGender.TabIndex = 68;
            this.lblGender.Text = "Gender";
            // 
            // panelAddress
            // 
            this.panelAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAddress.Controls.Add(this.txtAddress);
            this.panelAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAddress.Location = new System.Drawing.Point(20, 575);
            this.panelAddress.Name = "panelAddress";
            this.panelAddress.Size = new System.Drawing.Size(397, 30);
            this.panelAddress.TabIndex = 60;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(11, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(383, 15);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.WordWrap = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(17, 556);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 67;
            this.lblAddress.Text = "Address";
            // 
            // panelPhone
            // 
            this.panelPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPhone.Controls.Add(this.txtPhone);
            this.panelPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPhone.Location = new System.Drawing.Point(20, 517);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(397, 30);
            this.panelPhone.TabIndex = 59;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(11, 8);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(383, 15);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.WordWrap = false;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(99, 108);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 16);
            this.lblID.TabIndex = 69;
            this.lblID.Text = "M0001";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(17, 498);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(103, 16);
            this.lblPhone.TabIndex = 66;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblDob
            // 
            this.lblDob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(17, 399);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(89, 16);
            this.lblDob.TabIndex = 65;
            this.lblDob.Text = "Date Of Birth";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(11, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 15);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.WordWrap = false;
            // 
            // panelUsername
            // 
            this.panelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUsername.Controls.Add(this.txtUsername);
            this.panelUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsername.Location = new System.Drawing.Point(20, 218);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(397, 30);
            this.panelUsername.TabIndex = 47;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(11, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(383, 15);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.WordWrap = false;
            // 
            // panelFullName
            // 
            this.panelFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFullName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFullName.Controls.Add(this.txtFullName);
            this.panelFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFullName.Location = new System.Drawing.Point(20, 158);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(397, 30);
            this.panelFullName.TabIndex = 45;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFullName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Location = new System.Drawing.Point(11, 8);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(383, 15);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.WordWrap = false;
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPassword.Location = new System.Drawing.Point(20, 336);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(397, 30);
            this.panelPassword.TabIndex = 50;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(11, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(383, 15);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.WordWrap = false;
            // 
            // panDivider
            // 
            this.panDivider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panDivider.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panDivider.Location = new System.Drawing.Point(17, 89);
            this.panDivider.Name = "panDivider";
            this.panDivider.Size = new System.Drawing.Size(407, 2);
            this.panDivider.TabIndex = 63;
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEmail.Controls.Add(this.txtEmail);
            this.panelEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEmail.Location = new System.Drawing.Point(20, 278);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(397, 30);
            this.panelEmail.TabIndex = 48;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 317);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 62;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(17, 197);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 16);
            this.lblUsername.TabIndex = 55;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(17, 137);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(73, 16);
            this.lblFullName.TabIndex = 51;
            this.lblFullName.Text = "Full Name";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDesc.Location = new System.Drawing.Point(103, 50);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(231, 25);
            this.lblDesc.TabIndex = 49;
            this.lblDesc.Text = "TRAINER UPDATE";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(111, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 40);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Zen Fitness";
            // 
            // UpdateTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 708);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.panelAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.panelPhone);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.panelFullName);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panDivider);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(455, 747);
            this.Name = "UpdateTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Trainer";
            this.Load += new System.EventHandler(this.UpdateTrainer_Load);
            this.panelAddress.ResumeLayout(false);
            this.panelAddress.PerformLayout();
            this.panelPhone.ResumeLayout(false);
            this.panelPhone.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel panelAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panDivider;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTitle;
    }
}