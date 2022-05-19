namespace code
{
    partial class TechnicianView
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contTechnician = new System.Windows.Forms.TabControl();
            this.pageRequestPool = new System.Windows.Forms.TabPage();
            this.pageMyWorks = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contTechnician.SuspendLayout();
            this.pageRequestPool.SuspendLayout();
            this.pageMyWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Lexend Deca", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGreeting.Location = new System.Drawing.Point(41, 36);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(144, 36);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, John!";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Lexend Deca", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(534, 36);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(140, 47);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Lexend Deca", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(713, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 47);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // contTechnician
            // 
            this.contTechnician.Controls.Add(this.pageRequestPool);
            this.contTechnician.Controls.Add(this.pageMyWorks);
            this.contTechnician.Font = new System.Drawing.Font("Lexend Deca", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contTechnician.Location = new System.Drawing.Point(37, 114);
            this.contTechnician.Name = "contTechnician";
            this.contTechnician.SelectedIndex = 0;
            this.contTechnician.Size = new System.Drawing.Size(824, 393);
            this.contTechnician.TabIndex = 3;
            this.contTechnician.SelectedIndexChanged += new System.EventHandler(this.contTechnician_SelectedIndexChanged);
            // 
            // pageRequestPool
            // 
            this.pageRequestPool.Controls.Add(this.dataGridView1);
            this.pageRequestPool.Location = new System.Drawing.Point(4, 41);
            this.pageRequestPool.Name = "pageRequestPool";
            this.pageRequestPool.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pageRequestPool.Size = new System.Drawing.Size(816, 348);
            this.pageRequestPool.TabIndex = 0;
            this.pageRequestPool.Text = "Request Pool";
            this.pageRequestPool.UseVisualStyleBackColor = true;
            // 
            // pageMyWorks
            // 
            this.pageMyWorks.Controls.Add(this.dataGridView2);
            this.pageMyWorks.Location = new System.Drawing.Point(4, 41);
            this.pageMyWorks.Name = "pageMyWorks";
            this.pageMyWorks.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pageMyWorks.Size = new System.Drawing.Size(816, 348);
            this.pageMyWorks.TabIndex = 1;
            this.pageMyWorks.Text = "My Works";
            this.pageMyWorks.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(773, 326);
            this.dataGridView2.TabIndex = 0;
            // 
            // TechnicianView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.contTechnician);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Lexend Deca", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TechnicianView";
            this.Text = "TechnicianView";
            this.Load += new System.EventHandler(this.TechnicianView_Load);
            this.contTechnician.ResumeLayout(false);
            this.pageRequestPool.ResumeLayout(false);
            this.pageMyWorks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGreeting;
        private Button btnProfile;
        private Button btnLogout;
        private TabControl contTechnician;
        private TabPage pageRequestPool;
        private TabPage pageMyWorks;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}