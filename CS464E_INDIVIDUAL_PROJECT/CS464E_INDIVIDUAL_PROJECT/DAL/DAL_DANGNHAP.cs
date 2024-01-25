using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class DAL_DANGNHAP
    {
        DungChung chung;

        public DAL_DANGNHAP ()
        {
            chung = new DungChung ();
        }

        public int dal_Login (string user , string pass)
        {
            string sqlLogin = "select (*) from DANGNHAP where TaiKhoan = '" + user + "' , MatKhau = '" + pass + "'   ";
          return  chung.scalar(sqlLogin);
        }
    }
}
