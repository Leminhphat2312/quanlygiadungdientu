using System;
using System.Data;
using System.Windows.Forms;
using BLL_QLDDT;

namespace GUI_DoanhThu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgVDoanhThu.AutoGenerateColumns = true;
            dgVDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgVDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVDoanhThu.ReadOnly = true;
            dgVDoanhThu.AllowUserToAddRows = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime tu = dateTimePicker1.Value.Date;
            DateTime den = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            DataTable dt = DoanhThuBLL.LayDoanhThu(tu, den);

            dgVDoanhThu.DataSource = dt;
        }

        private void dgVDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}