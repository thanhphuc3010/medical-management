using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using medical_management.BUS;
using medical_management.DTO;

namespace medical_management
{
    public partial class frmPhieubanhang : Form
    {
        private bool isCreate;
        private string customerId = "WALKINGUEST";
        private decimal subtotal = 0M;
        private decimal total = 0M;
        private decimal discount = 0M;
        private string invoiceId;
        private string staffId = "NV01";
        private bool isSelectCompleteInvoice = false;
        private bool isEdit = false;
        private string status;
        string selectedMedicalId;
        private List<Consignment> consignments = new List<Consignment>();
        public frmPhieubanhang()
        {
            InitializeComponent();
        }

        public frmPhieubanhang(bool isCreate, string invoiceId = null)
        {
            InitializeComponent();
            this.isCreate = isCreate;
            this.invoiceId = invoiceId;
        }

        private void frmPhieubanhang_Load(object sender, EventArgs e)
        {
            if (isCreate)
            {
                loadData();
                insertInvoice();
            }
            else
            {
                loadExistInvoice();
            }

            lblKhachHang.visibleOrGone(!isCreate);
        }

        private void loadExistInvoice()
        {
            DataTable data = InvoiceBUS.getInvoiceById(invoiceId);
            foreach (DataRow row in data.Rows)
            {
                txtMaHD.Text = row["MaHD"].ToString();
                lblKhachHang.Text = row["TenKH"].ToString();
                lblKhachHang.ForeColor = Color.FromArgb(16, 68, 115);
                dtpNgayHD.Value = Convert.ToDateTime(row["NgayHD"]);
                status = row["Trangthaihoadon"].ToString();
                txtTongcong.Text = Helper.formatCurrencyVN(Convert.ToDecimal(row["Tongtien"]));
            }
            btnSelectCustomer.gone();
            loadInvoiceDetail();
            bindControlByStatus(status);
            dgvPayment.DataSource = PaymentBUS.getPayments(invoiceId);
        }

        private void bindControlByStatus(string status)
        {
            switch (status)
            {
                case InvoiceStatus.COMPLETE:
                    {
                        btnLuuhoadon.gone();
                        btnHoanthanh.gone();
                        btnPayment.gone();
                    }
                    break;
                case InvoiceStatus.RESERVE:
                    {
                        btnLuuhoadon.gone();
                    }
                    break;
                case InvoiceStatus.PENDING:
                    {

                    }
                    break;

                default:
                    break;
            }

        }

        private void insertInvoice()
        {
            string insert = "INSERT INTO tbl_Invoice (MaHD, MaKH, MaNV, NgayHD, Tongtien, Dathanhtoan)" +
                           " VALUES( @MaHD , @MaKH , @MaNV , @NgayHD , @Tongtien , @Dathanhtoan )";
            Database.Instance.excuteNonQuery(insert, new object[] { invoiceId, customerId, staffId, dtpNgayHD.Value, subtotal, total });
        }

        private void loadData()
        {
            DateTime today = DateTime.Now;
            dtpNgayHD.Value = today;
            this.invoiceId = createInvoiceId();
            txtMaHD.Text = this.invoiceId;
            txtTongcong.BackColor = txtTongcong.BackColor;
            txtTongtienhang.BackColor = txtTongtienhang.BackColor;
            txtDongia.BackColor = txtDongia.BackColor;
        }

        private void loadConsignment(string medicalId)
        {
            string query = "SELECT Malo, (Soluong - Daban) AS Tonkho FROM tbl_Consignment WHERE Mathuoc = @Mathuoc " +
                           "AND Daban < Soluong";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { medicalId });
            cbLoThuoc.FillCombo("Malo", "Malo", data);
            if (data.Rows.Count > 0)
            {
                cbLoThuoc.SelectedIndex = 0;
                txtInventory.Text = data.Rows[0]["Tonkho"].ToString();
            }
            foreach (DataRow item in data.Rows)
            {
                string consignmentId = item["Malo"].ToString();
                int inventory = (int)item["Tonkho"];
                consignments.Add(new Consignment(consignmentId, inventory));
            }
        }

        private string createInvoiceId()
        {
            string query = "SELECT TOP 1 MaHD FROM tbl_Invoice ORDER BY MaHD DESC";
            return Helper.createId("HD", query, "MaHD");
        }

        private void bindCustomer(string id, string name)
        {
            lblKhachHang.Text = name;
            this.customerId = id;
            btnSelectCustomer.gone();
            lblKhachHang.visible();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            frmSelectCustomer f = new frmSelectCustomer();
            f.publisher = new frmSelectCustomer.passCustomerId(bindCustomer);
            f.ShowDialog();
        }

        private void btnSelectMedical_Click(object sender, EventArgs e)
        {
            frmSelectMedical f = new frmSelectMedical();
            f.medicalPublisher = new frmSelectMedical.passMedical(bindMedical);
            f.ShowDialog();
        }

        private void bindMedical(string id)
        {
            string query = "SELECT * FROM tbl_Item WHERE MaThuoc = @MaThuoc";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { id });
            var medical = data.Rows[0];
            txtMaThuoc.Text = medical["MaThuoc"].ToString();
            txtTenthuoc.Text = medical["TenThuoc"].ToString();
            txtDonvitinh.Text = medical["Donvi"].ToString();
            CultureInfo culture = new CultureInfo("vi-VN");
            decimal price = Convert.ToDecimal(medical["Dongia"]);
            txtDongia.Text = price.ToString();
            txtTotalInventory.Text = medical["Soluong"].ToString();
            loadConsignment(id);
            btnAdd.enable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //txtSoLuong.setHint(String.Empty);
            addMedical2Invoice();
        }

        private void addMedical2Invoice()
        {
            string medicalId = txtMaThuoc.Text;
            int quantity;
            decimal price = Convert.ToDecimal(txtDongia.Text);

            if (String.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập số lượng");
                return;
            }

            if (isDuplicateMedicineInDetail(medicalId))
            {
                Helper.showErrorMessage("Mặt hàng này đã tồn tại trong đơn thuốc!");
                return;
            }

            int inventory = Convert.ToInt32(txtTotalInventory.Text);
            quantity = Convert.ToInt32(txtSoLuong.Text);

            if (quantity > inventory)
            {
                Helper.showErrorMessage("Không đủ sản phẩm, tồn kho hiện có là: " + inventory.ToString());
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

            try
            {
                string insert = "INSERT INTO dbo.tbl_InvoiceDetail(MaHD, Mathuoc, Soluong, Dongia) " +
                            "VALUES( @MaHD , @MaThuoc , @Soluong , @Dongia ) ";
                Database.Instance.excuteNonQuery(insert, new object[] { invoiceId, medicalId, quantity, price });
                loadInvoiceDetail();
                resetMedical();
                btnAdd.disable();
            }
            catch (Exception)
            {

            }

        }

        private bool isDuplicateMedicineInDetail(string medicalId)
        {
            foreach (DataGridViewRow row in dgvHoadonchitiet.Rows)
            {
                if (row.Cells["Mathuoc"].Value != null)
                {
                    string id = row.Cells["Mathuoc"].Value.ToString();
                    if (medicalId == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void loadSubtotal()
        {
            subtotal = 0M;
            foreach (DataGridViewRow row in dgvHoadonchitiet.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["Thanhtien"].Value);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongtienhang.Text = subtotal.ToString("c", culture);
        }

        private void loadTotal()
        {
            total = calTotal();
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongcong.Text = total.ToString("c", culture);
        }

        private void resetMedical()
        {
            txtMaThuoc.Text = "";
            txtTenthuoc.Text = "";
            txtDonvitinh.Text = "";
            txtDongia.Text = "";
            txtSoLuong.Text = "";
            lblSoluong.Text = "Số lượng";
            cbLoThuoc.SelectedIndex = -1;
            txtInventory.Text = "";
            txtTotalInventory.Text = "";
        }

        private void loadInvoiceDetail()
        {
            string query = "SELECT b.Mathuoc, b.Tenthuoc, b.Donvi, a.Dongia, a.Soluong, (a.Soluong * a.Dongia) AS Thanhtien " +
                           "FROM dbo.tbl_InvoiceDetail a INNER JOIN dbo.tbl_Item b " +
                           "ON a.Mathuoc = b.Mathuoc WHERE a.MaHD = @MaHD";

            DataTable data = Database.Instance.excuteQuery(query, new object[] { invoiceId });
            dgvHoadonchitiet.DataSource = data;
            loadSubtotal();
            loadTotal();
        }

        // Auto genarate id with prefix

        private void frmPhieubanhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Button btnCompleteInvoice = sender as Button;

            if (isSelectCompleteInvoice)
            {
                Helper.showSuccessMessage("Thêm hóa đơn thành công");
            }
            else
            {
                if (isCreate)
                {
                    deleteInvoice();
                }
            }

            // Refresh list invoice (frmDSHD) when form closing
            frmDSHD fListInvoice = (frmDSHD)Owner;
            fListInvoice.loadWhenChildClosing();
        }

        private void deleteInvoice()
        {
            string id = txtMaHD.Text;
            InvoiceBUS.deleteInvoiceDetail(id);
            InvoiceBUS.deleteInvoicePayment(id);
            InvoiceBUS.deleteInvoice(id);
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGiamgia.Text))
            {
                discount = 0M;
                txtGiamgia.Text = "0";
            }

            discount = Convert.ToDecimal(txtGiamgia.Text);
            loadTotal();
        }

        private decimal calTotal()
        {
            return subtotal * (1 - (discount / 100));
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            string invoiceStatus = InvoiceStatus.PENDING;

            if (isCreate)
            {
                doSoldInvoice(invoiceStatus);
            } else
            {
                if (status == InvoiceStatus.RESERVE && isFullyPayment())
                {
                    InvoiceBUS.setInvoiceStatus(InvoiceStatus.COMPLETE, invoiceId);
                }

                if (status == InvoiceStatus.PENDING)
                {
                    doSoldInvoice(invoiceStatus);
                }
            }

            doSaveTotalPayment();
            isSelectCompleteInvoice = true;
            this.Close();
        }

        private void doSoldInvoice(string invoiceStatus)
        {
            if (!isFullyPayment())
            {
                DialogResult result = MessageBox.Show("Hóa đơn chưa thanh toán hoặc thanh toán chưa đủ, chọn CÓ nếu bạn muốn BÁN NỢ hóa đơn này!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    invoiceStatus = InvoiceStatus.RESERVE;
                }
                else
                {
                    return;
                }
            }
            else
            {
                invoiceStatus = InvoiceStatus.COMPLETE;
            }

            foreach (DataGridViewRow row in dgvHoadonchitiet.Rows)
            {
                if (row.IsNewRow) continue;
                string medicineId = row.Cells["Mathuoc"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Soluong"].Value);

                foreach (Consignment item in consignments)
                {
                    string consignmentId = item.Id;
                    int inventory = item.Inventory;
                    if (quantity <= inventory)
                    {
                        string proUpdateQuantity = "EXEC dbo.USP_Update_Quantity @idItem , @idConsignment , @SoLuong";
                        Database.Instance.excuteNonQuery(proUpdateQuantity, new object[] { medicineId, consignmentId, quantity });
                        break;
                    }
                    else
                    {
                        string proUpdateQuantity = "EXEC dbo.USP_Update_Quantity @idItem , @idConsignment , @SoLuong";
                        Database.Instance.excuteNonQuery(proUpdateQuantity, new object[] { medicineId, consignmentId, inventory });
                        quantity = quantity - inventory;
                    }

                }
            }

            string update = "UPDATE dbo.tbl_Invoice SET Trangthaihoadon = @Trangthaihoadon , Tongtien = @Tongtien " +
                            "WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(update, new object[] { invoiceStatus, total, invoiceId });
        }

        private bool isFullyPayment()
        {
            decimal totalPayment = getInvoiceTotalPayment();
            return totalPayment == total;
        }

        private decimal getInvoiceTotalPayment()
        {
            string query = "SELECT SUM(SoTienTT) FROM dbo.tbl_Payment WHERE MaHD = @MaHD";
            var result = Database.Instance.ExecuteScalar(query, new object[] { invoiceId });
            if (result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            else
            {
                return 0M;
            }
        }

        private void doSaveTotalPayment()
        {
            decimal payment = 0M;
            foreach (DataGridViewRow row in dgvPayment.Rows)
            {
                if (row.IsNewRow) continue;
                payment += Convert.ToDecimal(row.Cells["SoTienTT"].Value);
            }
            string update = "UPDATE dbo.tbl_Invoice SET Dathanhtoan = @Dathanhtoan WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(update, new object[] { payment, invoiceId });
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (isFullyPayment())
            {
                Helper.showSuccessMessage("Khách hàng đã thanh toán đủ giá trị đơn hàng");
                return;
            }
            frmPayment f = new frmPayment(customerId, invoiceId, total);
            f.publisher = new frmPayment.handlePaymented(doHandlePayment);
            f.ShowDialog();
        }

        private void doHandlePayment(bool isPaymented)
        {
            if (isPaymented)
            {
                string query = "SELECT a.PhuongThucTT, a.NgayTT, a.SoTienTT, a.NoidungTT FROM tbl_Payment a WHERE MaHD = @MaHD";
                DataTable data = Database.Instance.excuteQuery(query, new object[] { invoiceId });
                dgvPayment.DataSource = data;
            }
        }

        private void txtGiamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            string value = ((TextBox)sender).Text + e.KeyChar;
            if (e.KeyChar != '\b')
            {
                e.Handled = !isDiscountValid(value);
            }

        }

        public static bool isDiscountValid(string str)
        {
            decimal i;
            return decimal.TryParse(str, out i) && i >= 0 && i <= 100;
        }

        private void cbLoThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT (Soluong - Daban) AS Tonkho FROM tbl_Consignment WHERE Malo = @Malo ";
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.IsHandleCreated && comboBox.Focused && comboBox.SelectedValue != null)
            {
                string consignmentId = comboBox.SelectedValue.ToString();
                int inventory = (int)Database.Instance.ExecuteScalar(query, new object[] { consignmentId });
                txtInventory.Text = inventory.ToString();
            }
        }

        private void dgvHoadonchitiet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvHoadonchitiet.CurrentCell = dgvHoadonchitiet.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    dgvHoadonchitiet.Rows[e.RowIndex].Selected = true;
                    dgvHoadonchitiet.Focus();
                    if (dgvHoadonchitiet.Rows[e.RowIndex].IsNewRow)
                    {
                        selectedMedicalId = null;
                    }
                    else
                    {
                        selectedMedicalId = Convert.ToString(dgvHoadonchitiet.Rows[e.RowIndex].Cells[0].Value);
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        private void bindingEditMode(string id)
        {
            object dataSoure = dgvHoadonchitiet.DataSource;

            txtMaThuoc.binding(dataSoure, "Mathuoc");
            txtTenthuoc.binding(dataSoure, "Tenthuoc");
            txtDonvitinh.binding(dataSoure, "Donvi");
            txtDongia.binding(dataSoure, "Dongia");
            txtSoLuong.binding(dataSoure, "Soluong");
            string query = "SELECT Soluong FROM tbl_Item WHERE Mathuoc = @Mathuoc";
            txtTotalInventory.Text = Database.Instance.ExecuteScalar(query, new object[] { id }).ToString();
            loadConsignment(id);
            cbLoThuoc.disable();
        }

        private void dgvHoadonchitiet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmnuInvoiceDetail.Show(Cursor.Position.X, Cursor.Position.Y);
                if (isEdit)
                {
                    cmnuInvoiceDetail.disable();
                }
                else
                {
                    cmnuInvoiceDetail.enable();
                }
            }
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMedicalId != null)
            {
                bindingEditMode(selectedMedicalId);
                isEdit = true;
                btnAdd.gone();
                btnUpdate.visible();
                btnCancle.visible();
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMedicalId != null)
            {
                Helper.showDialogConfirmDelete("Bạn có chắn chắn muốn xóa sản phẩm này?", delMedicalFromInvoice);

            }
        }

        private void delMedicalFromInvoice()
        {
            string del = "DELETE FROM dbo.tbl_InvoiceDetail WHERE MaHD = @MaHD AND Mathuoc = @Mathuoc";
            try
            {
                int result = Database.Instance.excuteNonQuery(del, new object[] { invoiceId, selectedMedicalId });
                if (result > 0)
                {
                    loadInvoiceDetail();
                    resetMedical();
                }
            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    Helper.showErrorMessage(e.Message);
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            resetEditMode();
        }

        private void resetEditMode()
        {
            resetMedical();
            isEdit = false;
            btnAdd.visible();
            btnUpdate.gone();
            btnCancle.gone();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "UPDATE dbo.tbl_InvoiceDetail SET Soluong = @Soluong WHERE MaHD = @MaHD AND Mathuoc = @Mathuoc ";
            int quantity;

            if (String.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập số lượng");
                return;
            }

            quantity = Convert.ToInt32(txtSoLuong.Text);
            Database.Instance.excuteNonQuery(update, new object[] { quantity, invoiceId, txtMaThuoc.Text });
            loadInvoiceDetail();
            resetEditMode();
        }

        private void btnLuuhoadon_Click(object sender, EventArgs e)
        {
            string invoiceStatus = InvoiceStatus.PENDING;
            string update = "UPDATE dbo.tbl_Invoice SET Trangthaihoadon = @Trangthaihoadon , Tongtien = @Tongtien " +
                            "WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(update, new object[] { invoiceStatus, total, invoiceId });
            isSelectCompleteInvoice = true;
            this.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
