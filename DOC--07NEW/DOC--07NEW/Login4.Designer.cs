namespace DOC__07NEW
{
    partial class Login4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login4));
            this.lblCPassword = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.butUpdatePassword = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblCPassword.Location = new System.Drawing.Point(24, 82);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(636, 42);
            this.lblCPassword.TabIndex = 58;
            this.lblCPassword.Text = "Change the Password after Verification";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(414, 291);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 20);
            this.checkBox3.TabIndex = 57;
            this.checkBox3.Text = "Show Password";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // butUpdatePassword
            // 
            this.butUpdatePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.butUpdatePassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdatePassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butUpdatePassword.Location = new System.Drawing.Point(390, 436);
            this.butUpdatePassword.Name = "butUpdatePassword";
            this.butUpdatePassword.Size = new System.Drawing.Size(211, 89);
            this.butUpdatePassword.TabIndex = 55;
            this.butUpdatePassword.Text = "Update Password";
            this.butUpdatePassword.UseVisualStyleBackColor = false;
            this.butUpdatePassword.Click += new System.EventHandler(this.butUpdatePassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConfirmPassword.Location = new System.Drawing.Point(133, 291);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(233, 27);
            this.lblConfirmPassword.TabIndex = 54;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewPassword.Location = new System.Drawing.Point(133, 162);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(186, 27);
            this.lblNewPassword.TabIndex = 53;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConfirmPassword.Location = new System.Drawing.Point(138, 321);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(401, 59);
            this.txtConfirmPassword.TabIndex = 52;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNewPassword.Location = new System.Drawing.Point(138, 195);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(401, 59);
            this.txtNewPassword.TabIndex = 51;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(765, 82);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // Login4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 562);
            this.Controls.Add(this.lblCPassword);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.butUpdatePassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Login4";
            this.Text = "Login4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button butUpdatePassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}