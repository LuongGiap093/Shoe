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
namespace main
{
    public partial class PHIEUHOADONBAN : DevExpress.XtraEditors.XtraForm
    {
        SHOES_BUS bus_Shoes = new SHOES_BUS();
        HOADONBAN_BUS bus_HDB = new HOADONBAN_BUS();
        KHACHHANG_BUS bus_KH = new KHACHHANG_BUS();
        NhanVien_BUS bus_NV = new NhanVien_BUS();

        CHITIETHDBAN_BUS bus_CTHDB = new CHITIETHDBAN_BUS();
        List<CHITIETHDBAN_DTO> lstCTHDB = null;

        HOADONBAN_DTO dto_hdb= new HOADONBAN_DTO();
        public PHIEUHOADONBAN()
        {
            InitializeComponent();
            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            StartPosition = FormStartPosition.CenterScreen;  
            
        }



        private void PHIEUHOADON_Load(object sender, EventArgs e)
        {
            loaddulieu();
            //numericUpDownSoLuong.Value = 1;
            trangthaibandau();
           
        }
        public void loaddulieu()
        {
            cbxMaHDB.DataSource = bus_Shoes.LayDSShoes();
            cbxMaHDB.ValueMember = "MaShoes";
            cbxMaKH.DataSource = bus_KH.LayDSKHACHHANG();
            cbxMaKH.ValueMember = "MaKH";
            cbxMaNV.DataSource = bus_NV.LayDSNhanVien();
            cbxMaNV.ValueMember = "MaNV";
            cbxHoaDon.DataSource = bus_HDB.LayDSHoaDonBan();
            cbxHoaDon.ValueMember = "MaHD";

        }
        void hiemThiThongTinShoes(SHOES_DTO Shoes)
        {
                txtTenShoes.Text= Shoes.TenShoes;
                txtDonGia.Text = Shoes.DonGia.ToString();
                numericUpDownSoLuong.Value = 0;
                txtThanhTien.Text = "0";
        }
         void hiemThiThongTinKhachHang(KHACHHANG_DTO khachHang)
        {
            txtTenKH.Text = khachHang.TenKH;
            txtDiaChi.Text = khachHang.DiaChi;
            txtDienThoai.Text = khachHang.DienThoai;
        }
         void hienthiTenNhanVien(NhanVien_DTO nhanVien)
         {
             txtTenNV.Text = nhanVien.TenNV;
         }
        void hienThiThongTinHoaDonBan(HOADONBAN_DTO hdb)
         {
             txtMaHD.Text = hdb.MaHD;
             dtpNgayBan.Value = hdb.NgayBan;
             cbxMaNV.Text = hdb.MaNV;
             cbxMaKH.Text = hdb.MaKH;
         }

         private void cbxMaKH_SelectionChangeCommitted(object sender, EventArgs e)
         {
             KHACHHANG_DTO khachHang = (KHACHHANG_DTO)cbxMaKH.SelectedItem;
             hiemThiThongTinKhachHang(khachHang);
         }

         private void cbxMaNV_SelectionChangeCommitted(object sender, EventArgs e)
         {
             NhanVien_DTO nhanVien = (NhanVien_DTO)cbxMaNV.SelectedItem;
             hienthiTenNhanVien(nhanVien);
         }

         private void cbxMaKH_SelectedIndexChanged(object sender, EventArgs e)
         {
             //KHACHHANG_DTO khachHang = (KHACHHANG_DTO)cbxMaKH.SelectedItem;
             //hiemThiThongTinKhachHang(khachHang);
         }

         private void cbxMaHDB_SelectionChangeCommitted(object sender, EventArgs e)
         {
             if (cbxMaHDB.SelectedItem != null)
             {
                 SHOES_DTO shoes_DTO = (SHOES_DTO)cbxMaHDB.SelectedItem;
                 hiemThiThongTinShoes(shoes_DTO);
             }
          
         }
         long tongtien = 0;
         private void btnThemGiay_Click(object sender, EventArgs e)
         {

             //if (listViewHoaDonBan.Items.Count ==0)
             //{
             //    ListViewItem lvi = new ListViewItem(cbxMaHDB.Text);
             //    lvi.SubItems.Add(txtTenShoes.Text);
             //    lvi.SubItems.Add(txtDonGia.Text);
             //    lvi.SubItems.Add(numericUpDownSoLuong.Value.ToString());
             //   //lvi.SubItems.Add(txtGiamGia.Text);
             //    lvi.SubItems.Add(txtThanhTien.Text);
             //    listViewHoaDonBan.Items.Add(lvi);
             //}
             if (listViewHoaDonBan.Items.Count >= 0)
             {
                 int values = 0;
                 for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
                 {
                     if (listViewHoaDonBan.Items[i].Text.Equals(cbxMaHDB.Text))
                     {
                         long tongtienn = 0;
                         int soLuong = int.Parse(listViewHoaDonBan.Items[i].SubItems[3].Text);
                         long thanhTien = long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);  

                         listViewHoaDonBan.Items[i].SubItems[3].Text = (soLuong +numericUpDownSoLuong.Value).ToString();
                         listViewHoaDonBan.Items[i].SubItems[4].Text = (thanhTien + long.Parse(txtThanhTien.Text)).ToString();
                         long dg = Convert.ToInt32(txtDonGia.Text);
                         
                         thanhTien = dg * soLuong;
                         tongtienn += thanhTien;
                         txtTongTien.Text = tongtienn.ToString();
                         values = 1;
                         break;
                     }

                 }
                 if (values == 0)
                 {
                     //int tongtien = 0;
                     ListViewItem lvi = new ListViewItem(cbxMaHDB.Text);
                     int i = listViewHoaDonBan.Items.Count;
                     i++;
                  //   lvi.Text = i.ToString();

                     lvi.SubItems.Add(txtTenShoes.Text);
                     lvi.SubItems.Add(txtDonGia.Text);
                     lvi.SubItems.Add(numericUpDownSoLuong.Value.ToString());
                     // lvi.SubItems.Add(txtGiamGia.Text);
                     lvi.SubItems.Add(txtThanhTien.Text);
                  //   listViewHoaDonBan.Items.Add(lvi);

                          
                     listViewHoaDonBan.Items.Add(lvi);
                 }
             }
             for(int i= 0; i<listViewHoaDonBan.Items.Count;i++)
             {
                 tongtien = tongtien + long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);
               
                 
             }
             txtTongTien.Text = tongtien.ToString();
             tongtien = 0;

         }

     

         private void btnCapnhat_Click(object sender, EventArgs e)
         {
             if (listViewHoaDonBan.SelectedItems.Count > 0)
             {
                 listViewHoaDonBan.SelectedItems[0].SubItems[0].Text = cbxMaHDB.Text;
                 listViewHoaDonBan.SelectedItems[0].SubItems[1].Text = txtTenShoes.Text;
                 listViewHoaDonBan.SelectedItems[0].SubItems[2].Text = txtDonGia.Text;
                 listViewHoaDonBan.SelectedItems[0].SubItems[3].Text = numericUpDownSoLuong.Value.ToString();
                 //listViewHoaDonBan.SelectedItems[0].SubItems[3].Text = txtDonGia.Text;
                 listViewHoaDonBan.SelectedItems[0].SubItems[4].Text = txtThanhTien.Text;
             }
             for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
             {
                 tongtien = tongtien + long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);


             }
             txtTongTien.Text = tongtien.ToString();
             tongtien = 0;
         }

         private void btnXoaSP_Click(object sender, EventArgs e)
         {
             
                 listViewHoaDonBan.Items.RemoveAt(0);
                 for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
                 {
                     tongtien = tongtien + long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);


                 }
                 txtTongTien.Text = tongtien.ToString();
                 tongtien = 0;

             
             //listViewHoaDonBan.Items.Clear();
         }

         private void btnTimHoaDon_Click(object sender, EventArgs e)
         {
             if (cbxHoaDon.SelectedItem != null)
             {
                 if (bus_HDB.CheckMaHDB(cbxHoaDon.Text))
                 {
                     listViewHoaDonBan.Items.Clear();
                     HOADONBAN_DTO hoaDonBan = (HOADONBAN_DTO)cbxHoaDon.SelectedItem;
                     hienThiThongTinHoaDonBan(hoaDonBan);
                     KHACHHANG_DTO khachHang = (KHACHHANG_DTO)cbxMaKH.SelectedItem;
                     hiemThiThongTinKhachHang(khachHang);
                     NhanVien_DTO nhanVien = (NhanVien_DTO)cbxMaNV.SelectedItem;
                     hienthiTenNhanVien(nhanVien);
                      lstCTHDB= bus_CTHDB.LayDanhSachTheoMa(cbxHoaDon.Text);
                     foreach (CHITIETHDBAN_DTO ctHDB in lstCTHDB)
                     {
                         ListViewItem lvi = new ListViewItem(ctHDB.MaShoes);
                         lvi.SubItems.Add(ctHDB.TenShoes);
                         lvi.SubItems.Add(ctHDB.DonGia.ToString());
                         lvi.SubItems.Add(ctHDB.SoLuong.ToString());
                         lvi.SubItems.Add(ctHDB.ThanhTien.ToString());
                         listViewHoaDonBan.Items.Add(lvi);  
                     }

                     for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
                     {
                         tongtien = tongtien + long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);
                     }
                     txtTongTien.Text = tongtien.ToString();
                     tongtien = 0;
                 }
                 else
                 {
                     MessageBox.Show("Không Tìm Thấy !");
                 }
                 btnLuuHoaDon.Enabled = false;
                 btnThemHoaDon.Enabled = true;

             }
         }

         private void listViewHoaDonBan_SelectedIndexChanged(object sender, EventArgs e)
         {

             if (listViewHoaDonBan.SelectedItems.Count > 0)
             {
                 ListViewItem item = listViewHoaDonBan.SelectedItems[0];
                 CHITIETHDBAN_DTO ctHDB = new CHITIETHDBAN_DTO(item.SubItems[1].Text, item.Text, int.Parse(item.SubItems[3].Text),double.Parse(item.SubItems[2].Text),long.Parse(item.SubItems[4].Text));
                 txtTenShoes.Text = ctHDB.MaHD;
                 cbxMaHDB.SelectedValue = ctHDB.MaShoes;
                 txtDonGia.Text = ctHDB.DonGia.ToString();
                 numericUpDownSoLuong.Value = ctHDB.SoLuong;
                 txtThanhTien.Text = ctHDB.ThanhTien.ToString();
             }
         }
         private void numericUpDownSoLuong_ValueChanged(object sender, EventArgs e)
         {
            txtThanhTien.Text = (numericUpDownSoLuong.Value * long.Parse(txtDonGia.Text)).ToString();
         }
         public bool kiemtra()
         {
             bool res = false;
             if (txtDiaChi.Text.ToString().Trim() == "" || txtDienThoai.Text.ToString().Trim() == "" || txtTenKH.Text.ToString().Trim() == ""
                 || txtTenNV.Text.ToString().Trim() == "" || txtTenShoes.Text.ToString().Trim()=="" || txtDonGia.Text.ToString().Trim()=="" || txtTongTien.Text.ToString().Trim()=="")
             {
                 res = false;
                 MessageBox.Show("Bạn chưa nhập dữ liệu ", "Thông báo");
             }
             else
                 res = true;
             return res;

         }
         private void btnLuuHoaDon_Click(object sender, EventArgs e)
         {

             if (kiemtra())
             {
                 if (bus_HDB.CheckMaHDB(txtMaHD.Text))
                 {
                     MessageBox.Show("Mã đã tồn tại ,nên bạn cần nhập lại mã", "Thông báo",MessageBoxButtons.OK);
                 }
                 else if(!bus_HDB.CheckMaHDB(txtMaHD.Text))
                 {                                         
                         dto_hdb.MaHD = txtMaHD.Text;
                         dto_hdb.MaKH = cbxMaKH.Text;
                         dto_hdb.MaNV = cbxMaNV.Text;
                         dto_hdb.NgayBan = dtpNgayBan.Value;
                         dto_hdb.TongTien = double.Parse(txtTongTien.Text);
                         bus_HDB.ThemHDB(dto_hdb);
                         for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
                         {
                             int soLuong = int.Parse(listViewHoaDonBan.Items[i].SubItems[3].Text);
                             long thanhTien = long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);
                             string maHH = listViewHoaDonBan.Items[i].Text;
                             CHITIETHDBAN_DTO cTHDB_DTO = new CHITIETHDBAN_DTO();
                             cTHDB_DTO.MaHD = txtMaHD.Text;
                             cTHDB_DTO.MaShoes = maHH;
                             cTHDB_DTO.SoLuong = soLuong;
                             cTHDB_DTO.ThanhTien = thanhTien;
                             cTHDB_DTO.GiamGia = 0;
                             bus_CTHDB.ThemCTHDB(cTHDB_DTO);
                         }
                         MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK);
                 }
                 //if (bus_HDB.CheckMaHDB(txtMaHD.Text))
                 //{
                 //    bus_CTHDB.XoaCTHDB(txtMaHD.Text);
                 //    for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
                 //    {
                 //        int soLuong = int.Parse(listViewHoaDonBan.Items[i].SubItems[3].Text);
                 //        long thanhTien = long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);
                 //        string maHH = listViewHoaDonBan.Items[i].Text;
                 //        CHITIETHDBAN_DTO cTHDB_DTO = new CHITIETHDBAN_DTO();
                 //        cTHDB_DTO.MaHD = txtMaHD.Text;
                 //        cTHDB_DTO.MaShoes = maHH;
                 //        cTHDB_DTO.SoLuong = soLuong;
                 //        cTHDB_DTO.ThanhTien = thanhTien;
                 //        cTHDB_DTO.GiamGia = 0;
                 //        bus_CTHDB.ThemCTHDB(cTHDB_DTO);
                 //    }
                 //}
                 trangthaibandau();
                 loaddulieu();
                 btnLuuHoaDon.Enabled = false;
                 btnThemHoaDon.Enabled = true;
             }
        
         }
         public void trangthaibandau()
         {
             txtMaHD.Text = txtTenNV.Text = txtDiaChi.Text = txtDienThoai.Text = txtTenKH.Text = txtTenShoes.Text = "";
             txtThanhTien.Text = "";
             txtDonGia.Text = "";
             btnLuuHoaDon.Enabled = false;
             txtDiaChi.Enabled = txtDienThoai.Enabled = txtDonGia.Enabled = txtTenKH.Enabled = txtTenNV.Enabled = txtTenShoes.Enabled = txtThanhTien.Enabled = txtTongTien.Enabled = false;
             listViewHoaDonBan.Items.Clear();
         }
         
         private void btnThemHoaDon_Click(object sender, EventArgs e)
         {
             trangthaibandau();
             txtMaHD.Text = "HDB";
             btnLuuHoaDon.Enabled = true;
             btnThemHoaDon.Enabled = false;
             btnCapnhatHDVuaTim.Enabled = false;
         }

         private void btnKiemTraMa_Click(object sender, EventArgs e)
         {
             if (bus_HDB.CheckMaHDB(txtMaHD.Text))
             {
                 MessageBox.Show("Mã Tồn Tại, Vui lòng nhập mã khác !!!","Thông Báo");
             }
             else
             {
                 MessageBox.Show("Mã Không Tồn Tại Bạn Có Thể Thêm Hóa Đơn  !!!", "Thông Báo");
             }
         }

         private void btnreset_Click(object sender, EventArgs e)
         {

             btnThemHoaDon.Enabled = true;
             btnreset.Enabled = true;
             btnLuuHoaDon.Enabled = false;
             trangthaibandau();
         }

         private void numericUpDownSoLuong_Click(object sender, EventArgs e)
         {
             txtThanhTien.Text = (numericUpDownSoLuong.Value * long.Parse(txtDonGia.Text)).ToString();
         }

         private void btnCapnhatHDVuaTim_Click(object sender, EventArgs e)
         {
             if (bus_HDB.CheckMaHDB(txtMaHD.Text))
             {
                
                 
                 
                 //dto_hdb.MaHD = txtMaHD.Text;
                 //dto_hdb.MaKH = cbxMaKH.Text;
                 //dto_hdb.MaNV = cbxMaNV.Text;
                 //dto_hdb.NgayBan = dtpNgayBan.Value;
                 //dto_hdb.TongTien = double.Parse(txtTongTien.Text);
                 //bus_HDB.ThemHDB(dto_hdb);
                 bus_CTHDB.XoaCTHDB(txtMaHD.Text);
                 for (int i = 0; i < listViewHoaDonBan.Items.Count; i++)
                 {
                     int soLuong = int.Parse(listViewHoaDonBan.Items[i].SubItems[3].Text);
                     long thanhTien = long.Parse(listViewHoaDonBan.Items[i].SubItems[4].Text);
                     string maHH = listViewHoaDonBan.Items[i].Text;
                     CHITIETHDBAN_DTO cTHDB_DTO = new CHITIETHDBAN_DTO();
                     cTHDB_DTO.MaHD = txtMaHD.Text;
                     cTHDB_DTO.MaShoes = maHH;
                     cTHDB_DTO.SoLuong = soLuong;
                     cTHDB_DTO.ThanhTien = thanhTien;
                     cTHDB_DTO.GiamGia = 0;
                     bus_CTHDB.ThemCTHDB(cTHDB_DTO);
                 }
                 MessageBox.Show("Cập nhật hóa đơn thành công","Thông báo",MessageBoxButtons.OK);
             }

         }

         private void btnthoat_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void groupBox1_Enter(object sender, EventArgs e)
         {

         }

    }
}