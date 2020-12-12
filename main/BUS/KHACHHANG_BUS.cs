using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KHACHHANG_BUS
    {
        public List<KHACHHANG_DTO> LayDSKHACHHANG()
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            return dao.LayDSKhachHang();
        }

        public void ThemKhachHang(KHACHHANG_DTO dtDTO)
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            dao.ThemKhachHang(dtDTO);
        }

        public void XoaKhachHang(string maKH)
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            dao.XoaKhachHang(maKH);
        }

        public void SuaKhachHang(KHACHHANG_DTO dtDTO)
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            dao.SuaKhachHang(dtDTO);
        }
        public bool CheckMaKH(string maKH)
        {
            KHACHHANG_DAO dao = new KHACHHANG_DAO();
            return dao.CheckMaKH(maKH);
        }
        public List<KHACHHANG_DTO> Timtenkh(string tenKH)
        {
            KHACHHANG_DAO dtDAO = new KHACHHANG_DAO();
            return dtDAO.Timtheotenkh(tenKH);
        }
    }
}
