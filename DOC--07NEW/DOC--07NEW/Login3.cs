//This form is for verifiying with the email--->forgot password

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOC__07NEW
{
    public partial class Login3 : Form
    {
        //
        //class
        //
        public string verificationCode;
        private string GenerateRandomCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // 6-digit code
        }
        //
        //send email code
        //
        private void SendEmail(string recipientEmail, string code)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("Type your email address"); // Replace with your email address
            message.To.Add(recipientEmail);
            message.Subject = "Verification Code";
            message.Body = "Your verification code is: " + code;

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Use Gmail's SMTP server
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("email address", "password"); // Replace with your email credentials

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Login3()
        {
            InitializeComponent();
        }

        private void butEmail_Click(object sender, EventArgs e)
        {
            /* string email = txtEmail.Text;
                        
            string code = GenerateRandomCode();// Generate random code                                               
            SendEmail(email, code);// Send email with code
            verificationCode = code; // Store code for verification

            MessageBox.Show("Verification code sent to your email.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }

        private void butVerify_Click(object sender, EventArgs e)
        {
            string enteredCode = txtVCode.Text;

            if (enteredCode == verificationCode)
            {
                Login4 f4 = new Login4();
                f4.Show(); // or otherForm.ShowDialog()
                this.Hide(); // Hide the current form 
                MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);// Proceed with successful verification actions

            }
            else
            {
                MessageBox.Show("Invalid verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
