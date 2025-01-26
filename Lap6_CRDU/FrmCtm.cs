using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lap6_CRDU
{
    public partial class FrmCtm : Form
    {
        public FrmCtm()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }

        private void FrmCtm_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = CustomerID;
            txtCompanyName.Text = CompanyName;
            txtPhone.Text = Phone;
            txtCompanyName.Focus();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertCustomer();
            }
            else if (Status == "Update")
            {
                UpdateCustomer();
            }
            this.Close();
        }

        private void InsertCustomer()
        {
            MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผืดพลาด");
                return;
            }
            string sql = "INSERT INTO Customers (CustomerID, CompanyName, Phone) VALUES (@CustomerID, @CompanyName, @Phone)";
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("โปรดกรอกรหัสลูกค้า", "เกิดข้อผิดพลาด");
                return;
            }

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            int n = cmd.ExecuteNonQuery();
        }

        private void UpdateCustomer()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Update Customers"
                        + " Set CompanyName = @CompanyName, Phone = @phone"
                        + " where CustomerID = @CustomerID";  
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
            cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
            int n = cmd.ExecuteNonQuery();
        }
    }
}
