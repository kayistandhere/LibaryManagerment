using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT.GUI
{
    public partial class TRANGCHU : Form
    {
        public TRANGCHU()
        {
            InitializeComponent();
        }
        public bool kiemtra(string formName)
        {
            foreach (Form form in this.MdiChildren)   // MdiChildren: Trả về mảng chứa các Form con
            {
                if (form.Name.Equals(formName))
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        private void tHỂLOẠIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*THELOAI TL = new THELOAI();
            TL.MdiParent = this;
            TL.Show();*/
            if (kiemtra("THELOAI") == false)
            {
                THELOAI TL = new THELOAI();
                TL.Show();
                this.Hide();
            }
            else if (kiemtra("THELOAI") == true)
            {
                this.Show();
            }
        }


        private void sÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtra("SACH") == false)
            {
                SACH SA = new SACH();
                SA.Show();
                this.Hide();
            }
            else if (kiemtra("SACH") == true)
            {
                this.Show();
            }
        }

        private void đỘCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kiemtra("DOCGIA") == false)
            {
                DOCGIA SA = new DOCGIA();
                SA.Show();
                this.Hide();
            }
            else if (kiemtra("DOCGIA") == true)
            {
                this.Show();
            }
        }
        private void mƯỢNSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MUONSACH MS = new MUONSACH();
            MS.MdiParent = this;
            MS.Show();
            if (kiemtra("MUONSACH") == false)
            {
                MUONSACH SA = new MUONSACH();
                SA.Show();
                this.Hide();
            }
            else if (kiemtra("MUONSACH") == true)
            {
                this.Show(); 
            }
        }
        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TRANGCHU_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
