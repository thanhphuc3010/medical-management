using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using medical_management.DTO;

namespace medical_management.BUS
{
    class UserBUS
    {
        public static User getUser(string username, string password)
        {
            User user = new User();
            string query = "SELECT * FROM dbo.tbl_User WHERE Tenuser = @Tenuser AND Matkhau = @Matkhau";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { username, password });
            if (data.Rows.Count == 1)
            {
                user.StaffId = data.Rows[0]["MaNV"].ToString().Trim();
                user.Username = data.Rows[0]["Tenuser"].ToString().Trim();
                user.Password = data.Rows[0]["Matkhau"].ToString().Trim();
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
