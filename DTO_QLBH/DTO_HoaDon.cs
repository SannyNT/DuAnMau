using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBH
{
    public class DTO_HoaDon
    {
        private int billid;
        private DateTime createdate;
        private string maKH;


        public DTO_HoaDon(int billid, DateTime createdate, string maKh)
        {
            this.billid = billid;
            this.createdate = createdate;
            maKH = maKh;
        }

        public DTO_HoaDon(string maKh)
        {
            maKH = maKh;
        }

        public int Billid
        {
            get => billid;
            set => billid = value;
        }

        public DateTime Createdate
        {
            get => createdate;
            set => createdate = value;
        }

        public string MaKh
        {
            get => maKH;
            set => maKH = value;
        }
    }
}
