namespace hoa_don_nhap
{
    partial class frmmain
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
            this.khốiLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loạiGasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuSắcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nướcSảnXuấToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // khốiLượngToolStripMenuItem
            // 
            this.khốiLượngToolStripMenuItem.Name = "khốiLượngToolStripMenuItem";
            this.khốiLượngToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.khốiLượngToolStripMenuItem.Text = "Khối Lượng";
            this.khốiLượngToolStripMenuItem.Click += new System.EventHandler(this.khốiLượngToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiGasToolStripMenuItem,
            this.màuSắcToolStripMenuItem,
            this.khốiLượngToolStripMenuItem,
            this.nướcSảnXuấToolStripMenuItem,
            this.hoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loạiGasToolStripMenuItem
            // 
            this.loạiGasToolStripMenuItem.Name = "loạiGasToolStripMenuItem";
            this.loạiGasToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.loạiGasToolStripMenuItem.Text = "Loại Gas";
            this.loạiGasToolStripMenuItem.Click += new System.EventHandler(this.loạiGasToolStripMenuItem_Click);
            // 
            // màuSắcToolStripMenuItem
            // 
            this.màuSắcToolStripMenuItem.Name = "màuSắcToolStripMenuItem";
            this.màuSắcToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.màuSắcToolStripMenuItem.Text = "Màu Sắc";
            this.màuSắcToolStripMenuItem.Click += new System.EventHandler(this.màuSắcToolStripMenuItem_Click);
            // 
            // nướcSảnXuấToolStripMenuItem
            // 
            this.nướcSảnXuấToolStripMenuItem.Name = "nướcSảnXuấToolStripMenuItem";
            this.nướcSảnXuấToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.nướcSảnXuấToolStripMenuItem.Text = "Nước Sản Xuất";
            this.nướcSảnXuấToolStripMenuItem.Click += new System.EventHandler(this.nướcSảnXuấToolStripMenuItem_Click);
            // 
            // hoToolStripMenuItem
            // 
            this.hoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.bánToolStripMenuItem});
            this.hoToolStripMenuItem.Name = "hoToolStripMenuItem";
            this.hoToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hoToolStripMenuItem.Text = "Giao Dịch";
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhậpToolStripMenuItem.Text = "Nhập";
            this.nhậpToolStripMenuItem.Click += new System.EventHandler(this.nhậpToolStripMenuItem_Click);
            // 
            // bánToolStripMenuItem
            // 
            this.bánToolStripMenuItem.Name = "bánToolStripMenuItem";
            this.bánToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bánToolStripMenuItem.Text = "Bán";
            this.bánToolStripMenuItem.Click += new System.EventHandler(this.bánToolStripMenuItem_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmmain";
            this.Text = "frmmain";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem khốiLượngToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loạiGasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuSắcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nướcSảnXuấToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánToolStripMenuItem;
    }
}