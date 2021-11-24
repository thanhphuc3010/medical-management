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
    public partial class frmBCNhaphang : Form
    {
        public frmBCNhaphang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptNhaphang rpt = new rptNhaphang();
            string sql = " SELECT tbl_Item.Nhomthuoc, tbl_Item.Mathuoc, tbl_Item.Tenthuoc, tbl_Item.Donvi, sum( tbl_Consignment.Soluong * tbl_Consignment.Gianhap) as Thanhtien " 
                + " FROM tbl_Consignment INNER JOIN tbl_PurchaseOrder ON tbl_Consignment.Manhap = tbl_PurchaseOrder.Manhap INNER JOIN " 
                + " tbl_Item ON tbl_Consignment.Mathuoc = tbl_Item.Mathuoc " 
                + "  WHERE dbo.tbl_PurchaseOrder.Ngaynhap BETWEEN '" + dtpFrom.Value + "'" + " AND '" + dtpTo.Value + "'" 
                + " GROUP BY tbl_Item.Nhomthuoc, tbl_Item.Mathuoc, tbl_Item.Tenthuoc, tbl_Item.Donvi ";
            rpt.SetDataSource(Database.Instance.excuteQuery(sql));
            rptNhapthuocprv rp = new rptNhapthuocprv(rpt);
            rp.Show();
        }
    }
}
