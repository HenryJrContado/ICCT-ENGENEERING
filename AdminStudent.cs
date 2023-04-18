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

namespace ICCT_ENGENEERING
{
    public partial class AdminStudent : UserControl
    {
        public AdminStudent()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter ad;
        DataTable dt;

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {               
             MessageBox.Show("INPUT STUDENT NUMBER");             
            }
            if (TextBox1.Text.Length < 8)
            {
                MessageBox.Show("ID MAXIMUM 8");
            }
            else if (TextBox2.Text.Length == 0)
            {
               
                MessageBox.Show("INPUT FIRSTNAME");
            }
            else if (TextBox3.Text.Length == 0)
            {
                
                MessageBox.Show("INPUT LASTNAME");
            }
            else if (TextBox4.Text.Length == 0)
            {
               
                MessageBox.Show("INPUT EMAIL");
            }
            else if (TextBox5.Text.Length == 0)
            {
                MessageBox.Show("INPUT PASSWORD");
            }
            else if (Box1.Text.Length == 0)
            {
                MessageBox.Show("INPUT ROLE");
            }

            else
            {
                string ID;
                ID = TextBox1.Text;
                cmd = new SqlCommand("select * from Student where StudentID = '" + ID + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("insert into Student values ( @Id ,  @full, @course, @email, @password, @Position)", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@full", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@course", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@email", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Password", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Position", Box1.Text);                  
                   
                   
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted SuccessFully");

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    string query = "SELECT STUDENTID,FULLNAME,COURSE, EMAILS, PASSWORD, POSITION FROM Student";
                    ad = new SqlDataAdapter(query, con);
                    dt = new DataTable();
                    ad.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgv.DataSource = dt;
                    }

                    Reset();

                }
                else
                {
                    MessageBox.Show("STUDENT ID IS ALREADY TAKEN");
                }

                con.Close();


            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();          
        }  //RESET BUTTON

        //REFRESH 
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            string query = "SELECT STUDENTID,FULLNAME,COURSE, EMAILS, PASSWORD, POSITION FROM Student";
            ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
            }
        }

        //DELETE CODE
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (TextBox7.Text.Length == 0)
            {
                MessageBox.Show("INPUT STUDENT ID");
            }
            else
            {
                string ID;
                ID = TextBox7.Text;
                cmd = new SqlCommand("select * from Student where StudentID = '" + ID + "'", con);

                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Delete Student where STUDENTID = @id", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox7.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted SuccessFully");

                    // Code for refresh

                   
                    string query = "SELECT STUDENTID,FULLNAME,COURSE, EMAILS, PASSWORD, POSITION FROM Student";
                    ad = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgv.DataSource = dt;
                    }

                    Reset();

                }
                else
                {
                    MessageBox.Show("USER NOT EXIST");
                }

                con.Close();


            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("INPUT STUDENT NUMBER");
            }
            else if (TextBox2.Text.Length == 0)
            {
                MessageBox.Show("INPUT FIRSTNAME");
            }
            else if (TextBox3.Text.Length == 0)
            {
                MessageBox.Show("INPUT LASTNAME");
            }
            else if (TextBox4.Text.Length == 0)
            {
                MessageBox.Show("INPUT EMAIL");
            }
            else if (TextBox5.Text.Length == 0)
            {
                MessageBox.Show("INPUT PASSWORD");
            }
            else if (Box1.Text.Length == 0)
            {
                MessageBox.Show("INPUT ROLE");
            }

            else
            {
                string ID;
                ID = TextBox1.Text;
                cmd = new SqlCommand("select * from Student where StudentID = '" + ID + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Update Student set FULLNAME = @full, COURSE = @course, EMAILS = @email, PASSWORD = @password,  POSITION = @Position WHERE STUDENTID = @Id ", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@full", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@course", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@email", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Position", Box1.Text);                         
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("UPDATED SUCCESSFULLY");

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    string query = "SELECT STUDENTID,FULLNAME,COURSE, EMAILS, PASSWORD, POSITION FROM Student";
                    ad = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgv.DataSource = dt;
                    }

                    Reset();

                }
                else
                {
                    MessageBox.Show("STUDENT ID NOT EXIST");
                }

                con.Close();


            }











        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TextBox7.Clear();
        }


        // SEARCH BUTTON
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (TextBox7.Text.Length == 0)
            {
                MessageBox.Show("ENTER ID NUMBER");
            }
            else
            {

                string ID;
                ID = TextBox1.Text;
                con.Close();
                cmd = new SqlCommand("select * from Student where StudentID = '" + ID + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == false)
                {
                    con.Close();
                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select STUDENTID,FULLNAME,COURSE, EMAILS, PASSWORD, POSITION from Student  where StudentID = @id", con);
                    cmd.Parameters.AddWithValue("@Id ", TextBox7.Text);
                    ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    dgv.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("User Not Exist");
                }

                con.Close();


            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
                TextBox4.Text = dlg.FileName;
            }
        }

        private void guna2Button4_MouseEnter(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.Red;
        }

        private void guna2Button4_MouseLeave(object sender, EventArgs e)
        {
            guna2Button4.FillColor = Color.Blue;
        }

        private void guna2Button8_MouseEnter(object sender, EventArgs e)
        {
            guna2Button8.FillColor = Color.Red;
        }

        private void guna2Button8_MouseLeave(object sender, EventArgs e)
        {
            guna2Button8.FillColor = Color.Blue;
        }

        private void guna2Button7_MouseEnter(object sender, EventArgs e)
        {
            guna2Button7.FillColor = Color.Red;
        }

        private void guna2Button7_MouseLeave(object sender, EventArgs e)
        {
            guna2Button8.FillColor = Color.Blue;
        }

        private void guna2Button6_MouseEnter(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.Red;
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {
            guna2Button6.FillColor = Color.Blue;
        }

        private void guna2Button5_MouseEnter(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.Red;
        }

        private void guna2Button5_MouseLeave(object sender, EventArgs e)
        {
            guna2Button5.FillColor = Color.Blue;
        }

        private void guna2Button3_MouseEnter(object sender, EventArgs e)
        {
            guna2Button3.FillColor = Color.Red;
        }

        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            guna2Button3.FillColor = Color.Blue;;
        }

        private void guna2Button9_MouseEnter(object sender, EventArgs e)
        {
            guna2Button9.FillColor = Color.Red;
        }

        private void guna2Button9_MouseLeave(object sender, EventArgs e)
        {
            guna2Button9.FillColor = Color.Blue;
        }
    }   
   
}
