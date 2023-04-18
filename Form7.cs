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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(); 
            f6.ShowDialog();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form8 f8  = new Form8();
            f8.ShowDialog();
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(); 
            f4.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            string query = "SELECT ID, FILENAME, CHAPTER  FROM Docs1";
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgs.DataSource = dt;
            }
        }  //REFRESH DATA IN DATAGRADVIEW



        private void button1_Click(object sender, EventArgs e)

        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("INPUT ID NUMBER");
            }
            else
            {

                con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");

                {
                    string query = "SELECT DATA,FILENAME,CHAPTER FROM Docs1 WHERE FILENAME=@id and CHAPTER = @chapter";
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
                            TextBox1.Text = (string)((DataGridViewRow)row).Cells[0].Value;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Exist");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("INPUT SUBJECT");
                return;
            }
            else if (TextBox2.Text.Length == 0)
            {
                MessageBox.Show("INPUT CHAPTER");
                return;
            }


            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|* .pdf", ValidateNames = true })


            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to upload this Files?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string Filename = dlg.FileName;
                        UploadFile(Filename);
                    }
                }
            }
        }

        private void UploadFile(string filename)
        {
            con.Close();
            con.Open();
            FileStream Fstream = File.OpenRead(filename);
            byte[] contents = new byte[Fstream.Length];
            Fstream.Read(contents, 0, (int)Fstream.Length);
            Fstream.Close();

            cmd = new SqlCommand("insert into Docs1(FILENAME,CHAPTER, DATA) values ( @file , @chapter, @data )", con);

            cmd.Parameters.AddWithValue("@file", TextBox1.Text);
            cmd.Parameters.AddWithValue("@chapter", TextBox2.Text);
            cmd.Parameters.AddWithValue("@data", contents);

            cmd.ExecuteNonQuery();
            TextBox1.Clear();
            TextBox2.Clear();
            MessageBox.Show("UPLOADING DONE");
            LoadData();
        }
    }
}
