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
        DungChung chung;
        BLL.BLL_DANGNHAP bll_dn;
        SACH sach = new SACH();
        DANGNHAP dn = new DANGNHAP();

        public DANGNHAP()
        {
            InitializeComponent();
            chung = new DungChung();
            bll_dn = new BLL.BLL_DANGNHAP(this);

        }

        private void lb_User_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender,  EventArgs e)
        {
            bll_dn.bll_Login();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Thoát Chương Trình !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void DANGNHAP_Load(object sender, EventArgs e)
        {

        }
    }
}
