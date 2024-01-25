namespace CS464E_INDIVIDUAL_PROJECT
{
    partial class DOCGIA
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
            this.txt_NgaySinhDG = new System.Windows.Forms.DateTimePicker();
            this.txt_TenDG = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MaDG = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_TenDG = new System.Windows.Forms.Label();
            this.lb_MaDG = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XoaDG = new System.Windows.Forms.Button();
            this.btb_Thoat = new System.Windows.Forms.Button();
            this.btn_SuaDG = new System.Windows.Forms.Button();
            this.btn_ThemDG = new System.Windows.Forms.Button();
            this.datagrd_DG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrd_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_NgaySinhDG);
            this.panel1.Controls.Add(this.txt_TenDG);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.txt_MaDG);
            this.panel1.Controls.Add(this.lb_SDT);
            this.panel1.Controls.Add(this.lb_DiaChi);
            this.panel1.Controls.Add(this.lb_NgaySinh);
            this.panel1.Controls.Add(this.lb_TenDG);
            this.panel1.Controls.Add(this.lb_MaDG);
            this.panel1.Location = new System.Drawing.Point(55, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 304);
            this.panel1.TabIndex = 0;
            // 
            // txt_NgaySinhDG
            // 
            this.txt_NgaySinhDG.Location = new System.Drawing.Point(203, 132);
            this.txt_NgaySinhDG.Name = "txt_NgaySinhDG";
            this.txt_NgaySinhDG.Size = new System.Drawing.Size(168, 22);
            this.txt_NgaySinhDG.TabIndex = 9;
            // 
            // txt_TenDG
            // 
            this.txt_TenDG.Location = new System.Drawing.Point(203, 82);
            this.txt_TenDG.Name = "txt_TenDG";
            this.txt_TenDG.Size = new System.Drawing.Size(168, 22);
            this.txt_TenDG.TabIndex = 8;
            this.txt_TenDG.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(203, 193);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(168, 22);
            this.txt_DiaChi.TabIndex = 7;
            this.txt_DiaChi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(203, 262);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(168, 22);
            this.txt_SDT.TabIndex = 6;
            this.txt_SDT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.Location = new System.Drawing.Point(203, 28);
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.Size = new System.Drawing.Size(168, 22);
            this.txt_MaDG.TabIndex = 5;
            this.txt_MaDG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(44, 268);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(92, 16);
            this.lb_SDT.TabIndex = 4;
            this.lb_SDT.Text = "Số Điện Thoại";
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(44, 199);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(49, 16);
            this.lb_DiaChi.TabIndex = 3;
            this.lb_DiaChi.Text = "Địa Chỉ";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(44, 139);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(69, 16);
            this.lb_NgaySinh.TabIndex = 2;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_TenDG
            // 
            this.lb_TenDG.AutoSize = true;
            this.lb_TenDG.Location = new System.Drawing.Point(44, 88);
            this.lb_TenDG.Name = "lb_TenDG";
            this.lb_TenDG.Size = new System.Drawing.Size(82, 16);
            this.lb_TenDG.TabIndex = 1;
            this.lb_TenDG.Text = "Tên Độc Giả";
            this.lb_TenDG.Click += new System.EventHandler(this.lb_TenDG_Click);
            // 
            // lb_MaDG
            // 
            this.lb_MaDG.AutoSize = true;
            this.lb_MaDG.Location = new System.Drawing.Point(44, 35);
            this.lb_MaDG.Name = "lb_MaDG";
            this.lb_MaDG.Size = new System.Drawing.Size(77, 16);
            this.lb_MaDG.TabIndex = 0;
            this.lb_MaDG.Text = "Mã Độc Giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_XoaDG);
            this.panel2.Controls.Add(this.btb_Thoat);
            this.panel2.Controls.Add(this.btn_SuaDG);
            this.panel2.Controls.Add(this.btn_ThemDG);
            this.panel2.Location = new System.Drawing.Point(511, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 304);
            this.panel2.TabIndex = 1;
            // 
            // btn_XoaDG
            // 
            this.btn_XoaDG.Location = new System.Drawing.Point(60, 88);
            this.btn_XoaDG.Name = "btn_XoaDG";
            this.btn_XoaDG.Size = new System.Drawing.Size(96, 35);
            this.btn_XoaDG.TabIndex = 3;
            this.btn_XoaDG.Text = "Xóa";
            this.btn_XoaDG.UseVisualStyleBackColor = true;
            // 
            // btb_Thoat
            // 
            this.btb_Thoat.Location = new System.Drawing.Point(60, 230);
            this.btb_Thoat.Name = "btb_Thoat";
            this.btb_Thoat.Size = new System.Drawing.Size(96, 35);
            this.btb_Thoat.TabIndex = 2;
            this.btb_Thoat.Text = "Thoát";
            this.btb_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_SuaDG
            // 
            this.btn_SuaDG.Location = new System.Drawing.Point(60, 155);
            this.btn_SuaDG.Name = "btn_SuaDG";
            this.btn_SuaDG.Size = new System.Drawing.Size(96, 35);
            this.btn_SuaDG.TabIndex = 1;
            this.btn_SuaDG.Text = "Sửa";
            this.btn_SuaDG.UseVisualStyleBackColor = true;
            // 
            // btn_ThemDG
            // 
            this.btn_ThemDG.Location = new System.Drawing.Point(60, 22);
            this.btn_ThemDG.Name = "btn_ThemDG";
            this.btn_ThemDG.Size = new System.Drawing.Size(96, 35);
            this.btn_ThemDG.TabIndex = 0;
            this.btn_ThemDG.Text = "Thêm";
            this.btn_ThemDG.UseVisualStyleBackColor = true;
            // 
            // datagrd_DG
            // 
            this.datagrd_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrd_DG.Location = new System.Drawing.Point(55, 44);
            this.datagrd_DG.Name = "datagrd_DG";
            this.datagrd_DG.RowHeadersWidth = 51;
            this.datagrd_DG.RowTemplate.Height = 24;
            this.datagrd_DG.Size = new System.Drawing.Size(721, 244);
            this.datagrd_DG.TabIndex = 2;
            // 
            // DOCGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 627);
            this.Controls.Add(this.datagrd_DG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DOCGIA";
            this.Text = "DOCGIA";
            this.Load += new System.EventHandler(this.DOCGIA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrd_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_TenDG;
        private System.Windows.Forms.Label lb_MaDG;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.DateTimePicker txt_NgaySinhDG;
        private System.Windows.Forms.TextBox txt_TenDG;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MaDG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_XoaDG;
        private System.Windows.Forms.Button btb_Thoat;
        private System.Windows.Forms.Button btn_SuaDG;
        private System.Windows.Forms.Button btn_ThemDG;
        private System.Windows.Forms.DataGridView datagrd_DG;
    }
}