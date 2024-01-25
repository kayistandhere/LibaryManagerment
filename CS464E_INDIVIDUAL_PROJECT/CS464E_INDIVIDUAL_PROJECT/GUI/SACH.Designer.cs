namespace CS464E_INDIVIDUAL_PROJECT
{
    partial class SACH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_anh = new System.Windows.Forms.TextBox();
            this.txt_HinhAnh = new System.Windows.Forms.Label();
            this.cb_TLoai_Sach = new System.Windows.Forms.ComboBox();
            this.picB_Hinh = new System.Windows.Forms.PictureBox();
            this.txt_GiaThanh = new System.Windows.Forms.TextBox();
            this.txt_TG_Sach = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.lb_TenSach = new System.Windows.Forms.Label();
            this.lb_TheLoai = new System.Windows.Forms.Label();
            this.lb_TacGia = new System.Windows.Forms.Label();
            this.lb_GiaThanh = new System.Windows.Forms.Label();
            this.lb_MaSach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_XoaSach = new System.Windows.Forms.Button();
            this.btb_Thoat = new System.Windows.Forms.Button();
            this.btn_SuaSach = new System.Windows.Forms.Button();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.datagrid_Sach = new System.Windows.Forms.DataGridView();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_DSTL = new System.Windows.Forms.Button();
            this.btn_DSMS = new System.Windows.Forms.Button();
            this.btn_QLDG = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Hinh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Sach)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_anh);
            this.panel1.Controls.Add(this.txt_HinhAnh);
            this.panel1.Controls.Add(this.cb_TLoai_Sach);
            this.panel1.Controls.Add(this.picB_Hinh);
            this.panel1.Controls.Add(this.txt_GiaThanh);
            this.panel1.Controls.Add(this.txt_TG_Sach);
            this.panel1.Controls.Add(this.txt_TenSach);
            this.panel1.Controls.Add(this.txt_MaSach);
            this.panel1.Controls.Add(this.lb_TenSach);
            this.panel1.Controls.Add(this.lb_TheLoai);
            this.panel1.Controls.Add(this.lb_TacGia);
            this.panel1.Controls.Add(this.lb_GiaThanh);
            this.panel1.Controls.Add(this.lb_MaSach);
            this.panel1.Location = new System.Drawing.Point(685, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 249);
            this.panel1.TabIndex = 0;
            // 
            // txt_anh
            // 
            this.txt_anh.Location = new System.Drawing.Point(106, 213);
            this.txt_anh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_anh.Name = "txt_anh";
            this.txt_anh.Size = new System.Drawing.Size(120, 20);
            this.txt_anh.TabIndex = 13;
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.AutoSize = true;
            this.txt_HinhAnh.Location = new System.Drawing.Point(19, 218);
            this.txt_HinhAnh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(51, 13);
            this.txt_HinhAnh.TabIndex = 12;
            this.txt_HinhAnh.Text = "Hình Ảnh";
            // 
            // cb_TLoai_Sach
            // 
            this.cb_TLoai_Sach.FormattingEnabled = true;
            this.cb_TLoai_Sach.Location = new System.Drawing.Point(106, 98);
            this.cb_TLoai_Sach.Margin = new System.Windows.Forms.Padding(2);
            this.cb_TLoai_Sach.Name = "cb_TLoai_Sach";
            this.cb_TLoai_Sach.Size = new System.Drawing.Size(120, 21);
            this.cb_TLoai_Sach.TabIndex = 11;
            this.cb_TLoai_Sach.SelectedIndexChanged += new System.EventHandler(this.cb_TLoai_Sach_SelectedIndexChanged);
            // 
            // picB_Hinh
            // 
            this.picB_Hinh.Image = global::CS464E_INDIVIDUAL_PROJECT.Properties.Resources.click;
            this.picB_Hinh.Location = new System.Drawing.Point(242, 19);
            this.picB_Hinh.Margin = new System.Windows.Forms.Padding(2);
            this.picB_Hinh.Name = "picB_Hinh";
            this.picB_Hinh.Size = new System.Drawing.Size(172, 214);
            this.picB_Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_Hinh.TabIndex = 10;
            this.picB_Hinh.TabStop = false;
            this.picB_Hinh.Click += new System.EventHandler(this.picB_Hinh_Click);
            // 
            // txt_GiaThanh
            // 
            this.txt_GiaThanh.Location = new System.Drawing.Point(106, 176);
            this.txt_GiaThanh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GiaThanh.Name = "txt_GiaThanh";
            this.txt_GiaThanh.Size = new System.Drawing.Size(120, 20);
            this.txt_GiaThanh.TabIndex = 9;
            // 
            // txt_TG_Sach
            // 
            this.txt_TG_Sach.Location = new System.Drawing.Point(106, 136);
            this.txt_TG_Sach.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TG_Sach.Name = "txt_TG_Sach";
            this.txt_TG_Sach.Size = new System.Drawing.Size(120, 20);
            this.txt_TG_Sach.TabIndex = 8;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(106, 58);
            this.txt_TenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(120, 20);
            this.txt_TenSach.TabIndex = 7;
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(106, 19);
            this.txt_MaSach.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(120, 20);
            this.txt_MaSach.TabIndex = 6;
            this.txt_MaSach.TextChanged += new System.EventHandler(this.txt_MaSach_TextChanged);
            // 
            // lb_TenSach
            // 
            this.lb_TenSach.AutoSize = true;
            this.lb_TenSach.Location = new System.Drawing.Point(16, 63);
            this.lb_TenSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenSach.Name = "lb_TenSach";
            this.lb_TenSach.Size = new System.Drawing.Size(54, 13);
            this.lb_TenSach.TabIndex = 5;
            this.lb_TenSach.Text = "Tên Sách";
            // 
            // lb_TheLoai
            // 
            this.lb_TheLoai.AutoSize = true;
            this.lb_TheLoai.Location = new System.Drawing.Point(19, 105);
            this.lb_TheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TheLoai.Name = "lb_TheLoai";
            this.lb_TheLoai.Size = new System.Drawing.Size(49, 13);
            this.lb_TheLoai.TabIndex = 4;
            this.lb_TheLoai.Text = "Thể Loại";
            // 
            // lb_TacGia
            // 
            this.lb_TacGia.AutoSize = true;
            this.lb_TacGia.Location = new System.Drawing.Point(19, 141);
            this.lb_TacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TacGia.Name = "lb_TacGia";
            this.lb_TacGia.Size = new System.Drawing.Size(45, 13);
            this.lb_TacGia.TabIndex = 3;
            this.lb_TacGia.Text = "Tác Giả";
            this.lb_TacGia.Click += new System.EventHandler(this.lb_TacGia_Click);
            // 
            // lb_GiaThanh
            // 
            this.lb_GiaThanh.AutoSize = true;
            this.lb_GiaThanh.Location = new System.Drawing.Point(19, 180);
            this.lb_GiaThanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_GiaThanh.Name = "lb_GiaThanh";
            this.lb_GiaThanh.Size = new System.Drawing.Size(57, 13);
            this.lb_GiaThanh.TabIndex = 2;
            this.lb_GiaThanh.Text = "Giá Thành";
            // 
            // lb_MaSach
            // 
            this.lb_MaSach.AutoSize = true;
            this.lb_MaSach.Location = new System.Drawing.Point(19, 24);
            this.lb_MaSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaSach.Name = "lb_MaSach";
            this.lb_MaSach.Size = new System.Drawing.Size(50, 13);
            this.lb_MaSach.TabIndex = 0;
            this.lb_MaSach.Text = "Mã Sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_CapNhap);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_XoaSach);
            this.panel2.Controls.Add(this.btb_Thoat);
            this.panel2.Controls.Add(this.btn_SuaSach);
            this.panel2.Controls.Add(this.btn_ThemSach);
            this.panel2.Location = new System.Drawing.Point(685, 487);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 112);
            this.panel2.TabIndex = 2;
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.Location = new System.Drawing.Point(219, 59);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(92, 39);
            this.btn_CapNhap.TabIndex = 7;
            this.btn_CapNhap.Text = "Cập Nhập";
            this.btn_CapNhap.UseVisualStyleBackColor = true;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhap_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Đếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu Hình";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_XoaSach
            // 
            this.btn_XoaSach.Location = new System.Drawing.Point(113, 14);
            this.btn_XoaSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaSach.Name = "btn_XoaSach";
            this.btn_XoaSach.Size = new System.Drawing.Size(99, 39);
            this.btn_XoaSach.TabIndex = 3;
            this.btn_XoaSach.Text = "Xóa";
            this.btn_XoaSach.UseVisualStyleBackColor = true;
            this.btn_XoaSach.Click += new System.EventHandler(this.btn_XoaSach_Click);
            // 
            // btb_Thoat
            // 
            this.btb_Thoat.Location = new System.Drawing.Point(319, 60);
            this.btb_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btb_Thoat.Name = "btb_Thoat";
            this.btb_Thoat.Size = new System.Drawing.Size(95, 39);
            this.btb_Thoat.TabIndex = 2;
            this.btb_Thoat.Text = "Thoát";
            this.btb_Thoat.UseVisualStyleBackColor = true;
            this.btb_Thoat.Click += new System.EventHandler(this.btb_Thoat_Click);
            // 
            // btn_SuaSach
            // 
            this.btn_SuaSach.Location = new System.Drawing.Point(113, 59);
            this.btn_SuaSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaSach.Name = "btn_SuaSach";
            this.btn_SuaSach.Size = new System.Drawing.Size(99, 39);
            this.btn_SuaSach.TabIndex = 1;
            this.btn_SuaSach.Text = "Sửa";
            this.btn_SuaSach.UseVisualStyleBackColor = true;
            this.btn_SuaSach.Click += new System.EventHandler(this.btn_SuaSach_Click);
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Location = new System.Drawing.Point(12, 14);
            this.btn_ThemSach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(97, 40);
            this.btn_ThemSach.TabIndex = 0;
            this.btn_ThemSach.Text = "Thêm";
            this.btn_ThemSach.UseVisualStyleBackColor = true;
            this.btn_ThemSach.Click += new System.EventHandler(this.btn_ThemSach_Click);
            // 
            // datagrid_Sach
            // 
            this.datagrid_Sach.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Sach.Location = new System.Drawing.Point(11, 113);
            this.datagrid_Sach.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_Sach.Name = "datagrid_Sach";
            this.datagrid_Sach.RowHeadersWidth = 51;
            this.datagrid_Sach.RowTemplate.Height = 24;
            this.datagrid_Sach.Size = new System.Drawing.Size(654, 488);
            this.datagrid_Sach.TabIndex = 3;
            this.datagrid_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Sach_CellClick);
            this.datagrid_Sach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Sach_CellContentClick);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(480, 21);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(222, 32);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "QUẢN LÝ SÁCH";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_DSTL);
            this.panel3.Controls.Add(this.btn_DSMS);
            this.panel3.Controls.Add(this.btn_QLDG);
            this.panel3.Location = new System.Drawing.Point(685, 336);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 138);
            this.panel3.TabIndex = 5;
            // 
            // btn_DSTL
            // 
            this.btn_DSTL.Location = new System.Drawing.Point(12, 94);
            this.btn_DSTL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DSTL.Name = "btn_DSTL";
            this.btn_DSTL.Size = new System.Drawing.Size(402, 33);
            this.btn_DSTL.TabIndex = 2;
            this.btn_DSTL.Text = "Thể Loại Sách";
            this.btn_DSTL.UseVisualStyleBackColor = true;
            this.btn_DSTL.Click += new System.EventHandler(this.btn_DSTL_Click);
            // 
            // btn_DSMS
            // 
            this.btn_DSMS.Location = new System.Drawing.Point(12, 55);
            this.btn_DSMS.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DSMS.Name = "btn_DSMS";
            this.btn_DSMS.Size = new System.Drawing.Size(402, 35);
            this.btn_DSMS.TabIndex = 1;
            this.btn_DSMS.Text = "Danh Sách Mượn Sách";
            this.btn_DSMS.UseVisualStyleBackColor = true;
            this.btn_DSMS.Click += new System.EventHandler(this.btn_DSMS_Click);
            // 
            // btn_QLDG
            // 
            this.btn_QLDG.Location = new System.Drawing.Point(12, 11);
            this.btn_QLDG.Margin = new System.Windows.Forms.Padding(2);
            this.btn_QLDG.Name = "btn_QLDG";
            this.btn_QLDG.Size = new System.Drawing.Size(402, 40);
            this.btn_QLDG.TabIndex = 0;
            this.btn_QLDG.Text = "Quản Lý Đọc Giả";
            this.btn_QLDG.UseVisualStyleBackColor = true;
            this.btn_QLDG.Click += new System.EventHandler(this.btn_QLDG_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_Dem);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_tim);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(11, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(654, 35);
            this.panel4.TabIndex = 6;
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(541, 7);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(100, 20);
            this.txt_Dem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đếm";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(87, 7);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(367, 20);
            this.txt_tim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // SACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1125, 610);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.datagrid_Sach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SACH";
            this.Text = "SACH";
            this.Load += new System.EventHandler(this.SACH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Hinh)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Sach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_GiaThanh;
        public System.Windows.Forms.TextBox txt_TG_Sach;
        public System.Windows.Forms.TextBox txt_TenSach;
        public System.Windows.Forms.TextBox txt_MaSach;
        public System.Windows.Forms.Label lb_TenSach;
        public System.Windows.Forms.Label lb_TheLoai;
        public System.Windows.Forms.Label lb_TacGia;
        public System.Windows.Forms.Label lb_GiaThanh;
        public System.Windows.Forms.Label lb_MaSach;
        public System.Windows.Forms.ComboBox cb_TLoai_Sach;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_XoaSach;
        public System.Windows.Forms.Button btb_Thoat;
        public System.Windows.Forms.Button btn_SuaSach;
        public System.Windows.Forms.Button btn_ThemSach;
        public System.Windows.Forms.DataGridView datagrid_Sach;
        public System.Windows.Forms.Label lb_Title;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btn_DSTL;
        public System.Windows.Forms.Button btn_DSMS;
        public System.Windows.Forms.Button btn_QLDG;
        public System.Windows.Forms.TextBox txt_anh;
        public System.Windows.Forms.Label txt_HinhAnh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picB_Hinh;
        private System.Windows.Forms.Button btn_CapNhap;
    }
}