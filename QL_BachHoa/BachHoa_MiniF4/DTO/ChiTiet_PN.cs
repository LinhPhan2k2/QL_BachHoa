using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTiet_PN
    {
        int mapn, masp, sl, gianhap, thanhtien;

        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        public int Gianhap
        {
            get { return gianhap; }
            set { gianhap = value; }
        }

        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }

        public int Masp
        {
            get { return masp; }
            set { masp = value; }
        }

        public int Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }

    }
}
