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
    public partial class ChatLieu : DevExpress.XtraEditors.XtraForm
    {
        public ChatLieu()
        {
            InitializeComponent();
            trangthaibandau();
            StartPosition = FormStartPosition.CenterScreen;  
        }
        private void ChatLieu_Load(object sender, EventArgs e)
        {
            ChatLieu.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;

            this.autocomplete();


            CHATLIEU_BUS bus = new CHATLIEU_BUS();
            List<CHATLIEU_DTO> dto = bus.LayDSChatLieu();
           

            gidviewchatlieu.DataSource = dto;
            gidviewchatlieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gidviewchatlieu.Columns["MACL"].HeaderText = "Mã Chất Liệu";
            gidviewchatlieu.Columns["TENCL"].HeaderText = "Tên Chất Liệu";
            gidviewchatlieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void gidviewchatlieu_SelectionChanged(object sender, EventArgs e)
        {
            if (gidviewchatlieu.SelectedRows.Count>0)
            {
                DataGridViewRow item = gidviewchatlieu.SelectedRows[0];
                txtma.Text = item.Cells["MACL"].Value.ToString();
                txtten.Text = item.Cells["TENCL"].Value.ToString();
               
            }
        }
        void reset()
        {
             txtma.Text = "";
             txtten.Text = "";
        }
        private void btnThemCL_Click(object sender, EventArgs e)
        {
            reset();

            btnThemXong.Enabled = true;
            btnsua.Enabled = false;
            btnsuaxong.Enabled = false;
            btnxoa.Enabled = false;
            btnThemCL.Enabled = false;
            btntimkiem.Enabled = false;
            //text nhap
            txtma.Enabled = true;
            txtten.Enabled = true;
            txttimtencl.Enabled = false;

        }
        public bool kiemtra()
        {
            bool res = false;
            if (txtma.Text.ToString().Trim() == "" || txtten.Text.ToString().Trim() == "" )
            {
                res = false;
                MessageBox.Show("Bạn chưa nhập dữ liệu ", "Thông báo", MessageBoxButtons.OK);
            }
            else
                res = true;
            return res;

        }
        public void ReLoad()
        {
            CHATLIEU_BUS dtBUS = new CHATLIEU_BUS();
            gidviewchatlieu.DataSource = dtBUS.LayDSChatLieu();
        }

        private void btnThemXong_Click(object sender, EventArgs e)
        {
            CHATLIEU_BUS clBUS = new CHATLIEU_BUS();
            if (clBUS.CheckMaCL(txtma.Text))
            {
                MessageBox.Show("Mã đã tồn tại ,nên bạn cần nhập lại mã", "Thông báo", MessageBoxButtons.OK);
            }
            else if (!clBUS.CheckMaCL(txtma.Text))
            {
                if (kiemtra())
                {
                    CHATLIEU_DTO dtDTO = new CHATLIEU_DTO();
                    //them từ text
                    dtDTO.MaCL = txtma.Text;
                    dtDTO.TenCL = txtten.Text;
                   

                    clBUS.ThemChatLieu(dtDTO);
                    ReLoad();
                    //button
                    khoa();
                    btnThemXong.Enabled = false;
                }
            }
        }
        void khoa()
        {
            //khoa button
            btnsua.Enabled = true;
            btnThemCL.Enabled = true;
            btnxoa.Enabled = true;
            btnThemXong.Enabled = false;
            btnsuaxong.Enabled = false;
            btntimkiem.Enabled = true;
            //khoa text
            txtma.Enabled = false;
            txtten.Enabled = false;
            txttimtencl.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnThemXong.Enabled = false;
            btnsuaxong.Enabled = true;
            btnxoa.Enabled = false;
            btnThemCL.Enabled = false;
            btnsua.Enabled = false;
            btntimkiem.Enabled = false;
            // btntimgiay.Enabled = false;

            //text nhap
            txtma.Enabled = false;
            txtten.Enabled = true;
            txttimtencl.Enabled = false;
           
        }

        private void btnsuaxong_Click(object sender, EventArgs e)
        {
            CHATLIEU_DTO dtDTO = new CHATLIEU_DTO();
            CHATLIEU_BUS khBUS = new CHATLIEU_BUS();
            dtDTO.MaCL = txtma.Text;
            dtDTO.TenCL = txtten.Text;
          
            khBUS.SuaChatLieu(dtDTO);
            ReLoad();
            khoa();
            btnsuaxong.Enabled = false;
        }
        public void trangthaibandau()
        {
            btnThemCL.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthoat.Enabled = true;

            btnThemXong.Enabled = false;
            btnsuaxong.Enabled = false;
            txtma.Enabled = false;
            txtten.Enabled = false;
        
         }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn xóa Nhân Viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CHATLIEU_BUS khBUS = new CHATLIEU_BUS();
                khBUS.XoaChatLieu(txtma.Text);
                ReLoad();
                MessageBox.Show("Xóa Thành công", "Thông báo ");
            }
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            CHATLIEU_BUS bus = new CHATLIEU_BUS();
            List<CHATLIEU_DTO> listcl = bus.TimKiemChatLieu(txttimtencl.Text);
            gidviewchatlieu.DataSource = listcl;
        }
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private void autocomplete()
        {
            SqlDataReader dr;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenChatLieu from CHATLIEU where TrangThai=1";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    auto.Add(dr["TenChatLieu"].ToString());
            }
            dr.Close();
            this.txttimtencl.AutoCompleteMode = AutoCompleteMode.Suggest;
            txttimtencl.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttimtencl.AutoCompleteCustomSource = auto;
        }

        private void ChatLieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                btnthoat.PerformClick();
            }
        }
    }
}