using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_KhachHang
    {
        private string maKH;
        private string tenKhachHang;
        private string dienThoai;
        private string diaChi;
        private string gioiTinh;
        private string emailkh;

        public DTO_KhachHang()
        {
        }

        public DTO_KhachHang(string tenKhachHang, string dienThoai, string diaChi, string gioiTinh, string emailkh=null)
        {
            this.tenKhachHang = tenKhachHang;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.emailkh = emailkh;
        }

        public DTO_KhachHang(string maKh, string tenKhachHang, string dienThoai, string diaChi, string gioiTinh, string emailkh)
        {
            maKH = maKh;
            this.tenKhachHang = tenKhachHang;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.emailkh = emailkh;
        }

        public string MaKh
        {
            get => maKH;
            set => maKH = value;
        }

        public string TenKhachHang
        {
            get => tenKhachHang;
            set => tenKhachHang = value;
        }

        public string DienThoai
        {
            get => dienThoai;
            set => dienThoai = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public string GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string Emailkh
        {
            get => emailkh;
            set => emailkh = value;
        }
    }
}
