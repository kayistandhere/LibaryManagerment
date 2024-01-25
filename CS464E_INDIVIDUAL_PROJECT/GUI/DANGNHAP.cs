using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT
{
    public partial class DANGNHAP : Form
    {
        BLL.Bll_DANGNHAP bll_DN;
        public DANGNHAP()
        {
            InitializeComponent();
            bll_DN = new BLL.Bll_DANGNHAP(this);
        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int ketqua = bll_DN.BLL_DN();
            if (ketqua >=1)
            {
                SACH s = new SACH();
                s.Show();
            }
            else
            {
                MessageBox.Show("Nhap sai ");
            }
        }
    }
}
