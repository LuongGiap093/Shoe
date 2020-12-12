using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NHACC_DAO
    {
        public List<NHACC_DTO> LayDSNhaCungCap()
        {
            List<NHACC_DTO> dsncc = new List<NHACC_DTO>();

            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from NHACUNGCAP where TRANGTHAI = 1";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NHACC_DTO ncc = new NHACC_DTO();
                    if (!dr.IsDBNull(0))
                        ncc.MaNCC = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        ncc.TenNCC = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        ncc.DiaChi = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        ncc.DienThoai = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        ncc.GhiChu = (string)dr[4];
                    dsncc.Add(ncc);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dsncc;
        }

        public void ThemNhaCC(NHACC_DTO dtDTO)
        {
            List<KHACHHANG_DTO> ListNCC = new List<KHACHHANG_DTO>();
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT NHACUNGCAP(MaNCC, TenNCC, DiaChi, DienThoai, GhiChu, TrangThai) VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}')", dtDTO.MaNCC, dtDTO.TenNCC, dtDTO.DiaChi, dtDTO.DienThoai, dtDTO.GhiChu, 1);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }

        public void xoaNCC(string maNCC)
        {
            List<NHACC_DTO> ListNCC = new List<NHACC_DTO>();
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("EXEC sp_XoaNhaCungCap '{0}'", maNCC);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }

        public void SuaNCC(NHACC_DTO dtDTO)
        {
            List<NHACC_DTO> ListNCC = new List<NHACC_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("UPDATE NHACUNGCAP set TenNCC = N'{0}', DiaChi = N'{1}', DienThoai = '{2}', GhiChu = N'{3}' WHERE MaNCC = '{4}' ", dtDTO.TenNCC, dtDTO.DiaChi, dtDTO.DienThoai, dtDTO.GhiChu, dtDTO.MaNCC);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }

        public void TimKiemNCC(string maNCC)
        {
            List<NHACC_DTO> ListNCC = new List<NHACC_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("SELECT * FROM NHACUNGCAP Where MaNCC = '{0}'" + maNCC);
            cmd.Connection = conn;
            cmd.ExecuteReader();
            Provider.NgatKetNoi(conn);
        }
        public List<NHACC_DTO> Timtheotenncc(string tenNCC)
        {
            List<NHACC_DTO> dsncc = new List<NHACC_DTO>();

            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from NHACUNGCAP where TRANGTHAI = 1 and TenNCC like N'%" + tenNCC + "%'";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NHACC_DTO ncc = new NHACC_DTO();
                    if (!dr.IsDBNull(0))
                        ncc.MaNCC = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        ncc.TenNCC = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        ncc.DiaChi = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        ncc.DienThoai = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        ncc.GhiChu = (string)dr[4];
                    dsncc.Add(ncc);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dsncc;
        }
        public bool CheckMaNCC(string maNCC)
        {
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MaNCC FROM NHACUNGCAP WHERE MaNCC ='{0}'", maNCC);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maNCC == reader.GetString(0).Trim()))
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
    }
}
