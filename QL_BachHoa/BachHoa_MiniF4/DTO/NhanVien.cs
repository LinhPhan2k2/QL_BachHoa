using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        int manv, maquyen;

        public int Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        string tennv, gioitinh, sdt, taikhoan, matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }

    }
}
