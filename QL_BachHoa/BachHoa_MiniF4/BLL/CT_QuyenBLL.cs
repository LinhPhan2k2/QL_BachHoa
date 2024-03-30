using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class CT_QuyenBLL
    {
        ChiTietQuyenDAL dalCT = new ChiTietQuyenDAL();
        public CT_QuyenBLL()
        {

        }
        public DataTable GetCTQuyen(int maq)
        {
            return dalCT.LoadCTQuyen(maq);
        }
        public int? Update_PhanQuyen(int CapPhep, int maCT)
        {
            return dalCT.Update_PQ(CapPhep, maCT);
        }
        public int? Insert_PQ(int CapPhep, int maQ, string tenCT)
        {
            return dalCT.Insert_PQ(CapPhep, maQ, tenCT);
        }
    }
}
