using DAL.QL_BachHoaTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomHangDAL
    {
        NHOMHANGTableAdapter da_NH = new NHOMHANGTableAdapter();
        public NhomHangDAL()
        { }

        public DataTable load_NH()
        {
            return da_NH.GetData();
        }
    }
}
