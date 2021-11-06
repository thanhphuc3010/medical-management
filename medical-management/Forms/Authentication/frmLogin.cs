using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using medical_management.BUS;
using medical_management.DTO;

namespace medical_management
{
    public partial class frmLogin : Form
    {
        private string username;
        private string password;
        private bool isLogin = false;
        private string staffId;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password)) return;
            User user = UserBUS.getUser(username, password);
            if (user != null)
            {
                isLogin = true;
                staffId = user.StaffId;
                this.Close();
                Helper.showSuccessMessage(username + "-" + password);
            } else
            {
                Helper.showErrorMessage("Tên đăng nhập hoặc mật khẩu không chính xác, vui lòng thử lại!");
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogin)
            {
                Application.Exit();
            } else
            {
                frmHTPPharmacy f = (frmHTPPharmacy)Owner;
                f.staffId = this.staffId;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            username = txtUserName.Text.Trim();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text.Trim();
        }
    }
}
