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
using medical_management.BUS;

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
            dtpToDate.Value = DateTime.Now;
            loadListInvoice();
            loadInvoiceSummary();
            loadStatPayment(false);

        }

        private void initializeUI()
        {
            foreach (DataGridViewRow row in dgvDSHD.Rows)
            {
                string status = row.Cells["Trangthai"].Value.ToString();

                switch (status)
                {
                    case InvoiceStatus.COMPLETE:
                        row.Cells["Trangthai"].Style.ForeColor = Color.FromArgb(6, 189, 109);
                        break;

                    case InvoiceStatus.RESERVE:
                        row.Cells["Trangthai"].Style.ForeColor = Color.FromArgb(255, 0, 0);
                        break;

                    default:
                        break;
                }

                row.Cells["MaHD"].Style.ForeColor = Color.FromArgb(16, 68, 115);

            }
        }

        private void loadListInvoice()
        {
            string query = "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                           "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                           "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                           "AND NgayHD BETWEEN @FromDate AND @ToDate ";

            DataTable data = Database.Instance.excuteQuery(query, new object[] { dtpFromDate.Value, dtpToDate.Value });

            dgvDSHD.DataSource = data;

            initializeUI();

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

        private void loadStatPayment(bool byFilter)
        {
            var paymentDictionary = byFilter ? InvoiceBUS.getPaymentSataticByFilter(fromDate, toDate, getListStatusFilter()) : InvoiceBUS.getPaymentSatatic();
            int count = Convert.ToInt32(paymentDictionary["count"]);
            decimal total = Convert.ToInt32(paymentDictionary["total"]);
            decimal payment = Convert.ToInt32(paymentDictionary["payment"]);

            lblInvoiceCount.Text = count.ToString();
            lblTotal.Text = Helper.formatCurrencyVN(total);
            lblTotalPayment.Text = Helper.formatCurrencyVN(payment);
            lblReceivable.Text = Helper.formatCurrencyVN(total - payment);
        }

        private DateTime getEarliestDate()
        {
            string query = "SELECT TOP 1 NgayHD FROM dbo.tbl_Invoice ORDER BY NgayHD ASC";
            return Convert.ToDateTime(Database.Instance.ExecuteScalar(query));
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string invoiceId = Convert.ToString(dgvDSHD.Rows[e.RowIndex].Cells[0].Value);

                loadInvoiceDetailById(invoiceId);
            }
            else
            {
                initializeUI();
            }

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
            fromDate = dtpFromDate.Value;
            toDate = dtpToDate.Value;

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

                loadStatPayment(false);
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

                loadStatPayment(true);
            }

            DataTable data = Database.Instance.excuteQuery(query, new object[] { fromDate, toDate });

            dgvDSHD.DataSource = data;

            if (dgvDSHD.Rows.Count > 0 && data.Rows.Count != 0)
            {
                loadInvoiceDetailById(dgvDSHD.Rows[0].Cells["MaHD"].Value.ToString());
            }
            else
            {
                dgvHoadonchitiet.DataSource = null;
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

                fromDate = dtpFromDate.Value;
                toDate = dtpToDate.Value;

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
                    if (!status.Equals(lastItem))
                    {
                        query += "N'" + status + "', ";
                    }
                    else
                    {
                        query += "N'" + status + "')";
                    }

                }

                DataTable data = Database.Instance.excuteQuery(query, new object[] { fromDate, toDate });

                dgvDSHD.DataSource = data;

                initializeUI();
                loadStatPayment(true);

                if (dgvDSHD.Rows.Count > 0 && data.Rows.Count != 0)
                {
                    loadInvoiceDetailById(dgvDSHD.Rows[0].Cells["MaHD"].Value.ToString());
                }
                else
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

        private void dgvDSHD_Sorted(object sender, EventArgs e)
        {
            initializeUI();
        }
    }
}
