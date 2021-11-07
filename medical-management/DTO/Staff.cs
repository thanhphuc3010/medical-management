using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management.DTO
{
    class Staff
    {
        public Staff()
        {
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime Dob { get; set; }
        public bool Sex { get; set; }
        public string CertificateNumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Staff(string id, string name, string role, DateTime dob, bool sex, string certificateNumber, string address, string phone, string email)
        {
            Id = id;
            Name = name;
            Role = role;
            Dob = dob;
            Sex = sex;
            CertificateNumber = certificateNumber;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}
