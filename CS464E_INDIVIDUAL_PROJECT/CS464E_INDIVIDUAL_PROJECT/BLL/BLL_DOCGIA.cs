using CS464E_INDIVIDUAL_PROJECT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class BLL_DOCGIA
    {
        DAL.DAL_DOCGIA dalDocGia;
        DOCGIA frm_DocGia;

        public BLL_DOCGIA (DOCGIA dg)
        {
            dalDocGia = new DAL.DAL_DOCGIA ();
            frm_DocGia = dg;
        }

        public void bll_LoadDataDG ()
        {
            frm_DocGia.datagrid_DG.DataSource = dalDocGia.dal_LoadDG();
        }
        public void bll_ThemDG()
        {
            dalDocGia.dal_ThemDG(frm_DocGia.txt_MaDG.Text,
                                 frm_DocGia.txt_TenDG.Text,
                                 frm_DocGia.txt_NgaySinhDG.Value,
                                 frm_DocGia.txt_DiaChi.Text,
                                 int.Parse(frm_DocGia.txt_SDT.Text)
                                 );
        }

        public void bll_XoaDG()
        {
            dalDocGia.dal_XoaDG(frm_DocGia.txt_MaDG.Text);
        }

        public void bll_SuaDG()
        {
            dalDocGia.dal_SuaDG(frm_DocGia.txt_TenDG.Text,
                                frm_DocGia.txt_NgaySinhDG.Value,
                                frm_DocGia.txt_DiaChi.Text,
                                int.Parse(frm_DocGia.txt_SDT.Text),
                                frm_DocGia.txt_MaDG.Text
                                );
        }
    }
}
