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
    public partial class frmSelectMedical : Form
    {
        public delegate void passMedical(string id);
        public passMedical medicalPublisher;

        public frmSelectMedical()
        {
            InitializeComponent();
        }

        private void frmSelectMedical_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void initializeUI()
        {
            foreach (DataGridViewRow row in dgvThuoc.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(175, 238, 238);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 255);
                }
            }
        }

        private void loadData()
        {
            string query = "SELECT * FROM tbl_Item";
            DataTable data = Database.Instance.excuteQuery(query);
            dgvThuoc.DataSource = data;
            initializeUI();
        }

        private void dgvKhachhang_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvThuoc.CurrentRow.Index;
            string medicalId = dgvThuoc.Rows[index].Cells["MaThuoc"].Value.ToString();
            medicalPublisher?.Invoke(medicalId);
            this.Close();
        }

        private void dgvThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAddMedical_Click(object sender, EventArgs e)
        {
            frmThuoc f = new frmThuoc();
            f.ShowDialog();
        }
    }
}
