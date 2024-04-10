namespace doc_4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblCPassword = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.butVerify = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtVCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.butEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPassword.Location = new System.Drawing.Point(6, 30);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(188, 38);
            this.lblCPassword.TabIndex = 49;
            this.lblCPassword.Text = "SendCode";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(323, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // butVerify
            // 
            this.butVerify.BackColor = System.Drawing.Color.Teal;
            this.butVerify.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVerify.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butVerify.Location = new System.Drawing.Point(501, 311);
            this.butVerify.Name = "butVerify";
            this.butVerify.Size = new System.Drawing.Size(211, 89);
            this.butVerify.TabIndex = 45;
            this.butVerify.Text = "Verifiy";
            this.butVerify.UseVisualStyleBackColor = false;
            this.butVerify.Click += new System.EventHandler(this.butVerify_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(54, 298);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(296, 27);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Type Verification Code :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsername.Location = new System.Drawing.Point(54, 124);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(313, 27);
            this.lblUsername.TabIndex = 38;
            this.lblUsername.Text = "Type Your Email Address";
            // 
            // txtVCode
            // 
            this.txtVCode.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtVCode.Location = new System.Drawing.Point(47, 328);
            this.txtVCode.Multiline = true;
            this.txtVCode.Name = "txtVCode";
            this.txtVCode.PasswordChar = '*';
            this.txtVCode.Size = new System.Drawing.Size(448, 46);
            this.txtVCode.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(47, 167);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(448, 46);
            this.txtEmail.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(850, 82);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // butEmail
            // 
            this.butEmail.BackColor = System.Drawing.Color.DarkKhaki;
            this.butEmail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butEmail.Location = new System.Drawing.Point(501, 150);
            this.butEmail.Name = "butEmail";
            this.butEmail.Size = new System.Drawing.Size(211, 89);
            this.butEmail.TabIndex = 52;
            this.butEmail.Text = "Send Veri Code";
            this.butEmail.UseVisualStyleBackColor = false;
            this.butEmail.Click += new System.EventHandler(this.butEmail_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 502);
            this.Controls.Add(this.butEmail);
            this.Controls.Add(this.lblCPassword);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butVerify);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtVCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form3";
            this.Text = "SendCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button butVerify;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtVCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button butEmail;
    }
}