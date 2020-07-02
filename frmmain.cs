
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoa_don_nhap
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {


        }

        private void loạiGasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loaics f1 = new Loaics();
            f1.Show();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mau f1 = new Mau();
            f1.Show();
        }

        private void nướcSảnXuấToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NuocSX f1 = new NuocSX();
            f1.Show();
        }

        private void khốiLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhoiLuong f1 = new KhoiLuong();
            f1.Show();
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void bánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }

}
