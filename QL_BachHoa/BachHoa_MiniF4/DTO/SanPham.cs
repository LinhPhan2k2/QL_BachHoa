using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        int manh, mancc, giaban, luotban, soluong;
        int masp;

        public int Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        public SanPham() { }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int Luotban
        {
            get { return luotban; }
            set { luotban = value; }
        }

        public int Giaban
        {
            get { return giaban; }
            set { giaban = value; }
        }

        public int Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }

        public int Manh
        {
            get { return manh; }
            set { manh = value; }
        }

       
        string tensp, hinh, khoiluong;

        public string Khoiluong
        {
            get { return khoiluong; }
            set { khoiluong = value; }
        }

        public string Hinh
        {
            get { return hinh; }
            set { hinh = value; }
        }

        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }



    }
}
