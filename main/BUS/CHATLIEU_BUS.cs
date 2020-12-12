using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class CHATLIEU_BUS
    {
        public List<CHATLIEU_DTO> LayDSChatLieu()
        {
            CHATLIEU_DAO dao = new CHATLIEU_DAO();
            return dao.LayDSChatLieu();
        }
        public void ThemChatLieu(CHATLIEU_DTO dtDTO)
        {
            CHATLIEU_DAO dao = new CHATLIEU_DAO();
            dao.ThemChatLieu(dtDTO);
        }

        public void XoaChatLieu(string maCL)
        {
            CHATLIEU_DAO dao = new CHATLIEU_DAO();
            dao.XoaChatLieu(maCL);
        }

        public void SuaChatLieu(CHATLIEU_DTO dtDTO)
        {
            CHATLIEU_DAO dao = new CHATLIEU_DAO();
            dao.SuaChatLieu(dtDTO);
        }
        public bool CheckMaCL(string maCL)
        {
            CHATLIEU_DAO dao = new CHATLIEU_DAO();
            return dao.CheckMaCL(maCL);
        }
        public List<CHATLIEU_DTO> TimKiemChatLieu(string tenCL)
        {
            CHATLIEU_DAO dtDAO = new CHATLIEU_DAO();
            return dtDAO.Timkiemchatlieu(tenCL);
        }
    }
}
