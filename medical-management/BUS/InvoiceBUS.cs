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
        public static DataTable getInvoiceById(string id)
        {
            string query = "SELECT a.*, b.TenKH " +
                "FROM dbo.tbl_Invoice a INNER JOIN dbo.tbl_Customer b " +
                "ON a.MaKH = b.MaKH " +
                "WHERE MaHD = @MaHD";
            return Database.Instance.excuteQuery(query, new object[] { id });
        }

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
                //result["count"] = 0;
                //result["total"] = 0;
                //result["payment"] = 0;
                //return result;
                query = "SELECT COUNT(*) AS count, SUM(Tongtien) AS total, SUM(Dathanhtoan) AS payment FROM dbo.tbl_Invoice " +
                           "WHERE NgayHD BETWEEN @FromDate AND @ToDate";
            } else
            {
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

        public static void setInvoiceStatus(string status, string invoiceId)
        {
            string update = "UPDATE dbo.tbl_Invoice SET Trangthaihoadon = @Trangthaihoadon " +
                                "WHERE MaHD = @MaHD";
            Database.Instance.excuteNonQuery(update, new object[] { status, invoiceId });
        }

        public static DataTable getInvoiceDetailById(string invoiceId)
        {
            string query =
                "SELECT a.Mathuoc, b.Tenthuoc, b.Donvi, a.Soluong, a.Dongia, (a.Soluong * a.Dongia) AS Thanhtien " +
                "FROM dbo.tbl_InvoiceDetail a, dbo.tbl_Item b " +
                "WHERE a.Mathuoc = b.Mathuoc " +
                "AND MaHD = @MaHD ";
            return Database.Instance.excuteQuery(query, new object[] { invoiceId });
        }

        public static DataTable getInvoiceSummary(DateTime from, DateTime to)
        {
            string querySummary =
                "SELECT DISTINCT Trangthaihoadon, COUNT(Trangthaihoadon) AS Soluong " +
                "FROM dbo.tbl_Invoice " +
                "WHERE NgayHD BETWEEN @FromDate AND @ToDate " +
                "GROUP BY Trangthaihoadon";

            return Database.Instance.excuteQuery(querySummary, new object[] { from, to });
        }

        public static DataTable getAllInvoiceToNow(DateTime from, DateTime to)
        {
            string query =
                "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                "AND NgayHD BETWEEN @FromDate AND @ToDate ";
            return Database.Instance.excuteQuery(query, new object[] { from, to });
        }

        public static DataTable getInvoiceWithFilter(DateTime from, DateTime to, List<string> listStatus)
        {
            string query =
                    "SELECT a.MaHD, a.NgayHD, a.Tongtien, (a.Tongtien - a.Dathanhtoan) AS Conthieu, a.Trangthaihoadon, b.TenKH, b.Sdt, c.TenNV " +
                    "FROM dbo.tbl_Invoice a, dbo.tbl_Customer b, dbo.tbl_Staff c " +
                    "WHERE a.MaKH = b.MaKH AND a.MaNV = c.MaNV " +
                    "AND NgayHD BETWEEN @FromDate AND @ToDate " +
                    "AND Trangthaihoadon IN (";
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

            return Database.Instance.excuteQuery(query, new object[] { from, to });
        }
    }
}
