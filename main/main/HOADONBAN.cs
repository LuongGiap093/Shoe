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
    public partial class HOADONBAN : DevExpress.XtraEditors.XtraForm
    {
        public HOADONBAN()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  
        }

        private void HOADONBAN_Load(object sender, EventArgs e)
        {
            HOADONBAN_BUS bus = new HOADONBAN_BUS();
            List<HOADONBAN_DTO> dto = bus.LayDSHoaDonBan();
            gidviewhdb.DataSource = dto;
            gidviewhdb.Columns["MAHD"].HeaderText = "Mã Hóa Đơn";
            gidviewhdb.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            gidviewhdb.Columns["MAKH"].HeaderText = "Mã Khách Hàng";
            gidviewhdb.Columns["NGAYBAN"].HeaderText = "Ngày Bán";
            gidviewhdb.Columns["TONGTIEN"].HeaderText = "Tổng Tiền";
            gidviewhdb.Columns["GHICHU"].HeaderText = "Ghi Chú";
            gidviewhdb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gidviewhdb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}