﻿using medical_management.Source.Utils;
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
    public partial class frmKhachhang : Form
    {
        private readonly frmSelectCustomer frmSelectCustomer;
        private string customerId;

        public frmKhachhang(frmSelectCustomer frmSelectCustomer)
        {
            InitializeComponent();
            this.frmSelectCustomer = frmSelectCustomer;
            initializeControl();

        }
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
            string query = "SELECT MaKH, TenKH, Diachi, Sdt, Email, Ghichu FROM tbl_Customer";
            dgvKhachhang.DataSource = Database.Instance.excuteQuery(query);
            bindingData();
        }

        private string createCustomerId()
        {
            string query = "SELECT TOP 1 MaKH FROM tbl_Customer ORDER BY MaKH DESC";
            return Helper.createCustomerId("KH", query, "MaKH");
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
            txtDiachi.binding(dataSoure, "Diachi");
            txtSdt.binding(dataSoure, "Sdt");
            txtEmail.binding(dataSoure, "Email");
            txtGhichu.binding(dataSoure, "Ghichu");
        }
      

        private void addCustomer()
        {
            string id = txtMaKH.Text.ToString().Trim();
            string name = txtTenKH.Text.ToString().Trim();
            string address = txtDiachi.Text.ToString().Trim();
            string phone = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();
            string note = txtGhichu.Text.ToString().Trim();

            string insert = "INSERT INTO tbl_Customer ( MaKH, TenKH, Diachi, Sdt, Email, Ghichu)" + "" +
                " VALUES ( @MaKH , @TenKH , @Diachi , @Sdt , @Email , @Ghichu )";

            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, name, address, phone, email, note });

            if (frmSelectCustomer != null)
            {
                frmSelectCustomer.refreshDataGrid();
                this.Close();
            }

            if (result > 0)
            {
                loadData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteCustomerWithConfirm();
        }

        private void deleteCustomerWithConfirm()
        {
            string message = "Bạn có chắc chắn muốn xóa khách hàng này không?";
            Helper.showDialogConfirmDelete(message, deleteCustomer);

        }


        private void deleteCustomer()
        {
            string id = txtMaKH.Text.ToString().Trim();
            string del = "Delete from tbl_Customer Where MaKH = @MaKH ";
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
                    Helper.showErrorMessage("Khách hàng này đã có giao dịch. Không thể xóa!");
                }
                else throw;
            }
            MessageBox.Show("Đã xóa thành công!", "Thông báo");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addCustomer();
            btnAdd.enable();
            btnSave.disable();
            MessageBox.Show("Đã lưu thành công!", "Thông báo");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.disable();
            resetFields();
            this.customerId = createCustomerId();
            txtMaKH.Text = this.customerId;
            txtMaKH.SetTextColorReadOnly(MyColor.primary);
            btnSave.enable();
            txtMaKH.Focus();
        }

        private void resetFields()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtGhichu.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtMaKH.Text.ToString().Trim();
            string name = txtTenKH.Text.ToString().Trim();
            string address = txtDiachi.Text.ToString().Trim();
            string phone = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();
            string note = txtGhichu.Text.ToString().Trim();
            string del = "UPDATE tbl_Customer" + "" +
                        " SET TenKH = @TenKH , Diachi = @Diachi , Sdt = @Sdt , Email = @Email , Ghichu = @Ghichu" + "" +
                        " WHERE MaKH = @MaKH";
            int result = Database.Instance.excuteNonQuery(del, new object[] { name, address, phone, email, note, id });
            if (result > 0)
            {
                loadData();
            }
            MessageBox.Show("Đã cập nhật thành công!", "Thông báo");
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

