using System;
using DTO_QLDDT;
using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class TaikhoanBLL
    {
        public static bool Dangnhap(TaikhoanDTO tk, out int maNV, out string tenNV)
        {
            return TaikhoanDAL.Kiemtradangnhap(tk, out maNV, out tenNV);
        }
        public static bool DangKy(string username, string password, string tenNV)
        {
            return TaikhoanDAL.DangKy(username, password, tenNV);
        }
        public static bool KiemTraTonTai(string username)
        {
            return TaikhoanDAL.KiemTraTonTai(username);
        }
    }
}