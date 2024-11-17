using System;
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

namespace DOC__07NEW
{
    public partial class Login2 : Form
    {
        //
        //query
        //
        private bool ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection("Connection_String"))
            {
                connection.Open();

                using (SqlCommand cmd1 = new SqlCommand(query, connection))
                {                
                    cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd1.Parameters.AddWithValue("@password", txtPassword.Text);

                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        return reader.HasRows; // Check if any rows were returned
                    }
                }
            }
        }
        //
        //non
        //
        private void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection("connection_string"))
            {
                connection.Open();

                using (SqlCommand cmd2 = new SqlCommand(query, connection))
                {                    
                    cmd2.Parameters.AddWithValue("@username", txtNewPassword.Text);
                    cmd2.Parameters.AddWithValue("@conNewPassword", txtNewPassword.Text);
                    cmd2.Parameters.AddWithValue("@password", txtConfirmPassword.Text);

                    cmd2.ExecuteNonQuery();
                }
            }
        }
        //
        //++++++++++++++++++++++
        //     
        public Login2()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
        
        private void butUpdatePassword_Click(object sender, EventArgs e)// Get username and password from textboxes
        {     
            
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string conNewPassword = txtConfirmPassword.Text.Trim();
                    
           

            // Basic validation           
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(conNewPassword))
            {
                MessageBox.Show("Username and password cannot be empty!");return;

            }
            else if (password.Length < 8 || password.Length > 20)
            {
                MessageBox.Show("Wrong current Password", "Short Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (newPassword.Length < 8 || newPassword.Length > 20)
            {
                MessageBox.Show($"Password must be at least {8} characters long","New Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!newPassword.Any(char.IsNumber))
            {
                MessageBox.Show("Password must include a  Number!");
                return;

            }
            else if (!newPassword.Any(char.IsLetter))
            {
                MessageBox.Show("Password must inclde a letter!");
                return;
            }
            else if (!newPassword.Any(char.IsUpper))
            {
                MessageBox.Show("Password must include a Upper letter!");
                 return;
            }
            else if (!newPassword.Any(char.IsLower))
            {
                MessageBox.Show("Password must include a  Lower letter!");
                return;
            }
            else if(!hasSymbols.IsMatch(newPassword))
            {
                MessageBox.Show("New password must contains symbol!");
                return;
            }
            else if (newPassword != conNewPassword)
            {
                MessageBox.Show("New password and confirm password does not match!");
                return;
            }
            else
            {
                MessageBox.Show("Please wait a moment!");
            }
            //
            //SQL QUERIES
            //
            try
            {
                // Execute query 1
                string query1 = "SELECT * FROM UserT WHERE userName=@username AND Password =@password";
                bool query1Result = ExecuteQuery(query1);

                if (query1Result)
                {
                    // Query 1 was true, so execute query 2
                    string query2 = "UPDATE  UserT SET Password='"+ conNewPassword+"' WHERE UserName='"+username+"' ";
                    ExecuteNonQuery(query2);

                    MessageBox.Show("New Password Updated successfully!");
                    //Login1 f1 = new Login1();
                   // f1.Show();
                    this.Close();                    
                    
                }
                else
                {
                    MessageBox.Show("Error occured during password Update.");//replace with suitable message
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during either query execution
                MessageBox.Show("EXCEPTION :An error occurred while executing the queries: " + ex.Message);
               
            }           

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
        }       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = this.checkBox1.Checked ? char.MinValue : '*';           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNewPassword.PasswordChar = this.checkBox2.Checked ? char.MinValue : '*';
            this.txtConfirmPassword.PasswordChar = this.checkBox2.Checked ? char.MinValue : '*';
        }
    }
}
