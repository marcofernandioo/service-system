namespace code
{
    partial class LogoutConfirmation
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
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Button();
            this.lblYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmation.Location = new System.Drawing.Point(520, 458);
            this.lblConfirmation.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(1249, 108);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "Are you sure you want to Logout?";
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.Red;
            this.lblNo.Location = new System.Drawing.Point(520, 650);
            this.lblNo.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(523, 186);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "No";
            this.lblNo.UseVisualStyleBackColor = false;
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            // 
            // lblYes
            // 
            this.lblYes.BackColor = System.Drawing.Color.Red;
            this.lblYes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYes.Location = new System.Drawing.Point(1157, 650);
            this.lblYes.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(506, 186);
            this.lblYes.TabIndex = 2;
            this.lblYes.Text = "Yes";
            this.lblYes.UseVisualStyleBackColor = false;
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            // 
            // LogoutConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(2286, 1440);
            this.Controls.Add(this.lblYes);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblConfirmation);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "LogoutConfirmation";
            this.Text = "LogoutConfirmation";
            this.Load += new System.EventHandler(this.LogoutConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConfirmation;
        private Button lblNo;
        private Button lblYes;
    }
}