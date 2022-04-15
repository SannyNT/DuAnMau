using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;

namespace PM_QuanLyBanHang.Forms
{
    public partial class fTotalBill : Form
    {
        private BUS_SanPham bussp = new BUS_SanPham();
        public fTotalBill()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Themecolor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }
            //lblttsp.ForeColor = Themecolor.SecondaryColor;
            //label5.ForeColor = Themecolor.PrimaryColor;
        }

        private void fTotalBill_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void Load_ThongKeHang()
        {
            dataGridthongke.AutoResizeColumns();
            dataGridthongke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridthongke.DataSource = bussp.ThongKeSP();
            dataGridthongke.Columns[0].HeaderText = "Mã nhân viên";
            dataGridthongke.Columns[1].HeaderText = "Tên nhân viên";
            dataGridthongke.Columns[2].HeaderText = "Số lượng sản phẩm nhập";
            dataGridthongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridthongke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnnhapkho_Click(object sender, EventArgs e)
        {
            Load_ThongKeHang();
        }
        private void Load_ThongKeHangTon()
        {
            dataGridthongke.AutoResizeColumns();
            dataGridthongke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridthongke.DataSource = bussp.TKTonKho();
            dataGridthongke.Columns[0].HeaderText = "Tên Hàng";
            dataGridthongke.Columns[1].HeaderText = "Số lượng tồn";
           dataGridthongke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btntonkho_Click(object sender, EventArgs e)
        {
            Load_ThongKeHangTon();
        }
    }
}
