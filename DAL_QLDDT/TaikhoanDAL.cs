using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLDDT;

namespace DAL_QLDDT
{
    public class TaikhoanDAL
    {
        private static string connectionString =
        "Data Source=.\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static bool Kiemtradangnhap(TaikhoanDTO tk, out int maNV, out string tenNV)
        {
            maNV = 0;
            tenNV = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT Ma_NV, Ten_NV 
                               FROM NhanVien 
                               WHERE Username = @user 
                               AND Password = @pass 
                               AND TrangThai = 1";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", tk.Username);
                cmd.Parameters.AddWithValue("@pass", tk.Password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    maNV = Convert.ToInt32(reader["Ma_NV"]); 
                    tenNV = reader["Ten_NV"].ToString();
                    return true;
                }
                return false;
            }
        }
        public static bool DangKy(string username, string password, string tenNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO NhanVien (Ten_NV, Username, Password, TrangThai)
                       VALUES (@ten, @user, @pass, 1)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ten", tenNV);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();

                return kq > 0;
            }
        }
        public static bool KiemTraTonTai(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE Username = @user";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", username);

                conn.Open();
                int kq = (int)cmd.ExecuteScalar();

                return kq > 0;
            }
        }
    }
}