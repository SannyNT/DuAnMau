using BUS_QLBH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLBH;

namespace PM_QuanLyBanHang.Forms
{
    public partial class fCreateAcc : Form
    {

        private BUS_NHANVIEN busNhanVien = new BUS_NHANVIEN();
        public fCreateAcc()
        {
            InitializeComponent();
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
        private void btndkitk_Click(object sender, EventArgs e)
        {
            string email;
            int role = 0;
            if (rbquanly.Checked)
                role = 1;
            if (txtemdn.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtemdn.Focus();
                return;
                
            }
            else if(!Isvalid(txtemdn.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemdn.Focus();
                return;
            }
            else if (txtmatk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập matk khẩu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtmatk.Focus();
                return;
                
            }
            else if (txthot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập matk khẩu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txthot.Focus();
                return;
                
            }
            else if (txtdc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtdc.Focus();
                return;
                
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txthot.Text, txtdc.Text, role, txtmatk.Text, txtemdn.Text);
                if (busNhanVien.insertNhanVien(nv))
                {
                    MessageBox.Show("Đăng ký thành công!");
                    email = txtemdn.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!");
                }
            }

            
        }

        
    }
}
