using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace main
{
    public partial class doimk : DevExpress.XtraEditors.XtraForm
    {
        string ketnoi = "Data Source=DESKTOP-CUUEMBN;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True";
       
        public doimk()
        {
            InitializeComponent();
        }

       
        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnxacnhan_Click_1(object sender, EventArgs e)
        {
            if (txttaikhoan.Text != "")
            {
                if (txtmkcu.Text != "")
                {
                    if (txtmkmoi.Text != "")
                    {
                        if (txtmkmoi.Text == txtmkmoi1.Text)
                        {
                            if (txtmkmoi.Text != txtmkcu.Text)
                            {
                                TAIKHOAN_BUS bus = new TAIKHOAN_BUS();
                                bus.DOIMK(txttaikhoan.Text, txtmkcu.Text, txtmkmoi1.Text);
                                MessageBox.Show("Đổi Mật Khẩu Thành Công");
                            }
                            else MessageBox.Show("Phải Đặt Mật Khẩu Mới Khác Mật Khẩu Hiện Tại");
                        }
                        else MessageBox.Show("Mật Khẩu Vừa Nhập Không Trùng Nhau");
                    }
                    else MessageBox.Show("Vui Lồng Nhập Mật Khẩu");
                }
                else MessageBox.Show("Vui Lồng Nhập Mật Khẩu Hiện Tại");
            }
            else MessageBox.Show("Vui Lồng Nhập Tài Khoản");            
        }
    }
}