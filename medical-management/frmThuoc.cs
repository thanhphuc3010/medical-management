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
            string demo = "demo code";
            string medical = "Medical infor";
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {

        }

        // chữ đầu tiên của từ đầu tiên viết thường, các chữ đầu tiên của các từ tiếp theo viết hoa, các từ viết liền không dấu

        private void loadData()
        {
            string query = "SELECT * FROM tbl_Item";
            DataTable data = Database.Instance.excuteQuery(query);
            dgvThuoc.DataSource = data;
        }
    }
}
