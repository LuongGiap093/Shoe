using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class TAIKHOAN_BUS
    {
        TAIKHOAN_DAO dao = new TAIKHOAN_DAO();
        public List<TAIKHOAN_DTO> LayDSTK()
        {
            return dao.LayDSTK();
        }

        public void DOIMK(string taikhoan, string matkhau, string matkhaumoi)
        {
             dao.DoiMK(taikhoan,matkhau,matkhaumoi);
        }

        public bool DangNhap(string taikhoan, string matkhau)
        {
             if(dao.DangNhap(taikhoan, matkhau))
                return true;          
            else 
                return false;
        }
        public void ThemTK(string taikhoan, string matkhau, string hoten)
        {
            dao.themtk(taikhoan, matkhau, hoten);
        }
    }
}
