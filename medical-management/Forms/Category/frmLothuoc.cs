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
    public partial class frmLothuoc : Form
    {
        public frmLothuoc()
        {
            InitializeComponent();
        }

        private void frmLothuoc_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string query = "Select * From tbl_Consignment";
            dgvLothuoc.DataSource = Database.Instance.excuteQuery(query);
            
        }
        
    }
}
