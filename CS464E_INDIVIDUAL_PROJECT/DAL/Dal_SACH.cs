using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class Dal_SACH
    {
        DungChung chung;

        public Dal_SACH()
        {
            chung = new DungChung();
        }

        public void Dal_Them_Sach(string masach , string tensach , string theloai , string tacgia , int giathanh , string hinhanh)
        {
            string sqlThemSach = "insert into SACH values ( '" + masach + "' , N'" 
                                                               + tensach + "' , N'" 
                                                               + theloai + "' , N'" 
                                                               + tacgia + "' , '" 
                                                               + giathanh + "' , '" 
                                                               + hinhanh + "'  )";
            chung.NonQuery(sqlThemSach);
        }
    }
}
