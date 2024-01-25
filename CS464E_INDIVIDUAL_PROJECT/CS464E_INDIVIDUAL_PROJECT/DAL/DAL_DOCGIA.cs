using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class DAL_DOCGIA
    {
        DungChung chung;
        
        public DAL_DOCGIA()
        {
            chung = new DungChung();
        }

        public DataTable dal_LoadDG ()
        {
            string sql = "select * from DOCGIA";
            return chung.LoadData(sql);
        }
        public void dal_ThemDG(string MaDG , string TenDG , DateTime NgaySinh , string DiaChi , int SoDienThoai)
        {
            string sqlThemDG = "insert into DOCGIA values  ( '" + MaDG + "' , N'"
                                                           + TenDG + "' , '"
                                                           + NgaySinh + "' , N'"
                                                           + DiaChi + "' , '"
                                                           + SoDienThoai + "' ) ";
            chung.NonQuery(sqlThemDG);
        }
        public void dal_XoaDG(string MaDG)
        {
            string sqlXoaDG = "delete from DOCGIA where MaDG = '" + MaDG + "'";
            chung.NonQuery(sqlXoaDG); 
        }
        public void dal_SuaDG(string TenDG, DateTime NgaySinh, string DiaChi, int SoDienThoai, string MaDG)
        {
            string sqlSua = "Update SACH set TenSach = '" + TenDG
                                      + "' , MaTheLoai = '" + NgaySinh
                                      + "' , TacGia = '" + DiaChi
                                      + "' , GiaThanh = '" + SoDienThoai
                                      + "' where MaSach = '" + MaDG + "'";
            chung.NonQuery(sqlSua);
        }

    }
}
