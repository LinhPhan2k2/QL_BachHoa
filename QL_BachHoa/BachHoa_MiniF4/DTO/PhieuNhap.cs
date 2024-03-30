using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        int mapn, mancc, manv;

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }

        public int Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }

        public int Mapn
        {
            get { return mapn; }
            set { mapn = value; }
        }
        DateTime ngaynhap;

        public DateTime Ngaynhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        int tongnhap;

        public int Tongnhap
        {
            get { return tongnhap; }
            set { tongnhap = value; }
        }

    }
}
