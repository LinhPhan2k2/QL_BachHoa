using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class SanPhamBLL
    {
         SanPhamDAL dal_sp = new SanPhamDAL();
        public SanPhamBLL()
        {

        }
        public DataTable Load_SP_theoNCC(int mancc)
        {
            return dal_sp.load_SP_theo_NCC(mancc);
        }

        public DataTable Load_SP_theoNH(int manh)
        {
            return dal_sp.load_SP_theo_NH(manh);
        }
        public int? KT_TrungTenSP(string tensp)
        {
            return dal_sp.KT_TrungTenSP(tensp);
        }

        public void update_GiaSP(int gia, int masp)
        {
            dal_sp.sua_SP(gia, masp);
        }

        public void themSP(SanPham sp)
        {
            dal_sp.themSP(sp);
        }
    }
}
