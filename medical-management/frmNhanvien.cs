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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
          

        }
        private void loadData()
        {
            string query = "Select * From tbl_Staff";
            dgvNhanvien.DataSource = Database.Instance.excuteQuery(query);
            bindingData();

        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bindingData()
        {
            object dataSource = dgvNhanvien.DataSource;
            txtMaNV.binding(dataSource, "MaNV");
            txtTenNV.binding(dataSource, "TenNV");
            txtChucvu.binding(dataSource, "Chucvu");
            txtNgaysinh.binding(dataSource, "Ngaysinh");
            txtGioitinh.binding(dataSource, "Gioitinh");
            txtChungchihanhnghe.binding(dataSource, "Chungchihanhnghe");
            txtDiachi.binding(dataSource, "Diachi");
            txtSodienthoai.binding(dataSource, "Sdt");
            txtEmail.binding(dataSource, "Email");
        } 

        private void addStaff()
        {
            string id = txtMaNV.Text.ToString().Trim();
            string tennv = txtTenNV.Text.ToString().Trim();
            string chucvu = txtChucvu.Text.ToString().Trim();
            string ngaysinh = txtNgaysinh.Text.ToString().Trim();
            string gioitinh = txtGioitinh.Text.ToString().Trim();
            string chungchihanhnghe = txtChungchihanhnghe.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string sdt = txtSodienthoai.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();

            string insert = "Insert into tbl_Staff (MaNV, TenNV, Chucvu, Ngaysinh, Gioitinh, Chungchihanhnghe, Diachi, Sdt, Email)" + "" +
                "Values ( @MaNV , @TenNV , @Chucvu , @Ngaysinh , @Gioitinh , @Chungchihanhnghe , @Diachi , @Sdt , @Email)";

            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, tennv, chucvu, ngaysinh, gioitinh, chungchihanhnghe, diachi, sdt, Email });
            if(result>0)
            {
                loadData();
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text.ToString().Trim();
            string del = "Delete From tbl_Staff Where MaNV = @MaNV ";
            int result = Database.Instance.excuteNonQuery(del, new object[] { id });
            if(result>0)
            {
                loadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addStaff();
            btnAdd.enable();
            btnSave.disable();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.disable();
            resetFields();
            btnSave.enable();
            txtMaNV.Focus();
        }
        private void resetFields()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtChucvu.Text = "";
            txtNgaysinh.Text = "";
            txtGioitinh.Text = "";
            txtChungchihanhnghe.Text = "";
            txtDiachi.Text = "";
            txtSodienthoai.Text = "";
            txtEmail.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtMaNV.Text.ToString().Trim();
            string tennv = txtTenNV.Text.ToString().Trim();
            string chucvu = txtChucvu.Text.ToString().Trim();
            string ngaysinh = txtNgaysinh.Text.ToString().Trim();
            string gioitinh = txtGioitinh.Text.ToString().Trim();
            string chungchihanhnghe = txtChungchihanhnghe.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string sdt = txtSodienthoai.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();

            string del = "Update tbl_Staff" + "" +
                "Set TenNV = @TenNV , Chucvu = @Chucvu , Ngaysinh = @Ngaysinh , Gioitinh = @Gioitinh , Chungchihanhnghe = @Chungchihanhnghe , Diachi = @Diachi , Sdt = @Sdt , Email = @Email" + "" +
                " Where MaNV =@MaNV ";
            int result = Database.Instance.excuteNonQuery(del, new object[] { tennv, chucvu, ngaysinh, gioitinh, chungchihanhnghe, diachi, sdt, email });
            if(result>0)
            {
                loadData();
            }

        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dgvNhanvien.ClearSelection();
            dgvNhanvien.CurrentCell = dgvNhanvien[0, 0];
            bindingData();        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvNhanvien.CurrentRow.Index.ToString());
            if(i>0)
            {
                dgvNhanvien.CurrentCell = dgvNhanvien[0, i - 1];
                bindingData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvNhanvien.CurrentRow.Index.ToString());
            if (i<dgvNhanvien.RowCount-1)
            {
                dgvNhanvien.CurrentCell = dgvNhanvien[0, i + 1];
                bindingData();
            }

        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dgvNhanvien.CurrentCell = dgvNhanvien[0, dgvNhanvien.RowCount - 1];
            bindingData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
