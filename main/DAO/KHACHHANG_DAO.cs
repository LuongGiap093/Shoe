using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class KHACHHANG_DAO
    {
        public List<KHACHHANG_DTO> LayDSKhachHang()
        {
            List<KHACHHANG_DTO> dskh = new List<KHACHHANG_DTO>();

            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from KHACHHANG where TRANGTHAI = 1";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KHACHHANG_DTO kh = new KHACHHANG_DTO();
                    if (!dr.IsDBNull(0))
                        kh.MaKH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        kh.TenKH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        kh.DiaChi = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        kh.DienThoai = (string)dr[3];
                    dskh.Add(kh);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dskh;
        }
        public void ThemKhachHang(KHACHHANG_DTO dtDTO)
        {
            List<KHACHHANG_DTO> ListKH = new List<KHACHHANG_DTO>();
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT KHACHHANG(MaKH, TenKH, DiaChi, DienThoai, TrangThai) VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}')", dtDTO.MaKH, dtDTO.TenKH, dtDTO.DiaChi, dtDTO.DienThoai, 1);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void XoaKhachHang(string maKH)
        {
            List<KHACHHANG_DTO> ListKH = new List<KHACHHANG_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("EXEC sp_XoaKhachHang '{0}'",maKH);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void SuaKhachHang(KHACHHANG_DTO dtDTO)
        {
            List<KHACHHANG_DTO> ListKH = new List<KHACHHANG_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("UPDATE KHACHHANG set TenKH = N'{0}', DiaChi = N'{1}', DienThoai = '{2}' WHERE MaKH = '{3}' ", dtDTO.TenKH, dtDTO.DiaChi, dtDTO.DienThoai,dtDTO.MaKH);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public bool CheckMaKH(string maKH)
        {
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MaKH FROM KHACHHANG WHERE MaKH ='{0}'", maKH);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maKH == reader.GetString(0).Trim()))
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

        public List<KHACHHANG_DTO> Timtheotenkh(string tenKH)
        {
            List<KHACHHANG_DTO> dskh = new List<KHACHHANG_DTO>();

            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from KHACHHANG where TRANGTHAI = 1 and TenKH like N'%"+tenKH+"%'";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KHACHHANG_DTO kh = new KHACHHANG_DTO();
                    if (!dr.IsDBNull(0))
                        kh.MaKH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        kh.TenKH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        kh.DiaChi = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        kh.DienThoai = (string)dr[3];
                    dskh.Add(kh);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dskh;
        }
    }
}
