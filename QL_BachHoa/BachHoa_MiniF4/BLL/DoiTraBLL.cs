using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;

namespace BLL
{
    public class DoiTraBLL
    {
        DoiTraDAL daldt = new DoiTraDAL();
        public DoiTraBLL()
        {

        }
        public int? Them(string madt, DateTime ngaydt, int masp, int sl, int giaban)
        {
            return daldt.Them(madt, ngaydt, masp, sl, giaban);
        }

    }
}
