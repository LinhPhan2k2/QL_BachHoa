using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class ChiTiet_PN_BLL
    {
        ChiTiet_PN_DAL dal_ctpn = new ChiTiet_PN_DAL();
        public ChiTiet_PN_BLL()
        {

        }

        public void them_CTPN(ChiTiet_PN ctpn)
        {
            dal_ctpn.themCTPN(ctpn);
        }

        public DataTable loadPN_theoMa(int ma)
        {
            return dal_ctpn.LoadCTPN_theoMa(ma);
        }

        public void xoaCTPN(int mapn, int masp)
        {
            dal_ctpn.xoaCTPN(mapn, masp);
        }
        
    }
}
