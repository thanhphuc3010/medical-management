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
    public partial class frmNhasanxuat : Form
    {
        public frmNhasanxuat()
        {
            InitializeComponent();
            initializeControl();

        }

        private void frmNhasanxuat_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = "Select * From tbl_make";
            dgvNhasanxuat.DataSource = Database.Instance.excuteQuery(query);
            bindingData();
            
        }
        private void initializeControl()
        {
            btnSave.disable();
        }
        private void bindingData()
        {
            object dataSource = dgvNhasanxuat.DataSource;

            txtMaNSX.binding(dataSource, "MaNSX");
            txtTenNSX.binding(dataSource, "TenNSX");
            txtDiachi.binding(dataSource, "Diachi");
            txtSdt.binding(dataSource, "Sdt");
            txtEmail.binding(dataSource, "Email");
        }

        private void addMake()
        {
            string id = txtMaNSX.Text.ToString().Trim();
            string tennsx = txtTenNSX.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string sdt = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();

            string insert = "Insert into tbl_make ( MaNSX, TenNSX, Diachi, Sdt, Email)" + "" +
                "Values ( @MaNSX, @TenNSX , @Diachi , @Sdt , @Email)";

            int result = Database.Instance.excuteNonQuery(insert, new object[] { id, tennsx, diachi, sdt, email });
            if(result>0)
            {
                loadData();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtMaNSX.Text.ToString().Trim();
            string del = "Delete From tbl_make Where MaNSX = @MaNSX";
            int result = Database.Instance.excuteNonQuery(del, new object[] { id });
            if (result > 0)
            {
                loadData();
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addMake();
            btnAdd.enable();
            btnSave.disable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.disable();
            resetFields();
            btnSave.enable();
            txtMaNSX.Focus();
        }
        private void resetFields()
        {
            txtMaNSX.Text = "";
            txtTenNSX.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtMaNSX.Text.ToString().Trim();
            string tennsx = txtTenNSX.Text.ToString().Trim();
            string diachi = txtDiachi.Text.ToString().Trim();
            string sdt = txtSdt.Text.ToString().Trim();
            string email = txtEmail.Text.ToString().Trim();

            string del = "Update tbl_make" + "" +
                " Set TenNSX = @TenNSX , Diachi = @Diachi , Sdt = @Sdt , Email = @Email" + "" +
                " Where MaNSX = @MaNSX";
            int result = Database.Instance.excuteNonQuery(del, new object[] { tennsx, diachi, sdt, email });
            if(result>0)
            {
                loadData();
            }
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            dgvNhasanxuat.ClearSelection();
            dgvNhasanxuat.CurrentCell = dgvNhasanxuat[0, 0];
            bindingData();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvNhasanxuat.CurrentRow.Index.ToString());
            if(i>0)
            {
                dgvNhasanxuat.CurrentCell = dgvNhasanxuat[0, i - 1];
                bindingData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(dgvNhasanxuat.CurrentRow.Index.ToString());
            if (i < dgvNhasanxuat.RowCount-1)
            {
                dgvNhasanxuat.CurrentCell = dgvNhasanxuat[0, i + 1];
                bindingData();
            }
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            dgvNhasanxuat.CurrentCell = dgvNhasanxuat[0, dgvNhasanxuat.RowCount - 1];
            bindingData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
