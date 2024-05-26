namespace DOC__07NEW
{
    partial class Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxLogin.Controls.Add(this.checkBox2);
            this.groupBoxLogin.Controls.Add(this.lblResetPassword);
            this.groupBoxLogin.Controls.Add(this.lblRegister);
            this.groupBoxLogin.Controls.Add(this.lblAlert);
            this.groupBoxLogin.Controls.Add(this.lblPassword);
            this.groupBoxLogin.Controls.Add(this.lblUsername);
            this.groupBoxLogin.Controls.Add(this.butClear);
            this.groupBoxLogin.Controls.Add(this.butLogin);
            this.groupBoxLogin.Controls.Add(this.txtPassword);
            this.groupBoxLogin.Controls.Add(this.txtUsername);
            this.groupBoxLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxLogin.Location = new System.Drawing.Point(463, 24);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(586, 598);
            this.groupBoxLogin.TabIndex = 56;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(348, 329);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(160, 26);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "Show Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblResetPassword.Location = new System.Drawing.Point(297, 548);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(263, 32);
            this.lblResetPassword.TabIndex = 48;
            this.lblResetPassword.Text = "Change the Password";
            this.lblResetPassword.Click += new System.EventHandler(this.lblResetPassword_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRegister.Location = new System.Drawing.Point(39, 548);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(217, 32);
            this.lblRegister.TabIndex = 47;
            this.lblRegister.Text = "Sign up/Resister?";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlert.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlert.Location = new System.Drawing.Point(45, 62);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(529, 34);
            this.lblAlert.TabIndex = 45;
            this.lblAlert.Text = "Username and Password cannot be empty !";
            this.lblAlert.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(69, 233);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 27);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(63, 133);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 27);
            this.lblUsername.TabIndex = 43;
            this.lblUsername.Text = "Username";
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.SteelBlue;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClear.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butClear.Location = new System.Drawing.Point(68, 480);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(460, 46);
            this.butClear.TabIndex = 42;
            this.butClear.Text = "CLEAR";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.Teal;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butLogin.Location = new System.Drawing.Point(68, 361);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(460, 113);
            this.butLogin.TabIndex = 41;
            this.butLogin.Text = "LOGIN";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.Location = new System.Drawing.Point(68, 263);
            this.txtPassword.MaxLength = 32;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(460, 53);
            this.txtPassword.TabIndex = 40;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.Location = new System.Drawing.Point(67, 163);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(461, 53);
            this.txtUsername.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 671);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(61, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 142);
            this.button1.TabIndex = 57;
            this.button1.Text = "CARELINK EHR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1071, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
    }
}

