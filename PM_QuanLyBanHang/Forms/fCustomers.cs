using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;

namespace PM_QuanLyBanHang
{
    public partial class fCustomers : Form
    {
        private BUS_KhachHang busKhach = new BUS_KhachHang();
        private string stremail = fManagement.mail;

        public fCustomers()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button) btns;
                    btn.BackColor = Themecolor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }

            lbttkh.ForeColor = Themecolor.SecondaryColor;
            ////label5.ForeColor = Themecolor.PrimaryColor;
        }

        private void fCustomers_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadGridview_Khach();
        }

        private void LoadGridview_Khach()
        {
            dataviewkh.DataSource = busKhach.getKhach();
            dataviewkh.Columns[0].HeaderText = "MaKH";
            dataviewkh.Columns[1].HeaderText = "Tên khách hàng";
            dataviewkh.Columns[2].HeaderText = "Điện thoại";
            dataviewkh.Columns[3].HeaderText = "Địa chỉ";
            dataviewkh.Columns[4].HeaderText = "Giới tính";
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            float intdt;
            bool isInt = float.TryParse(txtsdt.Text.Trim().ToString(), out intdt);
            string phai = "Nam";
            if (rbnu.Checked)
                phai = "Nữ";
            if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            else if (txtdc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdc.Focus();
                return;
            }
            else if (!isInt || float.Parse(txtsdt.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại và là số nguyên", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtsdt.Focus();
                return;
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txthoten.Text, txtsdt.Text, txtdc.Text, phai, stremail);
                if (busKhach.InsertKhach(kh))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadGridview_Khach();
                    txtmakh.Text = null;
                    txthoten.Text = null;
                    txtsdt.Text = null;
                    txtdc.Text = null;
                    txthoten.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }

        private void dataviewkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.ReadOnly = true;
            txtsdt.ReadOnly = true;
            if (dataviewkh.Rows.Count > 1)
            {
                txtmakh.ReadOnly = true;
                txtmakh.Text = dataviewkh.CurrentRow.Cells["MaKH"].Value.ToString();
                txthoten.Text = dataviewkh.CurrentRow.Cells["tenKhach"].Value.ToString();
                txtsdt.Text = dataviewkh.CurrentRow.Cells["DienThoai"].Value.ToString();
                txtdc.Text = dataviewkh.CurrentRow.Cells["DiaChi"].Value.ToString();
                if (dataviewkh.CurrentRow.Cells["Phai"].Value.ToString()=="Nam")
                {
                    rbnam.Checked = true;
                }
                else
                {
                    rbnu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            float intdt;
            bool isInt = float.TryParse(txtsdt.Text.Trim().ToString(), out intdt);
            string phai = "Nam";
            if (rbnu.Checked)
                phai = "Nữ";
            if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            else if (txtdc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdc.Focus();
                return;
            }
            else if (!isInt || float.Parse(txtsdt.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại và là số nguyên", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtsdt.Focus();
                return;
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(txthoten.Text, txtsdt.Text, txtdc.Text, phai, stremail);
                if (busKhach.UpadateKhach(kh))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadGridview_Khach();
                    txtmakh.Text = null;
                    txthoten.Text = null;
                    txtsdt.Text = null;
                    txtdc.Text = null;
                    txtsdt.ReadOnly = false;
                    txthoten.Focus();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sdt = txtsdt.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Thông báo", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)
            {
                if (busKhach.DeleteKhach(sdt))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    LoadGridview_Khach();
                    txthoten.Text = null;
                    txtmakh.Text = null;
                    txtsdt.Text = null;
                    txtdc.Text = null;
                    txtsdt.ReadOnly = false;
                    txthoten.Focus();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");

                }
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string sodt = txttimkiemkh.Text;
            DataTable ds1 = busKhach.FindKhach(sodt);
            if (ds1.Rows.Count > 0)
            {
                dataviewkh.DataSource = ds1;
                dataviewkh.Columns[0].HeaderText = "MaKH";
                dataviewkh.Columns[1].HeaderText = "Tên khách hàng";
                dataviewkh.Columns[2].HeaderText = "Điện thoại";
                dataviewkh.Columns[3].HeaderText = "Địa chỉ";
                dataviewkh.Columns[4].HeaderText = "Giới tính";
                txttimkiemkh.Text = null;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK);
            }

            txttimkiemkh.Focus();
        }

        private void txttimkiemkh_TextChanged(object sender, EventArgs e)
        {
        }
    }
} //hung123@gmail.com
    
