using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICCT_ENGENEERING
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Userdocs doc = new Userdocs();
            doc.Show();
            panel2.Controls.Add(doc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AdminDash dash = new AdminDash();
            dash.Show();
            panel2.Controls.Add(dash);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Button1.FillColor = Color.MidnightBlue;
            guna2Button3.FillColor = Color.MidnightBlue;
            //
            guna2Button2.FillColor = Color.Red;
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Button1.FillColor = Color.MidnightBlue;
            guna2Button2.FillColor = Color.MidnightBlue;
            //
            guna2Button3.FillColor = Color.Red;
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Button2.FillColor = Color.MidnightBlue;
            guna2Button3.FillColor = Color.MidnightBlue;
            //
            guna2Button1.FillColor = Color.Red;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UserBooks User = new UserBooks();
            User.Show();
            panel2.Controls.Add(User);
        }
    }

}
