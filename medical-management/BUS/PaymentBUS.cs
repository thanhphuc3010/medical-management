using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using medical_management.DTO;

namespace medical_management.BUS
{
    class PaymentBUS
    {
        public static List<Payment> GetPayments(string invoiceId)
        {
            List<Payment> result = new List<Payment>();
            string query = "SELECT * FROM dbo.tbl_Payment WHERE MaHD = @MaHD";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { invoiceId });

            foreach (DataRow row in data.Rows)
            {
                int id = Convert.ToInt32(row["MaTT"]);
                DateTime paymentDate = Convert.ToDateTime(row["NgayTT"]);
                decimal paid = Convert.ToDecimal(row["SoTienTT"]);
                string paymentMethod = row["PhuongThucTT"].ToString();
                string note = row["NoidungTT"].ToString();

                Payment payment = new Payment(id, invoiceId, paymentDate, paid, paymentMethod, note);
                result.Add(payment);
            }
            return result;
        }

        public static DataTable getPayments(string invoiceId)
        {
            string query = "SELECT a.PhuongThucTT, a.NgayTT, a.SoTienTT, a.NoidungTT FROM tbl_Payment a WHERE MaHD = @MaHD";
            return Database.Instance.excuteQuery(query, new object[] { invoiceId });
        }

        public static bool deleteAllPaymentByInvoiceId(string invoiceId)
        {
            try
            {
                string delete = "DELETE FROM dbo.tbl_Payment WHERE MaHD = @MaHD";
                Database.Instance.excuteNonQuery(delete, new object[] { invoiceId });
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static void addPayment(Payment payment)
        {
            string insert = "INSERT INTO dbo.tbl_Payment(MaHD, NgayTT, SoTienTT, PhuongThucTT, NoidungTT) " +
                            "VALUES(@MaHD, @NgayTT)";
        }
    }
}
