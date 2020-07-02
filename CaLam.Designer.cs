namespace hoa_don_nhap
{
    partial class CaLam
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labeltenca = new System.Windows.Forms.Label();
            this.labelmaca = new System.Windows.Forms.Label();
            this.textBoxtenca = new System.Windows.Forms.TextBox();
            this.textBoxmaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maca,
            this.tenca});
            this.dataGridView1.Location = new System.Drawing.Point(75, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(241, 186);
            this.dataGridView1.TabIndex = 30;
            // 
            // maca
            // 
            this.maca.DataPropertyName = "maca";
            this.maca.HeaderText = "Mã ca";
            this.maca.MinimumWidth = 6;
            this.maca.Name = "maca";
            this.maca.Width = 125;
            // 
            // tenca
            // 
            this.tenca.DataPropertyName = "tenca";
            this.tenca.HeaderText = "Tên ca";
            this.tenca.MinimumWidth = 6;
            this.tenca.Name = "tenca";
            this.tenca.Width = 125;
            // 
            // labeltenca
            // 
            this.labeltenca.AutoSize = true;
            this.labeltenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labeltenca.Location = new System.Drawing.Point(76, 158);
            this.labeltenca.Name = "labeltenca";
            this.labeltenca.Size = new System.Drawing.Size(87, 29);
            this.labeltenca.TabIndex = 29;
            this.labeltenca.Text = "Tên ca";
            // 
            // labelmaca
            // 
            this.labelmaca.AutoSize = true;
            this.labelmaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelmaca.Location = new System.Drawing.Point(84, 100);
            this.labelmaca.Name = "labelmaca";
            this.labelmaca.Size = new System.Drawing.Size(77, 29);
            this.labelmaca.TabIndex = 28;
            this.labelmaca.Text = "Mã ca";
            // 
            // textBoxtenca
            // 
            this.textBoxtenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxtenca.Location = new System.Drawing.Point(193, 156);
            this.textBoxtenca.Name = "textBoxtenca";
            this.textBoxtenca.Size = new System.Drawing.Size(123, 30);
            this.textBoxtenca.TabIndex = 27;
            // 
            // textBoxmaca
            // 
            this.textBoxmaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxmaca.Location = new System.Drawing.Point(193, 98);
            this.textBoxmaca.Name = "textBoxmaca";
            this.textBoxmaca.Size = new System.Drawing.Size(123, 30);
            this.textBoxmaca.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(232, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ca làm";
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthoat.Location = new System.Drawing.Point(396, 394);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(81, 31);
            this.buttonthoat.TabIndex = 35;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttonluu
            // 
            this.buttonluu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonluu.Location = new System.Drawing.Point(396, 310);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(81, 31);
            this.buttonluu.TabIndex = 34;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = false;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonxoa.Location = new System.Drawing.Point(396, 230);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(81, 31);
            this.buttonxoa.TabIndex = 33;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonsua.Location = new System.Drawing.Point(396, 158);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(81, 31);
            this.buttonsua.TabIndex = 32;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = false;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthem.Location = new System.Drawing.Point(396, 93);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(100, 36);
            this.buttonthem.TabIndex = 31;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labeltenca);
            this.Controls.Add(this.labelmaca);
            this.Controls.Add(this.textBoxtenca);
            this.Controls.Add(this.textBoxmaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Name = "CaLam";
            this.Text = "CaLam";
            this.Load += new System.EventHandler(this.CaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maca;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenca;
        private System.Windows.Forms.Label labeltenca;
        private System.Windows.Forms.Label labelmaca;
        private System.Windows.Forms.TextBox textBoxtenca;
        private System.Windows.Forms.TextBox textBoxmaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
    }
}