using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HOADONNHAP_BUS
    {
        public List<HOADONNHAP_DTO> LayDSHoaDonNhap()
        {
            HOADONNHAP_DAO dao = new HOADONNHAP_DAO();
            return dao.LayDSNhanVien();
        }
    }
}
