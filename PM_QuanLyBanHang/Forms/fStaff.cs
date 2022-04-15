using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;

namespace PM_QuanLyBanHang.Forms
{
    public partial class fStaff : Form
    {
        private BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public fStaff()
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
            lbttnv.ForeColor = Themecolor.SecondaryColor;
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadGridview_NhanVien();
        }

        private void LoadGridview_NhanVien()
        {
            dgvNhanvien.DataSource = busNhanVien.GetListNv();
            dgvNhanvien.Columns[0].HeaderText = "MaNV";
            dgvNhanvien.Columns[1].HeaderText = "Email";
            dgvNhanvien.Columns[2].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanvien.Columns[4].HeaderText = "Vai trò";
        }

        public bool Isvalid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string email;
            int role = 0;
            if (raquanly.Checked)
                role = 1;
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return;
            }
            else if(!Isvalid(txtemail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.Focus();
                return;
            }
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            else if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            else if (txtmk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk.Focus();
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txthoten.Text,txtdiachi.Text,role,txtmk.Text,txtemail.Text);
                if (busNhanVien.insertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công!");
                    email = txtemail.Text;
                    LoadGridview_NhanVien();
                    txtemail.Text = null;
                    txthoten.Text = null;
                    txtdiachi.Text = null;
                    txtmk.Text = null;
                    txtemail.ReadOnly = false;
                    txtemail.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
        }//abc123@gmail.com

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanvien.Rows.Count>1)
            {
                txtmk.Enabled = false;
                txtemail.ReadOnly = true;
                txthoten.Text = dgvNhanvien.CurrentRow.Cells["tennv"].Value.ToString();
                txtemail.Text = dgvNhanvien.CurrentRow.Cells["email"].Value.ToString();
                txtdiachi.Text = dgvNhanvien.CurrentRow.Cells["diaChi"].Value.ToString();
                //txtmk.Text = dgvNhanvien.CurrentRow.Cells["matKhau"].Value.ToString();
                if (int.Parse(dgvNhanvien.CurrentRow.Cells["vaiTro"].Value.ToString())==1)
                {
                    raquanly.Checked = true;
                }
                else
                {
                    ranhanvien.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string email1;
            int role = 0;
            if (raquanly.Checked)
                role = 1;
            else if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            else if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txthoten.Text, txtdiachi.Text, role,  txtemail.Text);
                if (busNhanVien.updateNhanVien(nv))
                {
                    MessageBox.Show("Sửa thành công!");
                    email1 = txtemail.Text;
                    LoadGridview_NhanVien();
                    txtemail.Text = null;
                    txthoten.Text = null;
                    txtdiachi.Text = null;
                    txtemail.ReadOnly = false;
                    txtmk.ReadOnly = false;
                    txtemail.Focus();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu","Thông báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (busNhanVien.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    LoadGridview_NhanVien();
                    txtemail.Text = null;
                    txthoten.Text = null;
                    txtdiachi.Text = null;
                    txtemail.ReadOnly = false;
                    txtmk.ReadOnly = false;
                    txtemail.Focus();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }


        private void btntk_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txttimkiem.Text;
            DataTable ds = busNhanVien.SearchNhanVien(tenNhanVien);
            if (ds.Rows.Count >0)
            {
                dgvNhanvien.DataSource = ds;
                dgvNhanvien.Columns[0].HeaderText = "MaNV";
                dgvNhanvien.Columns[1].HeaderText = "Email";
                dgvNhanvien.Columns[2].HeaderText = "Tên nhân viên";
                dgvNhanvien.Columns[3].HeaderText = "Địa chỉ";
                dgvNhanvien.Columns[4].HeaderText = "Vai trò";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK);
            }

            txttimkiem.Focus();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
