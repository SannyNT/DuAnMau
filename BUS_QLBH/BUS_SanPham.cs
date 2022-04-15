using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBH;
using DTO_QLBH;

namespace BUS_QLBH
{
    public class BUS_SanPham
    {
        private DAL_SANPHAM dalhang = new DAL_SANPHAM();
        public DataTable getHang()
        {
            return dalhang.GetListHang();
        }

        public bool InsertHang(DTO_SanPham hang)
        {
            return dalhang.insertHang(hang);
        }
        public bool Updatehang(DTO_SanPham hang)
        {
            return dalhang.UpdateHang(hang);
        }
        public bool DeleteHang(string mahang)
        {
            return dalhang.deleteHang(mahang);
        }
        public DataTable SearchHang(string tenHang)
        {
            return dalhang.SearchHang(tenHang);
        }
        public DataTable ThongKeSP()
        {
            return dalhang.ThongKeHang();
        }
        public DataTable TKTonKho()
        {
            return dalhang.ThongKeHangTon();
        }
    }
}
