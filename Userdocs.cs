using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICCT_ENGENEERING
{
    public partial class Userdocs : UserControl
    {
        public Userdocs()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

       
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadData();
            if (TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
                MessageBox.Show("ENTER SUBJECT NAME");
                return;
                
            }
            else
            {
                TextBox1.BorderColor = Color.Green;

                string ID;
                ID = TextBox1.Text;
                con.Close();
                cmd = new SqlCommand("select * from Docs1 where FILENAME = '" + ID + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {
                    con.Close();
                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select  FILENAME, CHAPTER from Docs1  where FILENAME = @files", con);
                    cmd.Parameters.AddWithValue("@files ", TextBox1.Text);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgs.DataSource = dt;

                }
                else
                {
                    TextBox1.BorderColor = Color.Red;
                    MessageBox.Show("FILES NOT EXIST");                   
                }

                con.Close();
            }                   
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            string query = "SELECT FILENAME, CHAPTER  FROM Docs1";
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgs.DataSource = dt;
            }
        } //REFRESH DATA IN DATAGRADVIEW

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
            }

             if(TextBox2.Text.Length == 0)
            {
                TextBox2.BorderColor = Color.Red;
                MessageBox.Show("INPUT SUBJECT AND CHAPTER NUMBER");
                return;
            }
            else
            {
                TextBox2.BorderColor = Color.Green;
            }

            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            {
                string query = "SELECT DATA,FILENAME,CHAPTER FROM Docs1 WHERE FILENAME = @id and CHAPTER = @chapter";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                cmd.Parameters.AddWithValue("@chapter", TextBox2.Text);
                con.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    var name = reader["FILENAME"].ToString();
                    var data = (byte[])reader["data"];

                    var chap = reader["CHAPTER"].ToString();
                    var newFileName = name.Replace(chap, DateTime.Now.ToString("ddMMyyyyhhmmss")) + chap;
                    File.WriteAllBytes(newFileName, data);
                    System.Diagnostics.Process.Start(newFileName);

                    var selectedID = dgs.SelectedRows;

                    foreach (var row in selectedID)
                    {                       
                      TextBox2.Text = (string)((DataGridViewRow)row).Cells[0].Value;                       
                    }
                }
                else
                {
                    TextBox2.BorderColor = Color.Red;
                    MessageBox.Show("FILE Not Exist");
                }
            }
           
        }             
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox1.BorderColor = Color.Black; 
            TextBox2.BorderColor = Color.Black;
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Red;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            guna2Button1.FillColor = Color.Blue;
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
    }
}
