using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CHITIETHDBAN_BUS
    {
        public List<CHITIETHDBAN_DTO> LayDSChiTietHD()
        {
            CHITIETHDBAN_DAO dao = new CHITIETHDBAN_DAO();
            return dao.LayDSChiTietHD();
        }
        public List<CHITIETHDBAN_DTO> LayDanhSachTheoMa(string maHDB)
        {
            CHITIETHDBAN_DAO dao = new CHITIETHDBAN_DAO();
            return dao.LayDanhSachTheoMa(maHDB);
        }
        public string TongTienHoaDon(string maHDB)
        {
            CHITIETHDBAN_DAO dao = new CHITIETHDBAN_DAO();
            return dao.TongTienHoaDon(maHDB);
        }
        public void XoaCTHDB(string maHDB)
        {
            CHITIETHDBAN_DAO dao = new CHITIETHDBAN_DAO();
            dao.XoaCTHDB(maHDB);
        }
        public void ThemCTHDB(CHITIETHDBAN_DTO dto)
        {
            CHITIETHDBAN_DAO dao = new CHITIETHDBAN_DAO();
            dao.ThemCTHDB(dto);
        }
        public void CapNhatCTHDB(CHITIETHDBAN_DTO dto)
        {
            CHITIETHDBAN_DAO dao = new CHITIETHDBAN_DAO();
            dao.CapNhatCTHDB(dto);
        }
    }
}
