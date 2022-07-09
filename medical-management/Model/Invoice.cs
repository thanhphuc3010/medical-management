using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management.DTO
{
    class Invoice
    {
        private string invoiceId;
        private string customerId;
        private string staffId;
        private decimal total;
        private decimal paid;
        private string status = "Pending";
        private DateTime invoiceDate = DateTime.Now;
        private List<InvoiceDetail> listInvoiceDetail = new List<InvoiceDetail>();


        public Invoice(string invoiceId, string customerId, string staffId, DateTime invoiceDate)
        {
            this.invoiceId = invoiceId;
            this.customerId = customerId;
            this.staffId = staffId;
            this.invoiceDate = invoiceDate;
        }

        public Invoice(string invoiceId, string customerId, string staffId, decimal total, 
            decimal paid, string status, DateTime invoiceDate)
        {
            this.invoiceId = invoiceId;
            this.customerId = customerId;
            this.staffId = staffId;
            this.total = total;
            this.paid = paid;
            this.status = status;
            this.invoiceDate = invoiceDate;
        }

        public string InvoiceId { get => invoiceId; set => invoiceId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public string StaffId { get => staffId; set => staffId = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Paid { get => paid; set => paid = value; }
        public string Status { get => status; set => status = value; }
        public DateTime InvoiceDate { get => invoiceDate; set => invoiceDate = value; }
        internal List<InvoiceDetail> ListInvoiceDetail { get => listInvoiceDetail; set => listInvoiceDetail = value; }
    }
}
