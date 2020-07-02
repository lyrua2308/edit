namespace hoa_don_nhap
{
    partial class MaKhoiLuong
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
            this.gridviewKhoiluong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMakhoiluong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewKhoiluong)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewKhoiluong
            // 
            this.gridviewKhoiluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewKhoiluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gridviewKhoiluong.Location = new System.Drawing.Point(59, 183);
            this.gridviewKhoiluong.Name = "gridviewKhoiluong";
            this.gridviewKhoiluong.RowHeadersWidth = 51;
            this.gridviewKhoiluong.Size = new System.Drawing.Size(288, 178);
            this.gridviewKhoiluong.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Makhoiluong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Khối Lượng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Khối Lượng";
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthoat.Location = new System.Drawing.Point(394, 402);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(97, 38);
            this.buttonthoat.TabIndex = 32;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            // 
            // buttonluu
            // 
            this.buttonluu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonluu.Location = new System.Drawing.Point(394, 254);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(97, 37);
            this.buttonluu.TabIndex = 31;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = false;
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonxoa.Location = new System.Drawing.Point(394, 330);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(97, 40);
            this.buttonxoa.TabIndex = 30;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthem.Location = new System.Drawing.Point(394, 183);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(97, 39);
            this.buttonthem.TabIndex = 29;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(147, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Khối Lượng";
            // 
            // txtMakhoiluong
            // 
            this.txtMakhoiluong.Location = new System.Drawing.Point(211, 100);
            this.txtMakhoiluong.Name = "txtMakhoiluong";
            this.txtMakhoiluong.Size = new System.Drawing.Size(136, 22);
            this.txtMakhoiluong.TabIndex = 27;
            // 
            // MaKhoiLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 510);
            this.Controls.Add(this.gridviewKhoiluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMakhoiluong);
            this.Name = "MaKhoiLuong";
            this.Text = "MaKhoiLuong";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewKhoiluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewKhoiluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMakhoiluong;
    }
}