using CS464E_INDIVIDUAL_PROJECT.GUI;
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
    public partial class THELOAI : Form
    {
        DungChung chung;
        BLL.BLL_THELOAI bll_tl;
        TRANGCHU TC = new TRANGCHU();
        public THELOAI()
        {
            InitializeComponent();
            chung = new DungChung();
            bll_tl = new BLL.BLL_THELOAI(this);
        }

        private void THELOAI_Load(object sender, EventArgs e)
        {
            Load_TheLoai();
        }

        public void Load_TheLoai ()
        {
            bll_tl.bll_LoadDataTL();
        }

        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            bll_tl.bll_Them();
            Load_TheLoai();
        }

        private void btn_XoaTL_Click(object sender, EventArgs e)
        {
            bll_tl.bll_Xoa();
            Load_TheLoai(); 
        }

        private void btn_SuaTL_Click(object sender, EventArgs e)
        {
            bll_tl.bll_Sua();
            Load_TheLoai();
        }

        private void txt_MaTL_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Thoát Chương Trình !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Close();
            }
            TC.Show();
        }

        private void lb_MaTL_Click(object sender, EventArgs e)
        {

        }
    }
}
