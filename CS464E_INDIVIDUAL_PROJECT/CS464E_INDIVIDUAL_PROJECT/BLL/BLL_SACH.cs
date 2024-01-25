using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class BLL_SACH
    {
        DAL.DAL_SACH dalsach;
        SACH sach;

        public BLL_SACH(SACH frm_Sach)
        {
            dalsach = new DAL.DAL_SACH();
            sach = frm_Sach;
        }

        public void bll_LoadDataSach()
        {
            sach.datagrid_Sach.DataSource = dalsach.dal_LoadData();
        }

        public void bll_ThemSach()
        {
            dalsach.dal_ThemSach(sach.txt_MaSach.Text, 
                                 sach.txt_TenSach.Text, 
                                 sach.cb_TLoai_Sach.SelectedValue.ToString(), 
                                 sach.txt_TG_Sach.Text, 
                                 int.Parse(sach.txt_GiaThanh.Text), 
                                 sach.txt_HinhAnh.Text);
        }
        
        public void bll_XoaSach()
        {
            dalsach.dal_XoaSach(sach.txt_MaSach.Text);
        }
        public void bll_SuaSach()
        {
            dalsach.dal_SuaSach(sach.txt_TenSach.Text, 
                                sach.cb_TLoai_Sach.SelectedValue.ToString(), 
                                sach.txt_TG_Sach.Text, 
                                int.Parse(sach.txt_GiaThanh.Text), 
                                sach.txt_HinhAnh.Text, 
                                sach.txt_MaSach.Text);
        }
       public void Bll_Update()
        {
            dalsach.DALUpdatedata();
        }
        public void Bll_dem()
        {
            int ketqua = dalsach.dal_Dem();
            sach.txt_Dem.Text = ketqua.ToString();
        }
        public void Bll_Tim()
        {
            //dalsach.dal_Tim(sach.txt_tim.Text);

        }
    }
}
