using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL.QL_BachHoaTableAdapters;

namespace DAL
{
    public class HoaDonDAL
    {
        HOADONTableAdapter dahd = new HOADONTableAdapter();
        SANPHAMTableAdapter da_SP = new SANPHAMTableAdapter();
        public HoaDonDAL()
        {

        }
        public DataTable LoadDT()
        {

            return dahd.GetDataDT("Chờ đổi trả");
        }
        public int? Sua(string trangthai, string mahd)
        {
            return dahd.UpdateHD(trangthai, mahd);
        }
        public DataTable LoadTimKiem(string ma)
        {
            return dahd.GetDataTimKiem(ma, ma, "Chờ đổi trả");
        }
        public string LayTen(int masp)
        {
            return da_SP.LayTenSP(masp);
        }

        public int? TongDT(int thang, int nam)
        {
            return dahd.TongTienHD(thang, nam);
        }
        public int CapNhatSL(int sl, int masp)
        {
            return da_SP.CapNhatSL(sl, masp);
        }
        public int? QuaSL(int masp)
        {
            return da_SP.QuaSL(masp);
        }
       
       
    }
}
