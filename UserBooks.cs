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
    public partial class UserBooks : UserControl
    {
        public UserBooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter ad;
        DataTable dt;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
                MessageBox.Show(" ENTER BOOKS NAME");
            }
            else
            {
                TextBox1.BorderColor = Color.Green;

                string ID;
                ID = TextBox1.Text;
                con.Close();
                cmd = new SqlCommand("select * from Books where BOOKNAME = '" + ID + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {
                    con.Close();
                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select BOOKNAME, AUTHOR, STATUS from Books  where BOOKNAME = @book", con);
                    cmd.Parameters.AddWithValue("@book ", TextBox1.Text);
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
        } // SEARCH FORM

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox1.BorderColor = Color.Black;
        } //RESET FORM

        private void guna2Button7_Click(object sender, EventArgs e)
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
            
        }  //REFRESH CODE

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
    }
    
}
