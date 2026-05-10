using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDDT
{
    internal class SanPhamDTO
    {
        public string Ma_SP { get; set; }
        public string Ten_SP { get; set; }
        public string Phan_Loai { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public string Nha_CC { get; set; }
        public string Hinh_Anh { get; set; }
    }
}
