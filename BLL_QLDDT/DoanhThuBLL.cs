using System;
using System.Data;
using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class DoanhThuBLL
    {
        public static DataTable LayDoanhThu(DateTime tu, DateTime den)
        {
            return DoanhThuDAL.LayDoanhThu(tu, den);
        }
    }
}