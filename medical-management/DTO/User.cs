using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medical_management.DTO
{
    class User
    {
        public string StaffId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string staffId, string username, string password)
        {
            StaffId = staffId;
            Username = username;
            Password = password;
        }

        public User()
        {
        }


    }
}
