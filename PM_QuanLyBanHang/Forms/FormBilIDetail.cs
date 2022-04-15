using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using BUS_QLBH;
using DTO_QLBH;

namespace PM_QuanLyBanHang.Forms
{
    public partial class FormBilIDetail : Form
    {
        private BUS_HoaDon busHoaDon = new BUS_HoaDon();
        private BUS_HoaDonChiTiet busdetail = new BUS_HoaDonChiTiet();
        public FormBilIDetail()
        {
            InitializeComponent();
            txttime.Text = DateTime.Now.ToString();
            txtmasp.Enabled = false;
            txtsoluong.Enabled = false;
            txttonkho.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnthanhtoan.Enabled = false;
        }

        private void btnthembill_Click(object sender, EventArgs e)
        {

            DTO_HoaDon  hoad = new DTO_HoaDon(txtmakh.Text);
            hoad.MaKh = txtmakh.Text;

            if (txtmakh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // else if (txtmakh.Text != ToString().ToUpper())
            // {
            //     MessageBox.Show("Bạn phải viết hoa mã khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     return;
            // }
            else
            {
                DTO_HoaDon hd = new DTO_HoaDon(txtmakh.Text.ToUpper());
                if (busHoaDon.InsertBill(hd))
                {
                    txtmasp.Enabled = true;
                    txtsoluong.Enabled = true;
                    txttonkho.Enabled = true;
                    btnthem.Enabled = true;
                    btnxoa.Enabled = true;
                    btnthanhtoan.Enabled = true;
                    MessageBox.Show("Nhập tiếp sản phẩm!");
                    LoadGridView_SP();
                   
                }
                else
                {
                    MessageBox.Show("Nhập không thành công!");
                }
                
            }
        }
        private void LoadGridView_SP()
        {
            dataGridViewsp.AutoResizeColumns();
            dataGridViewsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewsp.DataSource = busdetail.GetHang();
            dataGridViewsp.Columns[0].HeaderText = "MaHang";
            dataGridViewsp.Columns[1].HeaderText = "Tên hàng";
            dataGridViewsp.Columns[2].HeaderText = "Số lượng";
            dataGridViewsp.Columns[3].HeaderText = "Đơn giá";
            dataGridViewsp.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void LoadGridview_Detail()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = busdetail.GetBillDetail();
            dataGridView1.Columns[0].HeaderText = "Số hóa đơn";
            dataGridView1.Columns[1].HeaderText = "Mã hàng";
            dataGridView1.Columns[2].HeaderText = "Tên hàng";
            dataGridView1.Columns[3].HeaderText = "Số lượng";
            dataGridView1.Columns[4].HeaderText = "Đơn giá";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridViewsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewsp.Rows.Count > 1)
            {
                txtmasp.Text = dataGridViewsp.CurrentRow.Cells["MaHang"].Value.ToString();
                txttonkho.Text = dataGridViewsp.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtgia.Text = dataGridViewsp.CurrentRow.Cells["DonGia"].Value.ToString();
                txtmasp.ReadOnly = true;
                txttonkho.ReadOnly = true;
                txtgia.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void FormBilIDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmasp.Text.Trim().ToLower().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasp.Focus();
                return;
            }
            else if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            else if (int.Parse(txtsoluong.Text) <= 0 )
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            
            else if (int.Parse(txttonkho.Text) <= 0)
            {
                MessageBox.Show("Hàng tồn không đủ", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                DTO_HoaDonChiTiet detail = new DTO_HoaDonChiTiet(txtmasp.Text,int.Parse(txtsoluong.Text));
                if (busdetail.InsertDetail(detail))
                {
                    MessageBox.Show("Thêm thành công!"); 
                    LoadGridview_Detail();
                    loadtotal();
                    LoadGridView_SP();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                txtmasp.Text = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
                txtsoluong.Text = dataGridView1.CurrentRow.Cells["COUNT"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            string mahang = txtmasp.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu", "Thông báo", MessageBoxButtons.OKCancel) ==
                DialogResult.OK)
            {
                DTO_HoaDonChiTiet detail = new DTO_HoaDonChiTiet(txtmasp.Text, int.Parse(txtsoluong.Text));
                if (busdetail.DeleteDetail(detail))
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    LoadGridview_Detail();
                    txtmasp.Text = null;
                    txtsoluong.Text = null;
                    txtmasp.Focus();
                    loadtotal();
                    LoadGridView_SP();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");

                }
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
            this.Close();
            fManagement fm = new fManagement();
            fm.ShowDialog();
        }

        void loadtotal()
        {
            int sc = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            txttotal.Text = thanhtien.ToString("c");
        }
        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            loadtotal();
        }

    }
    
}
