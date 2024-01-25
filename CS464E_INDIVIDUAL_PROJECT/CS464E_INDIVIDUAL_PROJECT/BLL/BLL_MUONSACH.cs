using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class BLL_MUONSACH
    {
        DAL.DAL_MUONSACH dalMS;
        MUONSACH frm_MuonSach;

        public BLL_MUONSACH(MUONSACH ms)
        {
            dalMS = new DAL.DAL_MUONSACH();
            frm_MuonSach = ms;
        }

        public void bll_LoadDataTL()
        {
            frm_MuonSach.datagrid_MSach.DataSource = dalMS.dal_LoadMS();
        }

        public void bll_ThemMuon()
        {
            dalMS.dal_ThemSach(frm_MuonSach.txt_MaMuonSach.Text,
                                 frm_MuonSach.cb_MaSachMuon.SelectedValue.ToString(),
                                 frm_MuonSach.cb_MaDGMuon.SelectedValue.ToString(),
                                 int.Parse(frm_MuonSach.txt_SoLuong.Text),
                                 frm_MuonSach.dt_NgayMuon.Value,
                                 frm_MuonSach.dt_NgayTra.Value);
        }

        public void bll_XoaMuon ()
        {
            dalMS.dal_Xoa(frm_MuonSach.txt_MaMuonSach.Text);
        }

        public void bll_SuaMuon ()
        {
            dalMS.dal_Sua( frm_MuonSach.cb_MaSachMuon.SelectedValue.ToString(),
                           frm_MuonSach.cb_MaDGMuon.SelectedValue.ToString(),
                           int.Parse (frm_MuonSach.txt_SoLuong.Text),
                           frm_MuonSach.dt_NgayMuon.Value,
                           frm_MuonSach.dt_NgayTra.Value,
                           frm_MuonSach.txt_MaMuonSach.Text  );
        }
    }
}
