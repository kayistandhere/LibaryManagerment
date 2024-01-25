namespace CS464E_INDIVIDUAL_PROJECT
{
    partial class DANGNHAP
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
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_User.ForeColor = System.Drawing.Color.Black;
            this.lb_User.Location = new System.Drawing.Point(19, 56);
            this.lb_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(69, 17);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "UserName";
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Pass.ForeColor = System.Drawing.Color.Black;
            this.lb_Pass.Location = new System.Drawing.Point(19, 100);
            this.lb_Pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(63, 17);
            this.lb_Pass.TabIndex = 1;
            this.lb_Pass.Text = "Password";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(93, 53);
            this.txt_User.Margin = new System.Windows.Forms.Padding(2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(194, 20);
            this.txt_User.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(92, 97);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(195, 20);
            this.txt_Pass.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(92, 135);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(77, 36);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(202, 135);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 36);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(318, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_User);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DANGNHAP";
            this.Text = "DANGNHAP";
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Pass;
        public System.Windows.Forms.TextBox txt_User;
        public System.Windows.Forms.TextBox txt_Pass;
        public System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Label label1;
    }
}