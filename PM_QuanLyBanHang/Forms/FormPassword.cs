using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;

namespace PM_QuanLyBanHang.Forms
{
    public partial class FormPassword : Form
    {
        //private Thread th;
        //private string stremail;
        private BUS_NHANVIEN busNhanvien = new BUS_NHANVIEN();
        public FormPassword(string email)
        {
            //InitializeComponent();
            //stremail = email;
            //txtemail.Text = stremail;
            //txtemail.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
