using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public partial class frmDSPN : Form
    {
        public frmDSPN()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPhieunhap f = new frmPhieunhap(this);
            f.reloadPOEventHandler += refreshEventHandler;
            f.ShowDialog();
        }

        private void refreshEventHandler(object sender, frmPhieunhap.ReloadPOEventArgs args)
        {
            loadlistPO();
        }

        private void frmDSPN_Load(object sender, EventArgs e)
        {
            loadlistPO();
        }

        private void initializeUI()
        {
            foreach (DataGridViewRow row in dgvDSPN.Rows)
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

        private void loadlistPO()
        {
            string query = "SELECT Manhap, Ngaynhap, MaNV, MaNCC, Soluonglo, Tongtien, Thue FROM dbo.tbl_PurchaseOrder";
            DataTable data = Database.Instance.excuteQuery(query);
            dgvDSPN.DataSource = data;
            initializeUI();

            if (!dgvDSPN.Rows[0].IsNewRow)
            {
                loadPODetailById(dgvDSPN.Rows[0].Cells["Manhap"].Value.ToString());
            }
        }

        private void loadPODetailById(string poId)
        {
            string query =
                "SELECT a.Malo, b.Mathuoc, b.Donvi, a.Soluong, a.Gianhap , (a.Soluong * a.Gianhap) AS Thanhtien " +
                "FROM dbo.tbl_Consignment a Inner Join dbo.tbl_Item b " +
                "ON a.Mathuoc = b.Mathuoc Where Manhap = @Manhap ";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { poId });

            dgvPNCT.DataSource = data;
        }

        private void dgvDSPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string poId = Convert.ToString(dgvDSPN.Rows[e.RowIndex].Cells[0].Value);

                loadPODetailById(poId);
            }
            else
            {
                initializeUI();
            }
        }

        private void dgvDSPN_Sorted(object sender, EventArgs e)
        {
            initializeUI();
        }
    }
}
