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
using DTO;
using BUS;
using System.Data.SqlClient;
namespace main
{
    public partial class NHACUNGCAP : DevExpress.XtraEditors.XtraForm
    {
        public NHACUNGCAP()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  
            //khoa button
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = false;
            btntimncc.Enabled = true;
            //khoa text
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
            txtghichu.Enabled = false;
        }

        private void NHACUNGCAP_Load(object sender, EventArgs e)
        {
            NHACUNGCAP.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;

            this.autocomplete();

            NHACC_BUS bus = new NHACC_BUS();
            List<NHACC_DTO> dto = bus.LayDSNhaCungCap();
            gidviewnhacc.DataSource = dto;
            gidviewnhacc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gidviewnhacc.Columns["MaNCC"].HeaderText = "Mã Nhà Cung Cấp";
            gidviewnhacc.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            gidviewnhacc.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            gidviewnhacc.Columns["DienThoai"].HeaderText = "Điện Thoại";
            gidviewnhacc.Columns["GhiChu"].HeaderText = "Ghi Chú";
            gidviewnhacc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void gidviewnhacc_SelectionChanged_1(object sender, EventArgs e)
        {
            if (gidviewnhacc.SelectedRows.Count > 0)
            {
                DataGridViewRow item = gidviewnhacc.SelectedRows[0];
                txtma.Text = item.Cells["MaNCC"].Value.ToString();
                txtten.Text = item.Cells["TenNCC"].Value.ToString();
                txtdiachi.Text = item.Cells["DiaChi"].Value.ToString();
                txtdienthoai.Text = item.Cells["DienThoai"].Value.ToString();
                txtghichu.Text = item.Cells["GhiChu"].Value.ToString();
            }
        }

        void khoa()
        {
            //khoa button
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = false;
            btntimncc.Enabled = true;
            //khoa text
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdiachi.Enabled = false;
            txtdienthoai.Enabled = false;
            txtghichu.Enabled = false;
            txttimtenncc.Enabled = true;
        }

        void reset()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtghichu.Text = "";
        }

        public void ReLoad()
        {
            NHACC_BUS dtBUS = new NHACC_BUS();
            gidviewnhacc.DataSource = dtBUS.LayDSNhaCungCap();
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
            btntimncc.Enabled = false;
          

            //text nhap
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtghichu.Enabled = true;
            txttimtenncc.Enabled = false;
        }
        public bool kiemtra()
        {
            bool res = false;
            if (txtma.Text.ToString().Trim() == "" || txtten.Text.ToString().Trim() == "" || txtdiachi.Text.ToString().Trim() == ""
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
            NHACC_BUS nccBUS = new NHACC_BUS();
            if (nccBUS.CheckMaNCC(txtma.Text))
            {
                MessageBox.Show("Mã đã tồn tại ,nên bạn cần nhập lại mã", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!nccBUS.CheckMaNCC(txtma.Text))
            {
                if (kiemtra())
                {
                    NHACC_DTO dtDTO = new NHACC_DTO();
                    //them từ text
                    dtDTO.MaNCC = txtma.Text;
                    dtDTO.TenNCC = txtten.Text;
                    dtDTO.DiaChi = txtdiachi.Text;
                    dtDTO.DienThoai = txtdienthoai.Text;
                    dtDTO.GhiChu = txtghichu.Text;

                    nccBUS.ThemNhaCungCap(dtDTO);
                    ReLoad();
                    //button
                    khoa();
                    btnthemxong.Enabled = false;
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btntimncc.Enabled = false;
            btnsua.Enabled = false;
            

            //text nhap
            txtma.Enabled = false;
            txtten.Enabled = true;
            txtdiachi.Enabled = true;
            txtdienthoai.Enabled = true;
            txtghichu.Enabled = true;
            txttimtenncc.Enabled = false;
        }

        private void btnsuaxong_Click(object sender, EventArgs e)
        {
            NHACC_BUS nccBUS = new NHACC_BUS();
            if (kiemtra())
            {
                NHACC_DTO dtDTO = new NHACC_DTO();
                //them từ text
                dtDTO.MaNCC = txtma.Text;
                dtDTO.TenNCC = txtten.Text;
                dtDTO.DiaChi = txtdiachi.Text;
                dtDTO.DienThoai = txtdienthoai.Text;
                dtDTO.GhiChu = txtghichu.Text;

                nccBUS.SuaNCC(dtDTO);
                ReLoad();
                //button
                khoa();
                btnsuaxong.Enabled = false;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa Nhà Cung Cấp ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                NHACC_BUS nccBUSS = new NHACC_BUS();
                nccBUSS.XoaNCC(txtma.Text);
                ReLoad();
            }
            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
        }
        //tìm kiếm theo mã
        

        private void btntimncc_Click(object sender, EventArgs e)
        {
            NHACC_BUS bus = new NHACC_BUS();
            List<NHACC_DTO> listncc = bus.Timtennhacc(txttimtenncc.Text);
            gidviewnhacc.DataSource = listncc;
        }

        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private void autocomplete()
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenNCC from NHACUNGCAP where TrangThai=1";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    auto.Add(dr["TenNCC"].ToString());
            }
            dr.Close();
            this.txttimtenncc.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttimtenncc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttimtenncc.AutoCompleteCustomSource = auto;
        }
        private void txtdienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NHACUNGCAP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                btnthoat.PerformClick();
            }
        }

    }
}