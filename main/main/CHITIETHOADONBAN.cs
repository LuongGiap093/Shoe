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

namespace main
{
    public partial class CHITIETHOADONBAN : DevExpress.XtraEditors.XtraForm
    {
        public CHITIETHOADONBAN()
        {
            InitializeComponent();
        }


        private void CHITIETHOADONBAN_Load(object sender, EventArgs e)
        {
            CHITIETHDBAN_BUS bus = new CHITIETHDBAN_BUS();
            List<CHITIETHDBAN_DTO> dto = bus.LayDSChiTietHD();
            gidviewcthd.DataSource = dto;
            gidviewcthd.Columns["MAHD"].HeaderText = "Mã Hóa Đơn";
            gidviewcthd.Columns["MASHOES"].HeaderText = "Mã Giày";
            gidviewcthd.Columns["SOLUONG"].HeaderText = "Số Lượng";
            gidviewcthd.Columns["DONGIA"].HeaderText = "Đơn Giá";
            gidviewcthd.Columns["GIAMGIA"].HeaderText = "Giảm Giá";
            gidviewcthd.Columns["THANHTIEN"].HeaderText = "Thành Tiền";      
            gidviewcthd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gidviewcthd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}