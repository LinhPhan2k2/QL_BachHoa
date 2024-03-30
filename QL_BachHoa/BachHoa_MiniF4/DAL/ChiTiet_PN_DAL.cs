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
    public class ChiTiet_PN_DAL
    {
        CHITIET_PNTableAdapter da_CTPN = new CHITIET_PNTableAdapter();
        Linh_CTPNTableAdapter da_ctpn_Linh = new Linh_CTPNTableAdapter();
        public ChiTiet_PN_DAL() { }

        public void themCTPN(ChiTiet_PN ctpn)
        {
            int? sl = ctpn.Sl;
            int? gianhap = ctpn.Gianhap;
            int? thanhtien = ctpn.Thanhtien;
            da_CTPN.Insert(ctpn.Mapn, ctpn.Masp, sl, gianhap, thanhtien);
        }

        //public DataTable LoadCTPN_theoMa(int ma)
        //{
        //    return da_CTPN.LoadCTPN_TheoMa(ma);
        //    //return da_CTPN.Load_theoMa(ma);
        //}

        public DataTable LoadCTPN_theoMa(int mapn)
        {
            //return da_CTPN.LoadCTPN_TheoMa(mapn);
            //return da_CTPN.Load_theoMa(mapn);
            return da_ctpn_Linh.Linh_CTPN_Adapter(mapn);
        }

        public void xoaCTPN(int mapn, int masp)
        {
           da_CTPN.Xoa_CTPN(mapn, masp);
        }


    }
}
