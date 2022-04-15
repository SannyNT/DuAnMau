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

namespace PM_QuanLyBanHang
{
    public partial class fManagement : Form
    {
        private BUS_NHANVIEN busnv = new BUS_NHANVIEN();
        public static int session = 0;

        public static int profile=0;
        public static string mail;
        //private Thread th;
        private frmlogin fl = new frmlogin();
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        //Constructor
        public fManagement()
        {
            InitializeComponent();
            random = new Random();
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            btncaidat.Enabled = false;
        }

        private void VaiTroNV()
        {
            btnthongke.Visible = false;
            btnql.Visible = false;
        }
        //phan quyen khi load fManagement
        // private void Phanquyen()
        // {
        //     if ()
        //     {
        //         btnemailuser.Text = "Chào" + fManagement.mail;
        //         btndonhang.Enabled = true;
        //         btnsp.Enabled = true;
        //         btnkh.Enabled = true;
        //         btnql.Enabled = true;
        //         btnthongke.Enabled = true;
        //         btncaidat.Enabled = true;
        //         if (int.Parse(fl.vaitro) == 0)
        //         {
        //             VaiTroNV();
        //         }
        //     }
        //     else
        //     {
        //         btnemailuser.Text = "Chào" + fManagement.mail;
        //         btndonhang.Enabled = true;
        //         btnsp.Enabled = true;
        //         btnkh.Enabled = true;
        //         btnql.Enabled = false;
        //         btnthongke.Enabled = false;
        //         btncaidat.Enabled = true;
        //     }
        // }

    
        //ethods

        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Themecolor.colorList.Count);
            }
            tempIndex = index;
            string color = Themecolor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitle.BackColor = color;
                    panellogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    Themecolor.PrimaryColor = color;
                    Themecolor.SecondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }


        private void btnmain_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           OpenChildForm(new Forms.FormBillMain(), sender);
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fProducts(), sender);
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCustomers(), sender);
        }


    

        private void btnout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Close();
                frmlogin fl = new frmlogin();
                this.Hide();
                fl.ShowDialog();
                //this.Show();

            }

        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fTotalBill(), sender);
        }

        private void btnql_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.fStaff(), sender);
        }

        private void btncaidat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAccounts(), sender);
        }

        private void fManagement_Load(object sender, EventArgs e)
        {
            btnemailuser.Text = "Chào " + mail;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        // private void fManagement_Load(object sender, EventArgs e)
        // {
        //     //Resetvalue();
        //     if (profile == 1)
        //     {
        //         this.Close();
        //         profile = 0;
        //     }
        // }
    }
}
