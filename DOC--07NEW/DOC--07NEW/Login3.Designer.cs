namespace DOC__07NEW
{
    partial class Login3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login3));
            this.butEmail = new System.Windows.Forms.Button();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.butVerify = new System.Windows.Forms.Button();
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtVCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // butEmail
            // 
            this.butEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butEmail.Location = new System.Drawing.Point(513, 175);
            this.butEmail.Name = "butEmail";
            this.butEmail.Size = new System.Drawing.Size(211, 89);
            this.butEmail.TabIndex = 77;
            this.butEmail.Text = "Send the Code";
            this.butEmail.UseVisualStyleBackColor = false;
            this.butEmail.Click += new System.EventHandler(this.butEmail_Click);
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle3.Location = new System.Drawing.Point(12, 81);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(384, 37);
            this.lblTitle3.TabIndex = 75;
            this.lblTitle3.Text = "Sending Verification Code";
            // 
            // butVerify
            // 
            this.butVerify.BackColor = System.Drawing.Color.SteelBlue;
            this.butVerify.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVerify.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.butVerify.Location = new System.Drawing.Point(513, 336);
            this.butVerify.Name = "butVerify";
            this.butVerify.Size = new System.Drawing.Size(211, 89);
            this.butVerify.TabIndex = 74;
            this.butVerify.Text = "Verifiy the Code";
            this.butVerify.UseVisualStyleBackColor = false;
            this.butVerify.Click += new System.EventHandler(this.butVerify_Click);
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificationCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVerificationCode.Location = new System.Drawing.Point(66, 323);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(302, 32);
            this.lblVerificationCode.TabIndex = 73;
            this.lblVerificationCode.Text = "Type Verification Code :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(66, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(340, 32);
            this.lblEmail.TabIndex = 72;
            this.lblEmail.Text = "Type Your Email Address : ";
            // 
            // txtVCode
            // 
            this.txtVCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVCode.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtVCode.Location = new System.Drawing.Point(59, 353);
            this.txtVCode.Multiline = true;
            this.txtVCode.Name = "txtVCode";
            this.txtVCode.PasswordChar = '*';
            this.txtVCode.Size = new System.Drawing.Size(448, 46);
            this.txtVCode.TabIndex = 71;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(59, 192);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(448, 46);
            this.txtEmail.TabIndex = 70;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(850, 82);
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // Login3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 473);
            this.Controls.Add(this.butEmail);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.butVerify);
            this.Controls.Add(this.lblVerificationCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtVCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Login3";
            this.Text = "Login3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butEmail;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Button butVerify;
        private System.Windows.Forms.Label lblVerificationCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtVCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}