using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management.BUS
{
    class InvoiceBUS
    {
        public static void deleteInvoiceDetail(string id)
        {
            string delete = "DELETE FROM tbl_InvoiceDetail WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(delete, new object[] { id });
        }

        public static void deleteInvoicePayment(string id)
        {
            string delete = "DELETE FROM tbl_Payment WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(delete, new object[] { id });
        }

        public static void deleteInvoice(string id)
        {
            string delete = "DELETE FROM tbl_Invoice WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(delete, new object[] { id });
        }

        public static int getInvoiceCount()
        {
            string query = "SELECT COUNT(*) FROM dbo.tbl_Invoice";
            int count = Convert.ToInt32(Database.Instance.ExecuteScalar(query));
            return count;
        }

        public static decimal getInvoiceTotal()
        {
            string query = "SELECT SUM(Tongtien) FROM dbo.tbl_Invoice";
            decimal total = Convert.ToDecimal(Database.Instance.ExecuteScalar(query));
            return total;
        }

        public static decimal getInvoicePayment()
        {
            string query = "SELECT SUM(Dathanhtoan) FROM dbo.tbl_Invoice";
            decimal payment = Convert.ToDecimal(Database.Instance.ExecuteScalar(query));
            return payment;
        }

        public static decimal getInvoiceReceivable()
        {
            string query = "SELECT SUM(Tongtien - Dathanhtoan) FROM dbo.tbl_Invoice";
            decimal receivable = Convert.ToDecimal(Database.Instance.ExecuteScalar(query));
            return receivable;
        }

        public static Dictionary<string, object> getPaymentSatatic()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            string query = "SELECT COUNT(*) AS count, SUM(Tongtien) AS total, SUM(Dathanhtoan) AS payment FROM dbo.tbl_Invoice";
            DataTable data = Database.Instance.excuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                var count = data.Columns[0].ColumnName;
                var total = data.Columns[1].ColumnName;
                var payment = data.Columns[2].ColumnName;
                result[count] = row[count];
                result[total] = row[total];
                result[payment] = row[payment];
            }
            return result;
        }

        public static Dictionary<string, object> getPaymentSataticByFilter(DateTime from, DateTime to, List<string> listStatus)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            string query = "SELECT COUNT(*) AS count, SUM(Tongtien) AS total, SUM(Dathanhtoan) AS payment FROM dbo.tbl_Invoice " +
                           "WHERE NgayHD BETWEEN @FromDate AND @ToDate " +
                           "AND Trangthaihoadon IN (";

            if (listStatus.Count == 0)
            {
                result["count"] = 0;
                result["total"] = 0;
                result["payment"] = 0;
                return result;
            }

            var lastItem = listStatus.Last();

            foreach (string status in listStatus)
            {
                if (!status.Equals(lastItem))
                {
                    query += "N'" + status + "', ";
                }
                else
                {
                    query += "N'" + status + "')";
                }

            }

            DataTable data = Database.Instance.excuteQuery(query, new object[] { from, to });
            foreach (DataRow row in data.Rows)
            {
                var count = data.Columns[0].ColumnName;
                var total = data.Columns[1].ColumnName;
                var payment = data.Columns[2].ColumnName;
                result[count] = (row[count] as int?) ?? 0;
                result[total] = (row[total] != DBNull.Value) ? row[total] : 0;
                result[payment] = (row[payment] != DBNull.Value) ? row[payment] : 0;
            }
            return result;
        }

    }
}
