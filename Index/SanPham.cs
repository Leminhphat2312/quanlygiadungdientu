using BanHang;
using BLL_QLDDT;
using DTO_QLDDT;
using GUI_QuanLy;
using System;
using System.Data;
using System.Windows.Forms;
using GUI_DoanhThu;
using GUI_LSGD; 
namespace index
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadDanhMuc();
            LoadNhaCungCap();

            dgVSanPham.Columns["Gia_Nhap"].Visible = false;
            dgVSanPham.Columns["Hinh_Anh"].Visible = false;
            dgVSanPham.Columns["TrangThai"].Visible = false;
        }
        private void LoadSanPham()
        {
            dgVSanPham.DataSource = SanPhamBLL.LaySanPham();
        }

        private void LoadDanhMuc()
        {
            cbDanhMuc.DataSource = SanPhamBLL.LayDanhMuc();
            cbDanhMuc.DisplayMember = "Phan_Loai";
            cbDanhMuc.ValueMember = "Phan_Loai";
            cbDanhMuc.SelectedIndex = -1;
        }

        private void LoadNhaCungCap()
        {
            cbNhaCungCap.DataSource = SanPhamBLL.LayNhaCungCap();
            cbNhaCungCap.DisplayMember = "Nha_CC";
            cbNhaCungCap.ValueMember = "Nha_CC";
            cbNhaCungCap.SelectedIndex = -1;
        }
        private void dgVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgVSanPham.Rows[e.RowIndex];

                lblMa_SP.Text = row.Cells["colMa_SP"].Value.ToString();
                lblTen_SP.Text = row.Cells["colTen_SP"].Value.ToString();
                lblDanhMuc.Text = row.Cells["colPhanLoai"].Value.ToString();
                lblGia.Text = row.Cells["colGia"].Value.ToString();
                lblSoLuong.Text = row.Cells["colSoLuong"].Value.ToString();
                lblNhaCungCap.Text = row.Cells["colNhaCC"].Value.ToString();

                string tenFile = row.Cells["Hinh_Anh"].Value?.ToString();

                if (!string.IsNullOrEmpty(tenFile))
                {
                    pictureBox1.ImageLocation = Application.StartupPath + "\\LOR\\" + tenFile;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtSearch.Text;
            string dm = cbDanhMuc.Text;
            string ncc = cbNhaCungCap.Text;

            dgVSanPham.DataSource = SanPhamBLL.LocSanPham(ten, dm, ncc);
        }
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgVSanPham.CurrentRow != null)
            {
                string ma = dgVSanPham.CurrentRow.Cells["colMa_SP"].Value.ToString();
                string ten = dgVSanPham.CurrentRow.Cells["colTen_SP"].Value.ToString();
                decimal gia = Convert.ToDecimal(dgVSanPham.CurrentRow.Cells["colGia"].Value);

                GioHangBLL.Them(ma, ten, gia);

                MessageBox.Show("Đã thêm vào giỏ hàng");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GioHang().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            new QuanLy().ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblSoLuong_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void btnCong_Click(object sender, EventArgs e) { }
        private void btnTru_Click(object sender, EventArgs e) { }
        private void button6_Click(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void dgVSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            new LSGD().ShowDialog();
        }
    }
}