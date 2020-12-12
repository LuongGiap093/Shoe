using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SHOES_BUS
    {
        public List<SHOES_DTO> LayDSShoes()
        {
            SHOES_DAO dao = new SHOES_DAO();
            return dao.LayDSShoes();
        }

        public void timkiemsp(string masp)
        {
            SHOES_DAO dao = new SHOES_DAO();
            dao.timkiemsp(masp);
        }
        public void ThemShoes(SHOES_DTO dtDTO)
        {
            SHOES_DAO dao = new SHOES_DAO();
            dao.ThemShoes(dtDTO);
        }
        public void SuaShoes(SHOES_DTO dtDTO)
        {
            SHOES_DAO dao = new SHOES_DAO();
            dao.SuaShoes(dtDTO);
        }
        public void XoaShoes(string maShoes)
        {
            SHOES_DAO dao = new SHOES_DAO();
            dao.XoaShoes(maShoes);
        }
        public bool CheckMaShoes(string maShoes)
        {
            SHOES_DAO dao = new SHOES_DAO();
            return dao.CheckMaShoes(maShoes);
        }
        public List<SHOES_DTO> Timtenshoes(string tenShoes)
        {
            SHOES_DAO dtDAO = new SHOES_DAO();
            return dtDAO.Timkiemtheoten(tenShoes);
        }

    }
}
