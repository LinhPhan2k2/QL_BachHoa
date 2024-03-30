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
    public class ChiTietQuyenDAL
    {
        CHITIET_QUYEN_LOADTableAdapter daCT = new CHITIET_QUYEN_LOADTableAdapter ();
        CHITIET_QUYENTableAdapter dalCT = new CHITIET_QUYENTableAdapter();
        public ChiTietQuyenDAL()
        {

        }
        public DataTable LoadCTQuyen(int maq)
        {
           
            return daCT.GetData(maq);
        }
        public int? Update_PQ(int CapPhep, int maCT)
        {
            return dalCT.Update_PQ(CapPhep, maCT);
        }
        public int? Insert_PQ(int CapPhep, int maQ, string tenCT)
        {
            return dalCT.Insert(maQ ,tenCT, CapPhep);
        }
    }
}
