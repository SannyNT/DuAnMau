using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;
using PM_QuanLyBanHang.Forms;

namespace PM_QuanLyBanHang
{
    public partial class fProducts : Form
    {
        private BUS_SanPham busHang = new BUS_SanPham();
        private string stremail = fManagement.mail;
        private string checkUrlImage;
        private string fileName;
        private string fileSavePath;
        private string fillAddress;
        public fProducts()
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
            lblttsp.ForeColor = Themecolor.SecondaryColor;
            ////label5.ForeColor = Themecolor.PrimaryColor;
        }
        private void fProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadGridView_Hang();
        }

        private void LoadGridView_Hang()
        {
            dataGridViewHang.DataSource = busHang.getHang();
            dataGridViewHang.Columns[0].HeaderText = "MaHang";
            dataGridViewHang.Columns[1].HeaderText = "Tên hàng";
            dataGridViewHang.Columns[2].HeaderText = "Đơn giá";
            dataGridViewHang.Columns[3].HeaderText = "Số lượng";
            dataGridViewHang.Columns[4].HeaderText = "Hình ảnh";
            dataGridViewHang.Columns[5].HeaderText = "Ghi chú";
        }

        private void btnthemsp_Click(object sender, EventArgs e)
        {
            int intsoluong;
            bool isInt = int.TryParse(txtsoluong.Text.Trim().ToString(), out intsoluong);
            float floatGia;
            bool isFloatGia = float.TryParse(txtgiasp.Text.Trim().ToString(), out floatGia);
            if (!isFloatGia || float.Parse(txtgiasp.Text)<0)
            {
                MessageBox.Show("Bạn phải nhập giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiasp.Focus();
                return;
            }
            else if (txttensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttensp.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtgiasp.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            else if (txthinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải thêm hình", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnthemhinh.Focus();
                return;
            }else if (txtttsp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải thêm thông tin", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtttsp.Focus();
                return;
            }
            else
            {
                DTO_SanPham hang = new DTO_SanPham(txtmasp.Text,txttensp.Text,int.Parse(txtsoluong.Text) ,
                     float.Parse(txtgiasp.Text), "\\Image\\" + fileName, txtttsp.Text, stremail);
                if (busHang.InsertHang(hang))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    File.Copy(fillAddress,fileSavePath,true);
                    LoadGridView_Hang();
                    txtmasp.Text = null;
                    txttensp.Text = null;
                    txtsoluong.Text = null;
                    txtgiasp.Text = null;
                    txtttsp.Text = null;
                    txthinh.Text = null;
                    pictureBox1.Image = null;
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công");
                }
            }
        }


        private void btntk_Click(object sender, EventArgs e)
        {
            string tenhang = txttksp.Text;
            DataTable ds1 = busHang.SearchHang(tenhang);
            if (ds1.Rows.Count > 0)
            {
                dataGridViewHang.DataSource = ds1;
                dataGridViewHang.Columns[0].HeaderText = "MaHang";
                dataGridViewHang.Columns[1].HeaderText = "Tên hàng";
                dataGridViewHang.Columns[2].HeaderText = "Số lượng";
                dataGridViewHang.Columns[3].HeaderText = "Đơn giá";
                dataGridViewHang.Columns[4].HeaderText = "Hình ảnh";
                dataGridViewHang.Columns[5].HeaderText = "Ghi chú";
            }
            else
            {
                MessageBox.Show("Không tìm thấy hàng", "Thông báo", MessageBoxButtons.OK);
            }

            txttksp.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int intsoluong;
            bool isInt = int.TryParse(txtsoluong.Text.Trim().ToString(), out intsoluong);
            float floatGia;
            bool isFloatGia = float.TryParse(txtgiasp.Text.Trim().ToString(), out floatGia);
            if (!isFloatGia || float.Parse(txtgiasp.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiasp.Focus();
                return;
            }
            else if (txttensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttensp.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtgiasp.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            else if (txthinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải thêm hình", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnthemhinh.Focus();
                return;
            }
            else if (txtttsp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải thêm thông tin", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtttsp.Focus();
                return;
            }
            else
            {
                DTO_SanPham hang = new DTO_SanPham(txttensp.Text, int.Parse(txtsoluong.Text),
                     float.Parse(txtgiasp.Text), "\\Image\\" + fileName, txtttsp.Text, stremail);
                if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Thông báo", MessageBoxButtons.OKCancel)==DialogResult.OK) 
                {
                    if (busHang.Updatehang(hang))
                    {
                        if (txthinh.Text != checkUrlImage)
                            File.Copy(fillAddress, fileSavePath, true);
                        MessageBox.Show("Sửa thành công");
                        LoadGridView_Hang();
                        txtmasp.Text = null;
                        txttensp.Text = null;
                        txtsoluong.Text = null;
                        txtgiasp.Text = null;
                        txtttsp.Text = null;
                        txthinh.Text = null;
                        pictureBox1.Image = null;
                        txttensp.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }

            }
        }


        private void dataGridViewHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttensp.ReadOnly = true;
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dataGridViewHang.Rows.Count > 1)
            {
                txtmasp.ReadOnly = true;
                txtmasp.Text = dataGridViewHang.CurrentRow.Cells["MaHang"].Value.ToString();
                txttensp.Text = dataGridViewHang.CurrentRow.Cells["TenHang"].Value.ToString();
                txtsoluong.Text = dataGridViewHang.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtgiasp.Text = dataGridViewHang.CurrentRow.Cells["DonGia"].Value.ToString();
                txthinh.Text = dataGridViewHang.CurrentRow.Cells["HinhAnh"].Value.ToString();
                checkUrlImage = txthinh.Text;
                pictureBox1.Image =
                    Image.FromFile(saveDirectory + dataGridViewHang.CurrentRow.Cells["HinhAnh"].Value.ToString());
                txtttsp.Text = dataGridViewHang.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void btnthemhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitma(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fillAddress = dlgOpen.FileName;
                pictureBox1.Image = Image.FromFile(fillAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Image\\" + fileName;
                txthinh.Text = "\\Image\\" + fileName;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mahang = txtmasp.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Thông báo", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)
            {
                if (busHang.DeleteHang(mahang))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    LoadGridView_Hang();
                    txtmasp.Text = null;
                    txttensp.Text = null;
                    txtsoluong.Text = null;
                    txtgiasp.Text = null;
                    txtttsp.Text = null;
                    txthinh.Text = null;
                    pictureBox1.Image = null;
                    txttensp.ReadOnly = false;
                    txttensp.Focus();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");

                }
            }
        }

        private void txttksp_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
