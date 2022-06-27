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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.contReceptionist = new System.Windows.Forms.TabControl();
            this.pageCreate = new System.Windows.Forms.TabPage();
            this.fieldUsername = new System.Windows.Forms.ComboBox();
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
            this.lblUrgency = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pageOngoing = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.requestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contReceptionist.SuspendLayout();
            this.pageCreate.SuspendLayout();
            this.pageOngoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAccessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1836, 132);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(322, 134);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(148, 132);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(55, 76);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "-";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(1422, 132);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(320, 134);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // contReceptionist
            // 
            this.contReceptionist.Controls.Add(this.pageCreate);
            this.contReceptionist.Controls.Add(this.pageOngoing);
            this.contReceptionist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contReceptionist.Location = new System.Drawing.Point(138, 281);
            this.contReceptionist.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.contReceptionist.Name = "contReceptionist";
            this.contReceptionist.SelectedIndex = 0;
            this.contReceptionist.Size = new System.Drawing.Size(2020, 1001);
            this.contReceptionist.TabIndex = 3;
            this.contReceptionist.SelectedIndexChanged += new System.EventHandler(this.contReceptionist_SelectedIndexChanged);
            // 
            // pageCreate
            // 
            this.pageCreate.Controls.Add(this.fieldUsername);
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
            this.pageCreate.Controls.Add(this.lblUrgency);
            this.pageCreate.Controls.Add(this.lblServiceType);
            this.pageCreate.Controls.Add(this.lblUsername);
            this.pageCreate.Location = new System.Drawing.Point(12, 82);
            this.pageCreate.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pageCreate.Name = "pageCreate";
            this.pageCreate.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pageCreate.Size = new System.Drawing.Size(1996, 907);
            this.pageCreate.TabIndex = 0;
            this.pageCreate.Text = "Create Request";
            this.pageCreate.UseVisualStyleBackColor = true;
            // 
            // fieldUsername
            // 
            this.fieldUsername.FormattingEnabled = true;
            this.fieldUsername.Location = new System.Drawing.Point(358, 153);
            this.fieldUsername.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(656, 69);
            this.fieldUsername.TabIndex = 19;
            this.fieldUsername.DropDown += new System.EventHandler(this.dropdownClick);
            this.fieldUsername.SelectionChangeCommitted += new System.EventHandler(this.fieldUsername_SelectedIndexChanged);
            // 
            // btnCreateReq
            // 
            this.btnCreateReq.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateReq.ForeColor = System.Drawing.Color.Black;
            this.btnCreateReq.Location = new System.Drawing.Point(52, 646);
            this.btnCreateReq.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.btnCreateReq.Name = "btnCreateReq";
            this.btnCreateReq.Size = new System.Drawing.Size(255, 127);
            this.btnCreateReq.TabIndex = 18;
            this.btnCreateReq.Text = "Create";
            this.btnCreateReq.UseVisualStyleBackColor = false;
            this.btnCreateReq.Click += new System.EventHandler(this.btnCreateReq_Click);
            // 
            // fieldFullname
            // 
            this.fieldFullname.Location = new System.Drawing.Point(1352, 167);
            this.fieldFullname.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fieldFullname.Name = "fieldFullname";
            this.fieldFullname.Size = new System.Drawing.Size(559, 67);
            this.fieldFullname.TabIndex = 17;
            // 
            // fieldEmail
            // 
            this.fieldEmail.Location = new System.Drawing.Point(1352, 384);
            this.fieldEmail.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fieldEmail.Name = "fieldEmail";
            this.fieldEmail.Size = new System.Drawing.Size(559, 67);
            this.fieldEmail.TabIndex = 16;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Location = new System.Drawing.Point(1352, 270);
            this.fieldAddress.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(559, 67);
            this.fieldAddress.TabIndex = 15;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(1088, 170);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(228, 61);
            this.lblFullname.TabIndex = 14;
            this.lblFullname.Text = "Full Name";
            // 
            // fieldFee
            // 
            this.fieldFee.AutoSize = true;
            this.fieldFee.Location = new System.Drawing.Point(358, 497);
            this.fieldFee.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.fieldFee.Name = "fieldFee";
            this.fieldFee.Size = new System.Drawing.Size(45, 61);
            this.fieldFee.TabIndex = 11;
            this.fieldFee.Text = "-";
            this.fieldFee.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(1088, 384);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(134, 61);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(1088, 276);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(188, 61);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(45, 497);
            this.lblFee.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(97, 61);
            this.lblFee.TabIndex = 12;
            this.lblFee.Text = "Fee";
            // 
            // radUrgent
            // 
            this.radUrgent.AutoSize = true;
            this.radUrgent.Location = new System.Drawing.Point(595, 377);
            this.radUrgent.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.radUrgent.Name = "radUrgent";
            this.radUrgent.Size = new System.Drawing.Size(209, 65);
            this.radUrgent.TabIndex = 10;
            this.radUrgent.TabStop = true;
            this.radUrgent.Text = "Urgent";
            this.radUrgent.UseVisualStyleBackColor = true;
            this.radUrgent.CheckedChanged += new System.EventHandler(this.radUrgent_CheckedChanged);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(358, 377);
            this.radNormal.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(220, 65);
            this.radNormal.TabIndex = 9;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
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
            this.fieldServiceType.Location = new System.Drawing.Point(360, 266);
            this.fieldServiceType.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fieldServiceType.Name = "fieldServiceType";
            this.fieldServiceType.Size = new System.Drawing.Size(656, 69);
            this.fieldServiceType.TabIndex = 8;
            this.fieldServiceType.SelectedIndexChanged += new System.EventHandler(this.fieldServiceType_SelectedIndexChanged);
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Location = new System.Drawing.Point(45, 382);
            this.lblUrgency.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(193, 61);
            this.lblUrgency.TabIndex = 6;
            this.lblUrgency.Text = "Urgency";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(45, 271);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(275, 61);
            this.lblServiceType.TabIndex = 5;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(45, 161);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(228, 61);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // pageOngoing
            // 
            this.pageOngoing.Controls.Add(this.dataGridView1);
            this.pageOngoing.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageOngoing.Location = new System.Drawing.Point(12, 82);
            this.pageOngoing.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pageOngoing.Name = "pageOngoing";
            this.pageOngoing.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pageOngoing.Size = new System.Drawing.Size(1996, 907);
            this.pageOngoing.TabIndex = 1;
            this.pageOngoing.Text = "Ongoing Requests";
            this.pageOngoing.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1852, 742);
            this.dataGridView1.TabIndex = 19;
            // 
            // requestBindingSource2
            // 
            this.requestBindingSource2.DataSource = typeof(code.Request);
            // 
            // requestBindingSource1
            // 
            this.requestBindingSource1.DataSource = typeof(code.Request);
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataSource = typeof(code.Request);
            // 
            // dBAccessBindingSource
            // 
            this.dBAccessBindingSource.DataSource = typeof(code.DBAccess);
            // 
            // ReceptionistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2285, 1440);
            this.Controls.Add(this.contReceptionist);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "ReceptionistView";
            this.Text = "ReceptionistView";
            this.Load += new System.EventHandler(this.ReceptionistView_Load);
            this.contReceptionist.ResumeLayout(false);
            this.pageCreate.ResumeLayout(false);
            this.pageCreate.PerformLayout();
            this.pageOngoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAccessBindingSource)).EndInit();
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
        private BindingSource dBAccessBindingSource;
        private BindingSource requestBindingSource;
        private BindingSource requestBindingSource1;
        private DataGridView dataGridView1;
        private BindingSource requestBindingSource2;
        private ComboBox fieldUsername;
    }
}