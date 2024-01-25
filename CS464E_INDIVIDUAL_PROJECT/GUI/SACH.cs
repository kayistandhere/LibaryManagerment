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
        DAL.DungChung chung;
        BLL.Bll_SACH bllsach;
        public SACH()
        {
            InitializeComponent();
            chung = new DAL.DungChung();
            bllsach = new BLL.Bll_SACH(this);
        }

        private void lb_TacGia_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            picB_Hinh.Image.Save(duongdan + txt_HinhAnh.Text);
            
        }

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void picB_Hinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn File";
            OFD.Filter = "Tất cả File|*.*|file JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                picB_Hinh.Image = Image.FromFile(OFD.FileName);
                bllsach.Bll_Them_Sach();
            }
        }

        public void LoadCBTLoai ()
        {
            string chonTL = cb_TheLoai_Sach.SelectedValue.ToString();
            string sqlLoadGrid = "select * from SACH where MaSach = '" + chonTL + "'  ";
            datagrid_Sach.DataSource = chung.LoadData(sqlLoadGrid);
        }

        private void cb_TheLoai_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlTheLoai = "select * from THELOAI ";
            cb_TheLoai_Sach.DataSource = chung.LoadData(sqlTheLoai);
            cb_TheLoai_Sach.DisplayMember = "TenLoai";
            cb_TheLoai_Sach.ValueMember = "MaTheLoai";
        }

        private void SACH_Load(object sender, EventArgs e)
        {
            LoadCBTLoai();
        }
    }
}
