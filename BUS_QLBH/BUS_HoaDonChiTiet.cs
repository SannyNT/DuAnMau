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
    public class BUS_HoaDonChiTiet
    {
        private DAL_HoaDonChiTiet dalhdct = new DAL_HoaDonChiTiet();
        public DataTable GetBillDetail()
        {
            return dalhdct.GetBillDetail();
        }
        public DataTable GetHang()
        {
            return dalhdct.GetHang();
        }
        public bool InsertDetail(DTO_HoaDonChiTiet detail)
        {
            return dalhdct.insertDetail(detail);
        }
        public bool DeleteDetail(DTO_HoaDonChiTiet detail)
        {
            return dalhdct.deleteDetail(detail);
        }
        public DataTable HoaDonThanhToan()
        {
            return dalhdct.HoaDonThanhToan();
        }
        public DataTable Searchhoadon(string tenkh)
        {
            return dalhdct.findHoaDon(tenkh);
        }
    }
}
