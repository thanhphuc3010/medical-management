using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management.DTO
{
    class Payment
    {
        private int Id { get; set; }
        private string InvoiceId { get; set; }
        private DateTime PaymentDate { get; set; }
        private decimal Paid { get; set; }
        private string PaymentMethod { get; set; }
        private string Note { get; set; }

        public Payment(int id, string invoiceId, DateTime paymentDate, decimal paid, string paymentMethod, string note)
        {
            Id = id;
            InvoiceId = invoiceId;
            PaymentDate = paymentDate;
            Paid = paid;
            PaymentMethod = paymentMethod;
            Note = note;
        }
    }
}
