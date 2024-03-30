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
    public class NhanVienDAL
    {
        NHANVIENTableAdapter da_nv = new NHANVIENTableAdapter();
        Linh_NHANVIEN_TableAdapter linh_da_nv = new Linh_NHANVIEN_TableAdapter();
        public NhanVienDAL() { }

        public DataTable loadNV()
        {
            return linh_da_nv.GetNV();
        }

        public int? KT_TaiKhoan(string tk)
        {
            return da_nv.KT_TaiKhoan(tk);
        }

        //public void themNV(NhanVien nv)
        //{
        //    //da_nv.Insert_NV(nv.Tennv, nv.Gioitinh, nv.Sdt, nv.Matkhau, nv.Maquyen, nv.Taikhoan);
        //    da_nv.Insert(nv.Tennv, nv.Gioitinh, nv.Sdt, nv.Matkhau, nv.Taikhoan, nv.Maquyen);
        //}

        public void themNV(NhanVien nv)
        {
            da_nv.Insert_NV(nv.Tennv, nv.Gioitinh, nv.Sdt, nv.Matkhau, nv.Maquyen, nv.Taikhoan);
        }

        public void suaQuyenNV(int maq, int manv)
        {
            da_nv.Update_quyenNV(maq, manv);
        }
    }
}
