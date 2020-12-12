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
using System.IO;
using System.Data.SqlClient;
namespace main
{
    public partial class SHOES : DevExpress.XtraEditors.XtraForm
    {
        public SHOES()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  
            khoa();

        }

        private void SHOES_Load(object sender, EventArgs e)
        {
            SHOES.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.autocomplete();


            NHACC_BUS ncc = new NHACC_BUS();
            List<NHACC_DTO> dsNCC = ncc.LayDSNhaCungCap();
            cbxnhacungcap.DataSource = dsNCC;
            cbxnhacungcap.ValueMember = "MaNCC";
            cbxnhacungcap.DisplayMember = "TenNCC";

            CHATLIEU_BUS cl = new CHATLIEU_BUS();
            List<CHATLIEU_DTO> dscl = cl.LayDSChatLieu();
            cbxchatlieu.DataSource = dscl;
            cbxchatlieu.ValueMember = "MaCL";
            cbxchatlieu.DisplayMember = "TenCL";

            SHOES_BUS bus = new SHOES_BUS();
            List<SHOES_DTO> dto = bus.LayDSShoes();
            dataGridView1.DataSource = dto;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
        }
        public void ReLoad()
        {
            SHOES_BUS dtBUS = new SHOES_BUS();
            dataGridView1.DataSource = dtBUS.LayDSShoes();
        }
        void khoa()
        {
            //khoa button
            btnthemxong.Enabled = false;
            btnsuaxong.Enabled = false;
         
            //khoa text
            txtdongia.Enabled = false;
            txtghichu.Enabled = false;
            txtma.Enabled = false;
            cbxnhacungcap.Enabled = false;
            txtten.Enabled = false;
            cbxchatlieu.Enabled = false;
        }
        public void trangthaibandau()
        {
            txtdongia.Text = txtghichu.Text = txtma.Text = txtten.Text = "";
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled =btnthoat.Enabled= true;
            btnthemxong.Enabled = btnsuaxong.Enabled = btntimkiem.Enabled = false;

        }
        public void reset()
        {
            txtdongia.Text = txtghichu.Text = txtma.Text = txtten.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            //button
            btnthemxong.Enabled = true;
            btnsua.Enabled = false;
            btnsuaxong.Enabled = false;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = false;  
            btnthem.Enabled = false;

            //text nhap
            txtdongia.Enabled = true;
            txtghichu.Enabled = true;
            txtma.Enabled = true;
            cbxnhacungcap.Enabled = true;
            txtten.Enabled = true;
            cbxchatlieu.Enabled = true;
            txttimgiay.Enabled = false;
            reset();
           

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //button
            btnthemxong.Enabled = false;
            btnsua.Enabled = false;
            btnsuaxong.Enabled = true;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = false;
           
            btnthem.Enabled = false;

            //text nhap
            txtdongia.Enabled = true;
            txtghichu.Enabled = true;
            txtma.Enabled = false;
            cbxnhacungcap.Enabled = true;
            txtten.Enabled = true;
            cbxchatlieu.Enabled = true;
            txttimgiay.Enabled = false;
        }
        public bool kiemtra()
        {
            bool res = false;
            if (txtma.Text.ToString().Trim() == "" ||txtten.Text.ToString().Trim() == ""
            || txtdongia.Text.ToString().Trim() == "" )
            {
                res = false;
                MessageBox.Show("Bạn chưa nhập dữ liệu,nên bạn cần thêm lại từ đầu ", "Thông báo",MessageBoxButtons.OK);
            }
            else
                res = true;
            return res;

        }
        private void btnthemxong_Click(object sender, EventArgs e)
        {
            //button
            btnthemxong.Enabled = false;
          
            btnsua.Enabled = true;
            btnsuaxong.Enabled = false;
            btnxoa.Enabled = true;
            btntimkiem.Enabled = true;
            btnthem.Enabled = true;
            //text
            txtdongia.Enabled = false;
            txtghichu.Enabled = false;
            txtma.Enabled = false;
            cbxnhacungcap.Enabled = false;
            txtten.Enabled = false;
            cbxchatlieu.Enabled = false;
            txttimgiay.Enabled = true;

            SHOES_BUS bus = new SHOES_BUS();
            if (bus.CheckMaShoes(txtma.Text))
            {
                MessageBox.Show("Mã đã tồn tại ,nên bạn cần nhập lại mã", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!bus.CheckMaShoes(txtma.Text))
            {
                if (kiemtra())
                {
                    SHOES_DTO dtDTO = new SHOES_DTO();
                    dtDTO.MaShoes = txtma.Text;
                    dtDTO.TenShoes = txtten.Text;
                    dtDTO.MaChatLieu = cbxchatlieu.SelectedValue.ToString();
                    dtDTO.MaNhaCungCap = cbxnhacungcap.SelectedValue.ToString();
                    dtDTO.DonGia = long.Parse(txtdongia.Text);
                    dtDTO.GhiChu = txtghichu.Text;
                    //dtDTO.HinhAnh = txtimagePath.Text;
                    bus.ThemShoes(dtDTO);
                    ReLoad();
                    khoa();
                    trangthaibandau();
                    
                   
                }
            }
        }
        private void btnsuaxong_Click(object sender, EventArgs e)
        {
            //button
            btnthemxong.Enabled = false;
            btnsua.Enabled = true;
            btnsuaxong.Enabled = false;
            btnxoa.Enabled = true;
            btntimkiem.Enabled = true;
            btnthem.Enabled = true;
           
            //text
            txtdongia.Enabled = false;
            txtghichu.Enabled = false;
            txtma.Enabled = false;
            cbxnhacungcap.Enabled = false;
            txtten.Enabled = false;
            cbxchatlieu.Enabled = false;
            txttimgiay.Enabled = true;

            SHOES_BUS bus = new SHOES_BUS();
            if (kiemtra())
            {
                SHOES_DTO dtDTO = new SHOES_DTO();
                //them từ text
                //MemoryStream stream = new MemoryStream();
                //pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //byte[] pic = stream.ToArray();
                //
                dtDTO.MaShoes = txtma.Text;
                dtDTO.TenShoes = txtten.Text;
                dtDTO.MaChatLieu = cbxchatlieu.SelectedValue.ToString();
                dtDTO.MaNhaCungCap = cbxnhacungcap.SelectedValue.ToString();
                dtDTO.DonGia = long.Parse(txtdongia.Text);
                dtDTO.GhiChu = txtghichu.Text;
                //dtDTO.HinhAnh = txtimagePath.Text;


                bus.SuaShoes(dtDTO);
                ReLoad();
                khoa();

            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            SHOES_BUS bus = new SHOES_BUS();
            List<SHOES_DTO> listsh = bus.Timtenshoes(txttimgiay.Text);
            dataGridView1.DataSource = listsh;
        }

        private void btntimgiay_Click(object sender, EventArgs e)
        {
            //button
            btnthemxong.Enabled = false;
            btnsua.Enabled = true;
            btnsuaxong.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btntimkiem.Enabled = true;
         
            //text nhap
            txtdongia.Enabled = false;
            txtghichu.Enabled = false;
            txtma.Enabled = false;
            cbxnhacungcap.Enabled = false;
            txtten.Enabled = false;
            cbxchatlieu.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SHOES_DTO sh= (SHOES_DTO)dataGridView1.SelectedRows[0].DataBoundItem;
                txtma.Text = sh.MaShoes;
                txtten.Text = sh.TenShoes;
                cbxchatlieu.SelectedValue = sh.MaChatLieu;
                cbxnhacungcap.SelectedValue = sh.MaNhaCungCap;
                txtdongia.Text = sh.DonGia.ToString();
                txtghichu.Text = sh.GhiChu;
               
            }
        }

       
        

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa Sản Phẩm Này ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SHOES_BUS bus= new SHOES_BUS();
                bus.XoaShoes(txtma.Text);
                ReLoad();
                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private void autocomplete()
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenShoes from SHOES where TrangThai=1";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    auto.Add(dr["TenShoes"].ToString());
            }
            dr.Close();
            this.txttimgiay.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttimgiay.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttimgiay.AutoCompleteCustomSource = auto;

        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SHOES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                btnthoat.PerformClick();
            }
        }

      
        
    }
}