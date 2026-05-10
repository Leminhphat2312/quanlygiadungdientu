using System;
using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class KhachHangDAL
    {
        static string conn =
        "Data Source=.\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static int LayMaKH(string sdt)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT MaKH FROM KhachHang WHERE SDT = @sdt";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@sdt", sdt);

                con.Open();
                object kq = cmd.ExecuteScalar();

                if (kq != null)
                    return Convert.ToInt32(kq);

                return -1;
            }
        }
        public static int Them(string ten, string sdt, string diaChi, string email)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = @"INSERT INTO KhachHang(TenKH, SDT, DiaChi, Email)
                               OUTPUT INSERTED.MaKH
                               VALUES(@ten, @sdt, @dc, @email)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@dc", diaChi);

                // email có thể null
                cmd.Parameters.AddWithValue("@email",
                    string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);

                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}