using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class Dal_DANGNHAP
    {
        DungChung chung;

        public Dal_DANGNHAP()
        {
            chung = new DungChung();
        }

        public int DAL_DN (string TK , string MK )
        {
            string sqlDN = "select count (*) from DANGNHAP where TaiKhoan = '" + TK + "' and MatKhau = '" + MK + "'   ";
            return (int)chung.Scalar(sqlDN);
        }
    }
}
