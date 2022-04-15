using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_HoaDonChiTiet
    {
        private int billid;
        private string mahang;
        private int soluongmua;

        public DTO_HoaDonChiTiet(string mahang, int soluongmua)
        {
            this.mahang = mahang;
            this.soluongmua = soluongmua;

        }

        public DTO_HoaDonChiTiet()
        {
        }

        public DTO_HoaDonChiTiet(int billid, string mahang, int soluongmua)
        {
            this.billid = billid;
            this.mahang = mahang;
            this.soluongmua = soluongmua;
        }

        public int Billid
        {
            get => billid;
            set => billid = value;
        }

        public string Mahang
        {
            get => mahang;
            set => mahang = value;
        }

        public int Soluongmua
        {
            get => soluongmua;
            set => soluongmua = value;
        }
    }
}
