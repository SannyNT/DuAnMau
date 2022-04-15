using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
using DTO_QLBH;

namespace BUS_QLBH
{
    public class BUS_NHANVIEN
    {
        private DAL_NhanVien dalNhanVien = new DAL_NhanVien();

        public DataTable GetListNv()
        {
            return dalNhanVien.GetListNv();
        }

        public bool insertNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.insertNhanVien(nv);
        } 
        public bool updateNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.updateNhanVien(nv);
        }

        public bool DeleteNhanVien(string email)
        {
            return dalNhanVien.deleteNhanVien(email);
        }

        public DataTable SearchNhanVien(string tenNhanVien)
        {
            return dalNhanVien.findNhanVien(tenNhanVien);
        }
        // public DataTable LayVaiTroNhanVien(string email)
        // {
        //     return dalNhanVien.VaiTroNhanVien(email);
        // }
        public bool UpdateMatKhau(string email, string matKhauCu, string matKhuaMoi)
        {
            return dalNhanVien.UpdateMatKhau(email, matKhauCu, matKhuaMoi);
        }
        // public DataTable VaiTroNhanVien(string email)
        // {
        //     return dalNhanVien.VaiTroNhanVien(email);
        // }
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }
        //ma hoa mat khau
        
        //public string encryption(string password)
        //{
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    byte[] encrypt;
        //    UTF8Encoding encode = new UTF8Encoding();
        //    encrypt = md5.ComputeHash(encode.GetBytes(password));
        //    StringBuilder encryptdata = new StringBuilder();
        //    for (int i = 0; i < encrypt.Length; i++)
        //    {
        //        encryptdata.Append(encrypt[i].ToString());
        //    }

        //    return encryptdata.ToString();
        //}
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.NhanVienQuenMatKhau(email);
        }

        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            return dalNhanVien.TaoMatKhau(email, matKhauMoi);
        }
    }

}
