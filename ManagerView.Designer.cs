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
            this.fieldRole = new System.Windows.Forms.ComboBox();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.fieldAddress = new System.Windows.Forms.TextBox();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldFullname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.pageReport = new System.Windows.Forms.TabPage();
            this.dbReport = new System.Windows.Forms.DataGridView();
            this.fieldEndDate = new System.Windows.Forms.TextBox();
            this.fieldStartDate = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pageRegisterStaff.SuspendLayout();
            this.pageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(32, 58);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(150, 64);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello";
            this.lblGreeting.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageRegisterStaff);
            this.tabControl1.Controls.Add(this.pageReport);
            this.tabControl1.Location = new System.Drawing.Point(22, 163);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1948, 828);
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
            this.pageRegisterStaff.Location = new System.Drawing.Point(12, 69);
            this.pageRegisterStaff.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageRegisterStaff.Name = "pageRegisterStaff";
            this.pageRegisterStaff.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageRegisterStaff.Size = new System.Drawing.Size(1924, 747);
            this.pageRegisterStaff.TabIndex = 0;
            this.pageRegisterStaff.Text = "Register Staff";
            this.pageRegisterStaff.UseVisualStyleBackColor = true;
            // 
            // fieldRole
            // 
            this.fieldRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldRole.FormattingEnabled = true;
            this.fieldRole.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Technician"});
            this.fieldRole.Location = new System.Drawing.Point(442, 271);
            this.fieldRole.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldRole.Name = "fieldRole";
            this.fieldRole.Size = new System.Drawing.Size(1024, 63);
            this.fieldRole.TabIndex = 13;
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.BackColor = System.Drawing.Color.Aqua;
            this.btnCreateStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStaff.Location = new System.Drawing.Point(55, 588);
            this.btnCreateStaff.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(312, 70);
            this.btnCreateStaff.TabIndex = 12;
            this.btnCreateStaff.Text = "Create Staff";
            this.btnCreateStaff.UseVisualStyleBackColor = false;
            // 
            // fieldEmail
            // 
            this.fieldEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldEmail.Location = new System.Drawing.Point(442, 444);
            this.fieldEmail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(1024, 63);
            this.fieldEmail.TabIndex = 11;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldAddress.Location = new System.Drawing.Point(442, 358);
            this.fieldAddress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(1024, 63);
            this.fieldAddress.TabIndex = 10;
            // 
            // fieldUsername
            // 
            this.fieldUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldUsername.Location = new System.Drawing.Point(442, 185);
            this.fieldUsername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(1024, 63);
            this.fieldUsername.TabIndex = 8;
            // 
            // fieldFullname
            // 
            this.fieldFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldFullname.Location = new System.Drawing.Point(442, 98);
            this.fieldFullname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldFullname.Name = "fieldFullname";
            this.fieldFullname.Size = new System.Drawing.Size(1024, 63);
            this.fieldFullname.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(55, 463);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 55);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(55, 204);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(217, 55);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(55, 290);
            this.lblRole.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(112, 55);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(55, 377);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(181, 55);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(55, 118);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(201, 55);
            this.lblFullname.TabIndex = 2;
            this.lblFullname.Text = "Fullname";
            // 
            // pageReport
            // 
            this.pageReport.Controls.Add(this.btnGenerateReport);
            this.pageReport.Controls.Add(this.dbReport);
            this.pageReport.Controls.Add(this.fieldEndDate);
            this.pageReport.Controls.Add(this.fieldStartDate);
            this.pageReport.Controls.Add(this.lblStart);
            this.pageReport.Controls.Add(this.lblEnd);
            this.pageReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageReport.Location = new System.Drawing.Point(12, 69);
            this.pageReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageReport.Name = "pageReport";
            this.pageReport.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageReport.Size = new System.Drawing.Size(1924, 747);
            this.pageReport.TabIndex = 1;
            this.pageReport.Text = "Reports";
            this.pageReport.UseVisualStyleBackColor = true;
            // 
            // dbReport
            // 
            this.dbReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbReport.Location = new System.Drawing.Point(82, 259);
            this.dbReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dbReport.Name = "dbReport";
            this.dbReport.RowHeadersWidth = 51;
            this.dbReport.RowTemplate.Height = 29;
            this.dbReport.Size = new System.Drawing.Size(1382, 451);
            this.dbReport.TabIndex = 10;
            this.dbReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fieldEndDate
            // 
            this.fieldEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldEndDate.Location = new System.Drawing.Point(1180, 77);
            this.fieldEndDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldEndDate.Name = "fieldEndDate";
            this.fieldEndDate.Size = new System.Drawing.Size(472, 63);
            this.fieldEndDate.TabIndex = 9;
            // 
            // fieldStartDate
            // 
            this.fieldStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldStartDate.Location = new System.Drawing.Point(326, 77);
            this.fieldStartDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldStartDate.Name = "fieldStartDate";
            this.fieldStartDate.Size = new System.Drawing.Size(472, 63);
            this.fieldStartDate.TabIndex = 8;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(82, 77);
            this.lblStart.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(216, 55);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start Date";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.Location = new System.Drawing.Point(962, 77);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(202, 55);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End Date";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Silver;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(1265, 58);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(312, 70);
            this.btnProfile.TabIndex = 14;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1625, 58);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(312, 70);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Silver;
            this.btnGenerateReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReport.Location = new System.Drawing.Point(82, 165);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(479, 70);
            this.btnGenerateReport.TabIndex = 16;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1080);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGreeting);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.Load += new System.EventHandler(this.ManagerView_Load);
            this.tabControl1.ResumeLayout(false);
            this.pageRegisterStaff.ResumeLayout(false);
            this.pageRegisterStaff.PerformLayout();
            this.pageReport.ResumeLayout(false);
            this.pageReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbReport)).EndInit();
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
        private TabPage pageReport;
        private Button btnProfile;
        private Button btnLogout;
        private TextBox fieldEndDate;
        private TextBox fieldStartDate;
        private Label lblStart;
        private Label lblEnd;
        private DataGridView dbReport;
        private Button btnGenerateReport;
    }
}