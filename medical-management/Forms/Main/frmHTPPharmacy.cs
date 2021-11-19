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
            rptNhaphang rpt = new rptNhaphang();
            string sql = " SELECT tbl_Item.Nhomthuoc, tbl_Item.Mathuoc, tbl_Item.Tenthuoc, tbl_Item.Donvi, sum( tbl_Consignment.Soluong * tbl_Consignment.Gianhap) as Thanhtien " +
                " FROM tbl_Consignment INNER JOIN tbl_PurchaseOrder ON tbl_Consignment.Manhap = tbl_PurchaseOrder.Manhap INNER JOIN " +
                " tbl_Item ON tbl_Consignment.Mathuoc = tbl_Item.Mathuoc " +
                " WHERE MONTH(tbl_PurchaseOrder.Ngaynhap)= '11' and YEAR(tbl_PurchaseOrder.Ngaynhap)= '2021' " +
                " GROUP BY tbl_Item.Nhomthuoc, tbl_Item.Mathuoc, tbl_Item.Tenthuoc, tbl_Item.Donvi ";
           
            rpt.SetDataSource(Database.Instance.excuteQuery(sql));
            rptNhapthuocprv rp = new rptNhapthuocprv(rpt);
            rp.Show();


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
            rptDoanhthu rpt = new rptDoanhthu();
            string sql = " SELECT tbl_Item.Tenthuoc, tbl_Item.Donvi, tbl_Item.Dongia, SUM( tbl_InvoiceDetail.Soluong ) as Soluong, SUM( dbo.tbl_InvoiceDetail.Dongia * dbo.tbl_InvoiceDetail.Soluong ) as Thanhtien "
                        + " FROM tbl_Item INNER JOIN tbl_InvoiceDetail ON tbl_Item.Mathuoc = tbl_InvoiceDetail.Mathuoc "
                        + " GROUP BY tbl_Item.Tenthuoc, tbl_Item.Donvi, tbl_Item.Dongia ";
            rpt.SetDataSource(Database.Instance.excuteQuery(sql));
            rptDoanhthuprv rp = new rptDoanhthuprv(rpt);
            rp.Show();

        }
    }
}
