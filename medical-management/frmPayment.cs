using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace medical_management
{
    public partial class frmPayment : Form
    {
        public delegate void handlePaymented(bool isPaymented);
        public handlePaymented publisher;
        private string customerId;
        private string invoiceId;
        private decimal total;
        private decimal needToPay = 0M;
        public frmPayment()
        {
            InitializeComponent();
        }

        public frmPayment(string customerId, string invoiceId, decimal total)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.invoiceId = invoiceId;
            this.total = total;
        }

        public void initializePaymentMethodCombobox()
        {
            cbPaymentMethod.SelectedIndex = 0;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            initializePaymentMethodCombobox();
            loadCustomer();
            loadTotal();
        }

        private void loadCustomer()
        {
            string query = "SELECT TenKH FROM tbl_Customer WHERE MaKH = @MaKH";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { customerId });
            lblCustomer.Text = data.Rows[0]["TenKH"].ToString();
        }

        private void loadTotal()
        {
            needToPay = total - getPaymented();
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTotal.Text = needToPay.ToString("c", culture);
            //lblTotal.formatCurrency(total);
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            doSavePayment();
        }

        private decimal getPaymented()
        {
            string query = "SELECT SUM(SoTienTT) FROM dbo.tbl_Payment WHERE MaHD = @MaHD";
            var result = Database.Instance.ExecuteScalar(query, new object[] { invoiceId });
            if (result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            else
            {
                return 0M;
            }
        }


        private void doSavePayment()
        {
            decimal payment = Convert.ToDecimal(txtPayment.Text);
            string method = cbPaymentMethod.SelectedItem.ToString();
            string note = txtPaymentNote.Text.ToString();

            if (payment > needToPay)
            {
                return;
            }

            string insert = "INSERT INTO tbl_Payment(MaHD, SoTienTT, PhuongThucTT, NoidungTT) " +
                " VALUES( @MaHD , @SoTienTT , @PhuongThucTT , @NoidungTT ) ";
            Database.Instance.excuteNonQuery(insert, new object[] { invoiceId, payment, method, note });
            publisher?.Invoke(true);
            this.Close();
        }

        private void lblTotal_DoubleClick(object sender, EventArgs e)
        {
            txtPayment.Text = needToPay.ToString();
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Controls.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
