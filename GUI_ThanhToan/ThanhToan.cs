using System;
using System.Data;
using System.Windows.Forms;
using BLL_QLDDT;
using DAL_QLDDT;

namespace GUI_ThanhToan
{
    public partial class ThanhToan : Form
    {
        string TenKH;
        string SDT;
        string DiaChi;
        string Email;

        decimal TongTien;

        bool DaTinhTien = false;

        public ThanhToan()
        {
            InitializeComponent();
        }

        public ThanhToan(
            string tenKH,
            string sdt,
            string diaChi,
            string email,
            decimal tongTien)
        {
            InitializeComponent();

            TenKH = tenKH;
            SDT = sdt;
            DiaChi = diaChi;
            Email = email;

            TongTien = tongTien;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            lblThanhTien.Text =
                TongTien.ToString("N0") + " VNĐ";

            lblTienThua.Text = "0 VNĐ";
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienNhan_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTienNhan.Text))
            {
                decimal tien;

                string raw =
                    txtTienNhan.Text.Replace(".", "");

                if (decimal.TryParse(raw, out tien))
                {
                    txtTienNhan.Text =
                        tien.ToString("N0");
                }
            }
        }

        private void btnTienThua_Click(object sender, EventArgs e)
        {
            decimal tienNhan;

            string raw =
                txtTienNhan.Text.Replace(".", "");

            if (!decimal.TryParse(raw, out tienNhan))
            {
                MessageBox.Show("Nhập tiền hợp lệ!");
                return;
            }

            decimal tienThua = tienNhan - TongTien;

            if (tienThua < 0)
            {
                lblTienThua.Text = "Không đủ tiền!";
                DaTinhTien = false;
            }
            else
            {
                lblTienThua.Text =
                    tienThua.ToString("N0") + " VNĐ";

                DaTinhTien = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (!DaTinhTien)
            {
                MessageBox.Show("Hãy tính tiền thừa trước!");
                return;
            }

            decimal tienNhan;

            string raw =
                txtTienNhan.Text.Replace(".", "");

            if (!decimal.TryParse(raw, out tienNhan))
            {
                MessageBox.Show("Nhập tiền nhận!");
                return;
            }

            if (tienNhan < TongTien)
            {
                MessageBox.Show("Khách đưa chưa đủ tiền!");
                return;
            }

            int maKH = KhachHangBLL.XuLy(
                TenKH,
                SDT,
                DiaChi,
                Email
            );

            int maHD = HoaDonBLL.ThemHoaDon(
                maKH,
                TongTien,
                "Tiền mặt"
            );

            DataTable dt = GioHangDAL.LayDanhSach();

            foreach (DataRow row in dt.Rows)
            {
                CTHoaDonBLL.Them(
                    maHD,
                    row["Ma_SP"].ToString(),
                    row["Ten_SP"].ToString(),
                    Convert.ToDecimal(row["GiaBan"]),
                    Convert.ToInt32(row["SoLuong"]),
                    Convert.ToDecimal(row["ThanhTien"])
                );
            }

            GioHangBLL.Clear();

            MessageBox.Show("Thanh toán thành công!");

            this.Close();
        }
    }
}