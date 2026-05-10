using System;
using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class HoaDonDAL
    {
        static string conn =
        "Data Source=.\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static int ThemHoaDon(
            int maKH,
            decimal tongTien,
            string pttt)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = @"
                INSERT INTO HoaDon
                (
                    MaKH,
                    TongTien,
                    PhuongThucTT
                )

                OUTPUT INSERTED.MaHD

                VALUES
                (
                    @MaKH,
                    @TongTien,
                    @PTTT
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                cmd.Parameters.AddWithValue("@PTTT", pttt);

                con.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}