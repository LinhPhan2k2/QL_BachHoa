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
    public class DoiTraDAL
    {
        DOITRATableAdapter daldt = new DOITRATableAdapter();
        public DoiTraDAL()
        {

        }
        public int? Them(string madt, DateTime ngaydt, int masp, int sl, int giaban)
        {
            return daldt.Insert(madt, ngaydt, masp, sl, giaban);
        }
    }
}
