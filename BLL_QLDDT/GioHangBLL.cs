using DTO_QLDDT;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class GioHangBLL
    {
        public static DataTable LayDanhSach()
        {
            return GioHangDAL.LayDanhSach();
        }

        public static void Them(string Ma_SP, string Ten_SP, decimal gia)
        {
            if (GioHangDAL.KiemTraTonTai(Ma_SP))
            {
                GioHangDAL.TangSoLuong(Ma_SP);
            }
            else
            {
                GioHangDAL.Them(Ma_SP, Ten_SP, gia, 1);
            }
        }

        public static void CapNhatSoLuong(string Ma_SP, int soLuong)
        {
            GioHangDAL.CapNhatSoLuong(Ma_SP, soLuong);
        }

        public static void Xoa(string Ma_SP)
        {
            GioHangDAL.Xoa(Ma_SP);
        }

        public static void Clear()
        {
            GioHangDAL.Clear();

        }

        public static decimal TongTien()
        {
            return GioHangDAL.TongTien();
        }
    }
}