using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using medical_management.DTO;

namespace medical_management.BUS
{
    class StaffBUS
    {
        public static Staff getStaffById(string id)
        {
            Staff staff = new Staff();
            string query = "SELECT * FROM dbo.tbl_Staff WHERE MaNV = @MaNV";
            DataTable data = Database.Instance.excuteQuery(query, new object[] { id });
            if (data.Rows.Count == 1)
            {
                staff.Id = data.Rows[0]["MaNV"].ToString().Trim();
                staff.Name = data.Rows[0]["TenNV"].ToString().Trim();
                staff.Role = data.Rows[0]["Chucvu"].ToString().Trim();
                staff.Dob = Convert.ToDateTime(data.Rows[0]["Ngaysinh"]);
                staff.Sex = (data.Rows[0]["Gioitinh"] != DBNull.Value) ? Convert.ToBoolean(data.Rows[0]["Gioitinh"]) : false;
                staff.CertificateNumber = data.Rows[0]["Chungchihanhnghe"].ToString().Trim();
                staff.Address = data.Rows[0]["Diachi"].ToString().Trim();
                staff.Email = data.Rows[0]["Email"].ToString().Trim();
                staff.Phone = data.Rows[0]["Sdt"].ToString().Trim();
                return staff;
            }
            else
            {
                return null;
            }
        }
    }
}
