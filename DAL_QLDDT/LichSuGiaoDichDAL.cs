using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class LichSuGiaoDichDAL
    {
        static string conn = @"Data Source=.\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static DataTable LayLSGD(DateTime tu, DateTime den)
        {
            SqlConnection con = new SqlConnection(conn);

            string sql = @"SELECT MaHD, MaKH, NgayLap, TongTien, PhuongThucTT, TrangThai
                           FROM HoaDon
                           WHERE TrangThai = 1
                           AND NgayLap BETWEEN @Tu AND @Den";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.SelectCommand.Parameters.AddWithValue("@Tu", tu);
            da.SelectCommand.Parameters.AddWithValue("@Den", den);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}