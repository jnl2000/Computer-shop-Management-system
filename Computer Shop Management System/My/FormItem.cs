using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Computer_Shop_Management_System.My
{
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlDataReader dataReader;
        String sql, Output = "";
        SqlConnection cnn;

        string conString = "Data Source=DESKTOP-IVAA98R;Initial Catalog='ManagementSystem Database';Integrated Security=True";

        public void cud(string sql)
        {

            cnn = new SqlConnection(conString);
            cnn.Open();
            //MessageBox.Show("Connection Open !");
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();

            cnn.Close();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin A = new FormLogin();
            A.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = "Insert into ItemTbl(CompanyName,ModelName,ItemName,ItemPrice)values('" + txtCompanyName.Text + "','" + txtModelName.Text + "','" + txtItemName.Text + "'," + txtItemPrice.Text + ")";
            cud(sql);
            DataTable dd = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from ItemTbl", cnn);
            sda.Fill(dd);
            dgvItem.DataSource = dd;
        }
    }
}
