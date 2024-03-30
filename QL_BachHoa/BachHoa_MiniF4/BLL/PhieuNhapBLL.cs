using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL dal_pn = new PhieuNhapDAL();
        public PhieuNhapBLL() { }

        public void themPN_BLL(PhieuNhap pn)
        {
            dal_pn.themPN(pn);
        }

        public int? layMaPN_Moi()
        {
            return dal_pn.layMaPN_Moi();
        }

        public void loadPN_theoMa(int ma)
        {
            dal_pn.LoadPN_theoMa(ma);
        }

        public int? getMANCC(int mapn)
        {
            return dal_pn.getMANCC(mapn);
        }
        public int? getTongNhap(int mapn)
        {
            return dal_pn.getTongNhap(mapn);
        }

        public DateTime? getNgayNhap(int mapn)
        {
            return dal_pn.getNgayNhap(mapn);
        }


    }
}
