using BUS_QLBH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QuanLyBanHang.Forms
{
    public partial class FormBillMain : Form
    {
        private BUS_HoaDonChiTiet busdetail = new BUS_HoaDonChiTiet();
        public FormBillMain()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //labelloc.ForeColor = Themecolor.SecondaryColor;
            //label5.ForeColor = Themecolor.PrimaryColor;
        }
        private void FormBillMain_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadGridview_Bill();
        }
        private void LoadGridview_Bill()
        {
            dataGridView1.DataSource = busdetail.HoaDonThanhToan();
            dataGridView1.Columns[0].HeaderText = "Số hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Mã KH";
            dataGridView1.Columns[2].HeaderText = "Khách hàng";
            dataGridView1.Columns[3].HeaderText = "Ngày";
            dataGridView1.Columns[4].HeaderText = "Số lượng";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
        }
        private void btntao_Click(object sender, EventArgs e)
        {
            FormBilIDetail fb = new FormBilIDetail();
            fb.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                tbmakh.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
                txttenkh.Text = dataGridView1.CurrentRow.Cells["TenKhach"].Value.ToString();
                tbtime.Text = dataGridView1.CurrentRow.Cells["CreatedDate"].Value.ToString();
                tbsohd.Text = dataGridView1.CurrentRow.Cells["BillId"].Value.ToString();
                txttongtien.Text = dataGridView1.CurrentRow.Cells["Tổng tiền"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void tbttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tenkh = tbttimkiem.Text;
            DataTable ds = busdetail.Searchhoadon(tenkh);
            if (ds.Rows.Count > 0)
            {
                dataGridView1.DataSource = ds;
                dataGridView1.Columns[0].HeaderText = "Số hóa đơn";
                dataGridView1.Columns[1].HeaderText = "Mã KH";
                dataGridView1.Columns[2].HeaderText = "Khách hàng";
                dataGridView1.Columns[3].HeaderText = "Ngày";
                dataGridView1.Columns[4].HeaderText = "Số lượng";
                dataGridView1.Columns[5].HeaderText = "Thành tiền";
                tbttimkiem.Text = null;

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK);
            }

            tbttimkiem.Focus();
        }
    }
}
