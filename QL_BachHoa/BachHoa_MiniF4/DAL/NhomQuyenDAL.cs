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
    public class NhomQuyenDAL
    {
        NHOMQUYENTableAdapter daNhomQuyen = new NHOMQUYENTableAdapter();
        public NhomQuyenDAL()
        {

        }
        public DataTable LoadNhomQuyen()
        {
           
            return daNhomQuyen.GetData();
        }
        public int ThemQuyen(string TenQ)
        {
            return daNhomQuyen.Insert(TenQ);
        }
        public int SuaQuyen(string TenQ, int MaQ)
        {
            return daNhomQuyen.UpdateQuyen(TenQ, MaQ);
        }

    }
}
