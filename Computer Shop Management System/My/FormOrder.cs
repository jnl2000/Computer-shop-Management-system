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
    public partial class FormOrder : Form
    {
        public FormOrder()
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sql = "Insert into OrderTable(CusName,CusAddress,Contact,Gender,Email,CompanyName,ModlName)values('" + txtcusName.Text + "','" + txtCusAddress.Text + "','" + txtContactNo.Text + "'," + cmbGender.SelectedItem.ToString() + "','" + txtEmail.Text + "','" + txtComName.Text + "','" + txtModelName.Text + "')";
            cud(sql);
            DataTable dd = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from OrderTable", cnn);
            sda.Fill(dd);
            dgvOrder.DataSource = dd;
        }
    }
}
