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
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalkhach = new DAL_KhachHang();

        public DataTable getKhach()
        {
            return dalkhach.GetListkh();
        }

        public bool InsertKhach(DTO_KhachHang khach)
        {
            return dalkhach.insertKhach(khach);
        }
        public bool UpadateKhach(DTO_KhachHang khach)
        {
            return dalkhach.updateKhach(khach);
        } 
        public bool DeleteKhach(string sodt)
        {
            return dalkhach.deleteKhachHang(sodt);
        }
        public DataTable FindKhach(string sodt)
        {
            return dalkhach.findKH(sodt);
        }
    }
}
