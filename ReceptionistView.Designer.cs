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
            this.pageCreate = new System.Windows.Forms.TabPage();
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
            this.pageOngoing = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRequestUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRequestServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRequestServiceFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contReceptionist.SuspendLayout();
            this.pageCreate.SuspendLayout();
            this.pageOngoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(734, 68);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 56);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(59, 55);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(374, 32);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Welcome, Michael Henri Muljadi!";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(570, 68);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(128, 56);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // contReceptionist
            // 
            this.contReceptionist.Controls.Add(this.pageCreate);
            this.contReceptionist.Controls.Add(this.pageOngoing);
            this.contReceptionist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contReceptionist.Location = new System.Drawing.Point(55, 117);
            this.contReceptionist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contReceptionist.Name = "contReceptionist";
            this.contReceptionist.SelectedIndex = 0;
            this.contReceptionist.Size = new System.Drawing.Size(808, 417);
            this.contReceptionist.TabIndex = 3;
            this.contReceptionist.SelectedIndexChanged += new System.EventHandler(this.contReceptionist_SelectedIndexChanged);
            // 
            // pageCreate
            // 
            this.pageCreate.Controls.Add(this.btnCreateReq);
            this.pageCreate.Controls.Add(this.fieldFullname);
            this.pageCreate.Controls.Add(this.fieldEmail);
            this.pageCreate.Controls.Add(this.fieldAddress);
            this.pageCreate.Controls.Add(this.lblFullname);
            this.pageCreate.Controls.Add(this.fieldFee);
            this.pageCreate.Controls.Add(this.lblEmail);
            this.pageCreate.Controls.Add(this.lblAddress);
            this.pageCreate.Controls.Add(this.lblFee);
            this.pageCreate.Controls.Add(this.radUrgent);
            this.pageCreate.Controls.Add(this.radNormal);
            this.pageCreate.Controls.Add(this.fieldServiceType);
            this.pageCreate.Controls.Add(this.fieldUsername);
            this.pageCreate.Controls.Add(this.lblUrgency);
            this.pageCreate.Controls.Add(this.lblServiceType);
            this.pageCreate.Controls.Add(this.lblUsername);
            this.pageCreate.Location = new System.Drawing.Point(4, 34);
            this.pageCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageCreate.Name = "pageCreate";
            this.pageCreate.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageCreate.Size = new System.Drawing.Size(800, 379);
            this.pageCreate.TabIndex = 0;
            this.pageCreate.Text = "Create Request";
            this.pageCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreateReq
            // 
            this.btnCreateReq.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateReq.ForeColor = System.Drawing.Color.Black;
            this.btnCreateReq.Location = new System.Drawing.Point(21, 269);
            this.btnCreateReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateReq.Name = "btnCreateReq";
            this.btnCreateReq.Size = new System.Drawing.Size(102, 53);
            this.btnCreateReq.TabIndex = 18;
            this.btnCreateReq.Text = "Create";
            this.btnCreateReq.UseVisualStyleBackColor = false;
            // 
            // fieldFullname
            // 
            this.fieldFullname.Location = new System.Drawing.Point(541, 155);
            this.fieldFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldFullname.Name = "fieldFullname";
            this.fieldFullname.Size = new System.Drawing.Size(226, 32);
            this.fieldFullname.TabIndex = 17;
            // 
            // fieldEmail
            // 
            this.fieldEmail.Location = new System.Drawing.Point(541, 109);
            this.fieldEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(226, 32);
            this.fieldEmail.TabIndex = 16;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Location = new System.Drawing.Point(541, 67);
            this.fieldAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(226, 32);
            this.fieldAddress.TabIndex = 15;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(435, 71);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(97, 25);
            this.lblFullname.TabIndex = 14;
            this.lblFullname.Text = "Full Name";
            // 
            // fieldFee
            // 
            this.fieldFee.AutoSize = true;
            this.fieldFee.Location = new System.Drawing.Point(143, 207);
            this.fieldFee.Name = "fieldFee";
            this.fieldFee.Size = new System.Drawing.Size(69, 25);
            this.fieldFee.TabIndex = 11;
            this.fieldFee.Text = "RM. 90";
            this.fieldFee.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(435, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(435, 115);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 25);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(18, 207);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(41, 25);
            this.lblFee.TabIndex = 12;
            this.lblFee.Text = "Fee";
            // 
            // radUrgent
            // 
            this.radUrgent.AutoSize = true;
            this.radUrgent.Location = new System.Drawing.Point(238, 157);
            this.radUrgent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radUrgent.Name = "radUrgent";
            this.radUrgent.Size = new System.Drawing.Size(91, 29);
            this.radUrgent.TabIndex = 10;
            this.radUrgent.TabStop = true;
            this.radUrgent.Text = "Urgent";
            this.radUrgent.UseVisualStyleBackColor = true;
            this.radUrgent.CheckedChanged += new System.EventHandler(this.radUrgent_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(143, 157);
            this.radNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(96, 29);
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
            this.fieldServiceType.Location = new System.Drawing.Point(144, 111);
            this.fieldServiceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldServiceType.Name = "fieldServiceType";
            this.fieldServiceType.Size = new System.Drawing.Size(265, 33);
            this.fieldServiceType.TabIndex = 8;
            this.fieldServiceType.SelectedIndexChanged += new System.EventHandler(this.fieldServiceType_SelectedIndexChanged);
            // 
            // fieldUsername
            // 
            this.fieldUsername.Location = new System.Drawing.Point(143, 63);
            this.fieldUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(266, 32);
            this.fieldUsername.TabIndex = 7;
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Location = new System.Drawing.Point(18, 159);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(82, 25);
            this.lblUrgency.TabIndex = 6;
            this.lblUrgency.Text = "Urgency";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(18, 113);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(116, 25);
            this.lblServiceType.TabIndex = 5;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 25);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // pageOngoing
            // 
            this.pageOngoing.Controls.Add(this.dataGridView1);
            this.pageOngoing.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageOngoing.Location = new System.Drawing.Point(4, 34);
            this.pageOngoing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageOngoing.Name = "pageOngoing";
            this.pageOngoing.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageOngoing.Size = new System.Drawing.Size(800, 379);
            this.pageOngoing.TabIndex = 1;
            this.pageOngoing.Text = "Ongoing Requests";
            this.pageOngoing.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnRequestID,
            this.columnRequestUsername,
            this.columnRequestServiceType,
            this.columnRequestServiceFee,
            this.columnServiceStatus});
            this.dataGridView1.Location = new System.Drawing.Point(33, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(741, 309);
            this.dataGridView1.TabIndex = 19;
            // 
            // columnRequestID
            // 
            this.columnRequestID.HeaderText = "RequestID";
            this.columnRequestID.MinimumWidth = 6;
            this.columnRequestID.Name = "columnRequestID";
            this.columnRequestID.Width = 125;
            // 
            // columnRequestUsername
            // 
            this.columnRequestUsername.HeaderText = "Username";
            this.columnRequestUsername.MinimumWidth = 6;
            this.columnRequestUsername.Name = "columnRequestUsername";
            this.columnRequestUsername.Width = 125;
            // 
            // columnRequestServiceType
            // 
            this.columnRequestServiceType.HeaderText = "ServiceT Type";
            this.columnRequestServiceType.MinimumWidth = 6;
            this.columnRequestServiceType.Name = "columnRequestServiceType";
            this.columnRequestServiceType.Width = 180;
            // 
            // columnRequestServiceFee
            // 
            this.columnRequestServiceFee.HeaderText = "Service Fee";
            this.columnRequestServiceFee.MinimumWidth = 6;
            this.columnRequestServiceFee.Name = "columnRequestServiceFee";
            this.columnRequestServiceFee.Width = 125;
            // 
            // columnServiceStatus
            // 
            this.columnServiceStatus.HeaderText = "Service Status";
            this.columnServiceStatus.MinimumWidth = 6;
            this.columnServiceStatus.Name = "columnServiceStatus";
            this.columnServiceStatus.Width = 180;
            // 
            // ReceptionistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.contReceptionist);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReceptionistView";
            this.Text = "ReceptionistView";
            this.Load += new System.EventHandler(this.ReceptionistView_Load);
            this.contReceptionist.ResumeLayout(false);
            this.pageCreate.ResumeLayout(false);
            this.pageCreate.PerformLayout();
            this.pageOngoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private Label lblGreeting;
        private Button btnProfile;
        private TabControl contReceptionist;
        private TabPage pageCreate;
        private TabPage pageOngoing;
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
        private DataGridViewTextBoxColumn columnRequestID;
        private DataGridViewTextBoxColumn columnRequestUsername;
        private DataGridViewTextBoxColumn columnRequestServiceType;
        private DataGridViewTextBoxColumn columnRequestServiceFee;
        private DataGridViewTextBoxColumn columnServiceStatus;
    }
}