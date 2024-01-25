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
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(121, 106);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(73, 16);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "UserName";
            this.lb_User.Click += new System.EventHandler(this.lb_User_Click);
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Location = new System.Drawing.Point(121, 167);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(67, 16);
            this.lb_Pass.TabIndex = 1;
            this.lb_Pass.Text = "Password";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(276, 99);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(183, 22);
            this.txt_User.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(276, 161);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(183, 22);
            this.txt_Pass.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(158, 271);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(92, 31);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(437, 271);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 31);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lb_Pass);
            this.Controls.Add(this.lb_User);
            this.Name = "DANGNHAP";
            this.Text = "DANGNHAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_User;
        public System.Windows.Forms.Label lb_Pass;
        public System.Windows.Forms.TextBox txt_User;
        public System.Windows.Forms.TextBox txt_Pass;
        public System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.Button btn_Exit;
    }
}