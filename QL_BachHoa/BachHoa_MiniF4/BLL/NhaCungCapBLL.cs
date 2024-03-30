using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
         NhaCungCapDAL dal_ncc = new NhaCungCapDAL();
        public NhaCungCapBLL()
        {

        }
        public DataTable load_NCC()
        {
            return dal_ncc.load_NCC();
        }

        public string getTenNCC(int mapn)
        {
            return dal_ncc.getTenNCC(mapn);
        }
    }
}
