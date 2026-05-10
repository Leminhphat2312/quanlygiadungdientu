using System;

namespace DTO_QLDDT
{
    public class LichSuGiaoDichDTO
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public string PhuongThucTT { get; set; }
        public bool TrangThai { get; set; }
    }
}