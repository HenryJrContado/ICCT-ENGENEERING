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
    public partial class AdminDash1 : UserControl
    {
        public AdminDash1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(FILENAME) from Docs", con);
            var count = cmd.ExecuteScalar();
            label4.Text = count.ToString();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(STUDENTID) from Student", con);
            var count = cmd.ExecuteScalar();
            label6.Text = count.ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LIBRARYDATABASE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(BOOKNAME) from Books", con);
            var count = cmd.ExecuteScalar();
            label5.Text = count.ToString();
        }
    }
}
