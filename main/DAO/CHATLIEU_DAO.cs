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
    public class CHATLIEU_DAO
    {
        public List<CHATLIEU_DTO> LayDSChatLieu()
        {
            List<CHATLIEU_DTO> dsCL = new List<CHATLIEU_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT *from CHATLIEU  WHERE TrangThai=1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CHATLIEU_DTO cL = new CHATLIEU_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        cL.MaCL= (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cL.TenCL = (string)dr[1];
                    dsCL.Add(cL);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsCL;
        }

        public void ThemChatLieu(CHATLIEU_DTO dtDTO)
        {
            List<CHATLIEU_DTO> ListCL = new List<CHATLIEU_DTO>();
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT CHATLIEU(MaChatLieu,TenChatLieu,TrangThai) VALUES('{0}', N'{1}', N'{2}')", dtDTO.MaCL, dtDTO.TenCL, 1);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void XoaChatLieu(string maCL)
        {
            List<KHACHHANG_DTO> ListCL = new List<KHACHHANG_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("EXEC sp_XoaChatLieu '{0}'", maCL);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void SuaChatLieu(CHATLIEU_DTO dtDTO)
        {
            List<CHATLIEU_DTO> ListCL= new List<CHATLIEU_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("UPDATE CHATLIEU set TenChatLieu= N'{0}' WHERE MaChatLieu= '{1}' ", dtDTO.TenCL,dtDTO.MaCL);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public bool CheckMaCL(string maCL)
        {
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MaChatLieu FROM CHATLIEU WHERE MaChatLieu ='{0}'", maCL);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maCL == reader.GetString(0).Trim()))
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
        public List<CHATLIEU_DTO> Timkiemchatlieu(string tenCL)
        {
            List<CHATLIEU_DTO> dsCL = new List<CHATLIEU_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT *from CHATLIEU  WHERE TrangThai=1 and TenChatLieu like N'%"+tenCL+"%'";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CHATLIEU_DTO cL = new CHATLIEU_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        cL.MaCL = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cL.TenCL = (string)dr[1];
                    dsCL.Add(cL);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsCL;
        }

        
        
    }
}
