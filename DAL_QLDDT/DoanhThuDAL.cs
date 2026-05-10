using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class DoanhThuDAL
    {
        static string conn = @"Data Source=.\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static DataTable LayDoanhThu(DateTime tu, DateTime den)
        {
            SqlConnection con = new SqlConnection(conn);

            string sql = @"SELECT MaHD, MaKH, NgayLap, TongTien, PhuongThucTT
                           FROM HoaDon
                           WHERE NgayLap BETWEEN @Tu AND @Den";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.SelectCommand.Parameters.AddWithValue("@Tu", tu);
            da.SelectCommand.Parameters.AddWithValue("@Den", den);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}