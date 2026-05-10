using System;
using System.Data;
using System.Windows.Forms;
using BLL_QLDDT;

namespace GUI_LSGD
{
    public partial class LSGD : Form
    {
        public LSGD()
        {
            InitializeComponent();
        }

        private void LSGD_Load(object sender, EventArgs e)
        {
            dgvLSGD.AutoGenerateColumns = true;
            dgvLSGD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLSGD.ReadOnly = true;
            dgvLSGD.AllowUserToAddRows = false;
            dgvLSGD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tu = dtpTu.Value.Date;
                DateTime den = dtpDen.Value.Date.AddDays(1).AddSeconds(-1);

                DataTable dt = LichSuGiaoDichBLL.LayLSGD(tu, den);

                dgvLSGD.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}