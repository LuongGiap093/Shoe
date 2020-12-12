using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHACC_DTO
    {
        private string mancc;
        private string tenncc;
        private string diachi;
        private string dienthoai;
        private string ghichu;

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
        public string TenNCC
        {
            get
            {
                return tenncc;
            }
            set
            {
                tenncc = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public string DienThoai
        {
            get
            {
                return dienthoai;
            }
            set
            {
                dienthoai = value;
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
