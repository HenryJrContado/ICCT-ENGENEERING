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
    public partial class AdminDoc : UserControl
    {
        public AdminDoc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AdminDoc_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();        
            TextBox1.BorderColor = Color.Black;
            TextBox2.BorderColor = Color.Black;
        } //RESET BUTTON

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            TextBox3.Clear();
            TextBox4.Clear();

        }   // SEARCH RESET BUTTUN
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
                MessageBox.Show("INPUT SUBJECT");
                return;
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
            }
             if (TextBox2.Text.Length == 0)
            {
                TextBox2.BorderColor = Color.Red;
                MessageBox.Show("INPUT CHAPTER");
                return;
            }
             else
            {
                TextBox2.BorderColor = Color.Green;
                //
                string chap;
                string ID;
                ID = TextBox1.Text;
                chap = TextBox2.Text;
                cmd = new SqlCommand("select * from Docs where FILENAME = '" + ID + "' AND CHAPTER = '" + chap + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    TextBox1.BorderColor = Color.Red;
                    TextBox2.BorderColor = Color.Red;
                    MessageBox.Show("ITS ALREADY EXIST");
                } 
                else
                {
                    using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|* .pdf", ValidateNames = true })

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
                    //
                   
             }                                            
        }     // UPLOAD BUTTON CODES
        public void UploadFile(string filename)
        {
            con.Close();
            con.Open();
            FileStream Fstream = File.OpenRead(filename);
            byte[] contents = new byte[Fstream.Length];
            Fstream.Read(contents, 0, (int)Fstream.Length);
            Fstream.Close();

            cmd = new SqlCommand("insert into Docs(FILENAME,CHAPTER, DATA) values ( @file , @chapter, @data )", con);

            cmd.Parameters.AddWithValue("@file", TextBox1.Text);
            cmd.Parameters.AddWithValue("@chapter", TextBox2.Text);
            cmd.Parameters.AddWithValue("@data", contents);

            cmd.ExecuteNonQuery();
            MessageBox.Show("UPLOADING DONE");
            LoadData();
        }   // UPLOADING PDF FILES TO DATABASE

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(TextBox3.Text.Length == 0)
            {             
                TextBox3.BorderColor = Color.Red;
            }
            else
            {
                TextBox3.BorderColor = Color.Green;
            }

             if (TextBox4.Text.Length == 0)
            {
                TextBox4.BorderColor = Color.Red;
                MessageBox.Show("INPUT SUBJECT AND CHAPTER");
            }
          else
          {
                TextBox4.BorderColor = Color.Green;
                con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
           
             {
                string query = "SELECT DATA,FILENAME,CHAPTER FROM Docs WHERE FILENAME=@id and CHAPTER = @chapter";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", TextBox3.Text);
                cmd.Parameters.AddWithValue("@chapter", TextBox4.Text);
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
                        TextBox3.Text = (string)((DataGridViewRow)row).Cells[0].Value;
                    }
                }
                else
                {
                    MessageBox.Show("Not Exist");
                }
             }                   
          }          
        }       
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            LoadData();
            TextBox3.BorderColor = Color.Black;
            TextBox4.BorderColor = Color.Black;
        }

        private void LoadData()
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            string query = "SELECT  FILENAME, CHAPTER  FROM Docs";
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgs.DataSource = dt;
            }
        }  //REFRESH DATA IN DATAGRADVIEW

        private void guna2Button4_Click(object sender, EventArgs e)
        {          
            if (TextBox3.Text.Length == 0)
            {
                TextBox3.BorderColor = Color.Red;
                MessageBox.Show("ENTER SUBJECT");
            }
            else
            {
                TextBox3.BorderColor = Color.Green;
                string ID;
                ID = TextBox3.Text;
                con.Close();
                cmd = new SqlCommand("select * from Docs where FILENAME = '" + ID + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {
                    con.Close();
                    con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
                    con.Open();
                    cmd = new SqlCommand("select  FILENAME, CHAPTER from Docs  where FILENAME = @files", con);
                    cmd.Parameters.AddWithValue("@files ", TextBox3.Text);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgs.DataSource = dt;

                }
                else
                {
                    TextBox3.BorderColor = Color.Red;
                    MessageBox.Show("FILES NOT EXIST");
                }

                con.Close();


            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0)
            {
                MessageBox.Show("INPUT STUDENT ID");
                TextBox3.BorderColor = Color.Red;
            }
            else
            {
                TextBox3.BorderColor = Color.Green;
            }
             if (TextBox4.Text.Length == 0)
            {
                TextBox4.BorderColor = Color.Red;
                MessageBox.Show("INPUT CHAPTER NUMBER");
                return;
            }
            else
            {
                TextBox4.BorderColor = Color.Green;
            }
            
            {
                string CHA;
                string ID;
                CHA = TextBox4.Text;
                ID = TextBox3.Text;
                cmd = new SqlCommand("select * from Docs where FILENAME = '" + ID + "' and CHAPTER = '" + CHA + "'", con);

                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.HasRows == true)
                {
                    con.Close();
                    con.Open();

                    cmd = new SqlCommand("Delete Docs where FILENAME = @id and CHAPTER = @chap", con);
                    cmd.Parameters.AddWithValue("@Id", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@chap", TextBox4.Text);

                    cmd.ExecuteNonQuery();
                    TextBox3.Clear();
                    TextBox4.Clear();
                    MessageBox.Show("DELETED DONE");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("USER NOT EXIST");
                    TextBox3.BorderColor = Color.Red;
                    TextBox4.BorderColor = Color.Red;
                }

                con.Close();


            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text.Length == 0 )
            {
                TextBox3.BorderColor = Color.Red;
                MessageBox.Show("INPUT SUBJECT");
                return;
            }
            else
            {
                TextBox3.BorderColor = Color.Green;
            }
            if (TextBox4.Text.Length == 0)
            {
                TextBox4.BorderColor = Color.Red;
                MessageBox.Show("INPUT CHAPTER");
                return;
            }
            else
            {
                TextBox4.BorderColor = Color.Green;
            }
            if (TextBox1.Text.Length == 0)
            {
                TextBox1.BorderColor = Color.Red;
                MessageBox.Show("INPUT NEW SUBJECT NAME");
                return;
            }
            else
            {
                TextBox1.BorderColor = Color.Green;
            }
            if (TextBox2.Text.Length == 0)
            {
                TextBox2.BorderColor = Color.Red;
                MessageBox.Show("INPUT NEW CHAPTER NAME");
                
                return;
            }
            else
            {
                TextBox2.BorderColor = Color.Green;
            }

            string chap;
            string ID;
                ID = TextBox3.Text;
                chap = TextBox4.Text;
                cmd = new SqlCommand("select * from Docs where FILENAME = '" + ID + "' AND CHAPTER = '" + chap + "'", con);
                con.Close();
                con.Open();
                dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {                  
                    using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "PDF Documents(*.pdf)|* .pdf", ValidateNames = true })
                    {
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            DialogResult dialog = MessageBox.Show("Are you sure you want to UPDATE this Files?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialog == DialogResult.Yes)
                            {
                                string Filename = dlg.FileName;

                                UpdateFile(Filename);
                            }
                        }
                    }
            }
                else
                {
                TextBox3.BorderColor = Color.Red;
                TextBox4.BorderColor = Color.Red;
                MessageBox.Show("CHECKE SUBJECT AND CHAPTER NAME!!");               
                   
            }                                
        }     // UPLOAD BUTTON CODES
        public void UpdateFile(string filename)
        {
            con.Close();
            con.Open();
            FileStream Fstream = File.OpenRead(filename);
            byte[] contents = new byte[Fstream.Length];
            Fstream.Read(contents, 0, (int)Fstream.Length);
            Fstream.Close();

            cmd = new SqlCommand("Update Docs set FILENAME = @name, CHAPTER = @chapter, DATA = @data where FILENAME = @file AND CHAPTER = @chapters", con);
            cmd.Parameters.AddWithValue("@file", TextBox3.Text);
            cmd.Parameters.AddWithValue("@chapters", TextBox4.Text);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@chapter", TextBox2.Text);
            cmd.Parameters.AddWithValue("@data", contents);

            cmd.ExecuteNonQuery();
            TextBox1.Clear();
            TextBox2.Clear();
            MessageBox.Show("UPDATING DONE");
            LoadData();
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
