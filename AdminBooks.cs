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
    public partial class AdminBooks : UserControl
    {
        public AdminBooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter ad;
        DataTable dt;
        private void Box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("INPUT BOOKS NAME");
                TextBox1.BorderColor = Color.Red;
                return;
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
                
            }
             if (TextBox2.Text.Length == 0)
            {

                MessageBox.Show("INPUT AUTHOR");
                TextBox2.BorderColor = Color.Red;
                return;
            }
            else
            {
                TextBox2.BorderColor = Color.Green;
                
            }
             if (Box1.Text.Length == 0)
            {
                MessageBox.Show("INPUT STATUS");
                Box1.BorderColor = Color.Red;              
            }

            else
            {
                string chap;
                string ID;
                chap = TextBox2.Text;
                ID = TextBox1.Text;
                cmd = new SqlCommand("select * from Books where BOOKNAME = '" + ID + "' and AUTHOR = '" + chap + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("insert into Books (BOOKNAME, AUTHOR, STATUS) values ( @book ,  @author, @status)", con);
                   
                    cmd.Parameters.AddWithValue("@book", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@author", TextBox2.Text);                  
                    cmd.Parameters.AddWithValue("@status", Box1.Text);


                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("ADD SUCCESSFULLY");
                    LoadData();
                    Reset();
                }
                else
                {
                    MessageBox.Show("BOOKS IS ALREADY EXIST");
                }

                con.Close();


            }
        }

        private void Reset()
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox1.BorderColor = Color.Black;
            TextBox2.BorderColor = Color.Black;            
            Box1.BorderColor = Color.Black;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            LoadData();
            Reset();
           
        }  //REFRESH CODE

        private void LoadData()
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            string query = "SELECT  BOOKNAME,AUTHOR,STATUS FROM Books";
            ad = new SqlDataAdapter(query, con);
            dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgv1.DataSource = dt;
            }

            TextBox1.BorderColor = Color.Black;
            TextBox2.BorderColor = Color.Black;
            TextBox3.BorderColor = Color.Black;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TextBox3.BorderColor = Color.Black;
            TextBox3.Clear();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0)
            {
                TextBox3.BorderColor = Color.Red;
                MessageBox.Show(" ENTER BOOKS NAME");
            }
            else
            {
                TextBox3.BorderColor = Color.Red;
                string ID;
                ID = TextBox1.Text;
                con.Close();
                cmd = new SqlCommand("select * from Books where BOOKNAME = '" + ID + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == false)
                {
                    con.Close();
                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select  BOOKNAME, AUTHOR, STATUS from Books  where BOOKNAME = @book", con);
                    cmd.Parameters.AddWithValue("@book ", TextBox3.Text);
                    ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);

                    dgv1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("BOOKS NOT EXIST");
                }

                con.Close();


            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0)
            {
                TextBox3.BorderColor = Color.Red;
                MessageBox.Show("INPUT BOOKS NAME");
            }
            else
            {
                TextBox3.BorderColor = Color.Green;

                string ID;
                ID = TextBox3.Text;
                cmd = new SqlCommand("select * from Books where BOOKNAME = '" + ID + "'", con);

                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Delete Books where BOOKNAME = @book", con);
                    cmd.Parameters.AddWithValue("@book", TextBox3.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("DELETED SUCCESSFULLY");

                    // Code for refresh
                   LoadData();

                    Reset();

                }
                else
                {
                    TextBox3.BorderColor = Color.Red;
                    MessageBox.Show("USER NOT EXIST");
                }

                con.Close();


            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if(TextBox3.Text.Length == 0)
            {
                TextBox3.BorderColor = Color.Red;
                MessageBox.Show("INPUT BOOK NAME");
                return;
            }
            else
            {
                TextBox3.BorderColor = Color.Green;
            }

            if (TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
                MessageBox.Show("INPUT BOOKS NAME");             
                return;
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
            }
                    
             if (TextBox2.Text.Length == 0)
            {
                TextBox2.BorderColor = Color.Red;
                MessageBox.Show("INPUT AUTHOR");
                
                return;
            }
            else
            {
                TextBox2.BorderColor = Color.Green;
            }
             if (Box1.Text.Length == 0)
            {
                MessageBox.Show("INPUT STATUS");
            }

            else
            {
                string ID;
                ID = TextBox3.Text;
                cmd = new SqlCommand("select * from Books where BOOKNAME = '" + ID + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("Update Books set BOOKNAME = @book, AUTHOR = @author, STATUS = @status WHERE BOOKNAME = @Id ", con);
                    cmd.Parameters.AddWithValue("@id", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@book", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@author", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@status", Box1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("UPDATED SUCCESSFULLY");
                   LoadData();
                    Reset();
                }
                else
                {
                    TextBox3.BorderColor = Color.Red;
                    MessageBox.Show("BOOKS NOT EXIST");
                }

                con.Close();


            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row  = this.dgv1.Rows[e.RowIndex];

                TextBox1.Text = row.Cells["BOOKNAME"].Value.ToString();
                TextBox2.Text = row.Cells["AUTHOR"].Value.ToString();
                Box1.Text = row.Cells["STATUS"].Value.ToString();
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
    }
    
}
