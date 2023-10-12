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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin A = new FormLogin();
            A.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin A = new FormLogin();
            A.Show();
        }

        private void lblStaffManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStaffManagement A = new FormStaffManagement();
            A.Show();
        }

        private void lblItemCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormItem A = new FormItem();
            A.Show();
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormOrder A = new FormOrder();
            A.Show();
        }

        private void lblInquiry_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormInquiry A = new FormInquiry();
            A.Show();
        }

        private void lblMonthlyReport_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormMonthlyReport A = new FormMonthlyReport();
            A.Show();
        }
    }
}
