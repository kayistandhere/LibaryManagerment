using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class DAL_THELOAI
    {
        DungChung chung;

        public DAL_THELOAI()
        {
            chung = new DungChung();
        }

        public DataTable dal_LoadTL ()
        {
            string sql = "select * from THELOAI";
            return chung.LoadData (sql);
        }

        public void dal_ThemTL (string maTL, string tenTL)
        {
            string sqlThem = "insert into THELOAI values ( '" + maTL + "' , N'" + tenTL + "'  )";
            chung.LoadData (sqlThem);
        }
        public void dal_XoaTL(string maTL)
        {
            string sqlXoa = "delete from THELOAI where MaTheLoai = '" + maTL + "'";
            chung.LoadData(sqlXoa);
        }
        public void dal_SuaTL(string tenTL , string maTL)
        {
            string sqlSua = "update THELOAI set TenLoai = '" + tenTL + "',where MaTheLoai =  '" + maTL + "'";
            chung.LoadData(sqlSua);
        }
    }
}
