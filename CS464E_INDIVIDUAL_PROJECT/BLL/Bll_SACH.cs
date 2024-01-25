using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class Bll_SACH
    {
        DAL.Dal_SACH dalSach;
        SACH sach;
        public Bll_SACH(SACH fr_Sach)
        {
            dalSach = new DAL.Dal_SACH();
            sach = fr_Sach;
        }

        public void Bll_Them_Sach ()
        {
            dalSach.Dal_Them_Sach(sach.txt_MaSach.Text , sach.txt_TenSach.Text ,sach.cb_TheLoai_Sach.SelectedValue , sach.txtTG_Sach.Text , int.Parse(sach.txt_GiaThanh_Sach.Text) , sach.txt_HinhAnh.Text );
        }
    }
}
