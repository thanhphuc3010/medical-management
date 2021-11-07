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

        public static void loadListInvoice(string query, object[] param)
        {
            
        }
    }
}
