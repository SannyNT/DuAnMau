using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBH;

namespace DAL_QLBH.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests : DBConnect
    {
        [TestMethod()]
        public void NhanVienDangNhapTest1()
        {
            DAL_NhanVien dangnhap = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = "";
            nv.MatKhau = "12345";
            bool result = dangnhap.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void NhanVienDangNhapTest2()
        {
            DAL_NhanVien dangnhap = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = "a@gmail.com";
            nv.MatKhau = "";
            bool result = dangnhap.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void NhanVienDangNhapTest3()
        {
            DAL_NhanVien dangnhap = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = "ha@gmail.com";
            nv.MatKhau = "12345";
            bool result = dangnhap.NhanVienDangNhap(nv);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ThemNVThanhCong()
        {

            DAL_NhanVien dangnhap = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = "ha123@gmail.com";
            nv.MatKhau = "12345";
            nv.TenNhanVien = "Nguyen Huu Tu";
            nv.DiaChi = "An Khanh - Ha Noi";
            nv.VaiTro = 0;
            bool result = dangnhap.insertNhanVien(nv);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void insertNhanVienThatBaiTest()
        {
            DAL_NhanVien dangnhap = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien();
            //nv.Email = "ha123@gmail.com";
            nv.MatKhau = "12345";
            nv.TenNhanVien = "Nguyen Huu Tu";
            nv.DiaChi = "An Khanh - Ha Noi";
            nv.VaiTro = 0;
            bool result = dangnhap.insertNhanVien(nv);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void NhanVienDangNhapTest4()
        {
            DAL_NhanVien dangnhap = new DAL_NhanVien();
            DTO_NhanVien nv = new DTO_NhanVien();
            nv.Email = "";
            nv.MatKhau = "";
            bool result = dangnhap.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
    }
}