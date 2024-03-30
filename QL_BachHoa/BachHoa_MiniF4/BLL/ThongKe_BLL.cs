using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ThongKe_BLL
    {
        ThongKe_DAL dal_thongke = new ThongKe_DAL();
        HoaDonDAL dal_hd = new HoaDonDAL();
        public ThongKe_BLL() { }
        public DataTable loadThongKe(int thang, int nam)
        {
            return dal_thongke.loadThongKe(thang, nam);
        }

        

        public int? DonDaXN(int thang, int nam)
        {
            return dal_thongke.DonDaXN(thang, nam);
        }
        public int? DonChoXN(int thang, int nam)
        {
            return dal_thongke.DonChoXN(thang, nam);
        }
        public int? DonDaGiao(int thang, int nam)
        {
            return dal_thongke.DonDaGiao(thang, nam);
        }
        public int? DonDaDoiTra(int thang, int nam)
        {
            return dal_thongke.DonDaDoiTra(thang, nam);
        }
    }
}
