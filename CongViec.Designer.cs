namespace hoa_don_nhap
{
    partial class CongViec
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
            this.dataGridViewcv = new System.Windows.Forms.DataGridView();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxtencv = new System.Windows.Forms.TextBox();
            this.textBoxmacv = new System.Windows.Forms.TextBox();
            this.labeltencv = new System.Windows.Forms.Label();
            this.labelmacv = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewcv
            // 
            this.dataGridViewcv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macv,
            this.tencv});
            this.dataGridViewcv.Location = new System.Drawing.Point(148, 227);
            this.dataGridViewcv.Name = "dataGridViewcv";
            this.dataGridViewcv.RowHeadersWidth = 51;
            this.dataGridViewcv.Size = new System.Drawing.Size(240, 200);
            this.dataGridViewcv.TabIndex = 41;
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã công việc";
            this.macv.Name = "macv";
            this.macv.Width = 125;
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "tencv";
            this.tencv.HeaderText = "Tên công việc";
            this.tencv.Name = "tencv";
            this.tencv.Width = 125;
            // 
            // textBoxtencv
            // 
            this.textBoxtencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxtencv.Location = new System.Drawing.Point(246, 173);
            this.textBoxtencv.Name = "textBoxtencv";
            this.textBoxtencv.Size = new System.Drawing.Size(142, 30);
            this.textBoxtencv.TabIndex = 40;
            // 
            // textBoxmacv
            // 
            this.textBoxmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxmacv.Location = new System.Drawing.Point(246, 128);
            this.textBoxmacv.Name = "textBoxmacv";
            this.textBoxmacv.Size = new System.Drawing.Size(142, 30);
            this.textBoxmacv.TabIndex = 39;
            // 
            // labeltencv
            // 
            this.labeltencv.AutoSize = true;
            this.labeltencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeltencv.Location = new System.Drawing.Point(103, 176);
            this.labeltencv.Name = "labeltencv";
            this.labeltencv.Size = new System.Drawing.Size(135, 25);
            this.labeltencv.TabIndex = 38;
            this.labeltencv.Text = "Tên công việc";
            // 
            // labelmacv
            // 
            this.labelmacv.AutoSize = true;
            this.labelmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelmacv.Location = new System.Drawing.Point(103, 128);
            this.labelmacv.Name = "labelmacv";
            this.labelmacv.Size = new System.Drawing.Size(128, 25);
            this.labelmacv.TabIndex = 37;
            this.labelmacv.Text = "Mã công việc";
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthoat.Location = new System.Drawing.Point(455, 398);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(81, 29);
            this.buttonthoat.TabIndex = 36;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            // 
            // buttonluu
            // 
            this.buttonluu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonluu.Location = new System.Drawing.Point(455, 329);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(81, 29);
            this.buttonluu.TabIndex = 35;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = false;
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonxoa.Location = new System.Drawing.Point(455, 259);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(81, 29);
            this.buttonxoa.TabIndex = 34;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            // 
            // buttonsua
            // 
            this.buttonsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonsua.Location = new System.Drawing.Point(455, 189);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(81, 29);
            this.buttonsua.TabIndex = 33;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = false;
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthem.Location = new System.Drawing.Point(455, 128);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(81, 29);
            this.buttonthem.TabIndex = 32;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(201, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Công việc";
            // 
            // CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 506);
            this.Controls.Add(this.dataGridViewcv);
            this.Controls.Add(this.textBoxtencv);
            this.Controls.Add(this.textBoxmacv);
            this.Controls.Add(this.labeltencv);
            this.Controls.Add(this.labelmacv);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.label1);
            this.Name = "CongViec";
            this.Text = "CongViec";
            this.Load += new System.EventHandler(this.CongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.TextBox textBoxtencv;
        private System.Windows.Forms.TextBox textBoxmacv;
        private System.Windows.Forms.Label labeltencv;
        private System.Windows.Forms.Label labelmacv;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Label label1;
    }
}