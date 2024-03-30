using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomQuyenBLL
    {
        NhomQuyenDAL dalNhomQuyen = new NhomQuyenDAL();
        public NhomQuyenBLL()
        {

        }
        public DataTable GetNhomQuyen()
        {
            return dalNhomQuyen.LoadNhomQuyen();
        }
        public int ThemQuyen(string TenQ)
        {
            return dalNhomQuyen.ThemQuyen(TenQ);
        }
        public int SuaQuyen(string TenQ, int MaQ)
        {
            return dalNhomQuyen.SuaQuyen(TenQ, MaQ);
        }
    }
}
