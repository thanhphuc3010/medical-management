using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management.DTO
{
    class InvoiceDetail
    {
        private string invoiceId;
        private string medicineId;
        private int quantity;
        private decimal price;
        private DateTime createdDate = DateTime.Now;
        private DateTime updatedDate = DateTime.Now;

        public InvoiceDetail(string invoiceId, string medicineId, int quantity, decimal price)
        {
            this.invoiceId = invoiceId;
            this.medicineId = medicineId;
            this.quantity = quantity;
            this.price = price;
        }

        public string InvoiceId { get => invoiceId; set => invoiceId = value; }
        public string MedicineId { get => medicineId; set => medicineId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public DateTime UpdatedDate { get => updatedDate; set => updatedDate = value; }
    }
}