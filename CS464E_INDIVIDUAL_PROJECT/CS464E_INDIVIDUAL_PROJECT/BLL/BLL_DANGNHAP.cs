using CS464E_INDIVIDUAL_PROJECT.DAL;
using CS464E_INDIVIDUAL_PROJECT.GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT.BLL
{
    internal class BLL_DANGNHAP
    {
        DAL.DAL_DANGNHAP dal_DN;
        DANGNHAP frm_DangNhap;
        DungChung dal_dungchung = new DungChung();
        TRANGCHU TC = new TRANGCHU();
        public BLL_DANGNHAP (DANGNHAP dn)
        {
            dal_DN = new DAL.DAL_DANGNHAP ();
            frm_DangNhap = dn;
        }
        int i = 0;
        public void bll_Login ()
        {
            int ketqua = dal_DN.dal_Login(frm_DangNhap.txt_User.Text, frm_DangNhap.txt_Pass.Text);
            if (ketqua >= 1){
                TC.Show();
                frm_DangNhap.Hide();
            }else{
                i++;
                MessageBox.Show("Bạn đã nhập sai lần " + i);
                if (i == 3){
                    MessageBox.Show("Bạn đã nhập sai " + i + " lần và chương trính Thoát");
                    Application.Exit();
                }
            }
        }
    }
}
