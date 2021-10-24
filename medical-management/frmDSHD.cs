using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public partial class frmDSHD : Form
    {
        private DateTime fromDate = DateTime.Now;
        private DateTime toDate = DateTime.Now;
        public frmDSHD()
        {
            InitializeComponent();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            frmPhieubanhang f = new frmPhieubanhang();
            f.ShowDialog();
        }

        private void frmDSHD_Load(object sender, EventArgs e)
        {
            loadListInvoice();
            loadInvoiceSummary();
            loadInvoiceCount();
            loadTotal();
            loadPayment();
            loadReceivable();
        }

        private void loadListInvoice()
        {
            string query = "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                           "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                           "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV";

            DataTable data = Database.Instance.excuteQuery(query);

            dgvDSHD.DataSource = data;

            if (!dgvDSHD.Rows[0].IsNewRow)
            {
                loadInvoiceDetailById(dgvDSHD.Rows[0].Cells["MaHD"].Value.ToString());
            }
        }

        private void loadInvoiceSummary()
        {
            string query =
                "SELECT DISTINCT Trangthaihoadon, COUNT(Trangthaihoadon) AS Soluong " +
                "FROM dbo.tbl_Invoice " +
                "GROUP BY Trangthaihoadon";

            DataTable data = Database.Instance.excuteQuery(query);
            dgvInvoiceSummary.DataSource = data;
        }

        private void loadInvoiceCount()
        {
            string query = "SELECT COUNT(*) FROM dbo.tbl_Invoice";
            lblInvoiceCount.Text = Database.Instance.ExecuteScalar(query).ToString();
        }

        private void loadTotal()
        {
            string query = "SELECT SUM(Tongtien) FROM dbo.tbl_Invoice";
            decimal total = Convert.ToDecimal(Database.Instance.ExecuteScalar(query));

            CultureInfo culture = new CultureInfo("vi-VN");
            lblTotal.Text = total.ToString("c", culture);
        }

        private void loadPayment()
        {
            string query = "SELECT SUM(Dathanhtoan) FROM dbo.tbl_Invoice";
            decimal total = Convert.ToDecimal(Database.Instance.ExecuteScalar(query));

            CultureInfo culture = new CultureInfo("vi-VN");
            lblTotalPayment.Text = total.ToString("c", culture);
        }

        private void loadReceivable()
        {
            string query = "SELECT SUM(Tongtien - Dathanhtoan) FROM dbo.tbl_Invoice";
            decimal total = Convert.ToDecimal(Database.Instance.ExecuteScalar(query));

            CultureInfo culture = new CultureInfo("vi-VN");
            lblReceivable.Text = total.ToString("c", culture);
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string invoiceId = Convert.ToString(dgvDSHD.Rows[e.RowIndex].Cells[0].Value);

            loadInvoiceDetailById(invoiceId);
        }

        private void loadInvoiceDetailById(string invoiceId)
        {
            string query =
                "SELECT a.Mathuoc, b.Tenthuoc, b.Donvi, a.Soluong, a.Dongia, (a.Soluong * a.Dongia) AS Thanhtien " +
                "FROM dbo.tbl_InvoiceDetail a, dbo.tbl_Item b " +
                "WHERE a.Mathuoc = b.Mathuoc " +
                "AND MaHD = @MaHD ";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { invoiceId });

            dgvHoadonchitiet.DataSource = data;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            string query =
                "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                "AND NgayHD BETWEEN @FromDate AND @ToDate";

            DataTable data = Database.Instance.excuteQuery(query, new object[] { fromDate, toDate });

            dgvDSHD.DataSource = data;

            if (!dgvDSHD.Rows[0].IsNewRow)
            {
                loadInvoiceDetailById(dgvDSHD.Rows[0].Cells["MaHD"].Value.ToString());
            }
        }

        private void dgvInvoiceSummary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == isChecked.Index && e.RowIndex != -1)
            {
                if (Convert.ToBoolean(dgvInvoiceSummary.Rows[e.RowIndex].Cells[isChecked.Index].Value))
                {

                    Helper.showSuccessMessage(dgvInvoiceSummary.Rows[e.RowIndex].Cells["Trangthaihoadon"].Value.ToString());
                } else
                {
                    Helper.showSuccessMessage(dgvInvoiceSummary.Rows[e.RowIndex].Cells["Trangthaihoadon"].Value.ToString());
                }
            }
        }

        private void dgvInvoiceSummary_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == isChecked.Index && e.RowIndex != -1)
            {
                dgvInvoiceSummary.EndEdit();
            }
        }
    }
}
