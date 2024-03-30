using DAL.QL_BachHoaTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        SANPHAMTableAdapter da_SP = new SANPHAMTableAdapter();
        Linh_SPTheoNCC_TableAdapter da_SP_Linh = new Linh_SPTheoNCC_TableAdapter();
        Linh_Table_SPTheoNHTableAdapter da_SP_Linh_nh = new Linh_Table_SPTheoNHTableAdapter();
        public SanPhamDAL()
        { }

        public DataTable load_SP_theo_NCC(int mancc)
        {
            //return da_SP.GetSP_theoNCC(mancc);
            return da_SP_Linh.Linh_SPTheoNCC_Adapter(mancc);

        }
        public int? KT_TrungTenSP(string tensp)
        {
            return da_SP.KT_TrungTenSP(tensp);
        }

        public DataTable load_SP_theo_NH(int manh)
        {
            //return da_SP.GetSP_theoMaNH(manh);
            return da_SP_Linh_nh.getSPtheoNhomHang(manh);
        }

        public void sua_SP(int gia, int masp)
        {
            da_SP.Update_giaSP(gia, masp);
        }

        public void themSP(SanPham sp)
        {
            da_SP.Insert_SP(sp.Tensp, sp.Hinh, sp.Soluong, sp.Khoiluong, sp.Giaban, sp.Luotban, sp.Mancc, sp.Manh);
        }

    }
}
