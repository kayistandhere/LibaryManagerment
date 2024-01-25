using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.DAL
{
    internal class DAL_MUONSACH
    {
        DungChung chung;

        public DAL_MUONSACH()
        {
            chung = new DungChung();
        }

        public DataTable dal_LoadMS()
        {
            string sql = "select * from MUONSACH";
            return chung.LoadData(sql);
        }

        public void dal_ThemSach(string mamuon, string masach, string madg, int soluong, DateTime ngaymuon , DateTime ngaytra)
        {
            string dal_MuonSach = "insert into MUONSACH values ('"+mamuon+ "','" + masach + "','" + madg + "','" + soluong + "','" + ngaymuon + "','" + ngaytra + "')";
            chung.NonQuery(dal_MuonSach);
        }

        public void dal_Xoa (string mamuon)
        {
            string sqlXoa = "delete from MUONSACH where MaMuon =  '" + mamuon + "'   ";
            chung.NonQuery (sqlXoa);
        }

        public void dal_Sua (string masach, string madg, int soluong, DateTime ngaymuon, DateTime ngaytra , string mamuon)
        {
            string sqlSua = "Update MUONSACH set MaSach = '" + masach + "' , MaDG = '" 
                                                             + madg + "' , SoLuong = '" 
                                                             + soluong + "' , NgayMuon = '" 
                                                             + ngaymuon + "'  , NgayTra = '" 
                                                             + ngaytra + "'   where MaMuon = '"+mamuon+"' ";
            chung.NonQuery (sqlSua);
        }
    }
}
