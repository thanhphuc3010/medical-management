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
    
    public partial class frmBCDT : Form
    {  
        public frmBCDT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptDoanhthu rpt = new rptDoanhthu();
            string sql = " SELECT tbl_Item.Tenthuoc, tbl_Item.Donvi, tbl_Item.Dongia, SUM( tbl_InvoiceDetail.Soluong ) as Soluong, SUM(dbo.tbl_InvoiceDetail.Dongia * dbo.tbl_InvoiceDetail.Soluong) as Thanhtien "
                         + " FROM tbl_Item INNER JOIN tbl_InvoiceDetail ON tbl_Item.Mathuoc = tbl_InvoiceDetail.Mathuoc "
                         + " WHERE dbo.tbl_InvoiceDetail.Ngaytao BETWEEN '" + dtpFrom.Value +"'" + " AND '" + dtpTo.Value+"'"
                         + " GROUP BY tbl_Item.Tenthuoc, tbl_Item.Donvi, tbl_Item.Dongia ";
            rpt.SetDataSource(Database.Instance.excuteQuery(sql));
            rpt.DataDefinition.FormulaFields["Tungay"].Text = "'" + dtpFrom.Text + "'";
            rpt.DataDefinition.FormulaFields["Denngay"].Text = "'" + dtpTo.Text + "'";
            rptDoanhthuprv rp = new rptDoanhthuprv(rpt);
            rp.Show();
        }
    }
}
