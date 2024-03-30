using DAL.QL_BachHoaTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKe_DAL
    {
        Linh_ThongKeTableAdapter da_thongke = new Linh_ThongKeTableAdapter();
        HOADONTableAdapter da_hd = new HOADONTableAdapter();
        public ThongKe_DAL() { }

        public DataTable loadThongKe(int thang, int nam)
        {
            return da_thongke.GetData(thang, nam);
        }

        public int? DonDaXN(int thang, int nam)
        {
            
            return da_hd.layTongDHDaXN1(thang, nam);
        }

        public int? DonChoXN(int thang, int nam)
        {    
            return da_hd.layTongDHChoXN1(thang, nam);
        }
        public int? DonDaGiao(int thang, int nam)
        {
            return da_hd.layTongDHDaGiao1(thang, nam);
            
        }
        public int? DonDaDoiTra(int thang, int nam)
        {
            return da_hd.layTongDHDaDT1(thang, nam);
            
        }

    }
}
