using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using static Guna.UI2.Native.WinApi;
using System.Security.Policy;

namespace ICCT_ENGENEERING
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;             
  

        private void guna2Button4_Click_2(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AdminStudent st = new AdminStudent();
            st.Show();
            panel2.Controls.Add(st);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AdminBooks books = new AdminBooks();
            books.Show();
            panel2.Controls.Add(books);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AdminDoc doc = new AdminDoc();
            doc.Show();
            panel2.Controls.Add(doc);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AdminDash dash = new AdminDash();
            dash.Show();
            panel2.Controls.Add(dash);
        }
    }
}
