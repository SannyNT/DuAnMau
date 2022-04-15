using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_QuanLyBanHang.Forms;

namespace PM_QuanLyBanHang
{
    public partial class fAccounts : Form
    {
        public fAccounts()
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
            labelttcn.ForeColor = Themecolor.SecondaryColor;
            lbtttk.ForeColor = Themecolor.PrimaryColor;
        }
        private void fAccounts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            // FormPassword fpass = new FormPassword();
            // fpass.ShowDialog();
        }
    }
}
