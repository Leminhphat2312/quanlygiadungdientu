using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class HoaDonBLL
    {
        public static int ThemHoaDon(
            int maKH,
            decimal tongTien,
            string pttt)
        {
            return HoaDonDAL.ThemHoaDon(
                maKH,
                tongTien,
                pttt
            );
        }
    }
}