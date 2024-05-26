using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOC__07NEW
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            // Get username and password from textboxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty!");
                lblAlert.Show();
                return;

            }
            else if (password.Length < 8 || password.Length > 12)
            {
                MessageBox.Show($"Password must be at least {8} characters long.", "Short Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Please wait a moment!","Login In ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //
            //Connection String
            // 
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ipmah\Documents\NSBM\3 y NSBM Y1S3\ASSIGNMENT D\code\DOC--07NEW\DOC--07NEW\Database1.mdf"";Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from UserT where userName=@UserName and password =@Password", con);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Connection open here   
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully loged in", "Login In ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                   
                    Login2 f2 = new Login2();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password !");
                }
            }catch (Exception ex) { MessageBox.Show("Error Exceptional handeling:"+ex.Message); }





        }

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            Login2 login2 = new Login2();   
            login2.ShowDialog();
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = this.checkBox2.Checked ? char.MinValue : '*';
            ;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }
    }
}
