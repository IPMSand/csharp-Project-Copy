using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Security.Cryptography;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
//

namespace doc_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //
        //hash
        //
        

        //
        //end hash
        //
        SqlConnection con4 = new SqlConnection();
        private void butUpdatePassword_Click(object sender, EventArgs e)
        {

            //string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            // Get username and password from textboxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string conNewPassword= txtConfirmPassword.Text.Trim();

            // Basic validation 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(conNewPassword))
            {
                MessageBox.Show("Username and password cannot be empty!");

            }
            else if (password.Length < 8 || password.Length > 20)
            {
                MessageBox.Show($"Password must be at least {8} characters long.", "Short Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (newPassword.Length < 8 || newPassword.Length > 20)
            {
                MessageBox.Show(" new Password lenght");
            }
            else if (!newPassword.Any(char.IsUpper))
            {
                MessageBox.Show("Upper letter!");
            }
            else if (!newPassword.Any(char.IsLower))
            {
                MessageBox.Show("lower!");
            }
            else 
            {

                //
                //user name password
                //
                SqlCommand cmd = new SqlCommand("select * from UserT where userName=@UserName and password =@Password", con4);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Connection open here   
                con4.Open();
                int i = cmd.ExecuteNonQuery();
                con4.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully loged in");
                    //after successful it will redirect  to next page .
                    string pass =conNewPassword.ToString();
                    SqlCommand cmd2 = new SqlCommand("UPDATE * FROM UserT SET Password=@pass WHERE userName=@UserName ");
                    Form1 f1 = new Form1();
                    f1.Show();

                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password and Unsucesssfull");
                }

            }





            









        }
    }
}

/*Query q4 = new Query("update users set password='@NewPassword' where username='@Username' and password='@OldPassword'");
q4.SetParameter("NewPassword", SHA1(username + new1));
q4.SetParameter("OldPassword", SHA1(username + old));
q4.SetParameter("Username", SHA1(username));
return 1 == q4.Execute().AffectedRows*/
/*
static string hashPassword(string rawData)
{
    // Create a SHA256
    using (SHA256 sha256Hash = SHA256.Create())
    {
        // ComputeHash - returns byte array
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

        // Convert byte array to a string
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }
        return builder.ToString();
    }
}*/