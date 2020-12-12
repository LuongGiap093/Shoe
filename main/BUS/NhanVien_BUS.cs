using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class NhanVien_BUS
    {
       public List<NhanVien_DTO> LayDSNhanVien()
       {
           NhanVien_DAO dao = new NhanVien_DAO();
           return dao.LayDSNhanVien();
       }
       public void ThemNV(NhanVien_DTO dtDTO)
       {
           NhanVien_DAO dao = new NhanVien_DAO();
           dao.ThemNV(dtDTO);
       }
       public void XoaNV(string maNV)
       {
           NhanVien_DAO dao = new NhanVien_DAO();
           dao.XoaNV(maNV);
       }
       public void SuaNV(NhanVien_DTO dtDTO)
       {
           NhanVien_DAO dtDAO = new NhanVien_DAO();
           dtDAO.SuaNV(dtDTO);
       }
       public bool CheckMaNV(string maNV)
       {
           NhanVien_DAO dao = new NhanVien_DAO();
           return dao.CheckMaNV(maNV);
       }
       public List<NhanVien_DTO> Timtennhanvien(string tenNV)
       {
           NhanVien_DAO dtDAO = new NhanVien_DAO();
           return dtDAO.Timnhanvien(tenNV);
       }
    }
}
