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
    public partial class frmNhacungcap : Form
    {
        public frmNhacungcap()
        {
            InitializeComponent();
            initializeControl();
        }

        private void frmNhacungcap_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = "Select * From tbl_Supplier";
            dgvNhacungcap.DataSource = Database.Instance.excuteQuery(query);
            bindingData();
        }
        private void initializeControl()
        {
            btnSave.disable();
        }
        private void bindingData()
        {
            object dataSource = dgvNhacungcap.DataSource;
            txtMaNCC.binding(dataSource, "MaNCC");
            txtTenNCC.binding(dataSource, "TenNCC");
            txtDiachi.binding(dataSource, "Diachi");
            txtSdt.binding(dataSource, "Sdt");
            txtEmail.binding(dataSource, "Email");
        }
        private void addSupplier()
        {
            string id = txtMaNCC.Text.ToString().Trim();
            string tenncc = txtTenNCC.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string sdt = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();

            string insert = "Insert into tbl_Supplier ( MaNCC, TenNCC, Diachi, Sdt, Email)" + "" +
                "Values ( @MaNCC , @TenNCC , @Diachi , @ Sdt , @Email )";

            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, tenncc, diachi, sdt, email });
            if(result>0)
            {
                loadData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtMaNCC.Text.ToString().Trim();
            string del = "Delete From tbl_Supplier Where MaNCC = @MaNCC";
            int result = Database.Instance.excuteNonQuery(del, new object[] { id });
            if(result>0)
            {
                loadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addSupplier();
            btnAdd.enable();
            btnSave.disable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.disable();
            resetFields();
            btnSave.enable();
            txtMaNCC.Focus();
        }

        private void resetFields()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtMaNCC.Text.ToString().Trim();
            string tenncc = txtTenNCC.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string sdt = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();

            string del = "Update tbl_Suppiler" + "" +
                "Set MaNCC = @MaNCC , TenNCC = @TenNCC , Diachi = @Diachi , Sdt = @Sdt , Email = @Email" + "" +
                "Where MaNCC = @MaNCC ";
            int result = Database.Instance.excuteNonQuery(del, new object[] { tenncc, diachi, sdt, email });
            if(result>0)
            {
                loadData();
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dgvNhacungcap.ClearSelection();
            dgvNhacungcap.CurrentCell = dgvNhacungcap[0, 0];
            bindingData();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvNhacungcap.CurrentRow.Index.ToString());
            if(i>0)
            {
                dgvNhacungcap.CurrentCell = dgvNhacungcap[0, i - 1];
                bindingData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvNhacungcap.CurrentRow.Index.ToString());
            if (i<dgvNhacungcap.RowCount-1)
            {
                dgvNhacungcap.CurrentCell = dgvNhacungcap[0, i +1];
                bindingData();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dgvNhacungcap.CurrentCell = dgvNhacungcap[0, dgvNhacungcap.RowCount - 1];
            bindingData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
