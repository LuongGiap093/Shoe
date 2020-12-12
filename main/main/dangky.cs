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
    public partial class dangky : DevExpress.XtraEditors.XtraForm
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            TAIKHOAN_BUS bus =new TAIKHOAN_BUS();
            if (txttk.Text != "")
            {
                if (txtmk.Text != "")
                {
                    if (txthoten.Text != "")
                    {
                        if (txtmk.Text == txtmk1.Text)
                        {
                            bus.ThemTK(txttk.Text, txtmk.Text, txthoten.Text);
                            MessageBox.Show("Thêm Tài Khoản Thành Công");
                        }
                        else MessageBox.Show("Mật Khẩu Vừa Nhập Không Trùng Nhau");
                    }
                    else MessageBox.Show("Vui Lòng Nhập Họ Và Tên");
                }
                else MessageBox.Show("Vui Lòng Nhập Mật Khẩu Hiện Tại");
            }
            else MessageBox.Show("Vui Lòng Nhập Tài Khoản");
        }

        private void dangky_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}