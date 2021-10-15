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
    public partial class frmPhieubanhang : Form
    {
        private string customerId;
        private decimal subtotal = 0M;
        private decimal paymented = 0M;
        private string invoiceId;
        private string staffId;
        bool isChanged;
        public frmPhieubanhang()
        {
            InitializeComponent();
        }

        private void frmPhieubanhang_Load(object sender, EventArgs e)
        {
            loadData();
            insertInvoice();
        }

        private void insertInvoice()
        {
            string insert = "INSERT INTO tbl_Invoice (MaHD, NgayHD, Tongtien, Dathanhtoan)" +
                           " VALUES( @MaHD , @NgayHD , @Tongtien , @Dathanhtoan )";
            int status = Database.Instance.excuteNonQuery(insert, new object[] { invoiceId, dtpNgayHD.Value, subtotal, paymented });
        }

        private void loadData()
        {
            DateTime today = DateTime.Now;
            dtpNgayHD.Value = today;
            this.invoiceId = createId("HD");
            txtMaHD.Text = this.invoiceId;

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
            txtDongia.Text = medical["Dongia"].ToString();
            string quantity = medical["Soluong"].ToString();
            //lblSoluong.Text += "(TK: " + quantity + ")";
            txtSoLuong.setHint("Hiện có: " + quantity);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSoLuong.setHint(String.Empty);
            addMedicalInvoice();
        }

        private void addMedicalInvoice()
        {
            string medicalId = txtMaThuoc.Text;
            int quatity = Convert.ToInt32(txtSoLuong.Text);
            decimal price = Convert.ToDecimal(txtDongia.Text);

            bool isValid = !String.IsNullOrEmpty(medicalId) && quatity > 0;

            if (!isValid) return;
            string insert = "INSERT INTO dbo.tbl_InvoiceDetail(MaHD, Mathuoc, Soluong, Dongia) " +
                            "VALUES( @MaHD , @MaThuoc , @Soluong , @Dongia ) ";
            Database.Instance.excuteNonQuery(insert, new object[] { invoiceId, medicalId, quatity, price });
            loadInvoiceDetail();
            resetMedical();
        }

        private void loadSubtotal()
        {
            foreach (DataGridViewRow row in dgvHoadonchitiet.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["Thanhtien"].Value);
            }
            txtTongcong.Text = subtotal.ToString();
        }

        private void resetMedical()
        {
            txtMaThuoc.Text = "";
            txtTenthuoc.Text = "";
            txtDonvitinh.Text = "";
            txtDongia.Text = "";
            txtSoLuong.Text = "";
            lblSoluong.Text = "Số lượng";
        }

        
        private void loadInvoiceDetail()
        {
            string query = "SELECT b.Mathuoc, b.Tenthuoc, b.Donvi, a.Dongia, a.Soluong, (a.Soluong * a.Dongia) AS Thanhtien " +
                           "FROM dbo.tbl_InvoiceDetail a INNER JOIN dbo.tbl_Item b  " +
                           "ON a.Mathuoc = b.Mathuoc WHERE a.MaHD = @MaHD";

            DataTable data = Database.Instance.excuteQuery(query, new object[] { invoiceId });
            dgvHoadonchitiet.DataSource = data;
            loadSubtotal();
        }

        // Auto genarate id with prefix (tiền tố)
        private string createId(string prefix)
        {
            string query = "SELECT TOP 1 MaHD FROM tbl_Invoice ORDER BY MaHD DESC";
            DataTable data = Database.Instance.excuteQuery(query);
            string lastID = data.Rows[0]["MaHD"].ToString();
            string index = lastID.Substring(prefix.Length);
            int key = Convert.ToInt16(index) + 1;
            return formatStringNumber(key, prefix);
        }

        /*
        number = 1000;
        prefix = HD;
        1 & HD -> HD10000
        */
        private string formatStringNumber(int i, string prefix)
        {
            string result;
            if (i < 10)
            {
                result = prefix + "0000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = prefix + "000" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = prefix + "00" + i.ToString().Trim();
            }
            else if (i < 10000)
            {
                result = prefix + "0" + i.ToString().Trim();
            }
            else result = prefix + i.ToString().Trim();
            return result;
        }

        private void frmPhieubanhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            string deleteDetail = "DELETE FROM tbl_InvoiceDetail WHERE MaHD = @MaHD";
            string delete = "DELETE FROM tbl_Invoice WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(deleteDetail, new object[] { txtMaHD.Text });
            Database.Instance.excuteNonQuery(delete, new object[] { txtMaHD.Text });
        }
    }
}
