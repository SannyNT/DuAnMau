using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_SanPham
    {
        private string maHang;
        private string tenHang;
        private int soLuong;
        private float donGia;
        private string hinhAnh;
        private string ghiChu;
        private string maNV;
        private string emailnv;

        public DTO_SanPham(string maHang, string tenHang, int soLuong, float donGia, string hinhAnh, string ghiChu, string emailnv)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.emailnv = emailnv;
        }

        public DTO_SanPham(string tenHang, int soLuong, float donGia, string hinhAnh, string ghiChu, string emailnv)
        {
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.emailnv = emailnv;
        }

        public DTO_SanPham(string maHang, string tenHang, int soLuong, float donGia, string hinhAnh, string ghiChu, string maNv, string emailnv)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            maNV = maNv;
            this.emailnv = emailnv;

        }

        public string MaHang
        {
            get => maHang;
            set => maHang = value;
        }

        public string TenHang
        {
            get => tenHang;
            set => tenHang = value;
        }

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }

        public float DonGia
        {
            get => donGia;
            set => donGia = value;
        }

        public string HinhAnh
        {
            get => hinhAnh;
            set => hinhAnh = value;
        }

        public string GhiChu
        {
            get => ghiChu;
            set => ghiChu = value;
        }

        public string MaNv
        {
            get => maNV;
            set => maNV = value;
        }

        public string Emailnv
        {
            get => emailnv;
            set => emailnv = value;
        }
    }
}
