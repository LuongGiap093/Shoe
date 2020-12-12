using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HOADONBAN_BUS
    {
        public List<HOADONBAN_DTO> LayDSHoaDonBan()
        {
            HOADONBAN_DAO dao = new HOADONBAN_DAO();
            return dao.LayDSHoaDonBan();
        }
        public void ThemHDB(HOADONBAN_DTO dto)
        {
            HOADONBAN_DAO dao = new HOADONBAN_DAO();
            dao.ThemHDB(dto);
        }
        public bool CheckMaHDB(string maHDB)
        {
            HOADONBAN_DAO dao = new HOADONBAN_DAO();
            return dao.CheckMaHDB(maHDB);
        }
        public void XoaHDB(string maHDB)
        {
            HOADONBAN_DAO dao = new HOADONBAN_DAO();
            dao.XoaHDB(maHDB);
        }
    }
}
