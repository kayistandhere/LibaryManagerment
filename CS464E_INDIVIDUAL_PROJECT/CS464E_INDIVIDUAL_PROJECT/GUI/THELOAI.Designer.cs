namespace CS464E_INDIVIDUAL_PROJECT
{
    partial class THELOAI
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
            this.txt_TenTL = new System.Windows.Forms.TextBox();
            this.lb_TenTL = new System.Windows.Forms.Label();
            this.lb_MaTL = new System.Windows.Forms.Label();
            this.txt_MaTL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XoaTL = new System.Windows.Forms.Button();
            this.btn_SuaTL = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_ThemTL = new System.Windows.Forms.Button();
            this.datagrid_TheLoai = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TenTL);
            this.panel1.Controls.Add(this.lb_TenTL);
            this.panel1.Controls.Add(this.lb_MaTL);
            this.panel1.Controls.Add(this.txt_MaTL);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 77);
            this.panel1.TabIndex = 0;
            // 
            // txt_TenTL
            // 
            this.txt_TenTL.Location = new System.Drawing.Point(76, 47);
            this.txt_TenTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenTL.Name = "txt_TenTL";
            this.txt_TenTL.Size = new System.Drawing.Size(179, 20);
            this.txt_TenTL.TabIndex = 3;
            // 
            // lb_TenTL
            // 
            this.lb_TenTL.AutoSize = true;
            this.lb_TenTL.Location = new System.Drawing.Point(11, 47);
            this.lb_TenTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenTL.Name = "lb_TenTL";
            this.lb_TenTL.Size = new System.Drawing.Size(49, 13);
            this.lb_TenTL.TabIndex = 2;
            this.lb_TenTL.Text = "Tên Loại";
            // 
            // lb_MaTL
            // 
            this.lb_MaTL.AutoSize = true;
            this.lb_MaTL.Location = new System.Drawing.Point(11, 16);
            this.lb_MaTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaTL.Name = "lb_MaTL";
            this.lb_MaTL.Size = new System.Drawing.Size(45, 13);
            this.lb_MaTL.TabIndex = 1;
            this.lb_MaTL.Text = "Mã Loại";
            this.lb_MaTL.Click += new System.EventHandler(this.lb_MaTL_Click);
            // 
            // txt_MaTL
            // 
            this.txt_MaTL.Location = new System.Drawing.Point(76, 13);
            this.txt_MaTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaTL.Name = "txt_MaTL";
            this.txt_MaTL.Size = new System.Drawing.Size(179, 20);
            this.txt_MaTL.TabIndex = 0;
            this.txt_MaTL.TextChanged += new System.EventHandler(this.txt_MaTL_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_XoaTL);
            this.panel2.Controls.Add(this.btn_SuaTL);
            this.panel2.Controls.Add(this.btn_Thoat);
            this.panel2.Controls.Add(this.btn_ThemTL);
            this.panel2.Location = new System.Drawing.Point(11, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 104);
            this.panel2.TabIndex = 1;
            // 
            // btn_XoaTL
            // 
            this.btn_XoaTL.Location = new System.Drawing.Point(14, 58);
            this.btn_XoaTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XoaTL.Name = "btn_XoaTL";
            this.btn_XoaTL.Size = new System.Drawing.Size(125, 33);
            this.btn_XoaTL.TabIndex = 3;
            this.btn_XoaTL.Text = "Xóa";
            this.btn_XoaTL.UseVisualStyleBackColor = true;
            this.btn_XoaTL.Click += new System.EventHandler(this.btn_XoaTL_Click);
            // 
            // btn_SuaTL
            // 
            this.btn_SuaTL.Location = new System.Drawing.Point(154, 10);
            this.btn_SuaTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SuaTL.Name = "btn_SuaTL";
            this.btn_SuaTL.Size = new System.Drawing.Size(122, 35);
            this.btn_SuaTL.TabIndex = 2;
            this.btn_SuaTL.Text = "Sửa";
            this.btn_SuaTL.UseVisualStyleBackColor = true;
            this.btn_SuaTL.Click += new System.EventHandler(this.btn_SuaTL_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(154, 58);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(122, 33);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_ThemTL
            // 
            this.btn_ThemTL.Location = new System.Drawing.Point(14, 10);
            this.btn_ThemTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ThemTL.Name = "btn_ThemTL";
            this.btn_ThemTL.Size = new System.Drawing.Size(125, 35);
            this.btn_ThemTL.TabIndex = 0;
            this.btn_ThemTL.Text = "Thêm";
            this.btn_ThemTL.UseVisualStyleBackColor = true;
            this.btn_ThemTL.Click += new System.EventHandler(this.btn_ThemTL_Click);
            // 
            // datagrid_TheLoai
            // 
            this.datagrid_TheLoai.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_TheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_TheLoai.Location = new System.Drawing.Point(304, 13);
            this.datagrid_TheLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagrid_TheLoai.Name = "datagrid_TheLoai";
            this.datagrid_TheLoai.RowHeadersWidth = 51;
            this.datagrid_TheLoai.RowTemplate.Height = 24;
            this.datagrid_TheLoai.Size = new System.Drawing.Size(493, 185);
            this.datagrid_TheLoai.TabIndex = 2;
            // 
            // THELOAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(818, 215);
            this.Controls.Add(this.datagrid_TheLoai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "THELOAI";
            this.Text = "THELOAI";
            this.Load += new System.EventHandler(this.THELOAI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_TenTL;
        private System.Windows.Forms.Label lb_TenTL;
        private System.Windows.Forms.Label lb_MaTL;
        public System.Windows.Forms.TextBox txt_MaTL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_XoaTL;
        private System.Windows.Forms.Button btn_SuaTL;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_ThemTL;
        public System.Windows.Forms.DataGridView datagrid_TheLoai;
    }
}