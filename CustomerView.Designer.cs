namespace code
{
    partial class CustomerView
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageCurrent = new System.Windows.Forms.TabPage();
            this.DGVcurrent = new System.Windows.Forms.DataGridView();
            this.pageHistory = new System.Windows.Forms.TabPage();
            this.DGVhistory = new System.Windows.Forms.DataGridView();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.pageCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcurrent)).BeginInit();
            this.pageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1630, 74);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(312, 70);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Silver;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(1270, 74);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(312, 70);
            this.btnProfile.TabIndex = 18;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCurrent);
            this.tabControl1.Controls.Add(this.pageHistory);
            this.tabControl1.Location = new System.Drawing.Point(28, 180);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1948, 828);
            this.tabControl1.TabIndex = 17;
            // 
            // pageCurrent
            // 
            this.pageCurrent.Controls.Add(this.DGVcurrent);
            this.pageCurrent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageCurrent.Location = new System.Drawing.Point(12, 69);
            this.pageCurrent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageCurrent.Name = "pageCurrent";
            this.pageCurrent.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageCurrent.Size = new System.Drawing.Size(1924, 747);
            this.pageCurrent.TabIndex = 0;
            this.pageCurrent.Text = "Current";
            this.pageCurrent.UseVisualStyleBackColor = true;
            // 
            // DGVcurrent
            // 
            this.DGVcurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcurrent.Location = new System.Drawing.Point(62, 149);
            this.DGVcurrent.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DGVcurrent.Name = "DGVcurrent";
            this.DGVcurrent.RowHeadersWidth = 51;
            this.DGVcurrent.RowTemplate.Height = 29;
            this.DGVcurrent.Size = new System.Drawing.Size(1808, 451);
            this.DGVcurrent.TabIndex = 0;
            // 
            // pageHistory
            // 
            this.pageHistory.Controls.Add(this.DGVhistory);
            this.pageHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageHistory.Location = new System.Drawing.Point(12, 69);
            this.pageHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageHistory.Name = "pageHistory";
            this.pageHistory.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pageHistory.Size = new System.Drawing.Size(1924, 747);
            this.pageHistory.TabIndex = 1;
            this.pageHistory.Text = "History";
            this.pageHistory.UseVisualStyleBackColor = true;
            // 
            // DGVhistory
            // 
            this.DGVhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVhistory.Location = new System.Drawing.Point(62, 149);
            this.DGVhistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DGVhistory.Name = "DGVhistory";
            this.DGVhistory.RowHeadersWidth = 51;
            this.DGVhistory.RowTemplate.Height = 29;
            this.DGVhistory.Size = new System.Drawing.Size(1808, 451);
            this.DGVhistory.TabIndex = 10;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(38, 74);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(45, 64);
            this.lblGreeting.TabIndex = 16;
            this.lblGreeting.Text = "-";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1080);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGreeting);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.tabControl1.ResumeLayout(false);
            this.pageCurrent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcurrent)).EndInit();
            this.pageHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogout;
        private Button btnProfile;
        private TabControl tabControl1;
        private TabPage pageCurrent;
        private DataGridView DGVcurrent;
        private TabPage pageHistory;
        private DataGridView DGVhistory;
        private Label lblGreeting;
    }
}