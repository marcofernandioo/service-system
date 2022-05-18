namespace code
{
    partial class ReceptionistView
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.contReceptionist = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreateReq = new System.Windows.Forms.Button();
            this.fieldFullname = new System.Windows.Forms.TextBox();
            this.fieldEmail = new System.Windows.Forms.TextBox();
            this.fieldAddress = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.fieldFee = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.radUrgent = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.fieldServiceType = new System.Windows.Forms.ComboBox();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contReceptionist.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(642, 51);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 42);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(52, 41);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(298, 25);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Welcome, Michael Henri Muljadi!";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(499, 51);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(112, 42);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // contReceptionist
            // 
            this.contReceptionist.Controls.Add(this.tabPage1);
            this.contReceptionist.Controls.Add(this.tabPage2);
            this.contReceptionist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contReceptionist.Location = new System.Drawing.Point(48, 88);
            this.contReceptionist.Name = "contReceptionist";
            this.contReceptionist.SelectedIndex = 0;
            this.contReceptionist.Size = new System.Drawing.Size(707, 313);
            this.contReceptionist.TabIndex = 3;
            this.contReceptionist.SelectedIndexChanged += new System.EventHandler(this.contReceptionist_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreateReq);
            this.tabPage1.Controls.Add(this.fieldFullname);
            this.tabPage1.Controls.Add(this.fieldEmail);
            this.tabPage1.Controls.Add(this.fieldAddress);
            this.tabPage1.Controls.Add(this.lblFullname);
            this.tabPage1.Controls.Add(this.fieldFee);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.lblFee);
            this.tabPage1.Controls.Add(this.radUrgent);
            this.tabPage1.Controls.Add(this.radNormal);
            this.tabPage1.Controls.Add(this.fieldServiceType);
            this.tabPage1.Controls.Add(this.fieldUsername);
            this.tabPage1.Controls.Add(this.lblUrgency);
            this.tabPage1.Controls.Add(this.lblServiceType);
            this.tabPage1.Controls.Add(this.lblUsername);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateReq
            // 
            this.btnCreateReq.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateReq.ForeColor = System.Drawing.Color.Black;
            this.btnCreateReq.Location = new System.Drawing.Point(18, 202);
            this.btnCreateReq.Name = "btnCreateReq";
            this.btnCreateReq.Size = new System.Drawing.Size(89, 40);
            this.btnCreateReq.TabIndex = 18;
            this.btnCreateReq.Text = "Create";
            this.btnCreateReq.UseVisualStyleBackColor = false;
            // 
            // fieldFullname
            // 
            this.fieldFullname.Location = new System.Drawing.Point(473, 116);
            this.fieldFullname.Name = "fieldFullname";
            this.fieldFullname.Size = new System.Drawing.Size(198, 27);
            this.fieldFullname.TabIndex = 17;
            // 
            // fieldEmail
            // 
            this.fieldEmail.Location = new System.Drawing.Point(473, 82);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(198, 27);
            this.fieldEmail.TabIndex = 16;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Location = new System.Drawing.Point(473, 50);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(198, 27);
            this.fieldAddress.TabIndex = 15;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(381, 53);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(76, 20);
            this.lblFullname.TabIndex = 14;
            this.lblFullname.Text = "Full Name";
            // 
            // fieldFee
            // 
            this.fieldFee.AutoSize = true;
            this.fieldFee.Location = new System.Drawing.Point(125, 155);
            this.fieldFee.Name = "fieldFee";
            this.fieldFee.Size = new System.Drawing.Size(54, 20);
            this.fieldFee.TabIndex = 11;
            this.fieldFee.Text = "RM. 90";
            this.fieldFee.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(381, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(381, 86);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(16, 155);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(32, 20);
            this.lblFee.TabIndex = 12;
            this.lblFee.Text = "Fee";
            // 
            // radUrgent
            // 
            this.radUrgent.AutoSize = true;
            this.radUrgent.Location = new System.Drawing.Point(208, 118);
            this.radUrgent.Name = "radUrgent";
            this.radUrgent.Size = new System.Drawing.Size(72, 24);
            this.radUrgent.TabIndex = 10;
            this.radUrgent.TabStop = true;
            this.radUrgent.Text = "Urgent";
            this.radUrgent.UseVisualStyleBackColor = true;
            this.radUrgent.CheckedChanged += new System.EventHandler(this.radUrgent_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(125, 118);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(77, 24);
            this.radNormal.TabIndex = 9;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // fieldServiceType
            // 
            this.fieldServiceType.FormattingEnabled = true;
            this.fieldServiceType.Items.AddRange(new object[] {
            "Remove Virus, Malware, Spyware ",
            "Troubleshoot & Fix Slow Computer ",
            "Laptop Screen Replacement ",
            "Laptop Keyboard Replacement ",
            "Laptop Battery Replacement ",
            "OS Format & Installation ",
            "Data Backup & Recovery ",
            "Internet Connectivity Issues "});
            this.fieldServiceType.Location = new System.Drawing.Point(126, 83);
            this.fieldServiceType.Name = "fieldServiceType";
            this.fieldServiceType.Size = new System.Drawing.Size(232, 28);
            this.fieldServiceType.TabIndex = 8;
            this.fieldServiceType.SelectedIndexChanged += new System.EventHandler(this.fieldServiceType_SelectedIndexChanged);
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(125, 47);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(233, 27);
            this.fieldUsername.TabIndex = 7;
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Location = new System.Drawing.Point(16, 119);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(63, 20);
            this.lblUrgency.TabIndex = 6;
            this.lblUrgency.Text = "Urgency";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(16, 85);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(91, 20);
            this.lblServiceType.TabIndex = 5;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ongoing Requests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(648, 232);
            this.dataGridView1.TabIndex = 19;
            // 
            // ReceptionistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contReceptionist);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnLogout);
            this.Name = "ReceptionistView";
            this.Text = "ReceptionistView";
            this.Load += new System.EventHandler(this.ReceptionistView_Load);
            this.contReceptionist.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private Label lblGreeting;
        private Button btnProfile;
        private TabControl contReceptionist;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label fieldFee;
        private RadioButton radUrgent;
        private RadioButton radNormal;
        private ComboBox fieldServiceType;
        private TextBox fieldUsername;
        private Label lblUrgency;
        private Label lblServiceType;
        private Label lblUsername;
        private Label lblFullname;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblFee;
        private Button btnCreateReq;
        private TextBox fieldFullname;
        private TextBox fieldEmail;
        private TextBox fieldAddress;
        private DataGridView dataGridView1;
    }
}