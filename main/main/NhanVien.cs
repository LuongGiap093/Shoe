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
    public partial class NhanVien : DevExpress.XtraEditors.XtraForm
    {
        //const string chuoiketnoi = @"Data Source=DESKTOP-G2GES0F\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True";
        //SqlConnection conn;
        //SqlDataAdapter da;
        //DataTable dtb = new DataTable();

        public NhanVien()
        {
            InitializeComponent();
            khoa();
            string []gioitinh = { "Nam", "Nữ" };
            combogioitinh.Properties.Items.AddRange(gioitinh);
            combogioitinh.SelectedIndex = 0;
            datengaysinh.Format = DateTimePickerFormat.Short;
            datengaysinh.Value = DateTime.Now;
            StartPosition = FormStartPosition.CenterScreen;

        }
        

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.autocomplete();
            NhanVien.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;


            NhanVien_BUS dtBUS = new NhanVien_BUS();
            List<NhanVien_DTO> dsNhanVien = dtBUS.LayDSNhanVien();
          
            DgvNhanVien.DataSource = dsNhanVien;
            DgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvNhanVien.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            DgvNhanVien.Columns["TENNV"].HeaderText = "Tên Nhân Viên";
            DgvNhanVien.Columns["GiOITINH"].HeaderText = "Giới Tính";
            DgvNhanVien.Columns["DIACHI"].HeaderText = "Địa chỉ";
            DgvNhanVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            DgvNhanVien.Columns["DIENTHOAI"].HeaderText = "Số Điện Thoại";
            DgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void ReLoad()
        {
            NhanVien_BUS dtBUS = new NhanVien_BUS();
            DgvNhanVien.DataSource = dtBUS.LayDSNhanVien();
        }

        private void gidviewnhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow item = DgvNhanVien.SelectedRows[0];
                txtmanv.Text = item.Cells["MANV"].Value.ToString();
                txttennv.Text = item.Cells["TENNV"].Value.ToString();
                combogioitinh.Text = item.Cells["GIOITINH"].Value.ToString();
                datengaysinh.Value = DateTime.ParseExact(item.Cells["NgaySinh"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                txtdiachi.Text = item.Cells["DIACHI"].Value.ToString();

                txtdt.Text = item.Cells["DIENTHOAI"].Value.ToString();
            }
        }

        private void btnresset_Click(object sender, EventArgs e)
        {
            combogioitinh.Text = "Nam";
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtdt.Text = "";
            txtmanv.Text = "";

        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn xóa Nhân Viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NhanVien_BUS dtBUS = new NhanVien_BUS();
                dtBUS.XoaNV(txtmanv.Text);
                ReLoad();
            }
            MessageBox.Show("Xóa Thành công", "Thông báo ");

        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            txtdiachi.Enabled = true;
            txtdt.Enabled = true;
            txtmanv.Enabled = false;
            txttennv.Enabled = true;
            combogioitinh.Enabled = true;
            datengaysinh.Enabled = true;
            txttimtennv.Enabled = false;

            btnsuaxong.Enabled = true;
            btnsua.Enabled = false;
            btnthemxongnv.Enabled = false;
            btnxoanv.Enabled = false;
            btnthem.Enabled = false;
            btntimnhanvien.Enabled = false;

        }
        public bool kiemtra()
        {
            bool res = false;
            if (txtmanv.Text.ToString().Trim() == "" ||txttennv.Text.ToString().Trim() == "" || txtdiachi.Text.ToString().Trim() == ""
            || txtdt.Text.ToString().Trim() == "")
            {
                res = false;
                MessageBox.Show("Bạn chưa nhập dữ liệu ", "Thông báo", MessageBoxButtons.OK);
            }
            else
                res = true;
            return res;

        }
        private void btnthemxongnv_Click(object sender, EventArgs e)
        {
            NhanVien_BUS nvBUS = new NhanVien_BUS();
            if (nvBUS.CheckMaNV(txtmanv.Text))
            {
                MessageBox.Show("Mã đã tồn tại ,nên bạn cần nhập lại mã", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!nvBUS.CheckMaNV(txtmanv.Text))
            {
                if (kiemtra())
                {
                    NhanVien_DTO dtDTO = new NhanVien_DTO();
                    dtDTO.MaNV = txtmanv.Text;
                    dtDTO.TenNV = txttennv.Text;
                    dtDTO.Gioitinh = combogioitinh.Text;
                    dtDTO.DiaChi = txtdiachi.Text;
                    dtDTO.NgaySinh = (DateTime)DateTime.ParseExact(datengaysinh.Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null);
                    dtDTO.DienThoai = txtdt.Text;
                    nvBUS.ThemNV(dtDTO);
                    ReLoad();
                    trangthaibandau();
                }
            }
          
           trangthaibandau();
        }
        
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void khoa()
        {
            //khóa 
            txtdiachi.Enabled = false;
            txtdt.Enabled = false;
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            combogioitinh.Enabled = false;
            datengaysinh.Enabled = false;

            btnsuaxong.Enabled = false;
            btnthemxongnv.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtdiachi.Enabled = true;
            txtdt.Enabled = true;
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            combogioitinh.Enabled = true;
            datengaysinh.Enabled = true;
            txttimtennv.Enabled = false;

            btnsuaxong.Enabled = false;
            btnsua.Enabled = false;
            btnthemxongnv.Enabled = true;
            btnthem.Enabled = false;
            btnxoanv.Enabled = false;
            btntimnhanvien.Enabled = false;
            txtdiachi.Text = "";
            txtdt.Text = "";
            txtmanv.Text = "";
            txttennv.Text = "";
        }

        private void btnsuaxong_Click_1(object sender, EventArgs e)
        {
            NhanVien_BUS nvBUS = new NhanVien_BUS();
            if(kiemtra())
            {
            NhanVien_DTO dtDTO = new NhanVien_DTO();
            dtDTO.MaNV = txtmanv.Text;
            dtDTO.TenNV = txttennv.Text;
            dtDTO.Gioitinh = combogioitinh.Text;
            dtDTO.DiaChi = txtdiachi.Text;
            dtDTO.NgaySinh = (DateTime)DateTime.ParseExact(datengaysinh.Value.ToString(), "dd/MM/yyyy h:mm:ss tt", null);
            dtDTO.DienThoai = txtdt.Text;
           
            nvBUS.SuaNV(dtDTO);
            ReLoad();
            trangthaibandau();
            }
        }
        public void trangthaibandau()
        {
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoanv.Enabled = true;
            btnthemxongnv.Enabled = btnsuaxong.Enabled = false;
            txtdiachi.Text = txtdt.Text = txtmanv.Text ="";
            txttennv.Text="";
            txttimtennv.Enabled = true;
            btntimnhanvien.Enabled = true;
        }

        private void btntimnhanvien_Click(object sender, EventArgs e)
        {
            NhanVien_BUS bus = new NhanVien_BUS();
            List<NhanVien_DTO> listnv = bus.Timtennhanvien(txttimtennv.Text);
            DgvNhanVien.DataSource = listnv;
        }

        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private void autocomplete()
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenNV from NHANVIEN where TrangThai=1";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    auto.Add(dr["TenNV"].ToString());
            }
            dr.Close();
            this.txttimtennv.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttimtennv.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttimtennv.AutoCompleteCustomSource = auto;

        }

        private void txtdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                btnthoat.PerformClick();
            }
        }
       
      
    }
}