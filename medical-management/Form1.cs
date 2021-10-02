namespace medical_management
{
    using System.Data;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            //string demo = "demo to conflict";
            //string pull = "demo pull code";

            //string insert = "INSERT INTO tbl_CTHD (SoHD, MaThuoc, SoLuong, DonGia) VALUES (@SoHD , @MaThuoc , @SoLuong , @DonGia)";
            //int count = Database.Instance.excuteNonQuery(insert, new object[] { demo, pull, 1, 10000 });
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            loadData();
            btnDemo.disable();
            btnDemo.gone();
            lblDemo.gone();
            txtDemo.gone();
            
        }

        private void loadData()
        {
            string query = "SELECT * FROM tbl_Thuoc WHERE MaThuoc = @MaThuoc";
            string medicalId = "2020BD13";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { medicalId });
            dgvMedical.DataSource = data;
        }

        private void btnDemo_Click(object sender, System.EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, System.EventArgs e)
        {
            bool isVisible = txtDemo.isVisible();
            txtDemo.visibleOrGone(isVisible);
        }
    }
}
