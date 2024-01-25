using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class BLL_THELOAI
    {
        DAL.DAL_THELOAI dalTL;
        THELOAI frm_TheLoai;
        SACH frm_sach;

        public BLL_THELOAI(THELOAI tl)
        {
            dalTL = new DAL.DAL_THELOAI();
            frm_TheLoai = tl;
            frm_sach = new SACH();
        }

        public void bll_LoadDataTL()
        {
            frm_TheLoai.datagrid_TheLoai.DataSource = dalTL.dal_LoadTL ();
        }
        public void Load_CBTL ()
        {
            frm_sach.cb_TLoai_Sach.DataSource = dalTL.dal_LoadTL ();
            frm_sach.cb_TLoai_Sach.DisplayMember = "TenLoai";
            frm_sach.cb_TLoai_Sach.ValueMember = "MaTheLoai";
        }
        public void bll_Them()
        {
            dalTL.dal_ThemTL(frm_TheLoai.txt_MaTL.Text,
                             frm_TheLoai.txt_TenTL.Text
                            );
        }
        public void bll_Xoa()
        {
            dalTL.dal_XoaTL(frm_TheLoai.txt_MaTL.Text);
        }
        public void bll_Sua()
        {
            dalTL.dal_SuaTL(frm_TheLoai.txt_TenTL.Text,frm_TheLoai.txt_MaTL.Text);
        }
    }
}
