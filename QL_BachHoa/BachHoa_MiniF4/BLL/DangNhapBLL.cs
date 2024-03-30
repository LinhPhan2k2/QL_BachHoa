using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class DangNhapBLL
    {
        DangNhapDAL dalDN = new DangNhapDAL();
        public DangNhapBLL()
        {

        }
        public int? ktDangNhap(string user, string pass)
        {
            return dalDN.Check_User(user, pass);
        }
        public string layMaQuyen(string tk)
        {
            return dalDN.GetMaQuyen(tk);
        }
        public DataTable layManHinh(int maq)
        {
            return dalDN.GetMaManHinh(maq);
        }
        public string layNhanVien(string tk)
        {
            return dalDN.GetNhanVien(tk);
        }

    }
}
