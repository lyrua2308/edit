namespace hoa_don_nhap
{
    partial class DangNhap
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
            this.thatbai = new System.Windows.Forms.Label();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.checkBoxHienthi = new System.Windows.Forms.CheckBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.lbTaikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thatbai
            // 
            this.thatbai.AutoSize = true;
            this.thatbai.ForeColor = System.Drawing.Color.Red;
            this.thatbai.Location = new System.Drawing.Point(238, 239);
            this.thatbai.Name = "thatbai";
            this.thatbai.Size = new System.Drawing.Size(0, 17);
            this.thatbai.TabIndex = 15;
            // 
            // btDangnhap
            // 
            this.btDangnhap.Location = new System.Drawing.Point(281, 310);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(116, 42);
            this.btDangnhap.TabIndex = 14;
            this.btDangnhap.Text = "Đăng nhập";
            this.btDangnhap.UseVisualStyleBackColor = true;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // checkBoxHienthi
            // 
            this.checkBoxHienthi.AutoSize = true;
            this.checkBoxHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHienthi.Location = new System.Drawing.Point(119, 227);
            this.checkBoxHienthi.Name = "checkBoxHienthi";
            this.checkBoxHienthi.Size = new System.Drawing.Size(99, 29);
            this.checkBoxHienthi.TabIndex = 13;
            this.checkBoxHienthi.Text = "Hiển thị";
            this.checkBoxHienthi.UseVisualStyleBackColor = true;
            this.checkBoxHienthi.CheckedChanged += new System.EventHandler(this.checkBoxHienthi_CheckedChanged);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(344, 159);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(174, 22);
            this.txtMatkhau.TabIndex = 12;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(344, 83);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(174, 22);
            this.txtTaikhoan.TabIndex = 11;
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkhau.Location = new System.Drawing.Point(114, 159);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(93, 25);
            this.lbMatkhau.TabIndex = 10;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // lbTaikhoan
            // 
            this.lbTaikhoan.AutoSize = true;
            this.lbTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan.Location = new System.Drawing.Point(108, 83);
            this.lbTaikhoan.Name = "lbTaikhoan";
            this.lbTaikhoan.Size = new System.Drawing.Size(99, 25);
            this.lbTaikhoan.TabIndex = 9;
            this.lbTaikhoan.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(297, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Đăng ký tài khoản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thatbai);
            this.Controls.Add(this.btDangnhap);
            this.Controls.Add(this.checkBoxHienthi);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.lbMatkhau);
            this.Controls.Add(this.lbTaikhoan);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thatbai;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.CheckBox checkBoxHienthi;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.Label lbTaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}