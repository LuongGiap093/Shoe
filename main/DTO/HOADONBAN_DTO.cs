using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class HOADONBAN_DTO
    {
        private string mahd;
        private string manv;
        private string makh;
        private DateTime ngayban;
        private double tongtien;
        private string ghichu;

        public string MaHD
        {
            get
            {
                return mahd;
            }
            set
            {
                mahd = value;
            }
        }
        public string MaNV
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
            }
        }
        public string MaKH
        {
            get
            {
                return makh;
            }
            set
            {
                makh = value;
            }
        }
        public DateTime NgayBan
        {
            get
            {
                return ngayban;
            }
            set
            {
                ngayban = value;
            }
        }
        public double TongTien
        {
            get
            {
                return tongtien;
            }
            set
            {
                tongtien = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return ghichu;
            }
            set
            {
                ghichu = value;
            }
        }
    }
}
