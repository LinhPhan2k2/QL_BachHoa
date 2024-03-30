using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NhomHangBLL
    {
        NhomHangDAL dal_nh = new NhomHangDAL();
        public NhomHangBLL(){ }

        public DataTable load_NhomHang()
        {
            return dal_nh.load_NH();
        }

    }
}
