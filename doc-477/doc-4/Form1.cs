using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace doc_4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {// Get username and password from textboxes
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation 
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty!");
                
            }
            else if(password.Length < 8 || password.Length > 12)
            {
                MessageBox.Show($"Password must be at least {8} characters long.", "Short Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                MessageBox.Show("Enterd  sucess!");
            }
            //-----------------------------------------//
            // Connection String
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ipmah\Documents\NSBM\3 y NSBM Y1S3\ASSIGNMENT D\code\doc-4\doc-4\Database1.mdf"";Integrated Security=True");
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
                MessageBox.Show("Successfully loged in");
                //after successful it will redirect  to next page .  
                Form2 f2 = new Form2();
                f2.Show();
                
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password and not databse");
            }



        }

        private void butClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void linklblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
 }

