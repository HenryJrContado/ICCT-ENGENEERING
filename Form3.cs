using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ICCT_ENGENEERING
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;    // SqlCommand Connection
        SqlDataReader dr;  // SqlDataReader Connection
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Close();
            
        }   // Code for "x"
        private void SigninButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }       // Code for "BACK"       
        private void ResetButton3_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            TextBox6.Clear();
        }        // RESET BUTTON HERE
        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                TextBox6.UseSystemPasswordChar = true;

            }
            else
            {
                TextBox6.UseSystemPasswordChar = false;
            }
        }      // connection to CHECKBOX SHOW PASSWORD Code
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                TextBox6.UseSystemPasswordChar = true;

            }
            else
            {
                TextBox6.UseSystemPasswordChar = false;
            }
        }  // connection to CHECKBOX SHOW PASSWORD Code
        private void RegisterButton1_Click(object sender, EventArgs e)
        {
            string mail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            // validation for checking if user is already exist in database
            if (TextBox1.Text == " ")
            {

            }
            else
            {   
                string stNumber;
                stNumber = TextBox1.Text;
                cmd = new SqlCommand("select * from Student where StudentID = '" + stNumber + "'", cnn);
                cnn.Close();
                cnn.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    MessageBox.Show("Student ID Its already Taken");
                    cnn.Close();
                    return;
                }
            }  //last part of  validation for checking if user is already exist in database
            

            cmd = new SqlCommand("insert into Student values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "')", cnn);

            cmd.CommandType = CommandType.Text;
             if (!Regex.IsMatch(TextBox4.Text, mail))
            {

                MessageBox.Show("Invalid Email Address");
            }            
           else if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Input Student Number");
            }
            else if (TextBox1.Text.Length < 8)
            {
                MessageBox.Show("Student Number MAximum of 8");
            }
            else if (TextBox2.Text.Length == 0)

            {
                MessageBox.Show("Input First Name");
            }
            else if (TextBox3.Text.Length == 0)

            {
                MessageBox.Show("Input Last Name");
            }
            else if (TextBox4.Text.Length == 0 )
            {             
                MessageBox.Show("INPUT EMAIL");
            }
            else if (TextBox5.Text.Length == 0)

            {
                MessageBox.Show("Input Password");
            }
            else if (TextBox5.Text.Length < 4)
            {
                MessageBox.Show("Short password was Invalid");
            }
            else if (TextBox5.Text != TextBox6.Text)

            {
                MessageBox.Show("Not Matched Password");
            }
            else
            {
                MessageBox.Show("Successfully Registered");
                TextBox1.Clear();
                TextBox2.Clear();
                TextBox3.Clear();
                TextBox4.Clear();
                TextBox5.Clear();
                TextBox6.Clear();
                  cnn.Close();
                  cnn.Open();
                  cmd.ExecuteNonQuery();
                cnn.Close();
            }   // Code and validation and Inserting data to database

        }      // All code for log in Register Button
    }
}
