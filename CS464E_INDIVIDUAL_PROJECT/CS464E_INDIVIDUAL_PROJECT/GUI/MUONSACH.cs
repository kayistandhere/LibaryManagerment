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
    public partial class MUONSACH : Form
    {
        DungChung chung;
        BLL.BLL_MUONSACH bll_ms;
        TRANGCHU TC = new TRANGCHU();
        public MUONSACH()
        {
            InitializeComponent();
            chung = new DungChung();
            bll_ms = new BLL.BLL_MUONSACH(this);
        }

        private void MUONSACH_Load(object sender, EventArgs e)
        {
            LoadCBMaDG();
            LoadCBMaMuonSach();
            Load_MuonSach();
        }

        public void Load_MuonSach ()
        {
            bll_ms.bll_LoadDataTL();
        }

        private void cb_MaSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string chonMS = cb_MaSachMuon.SelectedValue.ToString();
            string sqlLoadGrid = "select *from SACH where MaSach =  '" + chonMS + "'  ";
            datagrid_MSach.DataSource = chung.LoadData(sqlLoadGrid);*/
        }

        private void cb_MaDGMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string chonDG = cb_MaDGMuon.SelectedItem.ToString();
            string sqlLoadGrid = "select * from DOCGIA where MaDG = '" + chonDG + "' ";
            datagrid_MSach.DataSource = chung.LoadData(sqlLoadGrid);*/
        }

        public void LoadCBMaMuonSach ()
        {
            string sqlMaMuon = "select * from SACH";
            cb_MaSachMuon.DataSource = chung.LoadData(sqlMaMuon);
            cb_MaSachMuon.DisplayMember = "MaSach";
            cb_MaSachMuon.ValueMember = "MaSach";
        }

        public void LoadCBMaDG ()
        {
            string sqlDocGia = "select * from DOCGIA ";
            cb_MaDGMuon.DataSource = chung.LoadData(sqlDocGia);
            cb_MaDGMuon.DisplayMember = "MaDG";
            cb_MaDGMuon.ValueMember = "MaDG";
        }

        private void datagrid_MSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMuonSach.Text = datagrid_MSach.CurrentRow.Cells["MaMuon"].Value.ToString();
            cb_MaSachMuon.Text = datagrid_MSach.CurrentRow.Cells["MaSach"].Value.ToString();
            cb_MaDGMuon.Text = datagrid_MSach.CurrentRow.Cells["MaDG"].Value.ToString();
            txt_SoLuong.Text = datagrid_MSach.CurrentRow.Cells["SoLuong"].Value.ToString();
            dt_NgayMuon.Text = datagrid_MSach.CurrentRow.Cells["NgayMuon"].Value.ToString();
            dt_NgayTra.Text = datagrid_MSach.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

        private void datagrid_MSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMuonSach.Text = datagrid_MSach.CurrentRow.Cells["MaMuon"].Value.ToString();
            cb_MaSachMuon.Text = datagrid_MSach.CurrentRow.Cells["MaSach"].Value.ToString();
            cb_MaDGMuon.Text = datagrid_MSach.CurrentRow.Cells["MaDG"].Value.ToString();
            txt_SoLuong.Text = datagrid_MSach.CurrentRow.Cells["SoLuong"].Value.ToString();
            dt_NgayMuon.Text = datagrid_MSach.CurrentRow.Cells["NgayMuon"].Value.ToString();
            dt_NgayTra.Text = datagrid_MSach.CurrentRow.Cells["NgayTra"].Value.ToString();
        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            bll_ms.bll_ThemMuon();
            Load_MuonSach();
        }

        private void btn_XoaMuon_Click(object sender, EventArgs e)
        {
            bll_ms.bll_XoaMuon();
            Load_MuonSach();
        }

        private void btn_SuaMuon_Click(object sender, EventArgs e)
        {
            bll_ms.bll_SuaMuon();
            Load_MuonSach();
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
    }
}
