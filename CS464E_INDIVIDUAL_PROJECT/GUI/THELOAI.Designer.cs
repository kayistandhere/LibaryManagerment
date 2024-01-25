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
            this.txt_MaTL = new System.Windows.Forms.TextBox();
            this.lb_MaTL = new System.Windows.Forms.Label();
            this.lb_TenTL = new System.Windows.Forms.Label();
            this.txt_TenTL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThemTL = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_SuaTL = new System.Windows.Forms.Button();
            this.btn_XoaTL = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(48, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 194);
            this.panel1.TabIndex = 0;
            // 
            // txt_MaTL
            // 
            this.txt_MaTL.Location = new System.Drawing.Point(181, 38);
            this.txt_MaTL.Name = "txt_MaTL";
            this.txt_MaTL.Size = new System.Drawing.Size(176, 22);
            this.txt_MaTL.TabIndex = 0;
            // 
            // lb_MaTL
            // 
            this.lb_MaTL.AutoSize = true;
            this.lb_MaTL.Location = new System.Drawing.Point(50, 44);
            this.lb_MaTL.Name = "lb_MaTL";
            this.lb_MaTL.Size = new System.Drawing.Size(55, 16);
            this.lb_MaTL.TabIndex = 1;
            this.lb_MaTL.Text = "Mã Loại";
            // 
            // lb_TenTL
            // 
            this.lb_TenTL.AutoSize = true;
            this.lb_TenTL.Location = new System.Drawing.Point(50, 120);
            this.lb_TenTL.Name = "lb_TenTL";
            this.lb_TenTL.Size = new System.Drawing.Size(60, 16);
            this.lb_TenTL.TabIndex = 2;
            this.lb_TenTL.Text = "Tên Loại";
            // 
            // txt_TenTL
            // 
            this.txt_TenTL.Location = new System.Drawing.Point(181, 114);
            this.txt_TenTL.Name = "txt_TenTL";
            this.txt_TenTL.Size = new System.Drawing.Size(176, 22);
            this.txt_TenTL.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_XoaTL);
            this.panel2.Controls.Add(this.btn_SuaTL);
            this.panel2.Controls.Add(this.btn_Thoat);
            this.panel2.Controls.Add(this.btn_ThemTL);
            this.panel2.Location = new System.Drawing.Point(522, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 253);
            this.panel2.TabIndex = 1;
            // 
            // btn_ThemTL
            // 
            this.btn_ThemTL.Location = new System.Drawing.Point(39, 36);
            this.btn_ThemTL.Name = "btn_ThemTL";
            this.btn_ThemTL.Size = new System.Drawing.Size(86, 33);
            this.btn_ThemTL.TabIndex = 0;
            this.btn_ThemTL.Text = "Thêm";
            this.btn_ThemTL.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(39, 192);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 33);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_SuaTL
            // 
            this.btn_SuaTL.Location = new System.Drawing.Point(39, 138);
            this.btn_SuaTL.Name = "btn_SuaTL";
            this.btn_SuaTL.Size = new System.Drawing.Size(86, 33);
            this.btn_SuaTL.TabIndex = 2;
            this.btn_SuaTL.Text = "Sửa";
            this.btn_SuaTL.UseVisualStyleBackColor = true;
            // 
            // btn_XoaTL
            // 
            this.btn_XoaTL.Location = new System.Drawing.Point(39, 88);
            this.btn_XoaTL.Name = "btn_XoaTL";
            this.btn_XoaTL.Size = new System.Drawing.Size(86, 33);
            this.btn_XoaTL.TabIndex = 3;
            this.btn_XoaTL.Text = "Xóa";
            this.btn_XoaTL.UseVisualStyleBackColor = true;
            // 
            // datagrid_TheLoai
            // 
            this.datagrid_TheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_TheLoai.Location = new System.Drawing.Point(156, 85);
            this.datagrid_TheLoai.Name = "datagrid_TheLoai";
            this.datagrid_TheLoai.RowHeadersWidth = 51;
            this.datagrid_TheLoai.RowTemplate.Height = 24;
            this.datagrid_TheLoai.Size = new System.Drawing.Size(491, 168);
            this.datagrid_TheLoai.TabIndex = 2;
            // 
            // THELOAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 566);
            this.Controls.Add(this.datagrid_TheLoai);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "THELOAI";
            this.Text = "THELOAI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TenTL;
        private System.Windows.Forms.Label lb_TenTL;
        private System.Windows.Forms.Label lb_MaTL;
        private System.Windows.Forms.TextBox txt_MaTL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_XoaTL;
        private System.Windows.Forms.Button btn_SuaTL;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_ThemTL;
        private System.Windows.Forms.DataGridView datagrid_TheLoai;
    }
}