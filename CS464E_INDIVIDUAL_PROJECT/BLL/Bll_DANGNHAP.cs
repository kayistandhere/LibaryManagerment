using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class Bll_DANGNHAP
    {
        DAL.Dal_DANGNHAP dal;
        DANGNHAP dn;

        public Bll_DANGNHAP(DANGNHAP fr_DN)
        {
            dal = new DAL.Dal_DANGNHAP();
            dn = fr_DN;
        }

        public int BLL_DN()
        {
            return dal.DAL_DN(dn.txt_User.Text, dn.txt_Pass.Text);
        }
    }
}
