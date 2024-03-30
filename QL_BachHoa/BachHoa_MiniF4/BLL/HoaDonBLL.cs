using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL dalhd = new HoaDonDAL();
        public HoaDonBLL()
        {

        }
        public DataTable getHDDT()
        {
            return dalhd.LoadDT();
        }
        public int? Sua(string trangthai, string mahd)
        {
            return dalhd.Sua(trangthai, mahd);
        }
        public DataTable LoadTimKiem(string ma)
        {
            return dalhd.LoadTimKiem(ma);
        }
        public int? QuaSL(int masp)
        {
            return dalhd.QuaSL(masp);
        }


        //public int? layThang()
        //{
        //    return dalhd.layThang();

        //}
        //public int? layNam()
        //{
        //    return dalhd.layNam();

        //}
        public int? TongDT(int thang, int nam)
        {
            return dalhd.TongDT(thang, nam);
        }
        public string LayTen(int masp)
        {
            return dalhd.LayTen(masp);
        }
        public int CapNhatSL(int sl, int masp)
        {
            return dalhd.CapNhatSL(sl, masp);
        }
    }
}
