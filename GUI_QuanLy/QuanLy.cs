using BLL_QLDDT;
using System;
using System.Data;
using System.Windows.Forms;
using Them_SP;

namespace GUI_QuanLy
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadDanhMuc();
            LoadNhaCungCap();
        }

        private void LoadSanPham()
        {
            var dt = SanPhamBLL.LaySanPham();

            dgVQuanLy.DataSource = dt;
            dgVQuanLy.AutoGenerateColumns = true;

            if (dgVQuanLy.Columns.Contains("Gia_Nhap"))
                dgVQuanLy.Columns["Gia_Nhap"].Visible = false;

            if (dgVQuanLy.Columns.Contains("Hinh_Anh"))
                dgVQuanLy.Columns["Hinh_Anh"].Visible = false;

            if (dgVQuanLy.Columns.Contains("TrangThai"))
                dgVQuanLy.Columns["TrangThai"].Visible = false;
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

        private void dgVQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgVQuanLy.Rows[e.RowIndex];

            lblMa_SP.Text = row.Cells["Ma_SP"].Value?.ToString();
            lblTen_SP.Text = row.Cells["Ten_SP"].Value?.ToString();
            lblDanhMuc.Text = row.Cells["Phan_Loai"].Value?.ToString();
            lblGia.Text = row.Cells["Gia"].Value?.ToString();
            lblSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
            lblNhaCungCap.Text = row.Cells["Nha_CC"].Value?.ToString();

            string img = row.Cells["Hinh_Anh"].Value?.ToString();

            if (!string.IsNullOrEmpty(img))
            {
                pictureBox1.ImageLocation = Application.StartupPath + "\\LOR\\" + img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string ten = txtSearch.Text;
            string dm = cbDanhMuc.Text;
            string ncc = cbNhaCungCap.Text;

            dgVQuanLy.DataSource = SanPhamBLL.LocSanPham(ten, dm, ncc);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cbDanhMuc.SelectedIndex = -1;
            cbNhaCungCap.SelectedIndex = -1;

            LoadSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHang frm = new ThemHang();
            frm.ShowDialog();

            LoadSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgVQuanLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgVQuanLy.Rows[e.RowIndex];

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

        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblSoLuong_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}