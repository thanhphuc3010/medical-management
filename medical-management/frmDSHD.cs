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
            dtpFromDate.Value = getEarliestDate();
            dtpToDate.Value = getLatestDate();
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

        private DateTime getEarliestDate()
        {
            string query = "SELECT TOP 1 NgayHD FROM dbo.tbl_Invoice ORDER BY NgayHD ASC";
            return Convert.ToDateTime(Database.Instance.ExecuteScalar(query));
        }
        private DateTime getLatestDate()
        {
            string query = "SELECT TOP 1 NgayHD FROM dbo.tbl_Invoice ORDER BY NgayHD DESC";
            return Convert.ToDateTime(Database.Instance.ExecuteScalar(query));
        }


        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string invoiceId = Convert.ToString(dgvDSHD.Rows[e.RowIndex].Cells[0].Value);

                loadInvoiceDetailById(invoiceId);
            }
            else return;
            
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

            List<string> statusFilter = getListStatusFilter();

            string querySummary =
                "SELECT DISTINCT Trangthaihoadon, COUNT(Trangthaihoadon) AS Soluong " +
                "FROM dbo.tbl_Invoice " +
                "WHERE NgayHD BETWEEN @FromDate AND @ToDate " +
                "GROUP BY Trangthaihoadon";

            DataTable dataSummary = Database.Instance.excuteQuery(querySummary, new object[] { fromDate, toDate });
            dgvInvoiceSummary.DataSource = dataSummary;

            string query =
                    "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                    "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                    "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                    "AND NgayHD BETWEEN @FromDate AND @ToDate " +
                    "AND Trangthaihoadon IN (";

            if (statusFilter.Count == 0)
            {
                query = "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                    "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                    "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                    "AND NgayHD BETWEEN @FromDate AND @ToDate ";
            }
            else
            {
                var lastItem = statusFilter.Last();

                foreach (string status in statusFilter)
                {
                    if (!status.Equals(lastItem))
                    {
                        query += "N'" + status + "', ";
                    }
                    else
                    {
                        query += "N'" + status + "')";
                    }

                }
            }

            DataTable data = Database.Instance.excuteQuery(query, new object[] { fromDate, toDate });

            dgvDSHD.DataSource = data;

            if (!dgvDSHD.Rows[0].IsNewRow)
            {
                loadInvoiceDetailById(dgvDSHD.Rows[0].Cells["MaHD"].Value.ToString());
            }
        }

        private List<string> getListStatusFilter()
        {
            List<string> statusFilter = new List<string>();

            foreach (DataGridViewRow row in dgvInvoiceSummary.Rows)
            {
                if (Convert.ToBoolean(row.Cells[isChecked.Index].Value))
                {
                    statusFilter.Add(row.Cells["Trangthaihoadon"].Value.ToString());
                }
                else
                {
                    statusFilter.Remove(row.Cells["Trangthaihoadon"].Value.ToString());
                }
            }
            return statusFilter;
        }

        private void dgvInvoiceSummary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == isChecked.Index && e.RowIndex != -1)
            {

                List<string> statusFilter = getListStatusFilter();

                DateTime fromDate = dtpFromDate.Value;
                DateTime toDate = dtpToDate.Value;

                string query = 
                        "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                        "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                        "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                        "AND NgayHD BETWEEN @FromDate AND @ToDate " +
                        "AND Trangthaihoadon IN (";

                if (statusFilter.Count == 0)
                {
                    loadListInvoice();
                    return;
                }
                var lastItem = statusFilter.Last();

                foreach (string status in statusFilter)
                {
                    if(!status.Equals(lastItem))
                    {
                        query += "N'" + status + "', ";
                    } else
                    {
                        query += "N'" + status + "')";
                    }
                    
                }

                DataTable data = Database.Instance.excuteQuery(query, new object[] { fromDate, toDate });

                dgvDSHD.DataSource = data;

                if (dgvDSHD.Rows.Count > 0 && data.Rows.Count != 0)
                {
                    loadInvoiceDetailById(dgvDSHD.Rows[0].Cells["MaHD"].Value.ToString());
                } else
                {
                    dgvHoadonchitiet.DataSource = null;
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
