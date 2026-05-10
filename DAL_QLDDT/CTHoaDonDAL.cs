using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class CTHoaDonDAL
    {
        static string conn =
        "Data Source=.\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static void Them(
            int maHD,
            string Ma_SP,
            string Ten_SP,
            decimal giaBan,
            int soLuong,
            decimal thanhTien)
        {
            using (SqlConnection con =
                new SqlConnection(conn))
            {
                string sql = @"
                INSERT INTO CTHoaDon
                (
                    MaHD,
                    Ma_SP,
                    Ten_SP,
                    GiaBan,
                    SoLuong,
                    ThanhTien
                )

                VALUES
                (
                    @MaHD,
                    @Ma_SP,
                    @Ten_SP,
                    @GiaBan,
                    @SoLuong,
                    @ThanhTien
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@Ma_SP", Ma_SP);
                cmd.Parameters.AddWithValue("@Ten_SP", Ten_SP);
                cmd.Parameters.AddWithValue("@GiaBan", giaBan);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}