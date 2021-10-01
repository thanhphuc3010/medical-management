namespace medical_management
{
    using System.Data;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            string demo = "demo to conflict";
            string pull = "demo pull code";

            string insert = "INSERT INTO tbl_CTHD (SoHD, MaThuoc, SoLuong, DonGia) VALUES (@SoHD , @MaThuoc , @SoLuong , @DonGia)";
            int count = Database.Instance.excuteNonQuery(insert, new object[] { demo, pull, 1, 10000 });
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            string demo = "phucpt change file to get conflict";
        }
    }
}
