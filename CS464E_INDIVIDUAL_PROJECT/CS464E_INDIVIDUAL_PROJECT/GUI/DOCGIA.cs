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
    public partial class DOCGIA : Form
    {
        DungChung chung;
        BLL.BLL_DOCGIA bll_dg;
        TRANGCHU TC = new TRANGCHU();
        public DOCGIA()
        {
            InitializeComponent();
            chung = new DungChung();
            bll_dg = new BLL.BLL_DOCGIA(this);
        }

        private void lb_TenDG_Click(object sender, EventArgs e)
        {

        }

        private void DOCGIA_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagrid_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDG.Text = datagrid_DG.CurrentRow.Cells["MaDG"].Value.ToString();
            txt_TenDG.Text = datagrid_DG.CurrentRow.Cells["TenDG"].Value.ToString();
            txt_NgaySinhDG.Text = datagrid_DG.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_DiaChi.Text = datagrid_DG.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_DiaChi.Text = datagrid_DG.CurrentRow.Cells["SoDienThoai"].Value.ToString();
        }

        public void LoadDataGrid ()
        {
            bll_dg.bll_LoadDataDG();
        }

        private void datagrid_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDG.Text = datagrid_DG.CurrentRow.Cells["MaDG"].Value.ToString();
            txt_TenDG.Text = datagrid_DG.CurrentRow.Cells["TenDG"].Value.ToString();
            txt_NgaySinhDG.Text = datagrid_DG.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_DiaChi.Text = datagrid_DG.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_DiaChi.Text = datagrid_DG.CurrentRow.Cells["SoDienThoai"].Value.ToString();
        }

        private void btn_ThemDG_Click(object sender, EventArgs e)
        {
            bll_dg.bll_ThemDG();
            LoadDataGrid();
        }

        private void btb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Thoát Chương Trình !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
               this.Close();
            }
            TC.Show();
        }

        private void btn_XoaDG_Click(object sender, EventArgs e)
        {
            bll_dg.bll_XoaDG();
            LoadDataGrid();
        }

        private void btn_SuaDG_Click(object sender, EventArgs e)
        {
            bll_dg.bll_SuaDG();
            LoadDataGrid();
        }
    }
}
