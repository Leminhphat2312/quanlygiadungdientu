using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class GioHangDAL
    {
        static string conn =
        "Data Source=.\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";
        public static DataTable LayDanhSach()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM GioHang";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static void Them(string Ma_SP, string Ten_SP, decimal gia, int soLuong)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = @"INSERT INTO GioHang(Ma_SP, Ten_SP, GiaBan, SoLuong)
                               VALUES(@Ma_SP, @Ten_SP, @GiaBan, @SoLuong)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ma_SP", Ma_SP);
                cmd.Parameters.AddWithValue("@Ten_SP", Ten_SP);
                cmd.Parameters.AddWithValue("@GiaBan", gia);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static bool KiemTraTonTai(string Ma_SP)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT COUNT(*) FROM GioHang WHERE Ma_SP = @Ma_SP";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ma_SP", Ma_SP);

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
        public static void TangSoLuong(string Ma_SP)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = @"UPDATE GioHang 
                               SET SoLuong = SoLuong + 1
                               WHERE Ma_SP = @Ma_SP";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ma_SP", Ma_SP);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void CapNhatSoLuong(string Ma_SP, int soLuong)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                if (soLuong <= 0)
                {
                    string sqlDelete = "DELETE FROM GioHang WHERE Ma_SP = @Ma_SP";
                    SqlCommand cmdDelete = new SqlCommand(sqlDelete, con);
                    cmdDelete.Parameters.AddWithValue("@Ma_SP", Ma_SP);
                    cmdDelete.ExecuteNonQuery();
                }
                else
                {
                    string sqlUpdate = @"UPDATE GioHang 
                                         SET SoLuong = @SoLuong
                                         WHERE Ma_SP = @Ma_SP";

                    SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);
                    cmdUpdate.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmdUpdate.Parameters.AddWithValue("@Ma_SP", Ma_SP);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }
        public static void Xoa(string Ma_SP)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "DELETE FROM GioHang WHERE Ma_SP = @Ma_SP";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Ma_SP", Ma_SP);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void Clear()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "DELETE FROM GioHang";

                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static decimal TongTien()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT SUM(GiaBan * SoLuong) FROM GioHang";

                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                    return 0;

                return Convert.ToDecimal(result);
            }
        }
    }
}