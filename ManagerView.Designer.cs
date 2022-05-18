namespace code
{
    partial class ManagerView
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageRegisterStaff = new System.Windows.Forms.TabPage();
            this.pageReports = new System.Windows.Forms.TabPage();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.fieldFullname = new System.Windows.Forms.TextBox();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldAddress = new System.Windows.Forms.TextBox();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.fieldRole = new System.Windows.Forms.ComboBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.fieldStartDate = new System.Windows.Forms.TextBox();
            this.fieldEndDate = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.pageRegisterStaff.SuspendLayout();
            this.pageReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(13, 24);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(61, 26);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello";
            this.lblGreeting.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageRegisterStaff);
            this.tabControl1.Controls.Add(this.pageReports);
            this.tabControl1.Location = new System.Drawing.Point(9, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 345);
            this.tabControl1.TabIndex = 1;
            // 
            // pageRegisterStaff
            // 
            this.pageRegisterStaff.Controls.Add(this.fieldRole);
            this.pageRegisterStaff.Controls.Add(this.btnCreateStaff);
            this.pageRegisterStaff.Controls.Add(this.fieldEmail);
            this.pageRegisterStaff.Controls.Add(this.fieldAddress);
            this.pageRegisterStaff.Controls.Add(this.fieldUsername);
            this.pageRegisterStaff.Controls.Add(this.fieldFullname);
            this.pageRegisterStaff.Controls.Add(this.lblEmail);
            this.pageRegisterStaff.Controls.Add(this.lblUsername);
            this.pageRegisterStaff.Controls.Add(this.lblRole);
            this.pageRegisterStaff.Controls.Add(this.lblAddress);
            this.pageRegisterStaff.Controls.Add(this.lblFullname);
            this.pageRegisterStaff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageRegisterStaff.Location = new System.Drawing.Point(4, 29);
            this.pageRegisterStaff.Name = "pageRegisterStaff";
            this.pageRegisterStaff.Padding = new System.Windows.Forms.Padding(3);
            this.pageRegisterStaff.Size = new System.Drawing.Size(771, 312);
            this.pageRegisterStaff.TabIndex = 0;
            this.pageRegisterStaff.Text = "Register Staff";
            this.pageRegisterStaff.UseVisualStyleBackColor = true;
            // 
            // pageReports
            // 
            this.pageReports.Controls.Add(this.fieldEndDate);
            this.pageReports.Controls.Add(this.fieldStartDate);
            this.pageReports.Controls.Add(this.lblStart);
            this.pageReports.Controls.Add(this.lblEnd);
            this.pageReports.Location = new System.Drawing.Point(4, 29);
            this.pageReports.Name = "pageReports";
            this.pageReports.Padding = new System.Windows.Forms.Padding(3);
            this.pageReports.Size = new System.Drawing.Size(771, 312);
            this.pageReports.TabIndex = 1;
            this.pageReports.Text = "Reports";
            this.pageReports.UseVisualStyleBackColor = true;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(22, 49);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(83, 22);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "Fullname";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(22, 157);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 22);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(22, 121);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 22);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(22, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 22);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(22, 193);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // fieldFullname
            // 
            this.fieldFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldFullname.Location = new System.Drawing.Point(177, 41);
            this.fieldFullname.Name = "fieldFullname";
            this.fieldFullname.Size = new System.Drawing.Size(412, 30);
            this.fieldFullname.TabIndex = 7;
            // 
            // fieldUsername
            // 
            this.fieldUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldUsername.Location = new System.Drawing.Point(177, 77);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(412, 30);
            this.fieldUsername.TabIndex = 8;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldAddress.Location = new System.Drawing.Point(177, 149);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(412, 30);
            this.fieldAddress.TabIndex = 10;
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldEmail.Location = new System.Drawing.Point(177, 185);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(412, 30);
            this.fieldEmail.TabIndex = 11;
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.BackColor = System.Drawing.Color.Aqua;
            this.btnCreateStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStaff.Location = new System.Drawing.Point(22, 245);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(125, 29);
            this.btnCreateStaff.TabIndex = 12;
            this.btnCreateStaff.Text = "Create Staff";
            this.btnCreateStaff.UseVisualStyleBackColor = false;
            // 
            // fieldRole
            // 
            this.fieldRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldRole.FormattingEnabled = true;
            this.fieldRole.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Technician"});
            this.fieldRole.Location = new System.Drawing.Point(177, 113);
            this.fieldRole.Name = "fieldRole";
            this.fieldRole.Size = new System.Drawing.Size(412, 30);
            this.fieldRole.TabIndex = 13;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Silver;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(506, 24);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(125, 29);
            this.btnProfile.TabIndex = 14;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(650, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 29);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.Location = new System.Drawing.Point(385, 32);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(83, 22);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(33, 32);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(89, 22);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start Date";
            // 
            // fieldStartDate
            // 
            this.fieldStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldStartDate.Location = new System.Drawing.Point(128, 24);
            this.fieldStartDate.Name = "fieldStartDate";
            this.fieldStartDate.Size = new System.Drawing.Size(191, 30);
            this.fieldStartDate.TabIndex = 8;
            // 
            // fieldEndDate
            // 
            this.fieldEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldEndDate.Location = new System.Drawing.Point(474, 24);
            this.fieldEndDate.Name = "fieldEndDate";
            this.fieldEndDate.Size = new System.Drawing.Size(191, 30);
            this.fieldEndDate.TabIndex = 9;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGreeting);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.tabControl1.ResumeLayout(false);
            this.pageRegisterStaff.ResumeLayout(false);
            this.pageRegisterStaff.PerformLayout();
            this.pageReports.ResumeLayout(false);
            this.pageReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGreeting;
        private TabControl tabControl1;
        private TabPage pageRegisterStaff;
        private ComboBox fieldRole;
        private Button btnCreateStaff;
        private TextBox fieldEmail;
        private TextBox fieldAddress;
        private TextBox fieldUsername;
        private TextBox fieldFullname;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblRole;
        private Label lblAddress;
        private Label lblFullname;
        private TabPage pageReports;
        private Button btnProfile;
        private Button btnLogout;
        private TextBox fieldEndDate;
        private TextBox fieldStartDate;
        private Label lblStart;
        private Label lblEnd;
    }
}