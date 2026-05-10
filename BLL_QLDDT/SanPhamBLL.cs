using DAL_QLDDT;
using System;
using System.Data;

namespace BLL_QLDDT
{
    public class SanPhamBLL
    {
        public static DataTable LaySanPham()
        {
            return SanPhamDAL.LaySanPham();
        }
        public static DataTable LocSanPham(string ten, string phanLoai, string nhaCC)
        {
            return SanPhamDAL.LocSanPham(ten, phanLoai, nhaCC);
        }
        public static DataTable LayDanhMuc()
        {
            return SanPhamDAL.LayDanhMuc();
        }

        public static DataTable LayNhaCungCap()
        {
            return SanPhamDAL.LayNhaCungCap();
        }
        public static int LaySoLuongTon(string Ma_SP)
        {
            return SanPhamDAL.LaySoLuongTon(Ma_SP);
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
            SanPhamDAL.ThemSanPham(
                tenSP,
                phanLoai,
                gia,
                giaNhap,
                soLuong,
                nhaCC,
                hinhAnh
            );
        }
       
    }
}