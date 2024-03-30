using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DuyetDH_BLL
    {
        DuyetDH_DAL dal_ddh = new DuyetDH_DAL();

        public DuyetDH_BLL()
        { }

        public DataTable loadDH()
        {
            return dal_ddh.loadDH();
        }
        public DataTable loadCTHD(string mahd)
        {
            return dal_ddh.loadCTHD(mahd);
        }

    }
}
