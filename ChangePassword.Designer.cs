﻿namespace code
{
    partial class ChangePassword
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
            this.lblFullname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldPass2 = new System.Windows.Forms.TextBox();
            this.fieldPass1 = new System.Windows.Forms.TextBox();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(272, 401);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(378, 55);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Password";
            // 
            // fieldPass2
            // 
            this.fieldPass2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldPass2.Location = new System.Drawing.Point(747, 393);
            this.fieldPass2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldPass2.Name = "fieldPass2";
            this.fieldPass2.Size = new System.Drawing.Size(709, 63);
            this.fieldPass2.TabIndex = 9;
            // 
            // fieldPass1
            // 
            this.fieldPass1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldPass1.Location = new System.Drawing.Point(747, 244);
            this.fieldPass1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fieldPass1.Name = "fieldPass1";
            this.fieldPass1.Size = new System.Drawing.Size(709, 63);
            this.fieldPass1.TabIndex = 10;
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.BackColor = System.Drawing.Color.Aqua;
            this.btnCreateStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStaff.Location = new System.Drawing.Point(272, 691);
            this.btnCreateStaff.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(312, 70);
            this.btnCreateStaff.TabIndex = 13;
            this.btnCreateStaff.Text = "Back";
            this.btnCreateStaff.UseVisualStyleBackColor = false;
            this.btnCreateStaff.Click += new System.EventHandler(this.btnCreateStaff_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(272, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 70);
            this.button1.TabIndex = 14;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2000, 1080);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateStaff);
            this.Controls.Add(this.fieldPass1);
            this.Controls.Add(this.fieldPass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullname);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFullname;
        private Label label1;
        private TextBox fieldPass2;
        private TextBox fieldPass1;
        private Button btnCreateStaff;
        private Button button1;
    }
}