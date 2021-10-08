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
    public partial class frmThuoc : Form
    {
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
            txtMathuoc.binding(dataSource, "MaThuoc");
            txtManhasanxuat.binding(dataSource, "MaNSX");
            txtTenthuoc.binding(dataSource, "Tenthuoc");
            txtDonvi.binding(dataSource, "Donvi");
            txtHamluong.binding(dataSource, "Hamluong");
            txtSoluong.binding(dataSource, "Soluong");
            txtDonggoi.binding(dataSource, "Donggoi");
            txtThanhphan.binding(dataSource, "Thanhphan");
            txtDongia.binding(dataSource, "Dongia");
            txtGianhap.binding(dataSource, "Gianhap");
            txtNgaysanxuat.binding(dataSource, "Ngaysanxuat");
            txtHsd.binding(dataSource, "Hansudung");
            txtGhichu.binding(dataSource, "Ghichu");

            //txtMathuoc.DataBindings.Clear();
            //txtMathuoc.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Mathuoc"));
            //txtManhasanxuat.DataBindings.Clear();
            //txtManhasanxuat.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "MaNSX"));
            //txtTenthuoc.DataBindings.Clear();
            //txtTenthuoc.DataBindings.Add(new Binding("Text",dgvThuoc.DataSource, "Tenthuoc"));
            //txtDonvi.DataBindings.Clear();
            //txtDonvi.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Donvi"));
            //txtHamluong.DataBindings.Clear();
            //txtHamluong.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Hamluong"));
            //txtSoluong.DataBindings.Clear();
            //txtSoluong.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Soluong"));
            //txtDonggoi.DataBindings.Clear();
            //txtDonggoi.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Donggoi"));
            //txtThanhphan.DataBindings.Clear();
            //txtThanhphan.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Thanhphan"));
            //txtDongia.DataBindings.Clear();
            //txtDongia.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Dongia"));
            //txtGianhap.DataBindings.Clear();
            //txtGianhap.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Gianhap"));
            //txtNgaysanxuat.DataBindings.Clear();
            //txtNgaysanxuat.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Ngaysanxuat"));
            //txtHsd.DataBindings.Clear();
            //txtHsd.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Hansudung"));
            //txtGhichu.DataBindings.Clear();
            //txtGhichu.DataBindings.Add(new Binding("Text", dgvThuoc.DataSource, "Ghichu"));

        }
        private void addItem()
        {
            string id = txtMathuoc.Text.ToString().Trim();
            string manhasanxuat = txtManhasanxuat.Text.ToString().Trim();
            string tenthuoc = txtTenthuoc.Text.ToString().Trim();
            string donvi = txtDonvi.Text.ToString().Trim();
            string hamluong = txtHamluong.Text.ToString().Trim();
            string soluong = txtSoluong.Text.ToString().Trim();
            string donggoi = txtDonggoi.Text.ToString().Trim();
            string thanhphan = txtThanhphan.Text.ToString().Trim();
            string dongia = txtDongia.Text.ToString().Trim();
            string gianhap = txtGianhap.Text.ToString().Trim();
            string ngaysanxuat = txtNgaysanxuat.Text.ToString().Trim();
            string hsd = txtHsd.Text.ToString().Trim();
            string ghichu = txtGhichu.Text.ToString().Trim();

            string insert = "INSERT INTO tbl_Item (MaThuoc, Manhasanxuat, Tenthuoc, Don vi, Ham luong, So luong, Donggoi, Thanhphan, Dongia, Gianhap, Ngaysanxuat, Hsd, Ghi chu)" + "" + "" +
                "VALUES ( @Mathuoc, @MaNSX, @Tenthuoc, @Donvi, @Hamluong, @Soluong, @Donggoi, @Thanhphan, @Dongia, @Gianhap, @Ngaysanxuat, @Hansudung, @Ghichu )";
            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, manhasanxuat, tenthuoc, donvi, hamluong, soluong, donggoi, thanhphan, ngaysanxuat, hsd, ghichu });
            if (result > 0)
            {
                loadData();
            }
        }

        private void resetFields()
        {
            txtMathuoc.Text = "";
            txtManhasanxuat.Text = "";
            txtTenthuoc.Text = "";
            txtDonvi.Text = "";
            txtHamluong.Text = "";
            txtSoluong.Text = "";
            txtDonggoi.Text = "";
            txtThanhphan.Text = "";
            txtNgaysanxuat.Text = "";
            txtHsd.Text = "";
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
            string id = txtMathuoc.Text.ToString().Trim();
            string del = "Delete from tbl_Item Where Mathuoc=@Mathuoc";
            int result = Database.Instance.excuteNonQuery(del, new object[] { id });
            if (result > 0)
            {
                loadData();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            string id = txtMathuoc.Text.ToString().Trim();
            string manhasanxuat = txtManhasanxuat.Text.ToString().Trim();
            string tenthuoc = txtTenthuoc.Text.ToString().Trim();
            string donvi = txtDonvi.Text.ToString().Trim();
            string hamluong = txtHamluong.Text.ToString().Trim();
            string soluong = txtSoluong.Text.ToString().Trim();
            string donggoi = txtDonggoi.Text.ToString().Trim();
            string thanhphan = txtThanhphan.Text.ToString().Trim();
            string dongia = txtDongia.Text.ToString().Trim();
            string gianhap = txtGianhap.Text.ToString().Trim();
            string ngaysanxuat = txtNgaysanxuat.Text.ToString().Trim();
            string hsd = txtHsd.Text.ToString().Trim();
            string ghichu = txtGhichu.Text.ToString().Trim();
            string del = "Update tbl_Item" + "" +
                " Set Manhasanxuat = @MaNSX , Tenthuoc = @Tenthuoc, Don vi = @Donvi , Ham luong = @Hamluong , So luong = @Soluong , Donggoi = @Donggoi , Thanhphan = @Thanhphan , Ngaysanxuat = @Ngaysanxuat, Dongia = @Dongia , Gianhap = @Gianhap , Hsd = @Hansudung , Ghi chu = @Ghichu )" + "" +
                " Where Mathuoc = @Mathuoc";
            int result = Database.Instance.excuteNonQuery(del, new object[] { manhasanxuat, tenthuoc, donvi, hamluong, soluong, donggoi, thanhphan, dongia, gianhap, ngaysanxuat, hsd, ghichu });
            if (result > 0)
            {
                loadData();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            addItem();
            btnAdd.enable();
            btnSave.disable();
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
    }
}

