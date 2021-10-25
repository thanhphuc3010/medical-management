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
    public partial class frmHTPPharmacy : Form
    {
        public frmHTPPharmacy()
        {
            InitializeComponent();
        }

        private void mItemReLogin_Click(object sender, EventArgs e)
        {
            // DEMO GIT & GITHUB
            // Change source from github website
        }

        private void mItemThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc f = new frmThuoc();
            f.Show();
           

        }

        private void mItemKH_Click(object sender, EventArgs e)
        {
            frmKhachhang f = new frmKhachhang();
            f.Show();
        }

        private void mItemNCC_Click(object sender, EventArgs e)
        {
            frmNhacungcap f = new frmNhacungcap();
            f.Show();
        }

        private void mItemNSX_Click(object sender, EventArgs e)
        {
            frmNhasanxuat f = new frmNhasanxuat();
            f.Show();
        }

        private void mItemNV_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            f.Show();
        }

        private void mItemInvoice_Click(object sender, EventArgs e)
        {
            frmPhieubanhang f = new frmPhieubanhang();
            f.MdiParent = this;
            f.Show();
        }
    }
}
