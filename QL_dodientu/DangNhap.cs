using BLL_QLDDT;
using DTO_QLDDT;
using System;
using System.Reflection;
using System.Windows.Forms;
using index;
using DAL_QLDDT;
namespace QL_dodientu
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            TaikhoanDTO tk = new TaikhoanDTO();
            tk.Username = TXT_NAME.Text;
            tk.Password = TXT_PASS.Text;

            int maNV;
            string tenNV;

            if (TaikhoanBLL.Dangnhap(tk, out maNV, out tenNV))
            {
                MessageBox.Show($"Cảm ơn nhân viên {tenNV} đã tiếp quản công việc");

                SanPham frm = new SanPham();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TXT_NewName.Text.Trim();
            string password = TXT_NewPass.Text.Trim();
            string tenNV = TXT_NewName.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (TaikhoanDAL.KiemTraTonTai(username))
            {
                MessageBox.Show("Username đã tồn tại!");
                return;
            }

            bool kq = TaikhoanDAL.DangKy(username, password, tenNV);

            if (kq)
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }
    }
}