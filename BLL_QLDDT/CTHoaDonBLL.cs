using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class CTHoaDonBLL
    {
        public static void Them(
            int maHD,
            string Ma_SP,
            string Ten_SP,
            decimal giaBan,
            int soLuong,
            decimal thanhTien)
        {
            CTHoaDonDAL.Them(
                maHD,
                Ma_SP,
                Ten_SP,
                giaBan,
                soLuong,
                thanhTien
            );
        }
    }
}