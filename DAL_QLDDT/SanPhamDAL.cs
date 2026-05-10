using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLDDT
{
    public class SanPhamDAL
    {
        static string conn =
        "Data Source=.\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True";

        public static DataTable LaySanPham()
        {
            SqlConnection con = new SqlConnection(conn);

            string sql = "SELECT * FROM SanPham";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public static DataTable LocSanPham(string ten, string phanLoai, string nhaCC)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT * FROM SanPham WHERE 1=1";

                if (!string.IsNullOrEmpty(ten))
                    sql += " AND Ten_SP LIKE N'%" + ten + "%'";

                if (!string.IsNullOrEmpty(phanLoai))
                    sql += " AND Phan_Loai = N'" + phanLoai + "'";

                if (!string.IsNullOrEmpty(nhaCC))
                    sql += " AND Nha_CC = N'" + nhaCC + "'";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public static DataTable LayDanhMuc()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT DISTINCT Phan_Loai FROM SanPham";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public static DataTable LayNhaCungCap()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "SELECT DISTINCT Nha_CC FROM SanPham";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public static int LaySoLuongTon(string Ma_SP)
        {
            int soLuong = 0;

            using (SqlConnection con =
                new SqlConnection(conn))
            {
                string sql =
                "SELECT SoLuong FROM SanPham WHERE Ma_SP = @ma";

                SqlCommand cmd =
                    new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ma", Ma_SP);

                con.Open();

                object result =
                    cmd.ExecuteScalar();

                if (result != null)
                {
                    soLuong =
                        Convert.ToInt32(result);
                }
            }

            return soLuong;
        }

        public static void ThemSanPham(
            string tenSP,
            string phanLoai,
            decimal gia,
            decimal giaNhap,
            int soLuong,
            string nhaCC,
            string hinhAnh)
        {
            using (SqlConnection con =
                new SqlConnection(conn))
            {
                string sql = @"

                INSERT INTO SanPham
                (
                    Ten_SP,
                    Phan_Loai,
                    Gia,
                    Gia_Nhap,
                    SoLuong,
                    Nha_CC,
                    Hinh_Anh,
                    TrangThai
                )

                VALUES
                (
                    @Ten_SP,
                    @Phan_Loai,
                    @Gia,
                    @GiaNhap,
                    @SoLuong,
                    @NhaCC,
                    @HinhAnh,
                    1
                )";

                SqlCommand cmd =
                    new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Ten_SP", tenSP);

                cmd.Parameters.AddWithValue("@Phan_Loai", phanLoai);

                cmd.Parameters.AddWithValue("@Gia", gia);

                cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);

                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                cmd.Parameters.AddWithValue("@NhaCC", nhaCC);

                cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);

                con.Open();

                cmd.ExecuteNonQuery();
            }
        }
        
    }
}