using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SHOES_DTO
    {
        public string mashoes;
        public string tenshoes;
        public string machatlieu;
        public string tenchatlieu;
        public string tennhacungcap;
      //  public string hinhanh;
        public double dongia;
        public string mancc;
        public string ghichu;

        
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
        public string TenShoes
        {
            get
            {
                return tenshoes;
            }
            set
            {
                tenshoes = value;
            }
        }
        public string MaChatLieu
        {
            get
            {
                return machatlieu;
            }
            set
            {
                machatlieu = value;
            }
        }
        public string MaNhaCungCap
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
        public string TenChatLieu
        {
            get
            {
                return tenchatlieu;
            }
            set
            {
                tenchatlieu = value;
            }
        }
        public string TenNhaCungCap
        {
            get
            {
                return tennhacungcap;
            }
            set
            {
                tennhacungcap = value;
            }
        }
    

       
    }
}
