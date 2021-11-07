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
    public partial class frmSelectSupplier : Form
    {
        public delegate void passSupplierId(string id, string name);
        public passSupplierId publisher;

        public frmSelectSupplier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void initializeUI()
        {
            foreach (DataGridViewRow row in dgvSupplier.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(175, 238, 238);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
                }
            }
        }
        private void loadData()
        {
            string query = "SELECT * FROM tbl_Supplier";
            DataTable data = Database.Instance.excuteQuery(query);
            dgvSupplier.DataSource = data;
            initializeUI();
        }

        //private void dgvSupplier_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int index = dgvSupplier.CurrentRow.Index;
        //    string supplierId = dgvSupplier.Rows[index].Cells["MaNCC"].Value.ToString();
        //    string supplierName = dgvSupplier.Rows[index].Cells["TenNCC"].Value.ToString();
        //    publisher?.Invoke(supplierId, supplierName);
        //    this.Close();
        //}

        private void dgvSupplier_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSupplier.CurrentRow.Index;
            string supplierId = dgvSupplier.Rows[index].Cells["MaNCC"].Value.ToString();
            string supplierName = dgvSupplier.Rows[index].Cells["TenNCC"].Value.ToString();
            publisher?.Invoke(supplierId, supplierName);
            this.Close();
        }
    }

}
