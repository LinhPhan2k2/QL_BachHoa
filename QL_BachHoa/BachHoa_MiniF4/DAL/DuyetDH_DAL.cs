using DAL.QL_BachHoaTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DuyetDH_DAL
    {
        Linh_DuyetDH_TableAdapter da_ddh = new Linh_DuyetDH_TableAdapter();
        Linh_CTHD_TableAdapter da_cthd = new Linh_CTHD_TableAdapter();
        public DuyetDH_DAL() { }

        public DataTable loadDH()
        {
            return da_ddh.GetData_TrangThai();
        }

        public DataTable loadCTHD(string mahd)
        {
            return da_cthd.GetData(mahd);
        }
    }
}
