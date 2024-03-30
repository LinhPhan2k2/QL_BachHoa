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
    public class NhanVienBLL
    {
        NhanVienDAL dal_nv = new NhanVienDAL();
        public NhanVienBLL()
        {

        }

        public DataTable loadNV()
        {
            return dal_nv.loadNV();
        }
        public int? KT_TaiKhoan(string tk)
        {
            return dal_nv.KT_TaiKhoan(tk);
        }

        public void themNV(NhanVien nv)
        {
            dal_nv.themNV(nv);
        }
        public void suaQuyenNV(int maq, int manv)
        {
            dal_nv.suaQuyenNV(maq, manv);
        }
    }
}
