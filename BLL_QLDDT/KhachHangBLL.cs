using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class KhachHangBLL
    {
        public static int XuLy(string ten, string sdt, string diaChi, string email)
        {
            int maKH = KhachHangDAL.LayMaKH(sdt);

            if (maKH != -1)
                return maKH;

            return KhachHangDAL.Them(ten, sdt, diaChi, email);
        }
    }
}