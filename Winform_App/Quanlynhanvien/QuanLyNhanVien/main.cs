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

namespace QuanLyNhanVien
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();
        }



        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien();
            nhanvien.Show();
        }

        private void côngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cong cong = new Cong();
            cong.Show();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luong luong = new Luong();
            luong.Show();
        }

        private void bảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangchamcong bangchamcong = new bangchamcong();
            bangchamcong.Show();
        }

        private void bt_dx_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void bảngTổngHợpChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.Quyen == "quanly")
            {
                bangthcc bangthcc = new bangthcc();
                bangthcc.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem bảng tổng hợp chấm công", "Thông báo");
            }
        }

        private void bảngTổngHợpLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Const.Quyen == "quanly")
            {
                bangthluong bangthluong = new bangthluong();
                bangthluong.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền xem bảng tổng hợp lương", "Thông báo");
            }
        }
    }
}
