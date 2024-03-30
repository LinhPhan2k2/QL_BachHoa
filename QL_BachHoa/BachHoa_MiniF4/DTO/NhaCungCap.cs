using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        int maNCC;

        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        string tenncc, diachi, sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string TenNCC
        {
            get { return tenncc; }
            set { tenncc = value; }
        }
    }
}
