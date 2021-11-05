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
    public partial class frmPhieunhap : Form
    {
        private decimal subtotal = 0M;
        private decimal total = 0M;
        private decimal discount = 0M;
        //private decimal totalInventory = 0M;
        private decimal VAT = 0M;
        private string poId; //Mã phiếu nhập
        private string malo; //Mã lô
        private string supplierId; //Mã nhà cung cấp
        private string medicalId; //Mã thuốc
        int quantity;
        private string staffId = "NV01";
        private bool isSelectCompletePO = false;
        private bool isEdit = false;
        string selectedMedicalId;
        private List<Consignment> consignments = new List<Consignment>();
        public frmPhieunhap()
        {
            InitializeComponent();
        }



        private void lblPhieunhap_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieunhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPhieunhap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void insertPO()
        {
            string query = "SELECT 1 FROM tbl_PurchaseOrder WHERE Manhap = @MaNhap";
            var res = Database.Instance.excuteQuery(query, new object[] { poId });
            if (res.Rows.Count != 0)
            {
                return;
            }
            string insert = "INSERT INTO tbl_PurchaseOrder ( Manhap, MaNCC, MaNV, Ngaynhap, Soluonglo, Tongtien, Thue, Dathanhtoan)" +
                           " VALUES( @Manhap , @MaNCC , @MaNV , @Ngaynhap , @Soluonglo , @Tongtien , @Thue , @Dathanhtoan )";
            Database.Instance.excuteNonQuery(insert, new object[] { poId, supplierId, staffId, dtpNgaynhap.Value, txtSoluong.Text, subtotal, total, VAT, 0 });
        }


        private void loadData()
        {

            DateTime today = DateTime.Now;
            dtpNgaynhap.Value = today;
            NextId();
            txtTongcong.BackColor = txtTongcong.BackColor;
            txtTongtienthanhtoan.BackColor = txtTongtienthanhtoan.BackColor;
            txtGianhap.BackColor = txtGianhap.BackColor;
            btnAdd.disable();
        }
        private void NextId()
        {
            this.poId = createPOId();
            txtManhap.Text = this.poId;
            this.malo = createMalo();
            txtMalo.Text = this.malo;
        }

        private string createPOId()
        {
            string query = "SELECT TOP 1 Manhap FROM tbl_PurchaseOrder ORDER BY Manhap DESC";
            return Helper.createId("PN", query, "Manhap");

        }

        private string createMalo()
        {
            string query = "Select Top 1 Malo From tbl_Consignment Order by Malo Desc";
            return Helper.createId("ML", query, "Malo");
        }

        private void bindSupplier(string id, string name)
        {
            lblNCC.Text = name;
            this.supplierId = id;
            btnSelectSupplier.gone();
            lblNCC.visible();
            checkingEnableAddBtn();
        }
        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
            frmSelectSupplier f = new frmSelectSupplier();
            f.publisher = new frmSelectSupplier.passSupplierId(bindSupplier);
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
            txtMathuoc.Text = medical["MaThuoc"].ToString();
            medicalId = medical["MaThuoc"].ToString();
            txtTenthuoc.Text = medical["TenThuoc"].ToString();
            txtDonvi.Text = medical["Donvi"].ToString();
            CultureInfo culture = new CultureInfo("vi-VN");
            decimal price = Convert.ToDecimal(medical["Dongia"]);

            checkingEnableAddBtn();
        }

        private void addMedicall2PO()
        {



            decimal price = Convert.ToDecimal(txtGianhap.Text);

            if (String.IsNullOrWhiteSpace(txtGianhap.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập Giá nhập");
                return;
            }

            if (String.IsNullOrWhiteSpace(txtSoluong.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập số lượng");
                return;
            }

            if (isDuplicateMedicineInDetail(medicalId))
            {
                Helper.showErrorMessage("Mặt hàng này đã tồn tại trong đơn thuốc!");
                return;
            }


            insertConsignment();
            loadConsignment();
            resetMedical();
            this.malo = createMalo();
            txtMalo.Text = this.malo;
            btnAdd.disable();
        }

        private bool isDuplicateMedicineInDetail(string medicalId)
        {
            foreach (DataGridViewRow row in dgvPhieunhapchitiet.Rows)
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

        private void insertConsignment()
        {
            decimal price = Convert.ToDecimal(txtGianhap.Text);
            string insert = "INSERT INTO dbo.tbl_Consignment(Manhap, Malo, Mathuoc, Soluong, Gianhap, Ngaysanxuat, Ngayhethan) " +
                            "VALUES( @Manhap , @Malo , @Mathuoc , @Soluong , @Gianhap , @Ngaysanxuat , @Ngayhethan ) ";
            Database.Instance.excuteNonQuery(insert, new object[] { poId, malo, medicalId, Int16.Parse(txtSoluong.Text), price, dtpNgaysanxuat.Value, dtpNgayhethan.Value });

        }

        private void loadConsignment()
        {
            string query = "SELECT a.Mathuoc, a.Soluong, a.Gianhap ,b.Donvi, (a.Soluong * a.Gianhap) AS Thanhtien " +
                           "FROM dbo.tbl_Consignment a INNER JOIN dbo.tbl_Item b " +
                           "ON a.Mathuoc = b.Mathuoc WHERE a.Manhap = @Manhap";

            DataTable data = Database.Instance.excuteQuery(query, new object[] { poId });
            dgvPhieunhapchitiet.DataSource = data;
            loadSubtotal();
            loadTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMedicall2PO();



        }

        private void loadSubtotal()
        {
            subtotal = 0M;
            foreach (DataGridViewRow row in dgvPhieunhapchitiet.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["Thanhtien"].Value);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongcong.Text = subtotal.ToString("c", culture);
        }

        private decimal calTotal()
        {
            return subtotal * (1 - (discount / 100)) * (1 + VAT / 100);
        }
        private void loadTotal()
        {
            total = calTotal();
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongtienthanhtoan.Text = total.ToString("c", culture);
        }
        private void resetMedical()
        {
            txtMathuoc.Text = "";
            txtTenthuoc.Text = "";
            txtDonvi.Text = "";
            txtGianhap.Text = "";
            txtSoluong.Text = "";
            //lblSoluong.Text = "Số lượng";
            dtpNgayhethan.CustomFormat = "";

        }

        /// <summary>
        /// Kiểm tra trạng thái enable nút thêm
        /// </summary>
        private void checkingEnableAddBtn()
        {
            if (supplierId != null && medicalId != null)
            {
                btnAdd.enable();
                insertPO();
            }
            else
            {
                btnAdd.disable();
            }
        }

        private void frmPhieunhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Button btnCompleteInvoice = sender as Button;

            if (isSelectCompletePO)
            {
                Helper.showSuccessMessage("Thêm phiếu nhập thành công");
            }
            else
            {
                deletePO();
            }
        }

        private void deletePO()
        {
            string id = txtManhap.Text;
            string delete = "Delete From tbl_PurchaseOrder Where Manhap= @Manhap";
            Database.Instance.excuteNonQuery(delete, new object[] { id });
            string delete1 = "Delete From tbl_Consignment Where Manhap= @Manhap";
            Database.Instance.excuteNonQuery(delete1, new object[] { id });

        }


        private void txtChietkhau_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtChietkhau_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtChietkhau.Text))
            {
                discount = 0M;
                txtChietkhau.Text = "0";
            }

            discount = Convert.ToDecimal(txtChietkhau.Text);
            loadTotal();
        }

        private void txtThue_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtChietkhau.Text))
            {
                VAT = 0M;
                txtThue.Text = "0";
            }

            VAT = Convert.ToDecimal(txtThue.Text);
            loadTotal();
        }

        public static bool isVATValid(string str)
        {
            decimal i;
            return decimal.TryParse(str, out i) && i >= 0 && i <= 100;
        }

        private void txtThue_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = !isVATValid(value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string update = "UPDATE dbo.tbl_Consignment SET Soluong = @Soluong , Gianhap = @Gianhap WHERE Manhap = @Manhap ";
            int quantity;
            quantity = Convert.ToInt32(txtSoluong.Text);

            if (String.IsNullOrWhiteSpace(txtGianhap.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập Giá nhập");
                return;
            }

            if (String.IsNullOrWhiteSpace(txtSoluong.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập số lượng");
                return;
            }
            Database.Instance.excuteNonQuery(update, new object[] { quantity, txtGianhap.Text , poId, txtMalo.Text });
            loadConsignment();
            resetEditMode();
        }

        private void resetEditMode()
        {
            resetMedical();
            isEdit = false;
            btnAdd.visible();
            btnUpdate.gone();
            btnCancel.gone();
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetEditMode();
        }

        private void btnGhinhan_Click(object sender, EventArgs e)
        {
            var query = "UPDATE tbl_PurchaseOrder SET Soluonglo = @Soluonglo , Tongtien = @Tongtien ,Dathanhtoan = @Dathanhtoan , Thue = @Thue WHERE Manhap = @Manhap";
            var param = new object[] { dgvPhieunhapchitiet.Rows.Count - 1, subtotal, subtotal, Int16.Parse(txtThue.Text), poId };
            Database.Instance.excuteNonQuery(query, param);

            Helper.showSuccessMessage("Thêm mới thành công");
            this.Close();
        
            return;


        }

        private void bindingEditMode(string id)
        {
            object dataSoure = dgvPhieunhapchitiet.DataSource;
            txtMathuoc.binding(dataSoure, "Mathuoc");
            //txtTenthuoc.binding(dataSoure, "Tenthuoc");
            string query = "Select Tenthuoc From dbo.tbl_Item Where Mathuoc = @Mathuoc ";
            txtTenthuoc.Text = Database.Instance.ExecuteScalar(query, new object[] { id }).ToString();
            Database.Instance.excuteQuery(query, new object[] { medicalId });
            txtDonvi.binding(dataSoure, "Donvi");
          



        }

        private void dgvPhieunhapchitiet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmnuPODetail.Show(Cursor.Position.X, Cursor.Position.Y);
                if (isEdit)
                {
                    cmnuPODetail.disable();
                }
                else
                {
                    cmnuPODetail.enable();
                }
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedMedicalId != null)
            {
                bindingEditMode(selectedMedicalId);
                isEdit = true;
                btnAdd.gone();
                btnUpdate.visible();
                btnCancel.visible();
            }
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (selectedMedicalId != null)
            {
                Helper.showDialogConfirmDelete("Bạn có chắn chắn muốn xóa sản phẩm này?", delMedicalFromPO);

            }
        }

        private void delMedicalFromPO()
        {
            string del = "DELETE FROM dbo.tbl_Consignment WHERE Manhap = @Manhap ";
            try
            {
                int result = Database.Instance.excuteNonQuery(del, new object[] { poId, selectedMedicalId });
                if (result > 0)
                {
                    loadConsignment();
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

        private void dgvPhieunhapchitiet_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvPhieunhapchitiet.CurrentCell = dgvPhieunhapchitiet.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    // Can leave these here - doesn't hurt
                    dgvPhieunhapchitiet.Rows[e.RowIndex].Selected = true;
                    dgvPhieunhapchitiet.Focus();
                    if (dgvPhieunhapchitiet.Rows[e.RowIndex].IsNewRow)
                    {
                        selectedMedicalId = null;
                    }
                    else
                    {
                        selectedMedicalId = Convert.ToString(dgvPhieunhapchitiet.Rows[e.RowIndex].Cells[0].Value);
                    }

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
