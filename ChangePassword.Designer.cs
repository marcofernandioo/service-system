namespace code
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
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(109, 167);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(83, 22);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fullname";
            // 
            // fieldUsername
            // 
            this.fieldUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldUsername.Location = new System.Drawing.Point(247, 159);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.Size = new System.Drawing.Size(286, 30);
            this.fieldUsername.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(247, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 30);
            this.textBox1.TabIndex = 10;
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.BackColor = System.Drawing.Color.Aqua;
            this.btnCreateStaff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateStaff.Location = new System.Drawing.Point(109, 288);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(125, 29);
            this.btnCreateStaff.TabIndex = 13;
            this.btnCreateStaff.Text = "Back";
            this.btnCreateStaff.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(109, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreateStaff);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullname);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFullname;
        private Label label1;
        private TextBox fieldUsername;
        private TextBox textBox1;
        private Button btnCreateStaff;
        private Button button1;
    }
}