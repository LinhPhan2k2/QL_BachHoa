using DAL.QL_BachHoaTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        NHACUNGCAPTableAdapter da_NCC = new NHACUNGCAPTableAdapter();
        public NhaCungCapDAL()
        {

        }

        public DataTable load_NCC()
        {
            return da_NCC.GetData();
        }

        public string getTenNCC(int mancc)
        {
            return da_NCC.GetTenNCC(mancc);
        }
    }
}
