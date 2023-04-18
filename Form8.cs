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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_MouseHover(object sender, EventArgs e)
        {

        }
        private void guna2Button4_MouseEnter(object sender, EventArgs e)
        {
        //    guna2Button4.FillColor= Color.Red;
          //  guna2Button4.ForeColor = Color.White;
        }

        private void guna2Button4_MouseLeave(object sender, EventArgs e)
        {
         //   guna2Button4.FillColor = Color.White;
         //   guna2Button4.ForeColor = Color.Black;
        }

        private void guna2Button4_MouseHover_1(object sender, EventArgs e)
        {
         //   guna2Button4.FillColor = Color.Red;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          //  guna2Button4.FillColor = Color.Red;
        }

        private void guna2Button4_MouseCaptureChanged(object sender, EventArgs e)
        {
         //   guna2Button4.FillColor = Color.Red;
        }

        private void guna2Button4_MouseClick(object sender, MouseEventArgs e)
        {
            //
          
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            //
           
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            //
            //guna2Button4.FillColor = Color.MidnightBlue;
            //guna2Button1.FillColor = Color.MidnightBlue;

            ////
            //guna2Button3.FillColor = Color.Red;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            // con.Open();
            //SqlCommand cmd = new SqlCommand("select count(ID) from Docs1", con);
            //var count = cmd.ExecuteScalar();
            //label1.Text = count.ToString();
            //SqlDataAdapter da = new SqlDataAdapter();          
            //DataTable dt = new DataTable();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(ID) from Docs1", con);
            var count = cmd.ExecuteScalar();
            label2.Text = count.ToString();
        }
    }
}
