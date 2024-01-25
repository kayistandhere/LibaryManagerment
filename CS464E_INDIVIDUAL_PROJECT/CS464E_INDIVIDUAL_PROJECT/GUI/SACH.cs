using CS464E_INDIVIDUAL_PROJECT.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT
{
    public partial class SACH : Form
    {
        DungChung chung;
        BLL.BLL_SACH bllsach;
        TRANGCHU TC = new TRANGCHU();
        public SACH()
        {
            InitializeComponent();
            chung = new DungChung();
            bllsach = new BLL.BLL_SACH(this);
        }
        private void lb_TacGia_Click(object sender, EventArgs e)
        {

        }

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            bllsach.bll_ThemSach();
            LoadDataGrid();
        }
        public void LoadCBTLoai()
        {
            string sqlTheLoai = "select * from THELOAI ";
            cb_TLoai_Sach.DataSource = chung.LoadData(sqlTheLoai);
            cb_TLoai_Sach.DisplayMember = "MaTheLoai";
            cb_TLoai_Sach.ValueMember = "MaTheLoai";
        }

        private void datagrid_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = datagrid_Sach.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_TenSach.Text = datagrid_Sach.CurrentRow.Cells["TenSach"].Value.ToString();
            cb_TLoai_Sach.Text = datagrid_Sach.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txt_TG_Sach.Text = datagrid_Sach.CurrentRow.Cells["TacGia"].Value.ToString();
            txt_GiaThanh.Text = datagrid_Sach.CurrentRow.Cells["GiaThanh"].Value.ToString();
            txt_anh.Text = datagrid_Sach.CurrentRow.Cells["HinhAnh"].Value.ToString();
            picB_Hinh.ImageLocation = duongdan + txt_anh.Text;
        }

        private void SACH_Load(object sender, EventArgs e)
        {
            LoadCBTLoai();
            LoadDataGrid();
        }

        private void datagrid_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = datagrid_Sach.CurrentRow.Cells["MaSach"].Value.ToString();
            txt_TenSach.Text = datagrid_Sach.CurrentRow.Cells["TenSach"].Value.ToString();
            cb_TLoai_Sach.Text = datagrid_Sach.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txt_TG_Sach.Text = datagrid_Sach.CurrentRow.Cells["TacGia"].Value.ToString();
            txt_GiaThanh.Text = datagrid_Sach.CurrentRow.Cells["GiaThanh"].Value.ToString();
        }

        private void txt_MaSach_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadDataGrid ()
        {
            bllsach.bll_LoadDataSach();
        }

        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            bllsach.bll_XoaSach();
            picB_Hinh.Image.Save(duongdan + txt_anh.Text);
            LoadDataGrid ();
        }

        private void btn_SuaSach_Click(object sender, EventArgs e)
        {
            bllsach.bll_SuaSach();
            picB_Hinh.Image.Save(duongdan + txt_anh.Text);
            LoadDataGrid();
        }

        private void btb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Thoát Chương Trình !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                //Application.Exit();
                this.Close();
            }
            TC.Show();
        }

        private void txt_TenAnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void picB_Hinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn File";
            OFD.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg|chọn tất cả ảnh|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                picB_Hinh.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void cb_TLoai_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string chonTL = cb_TLoai_Sach.SelectedValue.ToString();
            string sqlLoadGrid = "select * from SACH where MaSach = '" + chonTL + "'  ";
            datagrid_Sach.DataSource = chung.LoadData(sqlLoadGrid);*/
        }

        private void btn_QLDG_Click(object sender, EventArgs e)
        {
            DOCGIA dg = new DOCGIA();
            dg.Show();
        }
        private void btn_DSMS_Click(object sender, EventArgs e)
        {
            MUONSACH ms = new MUONSACH();
            ms.Show();
        }

        private void btn_DSTL_Click(object sender, EventArgs e)
        {
            THELOAI tl = new THELOAI();
            tl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picB_Hinh.Image.Save(duongdan + txt_anh.Text);
        }

        private void btn_CapNhap_Click(object sender, EventArgs e)
        {
            bllsach.Bll_Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bllsach.Bll_dem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //   bllsach.Bll_Tim();
         string sqlTim = "select * from SACH where MaSach = '"+txt_tim.Text+"'";
            datagrid_Sach.DataSource = chung.LoadData(sqlTim);
        }
    }
}
