﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-JT7PSAU2;Initial Catalog=QLNV_HELEN;Integrated Security=True;Encrypt=False");
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where TenDN = '"+ten_txt.Text+"' and MatKhau = '"+pass_txt.Text+"'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                main main = new main();
                main.Show();
                Const.Quyen = dt.Rows[0][2].ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng và đủ thông tin đăng nhập");
            }
        }
    }
}
