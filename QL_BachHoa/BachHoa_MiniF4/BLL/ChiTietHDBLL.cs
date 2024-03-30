using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHDBLL
    {

        ChiTietHDDAL dalhd = new ChiTietHDDAL();
        public ChiTietHDBLL()
        {

        }
        public DataTable getHDDT(string mahd)
        {
            return dalhd.LoadCTDT(mahd);
        }
    }
}
