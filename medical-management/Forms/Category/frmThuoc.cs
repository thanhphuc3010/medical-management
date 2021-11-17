using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public partial class frmThuoc : Form
    {
        private readonly frmSelectMedical frmSelectMedical;
        public frmThuoc(frmSelectMedical frmSelectMedical)
        {
            InitializeComponent();
            initializeControl();
            this.frmSelectMedical = frmSelectMedical;
        }
        public frmThuoc()
        {
            InitializeComponent();
            initializeControl();
        }
        private void loadData()
        {
            string query = "SELECT * FROM tbl_Item";
            dgvThuoc.DataSource = Database.Instance.excuteQuery(query);
            bindingData();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void initializeControl()
        {
            btnSave.disable();
        }
        private void bindingData()
        {
            object dataSource = dgvThuoc.DataSource;
            txtMathuoc.binding(dataSource, "Mathuoc");
            txtMaNSX.binding(dataSource, "MaNSX");
            txtNhomthuoc.binding(dataSource, "Nhomthuoc");
            txtTenthuoc.binding(dataSource, "Tenthuoc");
            txtDonvi.binding(dataSource, "Donvi");
            txtHamluong.binding(dataSource, "Hamluong");
            txtSoluong.binding(dataSource, "Soluong");
            txtDonggoi.binding(dataSource, "Donggoi");
            txtThanhphan.binding(dataSource, "Thanhphan");
            txtDongia.binding(dataSource, "Dongia");
            txtGianhap.binding(dataSource, "Gianhap");
            txtGhichu.binding(dataSource, "Ghichu");

        }
        private void addItem()
        {
            string id = txtMathuoc.Text.ToString().Trim();
            string manhasanxuat = txtMaNSX.Text.ToString().Trim();
            string nhomthuoc = txtNhomthuoc.Text.ToString().Trim();
            string tenthuoc = txtTenthuoc.Text.ToString().Trim();
            string donvi = txtDonvi.Text.ToString().Trim();
            string hamluong = txtHamluong.Text.ToString().Trim();
            string soluong = txtSoluong.Text.ToString().Trim();
            string donggoi = txtDonggoi.Text.ToString().Trim();
            string thanhphan = txtThanhphan.Text.ToString().Trim();
            string dongia = txtDongia.Text.ToString().Trim();
            string gianhap = txtGianhap.Text.ToString().Trim();
            string ghichu = txtGhichu.Text.ToString().Trim();

            string insert = "INSERT INTO tbl_Item (Mathuoc, Nhomthuoc, MaNSX, Tenthuoc, Donvi, Hamluong, Soluong, Donggoi, Thanhphan, Dongia, Gianhap, Ghichu)" + "" +
                "VALUES ( @Mathuoc , @Nhomthuoc , @MaNSX , @Tenthuoc , @Donvi , @Hamluong , @Soluong , @Donggoi , @Thanhphan , @Dongia , @Gianhap , @Ghichu )";
            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, nhomthuoc, manhasanxuat, tenthuoc, donvi, hamluong, soluong, donggoi, thanhphan, dongia, gianhap, ghichu });

            if (frmSelectMedical != null)
            {
                frmSelectMedical.refreshGrid();
                this.Close();
            }
            if (result > 0)
            {
                loadData();
            }
        }

        private void resetFields()
        {
            txtMathuoc.Text = "";
            txtNhomthuoc.Text = "";
            txtMaNSX.Text = "";
            txtTenthuoc.Text = "";
            txtDonvi.Text = "";
            txtHamluong.Text = "";
            txtSoluong.Text = "";
            txtDonggoi.Text = "";
            txtDongia.Text = "";
            txtGianhap.Text = "";
            txtThanhphan.Text = "";
            txtGhichu.Text = "";
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            btnAdd.disable();
            resetFields();
            btnSave.enable();
            txtMathuoc.Focus();

        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            deleteMedicineWithConfirm();
        }

        private void deleteMedicineWithConfirm()
        {
            string message = "Bạn có chắc chắn muốn xóa thuốc này không?";
            Helper.showDialogConfirmDelete(message, deleteMedicine);

        }

        private void deleteMedicine()
        {       
            string id = txtMathuoc.Text.ToString().Trim();
            string del = "Delete from tbl_Item Where Mathuoc = @Mathuoc";


            try
            {
               int result = Database.Instance.excuteNonQuery(del, new object[] { id });
                if (result > 0)
                {
                    loadData();
                }
            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    Helper.showErrorMessage("Sản phẩm này đã phát sinh giao dịch. Không thể xóa!");
                }
            }
            MessageBox.Show("Đã xóa thành công!", "Thông báo");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string id = txtMathuoc.Text.ToString().Trim();
            string nhomthuoc = txtNhomthuoc.Text.ToString().Trim();
            string manhasanxuat = txtMaNSX.Text.ToString().Trim();
            string tenthuoc = txtTenthuoc.Text.ToString().Trim();
            string donvi = txtDonvi.Text.ToString().Trim();
            string hamluong = txtHamluong.Text.ToString().Trim();
            string soluong = txtSoluong.Text.ToString().Trim();
            string donggoi = txtDonggoi.Text.ToString().Trim();
            string thanhphan = txtThanhphan.Text.ToString().Trim();
            string dongia = txtDongia.Text.ToString().Trim();
            string gianhap = txtGianhap.Text.ToString().Trim();
            string ghichu = txtGhichu.Text.ToString().Trim();
            string del = "Update tbl_Item" + "" +
                " Set Nhomthuoc = @Nhomthuoc , MaNSX = @MaNSX , Tenthuoc = @Tenthuoc , Donvi = @Donvi , Hamluong = @Hamluong , Soluong = @Soluong , Donggoi = @Donggoi , Thanhphan = @Thanhphan , Dongia = @Dongia , Gianhap = @Gianhap , Ghichu = @Ghichu " + "" +
                " Where Mathuoc = @Mathuoc";
            int result = Database.Instance.excuteNonQuery(del, new object[] { nhomthuoc, manhasanxuat, tenthuoc, donvi, hamluong, soluong, donggoi, thanhphan, dongia, gianhap, ghichu , id });
            if (result > 0)
            {
                loadData();
            }
            MessageBox.Show("Đã sửa thành công!", "Thông báo");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            addItem();
            btnAdd.enable();
            btnSave.disable();
            MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dgvThuoc.ClearSelection();
            dgvThuoc.CurrentCell = dgvThuoc[0, 0];
            bindingData();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvThuoc.CurrentRow.Index.ToString());
            if (i > 0)
            {
                dgvThuoc.CurrentCell = dgvThuoc[0, i - 1];
                bindingData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvThuoc.CurrentRow.Index.ToString());
            if (i < dgvThuoc.RowCount - 1)
            {
                dgvThuoc.CurrentCell = dgvThuoc[0, i + 1];
                bindingData();

            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dgvThuoc.CurrentCell = dgvThuoc[0, dgvThuoc.RowCount - 1];
            bindingData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }


        // Demo create pull request
    }
}

