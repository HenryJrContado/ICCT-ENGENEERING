using System;
using System.Drawing;
using System.Windows.Forms;

namespace ICCT_ENGENEERING
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        AdminStudent st;
        AdminDoc doc;
        AdminDash dash;
        AdminBooks books;      
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();                     
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          
            panel2.Controls.Clear();
            st = new AdminStudent();
            st.Show();
            panel2.Controls.Add(st);
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
            panel2.Controls.Clear();
            doc = new AdminDoc();
            doc.Show();
            panel2.Controls.Add(doc);
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            dash = new AdminDash();
            dash.Show();
            panel2.Controls.Add(dash);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            books = new AdminBooks();
            books.Show();
            panel2.Controls.Add(books);
        }



        // MOUSE CLICK CODE FOR HOVER
        private void guna2Button2_MouseClick(object sender, MouseEventArgs e)
        {
            //

            guna2Button1.FillColor = Color.MidnightBlue;
            guna2Button3.FillColor = Color.MidnightBlue;
            guna2Button4.FillColor = Color.MidnightBlue;
            guna2Button5.FillColor = Color.MidnightBlue;


            //
            guna2Button2.FillColor = Color.Red;
        }

        private void guna2Button3_MouseClick(object sender, MouseEventArgs e)
        {
            //

            guna2Button1.FillColor = Color.MidnightBlue;
            guna2Button2.FillColor = Color.MidnightBlue;
            guna2Button4.FillColor = Color.MidnightBlue;
            guna2Button5.FillColor = Color.MidnightBlue;


            //
            guna2Button3.FillColor = Color.Red;
        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            //

            guna2Button2.FillColor = Color.MidnightBlue;
            guna2Button3.FillColor = Color.MidnightBlue;
            guna2Button4.FillColor = Color.MidnightBlue;
            guna2Button5.FillColor = Color.MidnightBlue;

            //

            guna2Button1.FillColor = Color.Red;
        }

        private void guna2Button4_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Button1.FillColor = Color.MidnightBlue;
            guna2Button2.FillColor = Color.MidnightBlue;
            guna2Button3.FillColor = Color.MidnightBlue;
            guna2Button5.FillColor = Color.MidnightBlue;


            //
            guna2Button4.FillColor = Color.Red;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
           AdminIssue booksue = new AdminIssue();
            booksue.Show();
            panel2.Controls.Add(booksue);
        }

        private void guna2Button5_MouseClick(object sender, MouseEventArgs e)
        {
            guna2Button1.FillColor = Color.MidnightBlue;
            guna2Button2.FillColor = Color.MidnightBlue;
            guna2Button3.FillColor = Color.MidnightBlue;
            guna2Button4.FillColor = Color.MidnightBlue;
            

            //
            guna2Button5.FillColor = Color.Red;

        }
    }
}
