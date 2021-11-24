using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using medical_management.BUS;
using medical_management.DTO;

namespace medical_management
{
    public partial class frmHTPPharmacy : Form
    {
        public bool isLogin = false;
        public string staffId;
        private Staff staff;
        public frmHTPPharmacy()
        {
            InitializeComponent();
        }

        private void frmHTPPharmacy_Load(object sender, EventArgs e)
        {
            showLoginForm();
            if (isLogin)
            {
                staff = StaffBUS.getStaffById(staffId);
                tssStaffName.Text = staff.Id + " - " + staff.Name;
                ttsDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void showLoginForm()
        {
            frmLogin f = new frmLogin();
            f.ShowDialog(this);
        }

        private void mItemReLogin_Click(object sender, EventArgs e)
        {
            // DEMO GIT & GITHUB
            // Change source from github website
            showLoginForm();

        }

        private void mItemThuoc_Click(object sender, EventArgs e)
        {
            frmThuoc f = new frmThuoc();
            f.MdiParent = this;
            f.Show();


        }

        private void mItemKH_Click(object sender, EventArgs e)
        {
            frmKhachhang f = new frmKhachhang();
            f.MdiParent = this;
            f.Show();
        }

        private void mItemNCC_Click(object sender, EventArgs e)
        {
            frmNhacungcap f = new frmNhacungcap();
            f.MdiParent = this;
            f.Show();
        }

        private void mItemNSX_Click(object sender, EventArgs e)
        {
            frmNhasanxuat f = new frmNhasanxuat();
            f.MdiParent = this;
            f.Show();
        }

        private void mItemNV_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            f.MdiParent = this;
            f.Show();
        }

        private void mItemInvoice_Click(object sender, EventArgs e)
        {
            frmDSHD f = new frmDSHD();
            f.MdiParent = this;
            f.Show();
        }

        private void frmHTPPharmacy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mItemPO_Click(object sender, EventArgs e)
        {
            frmDSPN f = new frmDSPN();
            f.MdiParent = this;
            f.Show();
        }

        private void mItemPOReport_Click(object sender, EventArgs e)
        {
          
            frmBCNhaphang f = new frmBCNhaphang();
            f.Show();


        }

        private void mItemInventoryReport_Click(object sender, EventArgs e)
        {
            rptTonkho rpt = new rptTonkho();
            string sql = " SELECT Mathuoc, Tenthuoc, Donvi, Soluong " + " FROM tbl_Item ";        
            rpt.SetDataSource(Database.Instance.excuteQuery(sql));
            rptTonkhoprv rp = new rptTonkhoprv(rpt);
            rp.Show();

        }

        private void mItemMedicalExpired_Click(object sender, EventArgs e)
        {
            rptThuochethan rpt = new rptThuochethan();
            string sql = " SELECT tbl_Consignment.Malo , tbl_Item.Mathuoc , tbl_Item.Tenthuoc , tbl_Consignment.Ngayhethan , tbl_Consignment.Soluong - tbl_Consignment.Daban AS Soluongcon , tbl_Consignment.Gianhap , ( tbl_Consignment.Soluong - tbl_Consignment.Daban ) * tbl_Consignment.Gianhap AS Giatri "
                       + " FROM tbl_Consignment INNER JOIN  tbl_Item ON tbl_Consignment.Mathuoc = tbl_Item.Mathuoc "
                       + " where DATEDIFF(DAY , GETDATE() , tbl_Consignment.Ngayhethan ) < 0 "
                       + " GROUP BY tbl_Consignment.Malo , tbl_Consignment.Gianhap , tbl_Consignment.Ngayhethan , tbl_Item.Mathuoc , tbl_Item.Tenthuoc , ( tbl_Consignment.Soluong - tbl_Consignment.Daban) ";
            rpt.SetDataSource(Database.Instance.excuteQuery(sql));
            rptThuochethanprv rp = new rptThuochethanprv(rpt);
            rp.Show();
        }

        private void mItemDT_Click(object sender, EventArgs e)
        {
            frmBCDT f = new frmBCDT();
            f.Show();

        }

        private void mItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
