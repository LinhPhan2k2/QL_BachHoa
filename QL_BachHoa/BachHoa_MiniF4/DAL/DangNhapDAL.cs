using DAL.QL_BachHoaTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        public int Check_Config()
        {
            if (DAL.Properties.Settings.Default.QL_BACHHOAConnectionString == string.Empty)
            {
                return 1;

            }
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.QL_BACHHOAConnectionString);
            try
            {
                if (sql.State == System.Data.ConnectionState.Closed)
                    sql.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }

        public int? Check_User(string pUser, string pPass)
        {
            NHANVIENTableAdapter nv = new NHANVIENTableAdapter();
            int? kt = int.Parse(nv.KTDangNhap(pPass, pUser).ToString());


            if (kt == 0)
            {

                return 0;// Không hoạt động
            }
            return 1;// Đăng nhập thành công
        }
        public string GetMaQuyen(string manv)
        {
            NHANVIENTableAdapter nv = new NHANVIENTableAdapter();
            string mq = Convert.ToString(nv.LayMaQuyen(manv));
            return mq;
        }
        public DataTable GetMaManHinh(int maq)
        {
            CHITIET_QUYEN_LOADTableAdapter ct = new CHITIET_QUYEN_LOADTableAdapter();
            return ct.GetMH(maq);
        }
        public string GetNhanVien(string tk)
        {
            NHANVIENTableAdapter nv = new NHANVIENTableAdapter();
            string tennv = nv.LayTenNV(tk).ToString();
            return tennv;
        }

    }
}
