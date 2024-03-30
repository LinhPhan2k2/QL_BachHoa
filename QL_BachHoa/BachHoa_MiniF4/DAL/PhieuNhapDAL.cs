using DAL.QL_BachHoaTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        PHIEUNHAPTableAdapter da_pn = new PHIEUNHAPTableAdapter();
        public PhieuNhapDAL() { }

        public void themPN(PhieuNhap pn)
        {
            da_pn.Insert(pn.Mancc, pn.Ngaynhap, pn.Tongnhap, pn.Manv);
        }

        public int? layMaPN_Moi()
        {
            return da_pn.getMaPN();
        }

        public DataTable LoadPN_theoMa(int ma)
        {
            return da_pn.LoadPN_theoMa(ma);
        }

        public int? getTongNhap(int mapn)
        {
            int? t = da_pn.getTongNhap(mapn);
            return t;

        }

        public DateTime? getNgayNhap(int mapn)
        {
            DateTime? t = da_pn.getNgayNhap(mapn);
            return t;
        }


        public int? getMANCC(int mapn)
        {
            return da_pn.getMANCC(mapn);
        }


    }
}
