using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLDDT
{
    public class GioHangDTO : INotifyPropertyChanged
    {
        private int soLuong;

        public string Ma_SP { get; set; }
        public string Ten_SP { get; set; }
        public decimal Gia { get; set; }

        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (soLuong != value)
                {
                    soLuong = value;
                    OnPropertyChanged("SoLuong");
                    OnPropertyChanged("ThanhTien");
                }
            }
        }

        public decimal ThanhTien
        {
            get { return Gia * SoLuong; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
