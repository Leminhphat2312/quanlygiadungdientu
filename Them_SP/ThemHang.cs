using BLL_QLDDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Them_SP
{
    public partial class ThemHang : Form
    {
        public ThemHang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP =
                    txtTenSP.Text.Trim();

                string phanLoai =
                    txtPhanLoai.Text.Trim();

                decimal gia =
                    Convert.ToDecimal(txtGiaSP.Text);

                decimal giaNhap =
                    Convert.ToDecimal(txtGiaNH.Text);

                int soLuong =
                    Convert.ToInt32(txtSoLuong.Text);

                string nhaCC =
                    txtNhaCC.Text.Trim();

                string hinhAnh =
                    txtHinhAnh.Text.Trim();

                SanPhamBLL.ThemSanPham(
                    tenSP,
                    phanLoai,
                    gia,
                    giaNhap,
                    soLuong,
                    nhaCC,
                    hinhAnh
                );

                MessageBox.Show(
                    "Thêm sản phẩm thành công!"
                );

                this.Close();
            }
            catch
            {
                MessageBox.Show(
                    "Dữ liệu không hợp lệ!"
                );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}