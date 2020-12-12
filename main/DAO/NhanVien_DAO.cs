using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class NhanVien_DAO
    {
        public List<NhanVien_DTO> LayDSNhanVien()
        {
            List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT MaNV,TenNV,Gioitinh,DiaChi,NgaySinh,DienThoai FROM NHANVIEN WHERE TrangThai=1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien_DTO nV = new NhanVien_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        nV.MaNV = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        nV.TenNV = (string)dr[1];
                    if (!dr.IsDBNull(2))
                       nV.Gioitinh = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        nV.DiaChi = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        nV.NgaySinh = (DateTime)dr[4];
                    if (!dr.IsDBNull(5))
                         nV.DienThoai = (string)dr[5];
                        dsNV.Add(nV);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsNV;
        }
        public void ThemNV(NhanVien_DTO dtDTO)
        {
            List<NhanVien_DTO> ListDT = new List<NhanVien_DTO>();
            SqlConnection con = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format( "EXEC sp_ThemNhanVien '{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}','{6}'", dtDTO.MaNV, dtDTO.TenNV, dtDTO.Gioitinh, dtDTO.DiaChi, dtDTO.NgaySinh.ToString("MM/dd/yyyy h:mm:ss tt"), dtDTO.DienThoai, 1);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(con);
        }
        public void XoaNV(string maNV)
        {
            List<NhanVien_DTO> ListNV = new List<NhanVien_DTO>();
            SqlConnection con = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("EXEC sp_XoaNhanVien '{0}'", maNV);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(con);
        }
        public void SuaNV(NhanVien_DTO dtDTO)
        {

            List<NhanVien_DTO> ListDT = new List<NhanVien_DTO>();
            SqlConnection con = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("UPDATE NHANVIEN SET TENNV=N'{0}', GIOITINH =N'{1}' ,DIACHI =N'{2}' ,NGAYSINH='{3}', DIENTHOAI='{4}' WHERE MANV ='{5}'", dtDTO.TenNV, dtDTO.Gioitinh, dtDTO.DiaChi, dtDTO.NgaySinh.ToString("MM/dd/yyyy h:mm:ss tt"), dtDTO.DienThoai, dtDTO.MaNV);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(con);
        }
        public bool CheckMaNV(string maNV)
        {
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MaNV FROM NHANVIEN WHERE MaNV ='{0}'", maNV);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maNV == reader.GetString(0).Trim()))
                    {
                        value = 1;
                    }
                }
                if (value == 1)
                    return true;
                else
                    return false;
            }
            finally
            {
                // 5. đóng kết nối
                conn.Close();
            }
        }
        public List<NhanVien_DTO> Timnhanvien(string tenNV)
        {
            List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT MaNV,TenNV,Gioitinh,DiaChi,NgaySinh,DienThoai FROM NHANVIEN WHERE TrangThai=1 and TenNV like N'%"+tenNV+"%'";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien_DTO nV = new NhanVien_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        nV.MaNV = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        nV.TenNV = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        nV.Gioitinh = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        nV.DiaChi = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        nV.NgaySinh = (DateTime)dr[4];
                    if (!dr.IsDBNull(5))
                        nV.DienThoai = (string)dr[5];
                    dsNV.Add(nV);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsNV;
        }


    }
}
