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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
            initializeControl();
  
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHTDataSet.tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.qLHTDataSet.tbl_Customer);
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT * FROM tbl_Customer";
            dgvKhachhang.DataSource = Database.Instance.excuteQuery(query);
            bindingData();
        }

        private void initializeControl()
        {
            btnSave.disable();
        }

        private void bindingData()
        {
            object dataSoure = dgvKhachhang.DataSource;

            txtMaKH.binding(dataSoure, "MaKH");
            txtTenKH.binding(dataSoure, "TenKH");
            txtLoaidoituong.binding(dataSoure, "Loaidoituong");
            txtDiachi.binding(dataSoure, "Diachi");
            txtSdt.binding(dataSoure, "Sdt");
            txtEmail.binding(dataSoure, "Email");
            txtGhichu.binding(dataSoure, "Ghichu");

            //txtTenKH.DataBindings.Clear();
            //txtTenKH.DataBindings.Add(new Binding("Text", dgvKhachhang.DataSource, "TenKH"));
            //txtLoaidoituong.DataBindings.Clear();
            //txtLoaidoituong.DataBindings.Add(new Binding("Text", dgvKhachhang.DataSource, "Loaidoituong"));
            //txtDiachi.DataBindings.Clear();
            //txtDiachi.DataBindings.Add(new Binding("Text", dgvKhachhang.DataSource, "Diachi"));
            //txtSdt.DataBindings.Clear();
            //txtSdt.DataBindings.Add(new Binding("Text", dgvKhachhang.DataSource, "Sdt"));
            //txtEmail.DataBindings.Clear();
            //txtEmail.DataBindings.Add(new Binding("Text", dgvKhachhang.DataSource, "Email"));
            //txtGhichu.DataBindings.Clear();
            //txtGhichu.DataBindings.Add(new Binding("Text", dgvKhachhang.DataSource, "Ghichu"));
        }
        //private void Fillcombo()
        //{
        //    string query = "Select Loaidoituong From tbl_Customer";
        //    DataTable data = Database.Instance.excuteQuery(query);
        //    cboLoaidoituong = 'True';
        //    cboLoaidoituong = 'False';
        //}

        private void addCustomer()
        {
            string id = txtMaKH.Text.ToString().Trim();
            string name = txtTenKH.Text.ToString().Trim();
            string type = txtLoaidoituong.Text.ToString().Trim();
            string address = txtDiachi.Text.ToString().Trim();
            string phone = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();
            string note = txtGhichu.Text.ToString().Trim();

            string insert = "INSERT INTO tbl_Customer (MaKH, TenKH, Loaidoituong, Diachi, Sdt, Email, Ghichu)" + "" +
                " VALUES ( @MaKH , @TenKH , @Loaidoituong , @Diachi , @Sdt , @Email , @Ghichu )";

            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, name, type, address, phone, email, note });
            if (result > 0)
            {
                loadData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtMaKH.Text.ToString().Trim();
            string del = "DELETE FROM tbl_Customer WHERE MaKH = @MaKH";
            int result = Database.Instance.excuteNonQuery(del, new object[] { id });
            if (result > 0)
            {
                loadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addCustomer();
            btnAdd.enable();
            btnSave.disable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.disable();
            resetFields();
            btnSave.enable();
            txtMaKH.Focus();
        }

        private void resetFields()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtLoaidoituong.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtGhichu.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtMaKH.Text.ToString().Trim();
            string name = txtTenKH.Text.ToString().Trim();
            string type = txtLoaidoituong.Text.ToString().Trim();
            string address = txtDiachi.Text.ToString().Trim();
            string phone = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();
            string note = txtGhichu.Text.ToString().Trim();
            string del = "UPDATE tbl_Customer" + "" +
                        " SET TenKH = @TenKH , Loaidoituong = @Loaidoituong , Diachi = @Diachi , Sdt = @Sdt , Email = @Email , Ghichu = @Ghichu" + "" +
                        " WHERE MaKH = @MaKH";
            int result = Database.Instance.excuteNonQuery(del, new object[] { name, type, address, phone, email, note, id });
            if (result > 0)
            {
                loadData();
            }
            btnEdit.disable();
            btnSave.enable();
        }
       
        private void btnDau_Click_1(object sender, EventArgs e)
        {
            dgvKhachhang.ClearSelection();
            dgvKhachhang.CurrentCell = dgvKhachhang[0, 0];
            bindingData();
        }

        private void btnTruoc_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvKhachhang.CurrentRow.Index.ToString());
            if (i > 0)
            {
                dgvKhachhang.CurrentCell = dgvKhachhang[0, i - 1];
                bindingData();
            }
        }

        private void btnSau_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvKhachhang.CurrentRow.Index.ToString());
            if (i < dgvKhachhang.RowCount - 1)
            {
                dgvKhachhang.CurrentCell = dgvKhachhang[0, i + 1];
                bindingData();

            }
        }

        private void btnCuoi_Click_1(object sender, EventArgs e)
        {
            dgvKhachhang.CurrentCell = dgvKhachhang[0, dgvKhachhang.RowCount - 1];
            bindingData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

