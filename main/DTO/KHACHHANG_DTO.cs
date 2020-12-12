using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHACHHANG_DTO
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string dienthoai;

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
        public string TenKH
        {
            get
            {
                return tenkh;
            }
            set
            {
                tenkh = value;
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
    }
}
