using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;
using PM_QuanLyBanHang.Forms;
using MailKit;

namespace PM_QuanLyBanHang
{
    public partial class frmlogin : Form
    {
        private BUS_NHANVIEN busNhanvien = new BUS_QLBH.BUS_NHANVIEN();
        // public string vaitro;
        // private fManagement fm = new fManagement();


        public frmlogin()
        {
            InitializeComponent();
            // txtemail.Text = "ha@gmail.com";
            // txtmk.Text = "12345";
        }
        
       

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            fManagement f = new fManagement();
            nv.Email = txtemail.Text;
            //nv.MatKhau = encryption(txtmk.Text);
            nv.MatKhau = txtmk.Text;
            if (busNhanvien.NhanVienDangNhap(nv))
            {
                fManagement.mail = nv.Email;
                //DataTable dt = busNhanvien.VaiTroNhanVien(nv.Email);
                //vaitro = dt.Rows[0][0].ToString();
                MessageBox.Show("Đăng nhập thành công!");
                fManagement.session = 1;
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu!");
                txtemail.Text = null;
                txtmk.Text = null;
                txtemail.Focus();
            }
        }
        /*
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }

            return encryptdata.ToString();
        }
        */
        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            fCreateAcc fc = new fCreateAcc();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void btnquenmk_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "")
            {
                if (busNhanvien.NhanVienQuenMatKhau(txtemail.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    string matkhaumoi = builder.ToString();
                    busNhanvien.TaoMatKhau(txtemail.Text, matkhaumoi);
                    SendMail(txtemail.Text,builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại email!");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin phục hồi mật khẩu!");
                txtemail.Focus();
            }

        }
        //Tao chuoi ngau nhien
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();


        }
        //Tao so ngau nhien
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        //send mail
        public void SendMail(string email, string matkhau)
        {

            try
            { 
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
            NetworkCredential cred = new NetworkCredential("dalecarnegi918@gmail.com", "Nhung0808@");
            MailMessage Msg = new MailMessage();
            Msg.From = new MailAddress("dalecarnegi918@gmail.com");
            Msg.To.Add(email);
            Msg.Subject = "Bạn đã sử dụng chức năng quên mật khẩu";
            Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là: " + matkhau + " Anh/chị vui lòng đăng nhập lại phần mềm và đổi mật khẩu." ;
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(Msg);
            MessageBox.Show("Một email phục hồi đã được gửi tới bạn!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            //fManagement.session = 0;
        }
    }
}
