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
    public class DAL_KhachHangTests : DBConnect
    {
        [TestMethod()]
        public void insertKhachThanhCongTest1()
        {

            DAL_KhachHang khach = new DAL_KhachHang();
            DTO_KhachHang kh = new DTO_KhachHang();
            kh.Emailkh = "ha123@gmail.com";
            kh.TenKhachHang = "Nguyen Thi Ha";
            kh.DienThoai = "0912345678";
            kh.DiaChi = "Quốc Oai-Hà Nội";
            kh.GioiTinh = "1";
            bool result = khach.insertKhach(kh);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void insertKhachThatBaiTest2()
        {
            DAL_KhachHang khach = new DAL_KhachHang();
            DTO_KhachHang kh = new DTO_KhachHang();
            //kh.Emailkh = "ha123@gmail.com";
            kh.TenKhachHang = "Nguyen Thi Ha";
            kh.DienThoai = "0912345678";
            kh.DiaChi = "Quốc Oai-Hà Nội";
            kh.GioiTinh = "1";
            bool result = khach.insertKhach(kh);
            Assert.IsTrue(result);
        }
    }
}