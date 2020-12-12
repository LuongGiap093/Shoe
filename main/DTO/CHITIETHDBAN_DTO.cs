using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIETHDBAN_DTO
    {
        public string mahd;
        public string mashoes;
        public int soluong;
        public double dongia;
        public double thanhtien;
        public double giamgia;
        public string tenShoes;

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
        public double DonGia
        {
            get
            {
                return dongia;
            }
            set
            {
                dongia = value;
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
        public double GiamGia
        {
            get
            {
                return giamgia;
            }
            set
            {
                giamgia = value;
            }
        }
        public string TenShoes
        {
            get
            {
                return tenShoes;
            }
            set
            {
                tenShoes = value;
            }

        }

        public CHITIETHDBAN_DTO()
        {

        }
        public CHITIETHDBAN_DTO(string _mahd,string _mashoes,int _soluong,double _dongia,double _thanhtien)
        {
            this.mahd = _mahd;
            this.mashoes = _mashoes;
            this.soluong = _soluong;
            this.dongia = _dongia;
            this.thanhtien = _thanhtien;
        }
    }
}
