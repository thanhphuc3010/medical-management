namespace medical_management
{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        bool role;
        public Form1()
        {
            InitializeComponent();
            //string demo = "demo to conflict";
            //string pull = "demo pull code";

            //string insert = "INSERT INTO tbl_CTHD (SoHD, MaThuoc, SoLuong, DonGia) VALUES (@SoHD , @MaThuoc , @SoLuong , @DonGia)";
            //int count = Database.Instance.excuteNonQuery(insert, new object[] { demo, pull, 1, 10000 });
        }

        public Form1(bool role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //loadData();
            //btnDemo.disable();
            //btnDemo.gone();
            //lblDemo.gone();
            //txtDemo.gone();



        }

        private void loadData()
        {
            //string query = "SELECT * FROM tbl_Thuoc WHERE MaThuoc = @MaThuoc";
            //string medicalId = "2020BD13";
            //DataTable data = Database.Instance.excuteQuery(query, new object[] { medicalId });
            //dgvMedical.DataSource = data;

            // Comment selection code => Ctrl K + Ctrl C
            // Uncomment selection code => Ctrl K + Ctrl U
            // Format code => Ctrl K + Ctrl D
        }

        private void btnDemo_Click(object sender, System.EventArgs e)
        {
            if (role != true)
            {
                string name = "Phúc";
            }
        }

        private void btnShow_Click(object sender, System.EventArgs e)
        {
            bool isVisible = txtDemo.isVisible();
            txtDemo.visibleOrGone(isVisible);
            lblDemo.visibleOrGone(isVisible);
        }

        private void btnRole_Click(object sender, System.EventArgs e)
        {
            if (role == Role.ROLE_MANAGE)
            {
                btnRole.enable();
            }
            else
            {
                //string message = "Bạn không có quyền sử dụng chức năng này!";
                Helper.showMessageRole();
            }
        }
    }
}
