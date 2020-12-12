using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace main
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string tendangnhap = "", quyen = "", matkhau = "";
        //const string chuoiketnoi = "Data Source=DESKTOP-CUUEMBN;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True";
        //SqlConnection conn;
        //SqlCommand cmd;
        //SqlDataReader docdulieu;
        public string idlongin { get; set; }
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;          
        }

        
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Springtime"; // tên skin muốn hiển thị 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (quyen == "quanly")
            {
                btnphanquyen.Enabled = false;
            }
            skins(); 
            disendmenu(true, idlongin);
            StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            
            
        }
         
        private void btndangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn Có Muốn Đăng Xuất Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                Form fr = new dangnhap();
                fr.ShowDialog();
             
            }
        }

        public void disendmenu(bool e, string _idlongin)
        {
           
            btndangxuat.Enabled = e;
            btndoimk.Enabled = e;
        }
        private void btndoimk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("doimk"))
            {
                doimk frm = new doimk();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("doimk");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //dangnhap dn = new dangnhap();
            //dn.ShowDialog();
            //dn.Close();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("dangky"))
            {
                dangky frm = new dangky();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("dangky");
        }

        private void btndsNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("NhanVien"))
            {
                NhanVien frm = new NhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("NhanVien");

        }

        private void btntimnv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnchatlieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kiểm tra form tồn tại hay chưa, nếu chưa sẽ hiển thị , rồi thì sẽ không hiển thị lần 2.
            if (!CheckExistForm("ChatLieu"))
            {
                ChatLieu frm = new ChatLieu();

                frm.MdiParent = this;

                frm.Show();
            }
            else
                ActiveChildForm("ChatLieu");
        }

        //kiểm tra from đã hiện thị trong form cha hay chưa?
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        //kiểm tra from đã hiện thị trong form cha hay chưa?

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

     

        private void dsnhacc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("NHACUNGCAP"))
            {
                NHACUNGCAP frm = new NHACUNGCAP();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("NHACUNGCAP");
        }

        private void timnhacc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("NHACUNGCAP"))
            {
                NHACUNGCAP frm = new NHACUNGCAP();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("NHACUNGCAP");
        }

        private void timsp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("SHOES"))
            {
                SHOES frm = new SHOES();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("SHOES");
        }

        private void dssanpham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("SHOES"))
            {
                SHOES frm = new SHOES();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("SHOES");
        }

        private void btnDSnhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

         
                hienthibaocao frm = new hienthibaocao();
               // frm.Tatcachatlieu();
                frm.MdiParent = this;
                frm.Show();
          
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("KHACHHANG"))
            {
                KHACHHANG frm = new KHACHHANG();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("KHACHHANG");

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckExistForm("HOADONBAN"))
            {
                HOADONBAN frm = new HOADONBAN();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("HOADONBAN");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                btndsNV.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.K)
            {
                btnKhachHang.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                btnchatlieu.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                dssanpham.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                dsnhacc.PerformClick();
            }
        }
        
        
    }
}
