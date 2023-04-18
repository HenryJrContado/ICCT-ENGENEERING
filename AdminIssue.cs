using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICCT_ENGENEERING
{
    public partial class AdminIssue : UserControl
    {
        public AdminIssue()
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
                TextBox1.BorderColor = Color.Red;
                MessageBox.Show("INPUT STUDENT NUMBER");
                return;
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
            }

            if (TextBox2.Text.Length == 0)
            {
                TextBox2.BorderColor = Color.Red;
                MessageBox.Show("INPUT NAME");
                return;
            }
            else
            {
                TextBox2.BorderColor = Color.Green;
            }
             if (TextBox3.Text.Length == 0)
            {
                TextBox3.BorderColor = Color.Red;
                MessageBox.Show("INPUT BOOKS NAME");
                return;
            }
             else
            {
                TextBox3.BorderColor = Color.Green;
            }           
             if (TextBox4.Text.Length == 0)
            {
                TextBox4.BorderColor = Color.Red;
                MessageBox.Show("INPUT FINE");
                return;
            }
            else
            {
                TextBox4.BorderColor = Color.Green;
            }
            if (Box1.Text.Length == 0)
            {
                Box1.BorderColor = Color.Red;
                MessageBox.Show("INPUT STATUS");
                return;
            }         
            else
            {
                Box1.BorderColor = Color.Red;

                con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("insert into BooksIssue (STUDENTID, NAMES, BOOKNAME, ISSUEDATE, RETURNDATE, FINE, STATUS) values ( @id ,  @name, @bookname, @dateissue, @returndate, @fine, @status)", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@bookname", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@dateissue", this.DateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@returndate", this.DateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@fine", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Status", Box1.Text);
                    
                
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ADDING SUCCESSFULLY");

                loadData();
                Reset();
                con.Close();

                
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            loadData();

           
        }

        private void loadData()
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            string query = "SELECT  STUDENTID, NAMES, BOOKNAME, ISSUEDATE, RETURNDATE, FINE, STATUS FROM BooksIssue";
            ad = new SqlDataAdapter(query, con);
            dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgv1.DataSource = dt;
            }
            TextBox5.BorderColor = Color.Black;
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
            TextBox1.BorderColor= Color.Black;
            TextBox2.BorderColor = Color.Black;
            TextBox3.BorderColor = Color.Black;
            TextBox4.BorderColor = Color.Black;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TextBox5.Clear();
            TextBox5.BorderColor = Color.Black;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text.Length == 0)
            {
                TextBox5.BorderColor = Color.Red;
                MessageBox.Show("ENTER ID NUMBER");
            }
            else
            {
                TextBox5.BorderColor = Color.Green;
                string ID;
                ID = TextBox5.Text;
                con.Close();
                cmd = new SqlCommand("select * from BooksIssue where STUDENTID = '" + ID + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {
                    con.Close();
                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select  STUDENTID, NAMES, BOOKNAME, ISSUEDATE, RETURNDATE, FINE, STATUS from BooksIssue  where STUDENTID = @id", con);
                    cmd.Parameters.AddWithValue("@id ", TextBox5.Text);
                    ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    dgv1.DataSource = dt;

                }
                else
                {
                    TextBox5.BorderColor = Color.Red;
                    MessageBox.Show("User Not Exist");
                }

                con.Close();


            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (TextBox5.Text.Length == 0)
            {
                TextBox5.BorderColor = Color.Red;
                MessageBox.Show("INPUT STUDENT ID");
            }
            else
            {
                TextBox5.BorderColor = Color.Red;

                string ID;
                ID = TextBox5.Text;
                cmd = new SqlCommand("select * from Student where StudentID = '" + ID + "'", con);

                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == false)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Delete BooksIssue where STUDENTID = @id", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox5.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted SuccessFully");

                    // Code for refresh

                    loadData();

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
             if (TextBox5.Text.Length == 0)
            {
                TextBox5.BorderColor = Color.Red;
                MessageBox.Show("INPUT STUDENT ID");
                return;
            }
            else
            {
                TextBox5.BorderColor = Color.Green;
            }
            if (TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
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
            else if (Box1.Text.Length == 0)
            {
                MessageBox.Show("INPUT ROLE");
            }

            else
            {
                string ID;
                ID = TextBox5.Text;
                cmd = new SqlCommand("select * from BooksIssue where STUDENTID = '" + ID + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Update BooksIssue set STUDENTID = @studedentid, NAMES = @name, BOOKNAME = @bookname, ISSUEDATE = @dateissue, RETURNDATE = @returndate, FINE = @fine, STATUS = @status WHERE STUDENTID = @Id ", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@studedentid", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@bookname", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@dateissue", DateTimePicker1.MaxDate);
                    cmd.Parameters.AddWithValue("@returndate", DateTimePicker2.MaxDate);
                    cmd.Parameters.AddWithValue("@fine", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Status", Box1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("UPDATED SUCCESSFULLY");

                    // LOAD DATA
                    loadData();
                    Reset();

                }
                else
                {
                    TextBox5.BorderColor = Color.Red;
                    MessageBox.Show("STUDENT ID NOT EXIST");
                }

                con.Close();


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
            guna2Button7.FillColor = Color.Blue;
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
            guna2Button3.FillColor = Color.Blue;
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
