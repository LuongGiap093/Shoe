using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNV;
        private string tenNV;
        private string gioitinh;
        private string diachi;
        private DateTime ngaysinh;
        private string dienthoai;
        private string trangthai;


        public string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                maNV = value;
            }

        }
        public string TenNV
        {
            get
            {
                return tenNV;
            }
            set
            {
                tenNV = value;
            }

        }
        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
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
        public DateTime NgaySinh
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                ngaysinh = value;
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
        //public string TrangThai
        //{
        //    get
        //    {
        //        return trangthai;
        //    }
        //    set
        //    {
        //        trangthai = value;
        //    }

        //}
    }
}
