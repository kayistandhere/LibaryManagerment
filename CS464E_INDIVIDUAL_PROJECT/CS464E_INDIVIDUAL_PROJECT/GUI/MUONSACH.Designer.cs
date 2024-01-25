namespace CS464E_INDIVIDUAL_PROJECT
{
    partial class MUONSACH
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
            this.dt_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dt_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.cb_MaDGMuon = new System.Windows.Forms.ComboBox();
            this.cb_MaSachMuon = new System.Windows.Forms.ComboBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaMuonSach = new System.Windows.Forms.TextBox();
            this.lb_MaSachMuon = new System.Windows.Forms.Label();
            this.lb_MaDMuon = new System.Windows.Forms.Label();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.lb_NgayMuon = new System.Windows.Forms.Label();
            this.lb_NgayTra = new System.Windows.Forms.Label();
            this.lb_MaMuon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XoaMuon = new System.Windows.Forms.Button();
            this.btb_Thoat = new System.Windows.Forms.Button();
            this.btn_SuaMuon = new System.Windows.Forms.Button();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.datagrid_MSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_MSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_NgayMuon);
            this.panel1.Controls.Add(this.dt_NgayTra);
            this.panel1.Controls.Add(this.cb_MaDGMuon);
            this.panel1.Controls.Add(this.cb_MaSachMuon);
            this.panel1.Controls.Add(this.txt_SoLuong);
            this.panel1.Controls.Add(this.txt_MaMuonSach);
            this.panel1.Controls.Add(this.lb_MaSachMuon);
            this.panel1.Controls.Add(this.lb_MaDMuon);
            this.panel1.Controls.Add(this.lb_SoLuong);
            this.panel1.Controls.Add(this.lb_NgayMuon);
            this.panel1.Controls.Add(this.lb_NgayTra);
            this.panel1.Controls.Add(this.lb_MaMuon);
            this.panel1.Location = new System.Drawing.Point(11, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 136);
            this.panel1.TabIndex = 0;
            // 
            // dt_NgayMuon
            // 
            this.dt_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayMuon.Location = new System.Drawing.Point(349, 56);
            this.dt_NgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dt_NgayMuon.Name = "dt_NgayMuon";
            this.dt_NgayMuon.Size = new System.Drawing.Size(105, 20);
            this.dt_NgayMuon.TabIndex = 12;
            // 
            // dt_NgayTra
            // 
            this.dt_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgayTra.Location = new System.Drawing.Point(349, 99);
            this.dt_NgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dt_NgayTra.Name = "dt_NgayTra";
            this.dt_NgayTra.Size = new System.Drawing.Size(105, 20);
            this.dt_NgayTra.TabIndex = 11;
            // 
            // cb_MaDGMuon
            // 
            this.cb_MaDGMuon.FormattingEnabled = true;
            this.cb_MaDGMuon.Location = new System.Drawing.Point(121, 97);
            this.cb_MaDGMuon.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MaDGMuon.Name = "cb_MaDGMuon";
            this.cb_MaDGMuon.Size = new System.Drawing.Size(105, 21);
            this.cb_MaDGMuon.TabIndex = 9;
            this.cb_MaDGMuon.SelectedIndexChanged += new System.EventHandler(this.cb_MaDGMuon_SelectedIndexChanged);
            // 
            // cb_MaSachMuon
            // 
            this.cb_MaSachMuon.FormattingEnabled = true;
            this.cb_MaSachMuon.Location = new System.Drawing.Point(121, 49);
            this.cb_MaSachMuon.Margin = new System.Windows.Forms.Padding(2);
            this.cb_MaSachMuon.Name = "cb_MaSachMuon";
            this.cb_MaSachMuon.Size = new System.Drawing.Size(105, 21);
            this.cb_MaSachMuon.TabIndex = 8;
            this.cb_MaSachMuon.SelectedIndexChanged += new System.EventHandler(this.cb_MaSachMuon_SelectedIndexChanged);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(349, 6);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(105, 20);
            this.txt_SoLuong.TabIndex = 7;
            // 
            // txt_MaMuonSach
            // 
            this.txt_MaMuonSach.Location = new System.Drawing.Point(121, 6);
            this.txt_MaMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaMuonSach.Name = "txt_MaMuonSach";
            this.txt_MaMuonSach.Size = new System.Drawing.Size(105, 20);
            this.txt_MaMuonSach.TabIndex = 6;
            // 
            // lb_MaSachMuon
            // 
            this.lb_MaSachMuon.AutoSize = true;
            this.lb_MaSachMuon.Location = new System.Drawing.Point(13, 56);
            this.lb_MaSachMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaSachMuon.Name = "lb_MaSachMuon";
            this.lb_MaSachMuon.Size = new System.Drawing.Size(50, 13);
            this.lb_MaSachMuon.TabIndex = 5;
            this.lb_MaSachMuon.Text = "Mã Sách";
            // 
            // lb_MaDMuon
            // 
            this.lb_MaDMuon.AutoSize = true;
            this.lb_MaDMuon.Location = new System.Drawing.Point(13, 104);
            this.lb_MaDMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaDMuon.Name = "lb_MaDMuon";
            this.lb_MaDMuon.Size = new System.Drawing.Size(64, 13);
            this.lb_MaDMuon.TabIndex = 4;
            this.lb_MaDMuon.Text = "Mã Đọc Giả";
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(264, 12);
            this.lb_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(53, 13);
            this.lb_SoLuong.TabIndex = 3;
            this.lb_SoLuong.Text = "Số Lượng";
            // 
            // lb_NgayMuon
            // 
            this.lb_NgayMuon.AutoSize = true;
            this.lb_NgayMuon.Location = new System.Drawing.Point(264, 56);
            this.lb_NgayMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NgayMuon.Name = "lb_NgayMuon";
            this.lb_NgayMuon.Size = new System.Drawing.Size(62, 13);
            this.lb_NgayMuon.TabIndex = 2;
            this.lb_NgayMuon.Text = "Ngày Mượn";
            // 
            // lb_NgayTra
            // 
            this.lb_NgayTra.AutoSize = true;
            this.lb_NgayTra.Location = new System.Drawing.Point(264, 104);
            this.lb_NgayTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NgayTra.Name = "lb_NgayTra";
            this.lb_NgayTra.Size = new System.Drawing.Size(51, 13);
            this.lb_NgayTra.TabIndex = 1;
            this.lb_NgayTra.Text = "Ngày Trả";
            // 
            // lb_MaMuon
            // 
            this.lb_MaMuon.AutoSize = true;
            this.lb_MaMuon.Location = new System.Drawing.Point(13, 12);
            this.lb_MaMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaMuon.Name = "lb_MaMuon";
            this.lb_MaMuon.Size = new System.Drawing.Size(80, 13);
            this.lb_MaMuon.TabIndex = 0;
            this.lb_MaMuon.Text = "Mã Mượn Sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_XoaMuon);
            this.panel2.Controls.Add(this.btb_Thoat);
            this.panel2.Controls.Add(this.btn_SuaMuon);
            this.panel2.Controls.Add(this.btn_Muon);
            this.panel2.Location = new System.Drawing.Point(11, 523);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 61);
            this.panel2.TabIndex = 3;
            // 
            // btn_XoaMuon
            // 
            this.btn_XoaMuon.Location = new System.Drawing.Point(146, 10);
            this.btn_XoaMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaMuon.Name = "btn_XoaMuon";
            this.btn_XoaMuon.Size = new System.Drawing.Size(93, 42);
            this.btn_XoaMuon.TabIndex = 3;
            this.btn_XoaMuon.Text = "Xóa";
            this.btn_XoaMuon.UseVisualStyleBackColor = true;
            this.btn_XoaMuon.Click += new System.EventHandler(this.btn_XoaMuon_Click);
            // 
            // btb_Thoat
            // 
            this.btb_Thoat.Location = new System.Drawing.Point(397, 10);
            this.btb_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btb_Thoat.Name = "btb_Thoat";
            this.btb_Thoat.Size = new System.Drawing.Size(105, 42);
            this.btb_Thoat.TabIndex = 2;
            this.btb_Thoat.Text = "Thoát";
            this.btb_Thoat.UseVisualStyleBackColor = true;
            this.btb_Thoat.Click += new System.EventHandler(this.btb_Thoat_Click);
            // 
            // btn_SuaMuon
            // 
            this.btn_SuaMuon.Location = new System.Drawing.Point(278, 10);
            this.btn_SuaMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaMuon.Name = "btn_SuaMuon";
            this.btn_SuaMuon.Size = new System.Drawing.Size(97, 42);
            this.btn_SuaMuon.TabIndex = 1;
            this.btn_SuaMuon.Text = "Sửa";
            this.btn_SuaMuon.UseVisualStyleBackColor = true;
            this.btn_SuaMuon.Click += new System.EventHandler(this.btn_SuaMuon_Click);
            // 
            // btn_Muon
            // 
            this.btn_Muon.Location = new System.Drawing.Point(16, 10);
            this.btn_Muon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(89, 42);
            this.btn_Muon.TabIndex = 0;
            this.btn_Muon.Text = "Mượn Sách";
            this.btn_Muon.UseVisualStyleBackColor = true;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
            // 
            // datagrid_MSach
            // 
            this.datagrid_MSach.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_MSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_MSach.Location = new System.Drawing.Point(11, 221);
            this.datagrid_MSach.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid_MSach.Name = "datagrid_MSach";
            this.datagrid_MSach.RowHeadersWidth = 51;
            this.datagrid_MSach.RowTemplate.Height = 24;
            this.datagrid_MSach.Size = new System.Drawing.Size(504, 284);
            this.datagrid_MSach.TabIndex = 4;
            this.datagrid_MSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_MSach_CellClick);
            this.datagrid_MSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_MSach_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(183, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "MƯỢN SÁCH";
            // 
            // MUONSACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(527, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_MSach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MUONSACH";
            this.Text = "MUONSACH";
            this.Load += new System.EventHandler(this.MUONSACH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_MSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dt_NgayTra;
        public System.Windows.Forms.ComboBox cb_MaDGMuon;
        public System.Windows.Forms.ComboBox cb_MaSachMuon;
        public System.Windows.Forms.TextBox txt_SoLuong;
        public System.Windows.Forms.TextBox txt_MaMuonSach;
        public System.Windows.Forms.Label lb_MaSachMuon;
        private System.Windows.Forms.Label lb_MaDMuon;
        public System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label lb_NgayMuon;
        private System.Windows.Forms.Label lb_NgayTra;
        private System.Windows.Forms.Label lb_MaMuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_XoaMuon;
        private System.Windows.Forms.Button btb_Thoat;
        private System.Windows.Forms.Button btn_SuaMuon;
        private System.Windows.Forms.Button btn_Muon;
        public System.Windows.Forms.DataGridView datagrid_MSach;
        public System.Windows.Forms.DateTimePicker dt_NgayMuon;
        private System.Windows.Forms.Label label1;
    }
}