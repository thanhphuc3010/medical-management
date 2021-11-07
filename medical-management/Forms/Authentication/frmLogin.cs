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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUserName.Text.ToString().Trim();
            string phone = txtPassword.Text.ToString().Trim();

            string query = "SELECT MaKH, Sdt, Loaidoituong FROM tbl_Customer WHERE MaKH = @MaKH AND Sdt = @Sdt";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { id, phone });

            int count = data.Rows.Count;
            if (count == 1)
            {
                bool role = Convert.ToBoolean(data.Rows[0]["Loaidoituong"]);
                
            }
        }
    }
}
