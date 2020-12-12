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
using BUS;
using DTO;

namespace main
{
    public partial class dangnhap : DevExpress.XtraEditors.XtraForm
    {
        SqlCommand cmd;
        SqlDataReader read;
        public dangnhap()
        {
            InitializeComponent();
        }
        


        //public dangnhap(string tendangnhap, string quyen, string matkhau)
        //{
        //    InitializeComponent();
        //    StartPosition = FormStartPosition.CenterScreen;
        //    this.tendangnhap = tendangnhap;
        //    this.quyen = quyen;
        //    this.matkhau = matkhau;
        //    TAIKHOAN_BUS bus = new TAIKHOAN_BUS();         
        //}
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            dangky dk = new dangky();
            dk.ShowDialog();
        }

        private void dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        //    if (MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            TAIKHOAN_BUS bus = new TAIKHOAN_BUS();
            if (bus.DangNhap(txttk.Text, txtmk.Text))
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
            else
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            //string strChuoiKetNoi = @"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(strChuoiKetNoi);
            //string sql = string.Format("SELECT UserName, Pasword From TAIKHOAN WHERE UserName = '" + txttk.Text + "' and Pasword = '" + txtmk.Text + "'");
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     Form1 frm = new Form1(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
            //    this.Hide();
            //    frm.Show();

            
        }

        
    }
}