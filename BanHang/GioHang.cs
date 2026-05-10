using BLL_QLDDT;
using GUI_ThanhToan;
using System;
using System.Data;
using System.Windows.Forms;

namespace BanHang
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            dgVGioHang.AutoGenerateColumns = false;
            dgVGioHang.DataSource = GioHangBLL.LayDanhSach();

            if (dgVGioHang.Columns["colMa_SP"] != null)
                dgVGioHang.Columns["colMa_SP"].ReadOnly = true;

            if (dgVGioHang.Columns["colTen_SP"] != null)
                dgVGioHang.Columns["colTen_SP"].ReadOnly = true;

            if (dgVGioHang.Columns["colGia"] != null)
                dgVGioHang.Columns["colGia"].ReadOnly = true;

            if (dgVGioHang.Columns["colThanhTien"] != null)
                dgVGioHang.Columns["colThanhTien"].ReadOnly = true;

            if (dgVGioHang.Columns["colSoLuong"] != null)
                dgVGioHang.Columns["colSoLuong"].ReadOnly = false;

            dgVGioHang.CellEndEdit += dgVGioHang_CellEndEdit;
            dgVGioHang.EditingControlShowing += dgVGioHang_EditingControlShowing;

            CapNhatTongTien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgVGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadGioHang()
        {
            dgVGioHang.DataSource = null;
            dgVGioHang.DataSource = GioHangBLL.LayDanhSach();
        }

        private void dgVGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVGioHang.Columns[e.ColumnIndex].Name == "colSoLuong")
            {
                string ma = dgVGioHang.Rows[e.RowIndex]
                    .Cells["colMa_SP"].Value.ToString();

                int soLuongMoi;

                if (int.TryParse(
                    dgVGioHang.Rows[e.RowIndex]
                    .Cells["colSoLuong"].Value.ToString(),
                    out soLuongMoi))
                {
                    int tonKho = SanPhamBLL.LaySoLuongTon(ma);

                    if (soLuongMoi > tonKho)
                    {
                        MessageBox.Show($"Chỉ còn {tonKho} sản phẩm!");

                        GioHangBLL.CapNhatSoLuong(ma, 1);
                    }
                    else if (soLuongMoi <= 0)
                    {
                        GioHangBLL.Xoa(ma);
                    }
                    else
                    {
                        GioHangBLL.CapNhatSoLuong(ma, soLuongMoi);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ");
                }

                LoadGioHang();
                CapNhatTongTien();
            }
        }

        private void dgVGioHang_EditingControlShowing(
            object sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgVGioHang.CurrentCell != null &&
                dgVGioHang.Columns["colSoLuong"] != null &&
                dgVGioHang.CurrentCell.ColumnIndex ==
                dgVGioHang.Columns["colSoLuong"].Index)
            {
                TextBox tb = e.Control as TextBox;

                if (tb != null)
                {
                    tb.KeyPress -= OnlyNumber;
                    tb.KeyPress += OnlyNumber;
                }
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void CapNhatTongTien()
        {
            lblTong.Text =
                GioHangBLL.TongTien().ToString("N0")
                + " VNĐ";
        }

        private void btnDLT_Click(object sender, EventArgs e)
        {
            GioHangBLL.Clear();

            LoadGioHang();

            CapNhatTongTien();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string ten = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(ten) ||
                string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Nhập tên và SĐT!");
                return;
            }

            if (dgVGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            decimal tongTien = GioHangBLL.TongTien();

            ThanhToan frm = new ThanhToan(
                ten,
                sdt,
                diaChi,
                email,
                tongTien
            );

            frm.ShowDialog();
            LoadGioHang();
            CapNhatTongTien();
            this.Close();
        }
    }
}