using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class DAL_SACH
    {
        DungChung chung;

        public DAL_SACH()
        {
            chung = new DungChung();
        }

        public DataTable dal_LoadData()
        {
            string sqlLoad = "select * from SACH";
            return chung.LoadData(sqlLoad);
        }

        public void dal_ThemSach(string masach, string tensach, string maTL, string tacgia, int giathanh, string hinhanh)
        {
            string sqlThem = "insert into SACH values ( '" + masach + "' , N'"
                                                           + tensach + "' , '"
                                                           + maTL + "' , N'"
                                                           + tacgia + "' , '"
                                                           + giathanh + "','"
                                                           + hinhanh + "'  )";
            chung.NonQuery(sqlThem);
        }

        public void dal_XoaSach(string masach)
        {
            string sqlXoa = "delete from SACH where MaSach = '" + masach + "'";
            chung.NonQuery(sqlXoa);
        }

        public void dal_SuaSach (string tensach, string maTL, string tacgia, int giathanh, string hinhanh , string masach)
        {
            string sqlSua = "Update SACH set TenSach = '" + tensach 
                                      + "' , MaTheLoai = '" + maTL 
                                      + "' , TacGia = '" + tacgia 
                                      + "' , GiaThanh = '" + giathanh 
                                      + "' , HinhAnh = '" + hinhanh 
                                      + "' where MaSach = '" + masach + "'    ";
            chung.NonQuery (sqlSua);
        }
        public void DALUpdatedata()
        {
            chung.Updatedata();
        }
        public int dal_Dem()
        {
            string sqlDem = "select count(*) from SACH";
            return chung.scalar(sqlDem);
        }

    }
}
