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
        private decimal totalInventory = 0M;
        private decimal VAT = 0M;
        private string poId;
        private string malo;
        private string supplierId;
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
            //insertPurchaseOrder();
        }

        //private void insertPurchaseOrder()
        //{
        //    string insert = " Insert into tbl_PurchaseOrder ( Manhap , MaNCC, MaNV , Ngaynhap , Soluonglo , Tongtien , Dathanhtoan , Thue )" +
        //        "Values( @Manhap , @MaNCC , @MaNV , @Ngaynhap , @Soluonglo , @Tongtien , @Dathanhthoan , @Thue )";
        //    Database.Instance.excuteNonQuery(insert, new object[] { poId, supplierId, staffId, dtpNgaynhap.Value, totalInventory, subtotal, total, VAT });
        //}

        private void loadData()
        {
            
            DateTime today = DateTime.Now;
            dtpNgaynhap.Value = today;
            this.poId = createPOId();
            txtManhap.Text = this.poId;
            this.malo = createMalo();
            txtMalo.Text = this.malo;
            txtTongcong.BackColor = txtTongcong.BackColor;
            txtTongtienthanhtoan.BackColor = txtTongtienthanhtoan.BackColor;
            txtDongia.BackColor = txtDongia.BackColor;
        }

        private void loadConsignment(string medicalId)
        {

        }

        private string createPOId()
        {
            string query = "SELECT TOP 1 Manhap FROM tbl_PurchaseOrder ORDER BY Manhap DESC";
            return Helper.createId("PN", query, "Manhap");

        }

        private string createMalo()
        {
            string query = "Select Top 1 Malo From tbl_Consignment Order by Malo Desc";
            return Helper.createId("Lo", query, "Malo");
        }

       private void bindSupplier(string id, string name)
        {
            lblNCC.Text = name;
            this.supplierId = id;
            btnSelectSupplier.gone();
            lblNCC.visible();
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
            txtTenthuoc.Text = medical["TenThuoc"].ToString();
            txtDonvitinh.Text = medical["Donvi"].ToString();
            CultureInfo culture = new CultureInfo("vi-VN");
            decimal price = Convert.ToDecimal(medical["Dongia"]);
            //txtDongia.Text = price.ToString();
            //txtTotalInventory.Text = medical["Soluong"].ToString();
            loadConsignment(id);
            btnAdd.enable();
        }

        private void addMedicall2PO()
        {
            string medicalId = txtMathuoc.Text;
            int quantity;
            decimal price = Convert.ToDecimal(txtDongia.Text);

            if (String.IsNullOrWhiteSpace(txtSoluonglo.Text))
            {
                Helper.showErrorMessage("Vui lòng nhập số lượng");
                return;
            }

            if (isDuplicateMedicineInDetail(medicalId))
            {
                Helper.showErrorMessage("Mặt hàng này đã tồn tại trong đơn thuốc!");
                return;
            }
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
            return subtotal * (1 - (discount / 100));
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
            txtDonvitinh.Text = "";
            txtDongia.Text = "";
            txtSoluonglo.Text = "";
            lblSoluong.Text = "Số lượng";
            dtpHsd.CustomFormat = "";
          
        }

        private void loadInvoiceDetail()
        {
            string query = "SELECT b.Mathuoc, b.Tenthuoc, b.Donvi, a.Dongia, a.Soluong, (a.Soluong * a.Dongia) AS Thanhtien " +
                           "FROM dbo.tbl_PurchaseOrderDetail a INNER JOIN dbo.tbl_Item b " +
                           "ON a.Mathuoc = b.Mathuoc WHERE a.MaHD = @MaHD";

            DataTable data = Database.Instance.excuteQuery(query, new object[] { poId });
            dgvPhieunhapchitiet.DataSource = data;
            loadSubtotal();
            loadTotal();
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
            string delete = "Delete From tbl_PurchaseOrder Where Manhap=@Manhap";
            Database.Instance.excuteNonQuery(delete, new object[] { id });
           
        }

        private void txtGiamgia_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtChietkhau.Text))
            {
                discount = 0M;
                txtChietkhau.Text = "0";
            }

            discount = Convert.ToDecimal(txtChietkhau.Text);
            loadTotal();
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
    }
}
