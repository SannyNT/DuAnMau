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
    public class BUS_HoaDon
    {
        private DAL_HoaDon dalhoadon = new DAL_HoaDon();
        public bool InsertBill(DTO_HoaDon hd)
        {
            return dalhoadon.insertHoaDon(hd);
        }
    }
}
