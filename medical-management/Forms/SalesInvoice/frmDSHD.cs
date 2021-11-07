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
            initializeUI();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            frmPhieubanhang f = new frmPhieubanhang(isCreate: true, frmDSHD: this);
            f.reloadEventHandler += refreshEventHandler;
            f.ShowDialog(this);
        }

        private void refreshEventHandler(object sender, frmPhieubanhang.ReloadEventArgs args)
        {
            loadWhenChildClosing(true);
        }

        private void frmDSHD_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = getEarliestDate();
            dtpToDate.Value = DateTime.Now;
            loadListInvoice();
            loadInvoiceSummary();
            loadStatPayment(false);
        }

        private void loadWhenChildClosing(bool isReload)
        {
            dtpFromDate.Value = getEarliestDate();
            dtpToDate.Value = DateTime.Now;
            loadListInvoice();
            loadInvoiceSummary();
            loadStatPayment(false);
            int lastRowIndex = dgvDSHD.Rows.Count - 1;
            dgvDSHD.FirstDisplayedScrollingRowIndex = lastRowIndex;
            dgvDSHD.Rows[lastRowIndex].Selected = true;
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
            DataTable data = InvoiceBUS.getInvoiceDetailById(invoiceId);
            dgvHoadonchitiet.DataSource = data;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fromDate = dtpFromDate.Value;
            toDate = dtpToDate.Value;

            List<string> statusFilter = getListStatusFilter();

            // Load Invoice Summary

            DataTable dataSummary = InvoiceBUS.getInvoiceSummary(fromDate, toDate);
            dgvInvoiceSummary.DataSource = dataSummary;

            DataTable data = new DataTable();

            if (statusFilter.Count == 0)
            {
                data = InvoiceBUS.getAllInvoiceToNow(fromDate, toDate);
                loadStatPayment(true);
            } else
            {
                data = InvoiceBUS.getInvoiceWithFilter(fromDate, toDate, statusFilter);
                loadStatPayment(true);
            }

            dgvDSHD.DataSource = data;

            initializeUI();

            handleLoadInvoiceDetail(data);
        }

        private void handleLoadInvoiceDetail(DataTable data)
        {
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

                if (statusFilter.Count == 0)
                {
                    loadListInvoice();
                    loadStatPayment(true);
                    return;
                }

                DataTable data = InvoiceBUS.getInvoiceWithFilter(fromDate, toDate, statusFilter);

                dgvDSHD.DataSource = data;

                initializeUI();
                loadStatPayment(true);

                handleLoadInvoiceDetail(data);
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

        private void dgvDSHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDSHD.CurrentCell = dgvDSHD.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvDSHD.Rows[e.RowIndex].Selected = true;
                dgvDSHD.Focus();
                if (dgvDSHD.Rows[e.RowIndex].IsNewRow)
                {
                    return;
                }
                else
                {
                    string invoiceId = Convert.ToString(dgvDSHD.Rows[e.RowIndex].Cells[0].Value);
                    frmPhieubanhang f = new frmPhieubanhang(isCreate: false, this, invoiceId);
                    f.reloadEventHandler += refreshEventHandler;
                    f.ShowDialog(this);
                }

            }
            catch (Exception err)
            {
                Helper.showErrorMessage(err.Message);
            }
        }

        private void frmDSHD_Shown(object sender, EventArgs e)
        {
            // Handle UI when forms shown at the first times
            initializeUI();
        }
    }
}
