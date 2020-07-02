using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoa_don_nhap
{
    public partial class MaKhoiLuong : Form
    {
        public MaKhoiLuong()
        {
            InitializeComponent();
        }

        // private void buttonthem_Click(object sender, EventArgs e)


        private void loaddata()
        {
            string sql = "select* from Khoi_luong";
            DAO.loatdata(sql, gridviewKhoiluong);
        }
        private void frmmakhoiluong_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void gridviewKhoiluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakhoiluong.Text = gridviewKhoiluong.CurrentRow.Cells["makhoiluong"].Value.ToString();

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            txtMakhoiluong.Text = "";


        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (txtMakhoiluong.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã");
                txtMakhoiluong.Focus();
            }
            string sql = "insert into khoi_luong values('" + txtMakhoiluong.Text + "')";
            string sqlCheck = "select * from khoi_luong where ma_khoi_luong='" + txtMakhoiluong.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheck))
            {
                MessageBox.Show("mã khói lượng đã ton tai");
                DAO.CloseConnection();

                txtMakhoiluong.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sql;
                cmd.Connection = DAO.Conn;
                cmd.ExecuteNonQuery();

                loaddata();

                DAO.CloseConnection();
            }

        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from khoi_luong where ma_khoi_luong='" + txtMakhoiluong.Text + "'";
            DAO.RunSqlDel(sql);
            loaddata();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
