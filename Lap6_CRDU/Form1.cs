using System.Data;
using Microsoft.Data.SqlClient;

namespace Lap6_CRDU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        static string CustomerID = string.Empty;
        string Companyname = string.Empty;
        string Phone = string.Empty;
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            Showdata();
        }
        private void Showdata()
        {
            string sql = "SELECT * FROM Customers";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCustomer.DataSource = ds.Tables[0];
        }

        private void dgvCustomer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustomerID = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            Companyname = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            Phone = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCtm f = new FrmCtm();
            f.Status = "insert";
            f.ShowDialog();
            Showdata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerID))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            FrmCtm f = new FrmCtm();
            f.Status = "Update";
            f.CustomerID = CustomerID;
            f.CompanyName = Companyname;
            f.Phone = Phone;
            f.ShowDialog();
            Showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "รหัสลูกค้า :" + CustomerID.ToString() + Environment.NewLine;
            msg += "ชื่อบริษัทที่เป็นลูกค้า :" + CompanyName + Environment.NewLine;
            msg += "โทร :" + Phone;
            if (MessageBox.Show(msg, "คุณต้องการลบข้อมูลใช่หรือไม่") == DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(CustomerID))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผืดพลาด");
                return;
            }
            string sql = "Delete from Customers"
                + " Where CustomerID = @CustomerID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Showdata();
                    Clearfrom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void Clearfrom()
        {

        }

        private void dgvCustomer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.PerformClick();
        }
    }
}
