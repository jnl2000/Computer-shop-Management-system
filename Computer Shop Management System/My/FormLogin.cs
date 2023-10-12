using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Management_System.My
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void EmptyBox()
        {
            txtUsername.Clear();
            txtPassword.Clear(); 
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if (picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }

        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide .Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPassword.Text;

            //manager & admin can allow all sections.
            //Staff registration & inquiry manage also done by admin
            if (username == "admin@Pluscomputers" && pass == "admin")
            {
                this.Hide();
                FormMain A = new FormMain();
                A.Show();
            }

            else if (username == "manager@Pluscomputers" && pass == "manager")
            {
                this.Hide();
                FormMain A = new FormMain();
                A.Show();
            }



            //Cashier is manage orders
                    else if (username == "cashier@Pluscomputers" && pass == "cashier")
            {
                this.Hide();
                FormOrder A = new FormOrder();
                A.Show();
            }

            //salesmens is manage category and items
            else if (username == "salesmen@Pluscomputers" && pass == "salesmen")
            {
                this.Hide();
                FormItem A = new FormItem 
                    ();
                A.Show();
            }

            //manager is generate monthly report
            else if (username == "manager@Pluscomputers" && pass == "manager")
            {
                this.Hide();
                FormMonthlyReport A = new FormMonthlyReport();
                A.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct Username and Password");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
