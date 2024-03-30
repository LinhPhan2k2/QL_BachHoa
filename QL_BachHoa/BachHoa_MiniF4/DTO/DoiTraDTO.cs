using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiTraDTO
    {
        string masp, soluong, giaban, thanhtien;

        public string Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }

        public string Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        string stt;
        public string STT
        {
            get { return stt; }
            set { stt = value; }
        }
    }
}
