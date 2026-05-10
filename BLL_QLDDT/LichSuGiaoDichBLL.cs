using System;
using System.Data;
using DAL_QLDDT;

namespace BLL_QLDDT
{
    public class LichSuGiaoDichBLL
    {
        public static DataTable LayLSGD(DateTime tu, DateTime den)
        {
            return LichSuGiaoDichDAL.LayLSGD(tu, den);
        }
    }
}