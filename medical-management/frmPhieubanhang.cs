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
    public partial class frmPhieubanhang : Form
    {
        string customerId;
        public frmPhieubanhang()
        {
            InitializeComponent();
        }

        private void frmPhieubanhang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DateTime today = DateTime.Now;
            txtNgayban.Text = today.ToString("dd/MM/yyyy");
            loadMedical();
        }

        private void loadMedical()
        {
            string query = "SELECT MaThuoc, TenThuoc FROM tbl_Item";
            Helper.FillCombo(query, cboMaThuoc, "MaThuoc", "TenThuoc");
        }

        private void bindCustomer(string id, string name)
        {
            lblKhachHang.Text = name;
            this.customerId = id;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            frmSelectCustomer f = new frmSelectCustomer();
            f.publisher = new frmSelectCustomer.passCustomerId(bindCustomer);
            f.ShowDialog();
        }
    }
}
