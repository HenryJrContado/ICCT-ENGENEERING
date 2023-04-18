using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ICCT_ENGENEERING
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;   // SqlCommand Connection
        SqlDataReader dr;  // SqlDataReader Connection
        DataTable dt;     //Datatable Connection
        SqlDataAdapter sda;   //SqlDataAdapter connection

        public static string Position;  // Connection Position logic Admin and User
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Close();
            Form3 f3 = new Form3();
            f3.Close();

        }  // Code for "x"
        private void SigninButton2_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }   // Code foR "BACK"                                                                            
        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                TextBox2.UseSystemPasswordChar = true;

            }
            else
            {
                TextBox2.UseSystemPasswordChar = false;
            }
        }  // Connection code for CheckBox Code to show password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                TextBox2.UseSystemPasswordChar = true;

            }
            else
            {
                TextBox2.UseSystemPasswordChar = false;
            }
        }   // last code of CheckBox Show password code
        private void guna2Button1_Click(object sender, EventArgs e)
        {      
            
            if (TextBox1.Text.Length == 0 )
            {
                TextBox1.BorderColor = Color.Red;
                
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
            }
            if (TextBox2.Text.Length == 0)
            {
                TextBox2.BorderColor = Color.Red;
                return;
            }
            else
            {
                TextBox2.BorderColor = Color.Green;
            }

            try
            {
                    // Logic for user and Admin                
                sda = new SqlDataAdapter("select Position From Student where  STUDENTID ='" + TextBox1.Text + "' and PASSWORD = '" + TextBox2.Text + "'", cnn);
                dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1 )
                {
                   Position = dt.Rows[0][0].ToString();

                    if (Position == "Admin")
                    {
                        Form5 f5 = new Form5();
                        f5.ShowDialog();
                        this.Close();
                    } else if (Position == "User")
                    {
                        Form4 f4 = new Form4();
                        f4.ShowDialog();
                        this.Close();
                    }                  
                }
                else
                {
                    MessageBox.Show("User not Exist");
                }
            }
            catch (Exception ex)
            {
               
            }
        }     // VALIDATION FOR USER AND ADMIN LOG IN

        private void SigninButton2_MouseEnter(object sender, EventArgs e)
        {
            Button2.FillColor = Color.Red;
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
           Button2.FillColor = Color.Blue;
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            Button1.FillColor = Color.Red;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            Button1.FillColor = Color.Blue;
        }
    }

}
