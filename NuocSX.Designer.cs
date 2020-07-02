namespace hoa_don_nhap
{
    partial class NuocSX
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.TennuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenSX = new System.Windows.Forms.TextBox();
            this.ManuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gridviewSX = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(457, 327);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // TennuocSX
            // 
            this.TennuocSX.DataPropertyName = "TennuocSX";
            this.TennuocSX.HeaderText = "Tên Nước Sản Xuất";
            this.TennuocSX.MinimumWidth = 6;
            this.TennuocSX.Name = "TennuocSX";
            this.TennuocSX.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(560, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenSX
            // 
            this.txtTenSX.Location = new System.Drawing.Point(354, 129);
            this.txtTenSX.Name = "txtTenSX";
            this.txtTenSX.Size = new System.Drawing.Size(114, 22);
            this.txtTenSX.TabIndex = 33;
            // 
            // ManuocSX
            // 
            this.ManuocSX.DataPropertyName = "ManuocSX";
            this.ManuocSX.HeaderText = "Mã Nước Sản Xuất";
            this.ManuocSX.MinimumWidth = 6;
            this.ManuocSX.Name = "ManuocSX";
            this.ManuocSX.Width = 125;
            // 
            // txtMaSX
            // 
            this.txtMaSX.Location = new System.Drawing.Point(354, 94);
            this.txtMaSX.Name = "txtMaSX";
            this.txtMaSX.Size = new System.Drawing.Size(114, 22);
            this.txtMaSX.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên nước sản xuất";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(258, 327);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(165, 327);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(354, 327);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gridviewSX
            // 
            this.gridviewSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManuocSX,
            this.TennuocSX});
            this.gridviewSX.Location = new System.Drawing.Point(230, 164);
            this.gridviewSX.Name = "gridviewSX";
            this.gridviewSX.RowHeadersWidth = 51;
            this.gridviewSX.Size = new System.Drawing.Size(302, 157);
            this.gridviewSX.TabIndex = 34;
            this.gridviewSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSX_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã nước sản xuất";
            // 
            // NuocSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTenSX);
            this.Controls.Add(this.txtMaSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridviewSX);
            this.Controls.Add(this.label1);
            this.Name = "NuocSX";
            this.Text = "NuocSX";
            this.Load += new System.EventHandler(this.NuocSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TennuocSX;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManuocSX;
        private System.Windows.Forms.TextBox txtMaSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView gridviewSX;
        private System.Windows.Forms.Label label1;
    }
}