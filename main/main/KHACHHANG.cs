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
using BUS;
using DTO;
using System.Data.SqlClient;
namespace main
{
    public partial class KHACHHANG : DevExpress.XtraEditors.XtraForm
    {
        public KHACHHANG()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  
            gidviewKH.ReadOnly = true;
            //khoa button
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = false;
            //khoa text
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
        }
        
        void khoa()
        {
            //khoa button
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = false;
            btntimkiem.Enabled = true;
            //khoa text
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
            txttimtenkh.Enabled = true;
        }
        
        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            KHACHHANG.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;

            this.autocomplete();

            KHACHHANG_BUS bus = new KHACHHANG_BUS();
            List<KHACHHANG_DTO> dto = bus.LayDSKHACHHANG();
            gidviewKH.DataSource = dto;
            gidviewKH.Columns["MAKH"].HeaderText = "Mã Khách Hàng";
            gidviewKH.Columns["TENKH"].HeaderText = "Tên Khách Hàng";
            gidviewKH.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            gidviewKH.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            gidviewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gidviewKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }

        private void gidviewKH_SelectionChanged(object sender, EventArgs e)
        {
            if (gidviewKH.SelectedRows.Count > 0)
            {
                DataGridViewRow item = gidviewKH.SelectedRows[0];
                txtmakh.Text = item.Cells["MAKH"].Value.ToString();
                txttenkh.Text = item.Cells["TENKH"].Value.ToString();
                txtdiachi.Text = item.Cells["DIACHI"].Value.ToString();
                txtdienthoai.Text = item.Cells["DIENTHOAI"].Value.ToString();
            }
        }

        void reset()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //button
            reset();

            btnthemxong.Enabled = true;
            btnsua.Enabled = false;
            btnsuaxong.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = false;
            btntimkiem.Enabled = false;
          
            //text nhap
            txtmakh.Enabled = true;
            txttenkh.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txttimtenkh.Enabled = false;
           
        }
        public bool kiemtra()
        {
            bool res = false;
            if (txtmakh.Text.ToString().Trim() == "" || txttenkh.Text.ToString().Trim() == "" || txtdiachi.Text.ToString().Trim() == ""
            || txtdienthoai.Text.ToString().Trim() == "")
            {
                res = false;
                MessageBox.Show("Bạn chưa nhập dữ liệu ", "Thông báo", MessageBoxButtons.OK);
            }
            else
                res = true;
            return res;

        }

        private void btnthemxong_Click(object sender, EventArgs e)
        {
            KHACHHANG_BUS khBUS = new KHACHHANG_BUS();
            if(khBUS.CheckMaKH(txtmakh.Text))
            {
                MessageBox.Show("Mã đã tồn tại ,nên bạn cần nhập lại mã", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!khBUS.CheckMaKH(txtmakh.Text))
            {
                if (kiemtra())
                {
                    KHACHHANG_DTO dtDTO = new KHACHHANG_DTO();
                    //them từ text
                    dtDTO.MaKH = txtmakh.Text;
                    dtDTO.TenKH = txttenkh.Text;
                    dtDTO.DiaChi = txtdiachi.Text;
                    dtDTO.DienThoai = txtdienthoai.Text;

                    khBUS.ThemKhachHang(dtDTO);
                    ReLoad();
                    //button
                    khoa();
                    btnthemxong.Enabled = false;
                }
            }

        }
        public void ReLoad()
        {
            KHACHHANG_BUS dtBUS = new KHACHHANG_BUS();
            gidviewKH.DataSource = dtBUS.LayDSKHACHHANG();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //button
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = true;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;

            //text nhap
            txtmakh.Enabled = false;
            txttenkh.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txttimtenkh.Enabled = false;
        }

        private void btnsuaxong_Click(object sender, EventArgs e)
        {
            KHACHHANG_BUS khBUS = new KHACHHANG_BUS();
            if (kiemtra())
            {
                KHACHHANG_DTO dtDTO = new KHACHHANG_DTO();
                dtDTO.MaKH = txtmakh.Text;
                dtDTO.TenKH = txttenkh.Text;
                dtDTO.DiaChi = txtdiachi.Text;
                dtDTO.DienThoai = txtdienthoai.Text;
                khBUS.SuaKhachHang(dtDTO);
                ReLoad();
                khoa();
                btnsuaxong.Enabled = false;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn xóa Nhân Viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                KHACHHANG_BUS khBUS = new KHACHHANG_BUS();
                khBUS.XoaKhachHang(txtmakh.Text);
                ReLoad();
            }
            MessageBox.Show("Xóa Thành công", "Thông báo ");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            KHACHHANG_BUS bus = new KHACHHANG_BUS();
            List<KHACHHANG_DTO> listkh = bus.Timtenkh(txttimtenkh.Text);
            gidviewKH.DataSource = listkh;
        }
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private void autocomplete()
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenKH from KHACHHANG where TrangThai=1";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    auto.Add(dr["TenKH"].ToString());
            }
            dr.Close();
            this.txttimtenkh.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttimtenkh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttimtenkh.AutoCompleteCustomSource = auto;
        }

        private void txtdienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KHACHHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                btnthoat.PerformClick();
            }
        }
    }
}