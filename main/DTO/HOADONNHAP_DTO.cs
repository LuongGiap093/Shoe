using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HOADONNHAP_DTO
    {
        private string mahd;
        private string mashoes;
        private int soluong;
        private DateTime ngaynhap;
        private string mancc;
        private string manv;
        private double gianhap;
        private double thanhtien;

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
        public string MaShoes
        {
            get
            {
                return mashoes;
            }
            set
            {
                mashoes = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        public DateTime NgayNhap
        {
            get
            {
                return ngaynhap;
            }
            set
            {
                ngaynhap = value;
            }
        }
        public string MaNCC
        {
            get
            {
                return mancc;
            }
            set
            {
                mancc = value;
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
        public double GiaNhap
        {
            get
            {
                return gianhap;
            }
            set
            {
                gianhap = value;
            }
        }
        public double ThanhTien
        {
            get
            {
                return thanhtien;
            }
            set
            {
                thanhtien = value;
            }
        }
    }
}
