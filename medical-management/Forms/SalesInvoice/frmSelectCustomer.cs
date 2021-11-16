using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public partial class frmSelectCustomer : Form
    {
        public delegate void passCustomerId(string id, string name);
        public passCustomerId publisher;

        public frmSelectCustomer()
        {
            InitializeComponent();
        }

        private void frmSelectCustomer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void initializeUI()
        {
            foreach (DataGridViewRow row in dgvKhachhang.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(175, 238, 238);
                } else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
                }
            }
        }

        private void loadData()
        {
            string query = "SELECT * FROM tbl_Customer";
            DataTable data = Database.Instance.excuteQuery(query);
            dgvKhachhang.DataSource = data;
            initializeUI();
        }

        private void dgvKhachhang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvKhachhang.CurrentRow.Index;
            string customerId = dgvKhachhang.Rows[index].Cells["MaKH"].Value.ToString();
            string customerName = dgvKhachhang.Rows[index].Cells["TenKH"].Value.ToString();
            publisher?.Invoke(customerId, customerName);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachhang f = new frmKhachhang();
            f.ShowDialog();
        }
    }
}
