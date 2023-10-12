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
    public partial class FormStaffManagement : Form
    {
        public FormStaffManagement()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlDataReader dataReader;
        String sql, Output = "";
        SqlConnection cnn;

        String conString = "Data Source=DESKTOP-IVAA98R;Initial Catalog='ManagementSystem Database';Integrated Security=True";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain A = new FormMain();
            A.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = "Insert into StfManagementTbl(EmpName,NIC,Address,Gender,ContactNO,DateOfBirth)values('" + txtName.Text + "','" + txtNIC.Text + "','" + txtAddress.Text + "','" + cmbGender.SelectedItem.ToString() + "',"+ txtContactNO.Text + ",'" + dtpDateOfBirth.Text + "')";
            cud(sql);
            DataTable dd = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from StfManagementTbl", cnn);
            sda.Fill(dd);
            dgvStfManagement.DataSource = dd;
        }
    }

       
    
}
