using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
     public class DTO_NhanVien
    {
        private string tenNhanVien;
        private string diaChi;
        private int vaiTro;
        private string matKhau;
        private string email;

        public DTO_NhanVien(string tenNhanVien, string diaChi, int vaiTro, string matKhau, string email)
        {
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.matKhau = matKhau;
            this.email = email;
        }

        public DTO_NhanVien(string tenNhanVien, string diaChi,  int vaiTro, string email)
        {
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.email = email;
        }


        public string TenNhanVien
        {
            get => tenNhanVien;
            set => tenNhanVien = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public int VaiTro
        {
            get => vaiTro;
            set => vaiTro = value;
        }

        public string MatKhau
        {
            get => matKhau;
            set => matKhau = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public DTO_NhanVien()
        {}

    }
}
