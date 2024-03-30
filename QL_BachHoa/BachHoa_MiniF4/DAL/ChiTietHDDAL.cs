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
    public class ChiTietHDDAL
    {
        CHITIET_HDTableAdapter dact = new CHITIET_HDTableAdapter();
        
        public ChiTietHDDAL()
        {

        }
        public DataTable LoadCTDT(string mahd)
        {
           
            return dact.GetDataCTDT(mahd);
        }
    }
}
