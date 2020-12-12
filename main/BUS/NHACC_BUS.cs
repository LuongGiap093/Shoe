using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class NHACC_BUS
    {
        public List<NHACC_DTO> LayDSNhaCungCap()
        {
            NHACC_DAO dao = new NHACC_DAO();
            return dao.LayDSNhaCungCap();
        }

        public void ThemNhaCungCap(NHACC_DTO dtDTO)
        {
            NHACC_DAO dao = new NHACC_DAO();
            dao.ThemNhaCC(dtDTO);
        }

        public void XoaNCC(string maNCC)
        {
            NHACC_DAO dao = new NHACC_DAO();
            dao.xoaNCC(maNCC);
        }

        public void SuaNCC(NHACC_DTO dtDTO)
        {
            NHACC_DAO dao = new NHACC_DAO();
            dao.SuaNCC(dtDTO);
        }

        public void TimKiemNCC(string maNCC)
        {
            NHACC_DAO dao = new NHACC_DAO();
            dao.TimKiemNCC(maNCC);
        }
        public List<NHACC_DTO> Timtennhacc(string tenNCC)
        {
            NHACC_DAO dtDAO = new NHACC_DAO();
            return dtDAO.Timtheotenncc(tenNCC);
        }
        public bool CheckMaNCC(string maNCC)
        {
            NHACC_DAO dao = new NHACC_DAO();
            return dao.CheckMaNCC(maNCC);
        }
    }
}
