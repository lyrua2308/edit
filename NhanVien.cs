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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void loatdata()
        {

            DAO.OpenConnection();
            string sql = "select * from nhan_vien";
            SqlDataAdapter myAdater = new SqlDataAdapter(sql, DAO.Conn);
            DataTable table = new DataTable();
            myAdater.Fill(table);
            dataGridViewNhanVien.DataSource = table;
        }




        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loatdata();
            string sql = "select * from Cong_viec";
            DAO.fillDataToCombo(sql, comboBoxmacongviec, "macv", "tencv");//displaymember:chọn tên ,valuemember:lấy mã tương ứng

            string sql1 = "select * from ca_lam";
            DAO.fillDataToCombo(sql1, comboBoxmaca, "maca", "tenca");
            string sql2 = "select * from Nhan_vien";
            DAO.fillDataToCombo(sql2, comboBoxgioitinh, "manv", "gioitinh");

        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNV.Text = dataGridViewNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            textBoxTenNV.Text = dataGridViewNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            textBoxdiachi.Text = dataGridViewNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            textBoxdienthoai.Text = dataGridViewNhanVien.CurrentRow.Cells["dienthoai"].Value.ToString();
            comboBoxgioitinh.Text = dataGridViewNhanVien.CurrentRow.Cells["gioitinh"].Value.ToString();
            comboBoxmaca.Text = dataGridViewNhanVien.CurrentRow.Cells["maca"].Value.ToString();
            comboBoxmacongviec.Text = dataGridViewNhanVien.CurrentRow.Cells["macv"].Value.ToString();
            maskedTextBoxngaysinh.Text = dataGridViewNhanVien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            textBoxMaNV.Enabled = false;
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            string sql = "update Nhan_Vien set tennv=N'" + textBoxTenNV.Text + "',diachi=N'" + textBoxdiachi.Text + "',gioitinh='" + comboBoxgioitinh.SelectedValue
                + "',ngaysinh='" + maskedTextBoxngaysinh.Text + "',dienthoai='" + textBoxdienthoai.Text + "',maca='" + comboBoxmaca.SelectedValue + "',macv='"
                + comboBoxmacongviec.SelectedValue +
                "' where maNv=N'" + textBoxMaNV.Text + "'";
            //MessageBox.Show(sql);
            //DAO.openconnectionstring();
            //SqlCommand cmd = new SqlCommand(sql, DAO.conn);
            //cmd.ExecuteNonQuery();
            //DAO.closeconnectionstring();
            DAO.RunSqlDel(sql);
            loatdata();



        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            textBoxMaNV.Enabled = true;
            textBoxdienthoai.Text = "";
            textBoxMaNV.Text = "";
            textBoxTenNV.Text = "";
            textBoxdiachi.Text = "";
            maskedTextBoxngaysinh.Text = "";
            comboBoxmacongviec.SelectedValue = "";
            comboBoxmaca.SelectedValue = "";
            comboBoxgioitinh.SelectedValue = "";
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from nhan_vien where manv='" + textBoxMaNV.Text + "'";

            //MessageBox.Show(sql);
            //DAO.openconnectionstring();
            //SqlCommand cmd = new SqlCommand(sql, DAO.conn);
            //cmd.ExecuteNonQuery();
            // DAO.closeconnectionstring();

            // DAO.checkxoa(sql);
            string sqlcheck = "select * from nhan_vien join Hoa_don_ban on Hoa_don_ban.MaNV=Nhan_Vien.MaNV join hoa_don_nhap" +
                "on hoa_don_nhap.manv=nhan_vien.manv where nhan_vien.manv='" + textBoxMaNV.Text.Trim() + "'";
            DAO.OpenConnection();

            if (DAO.CheckKey(sqlcheck))
            {
                MessageBox.Show("không thể xóa");
                DAO.CloseConnection();

                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sql;
                cmd.Connection = DAO.Conn;
                cmd.ExecuteNonQuery();

                loatdata();

                DAO.CloseConnection();
            }


        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (textBoxdiachi.Text == "")
            {
                MessageBox.Show("bạn chưa nhập Địa chỉ");
                textBoxdiachi.Focus();

            }
            if (textBoxdienthoai.Text == "")
            {
                MessageBox.Show("bạn chưa nhập số điện thoại");
                textBoxdienthoai.Focus();
            }
            if (textBoxMaNV.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã");
                textBoxMaNV.Focus();
            }
            if (textBoxTenNV.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên");
                textBoxTenNV.Focus();

            }
            if (maskedTextBoxngaysinh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập ngay sinh");
                maskedTextBoxngaysinh.Focus();
            }
            if (comboBoxgioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa nhập giới tính");
                comboBoxgioitinh.Focus();




            }
            if (comboBoxmaca.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa nhập maca");
                comboBoxmaca.Focus();

            }
            if (comboBoxmacongviec.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa nhập mã công việc");
                comboBoxmacongviec.Focus();

            }
            string sql = "insert into nhan_vien values('" + textBoxMaNV.Text + "','" + textBoxTenNV.Text
                + "','" + comboBoxgioitinh.SelectedValue + "','" + maskedTextBoxngaysinh.Text
                + "','" + textBoxdiachi.Text + "','" + textBoxdienthoai.Text + "','" + comboBoxmaca.SelectedValue
                + "','" + comboBoxmacongviec.SelectedValue + "')";
            //MessageBox.Show(sql);
            DAO.OpenConnection();
            string sqlCheck = "select * from nhan_vien where manv='" + textBoxMaNV.Text.Trim() + "'";
            if (DAO.CheckKey(sqlCheck))
            {
                MessageBox.Show("nhanvien da ton tai");
                DAO.CloseConnection();
                textBoxMaNV.Enabled = true;
                textBoxMaNV.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = sql;
                cmd.Connection = DAO.Conn;
                cmd.ExecuteNonQuery();

                loatdata();

                DAO.CloseConnection();
            }

        }



    }
}
