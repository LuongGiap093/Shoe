using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class HOADONBAN_DAO
    {
        public List<HOADONBAN_DTO> LayDSHoaDonBan()
        {
            List<HOADONBAN_DTO> dsHDB = new List<HOADONBAN_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM HOADONBAN WHERE TrangThai=1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HOADONBAN_DTO hd = new HOADONBAN_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        hd.MaHD = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        hd.MaNV = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        hd.MaKH = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        hd.NgayBan = (DateTime)dr[3];
                    if (!dr.IsDBNull(4))
                        hd.TongTien = (double)dr[4];
                    if (!dr.IsDBNull(5))
                        hd.GhiChu = (string)dr[5];
                    dsHDB.Add(hd);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsHDB;
        }

        public void ThemHDB(HOADONBAN_DTO dtDTO)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("INSERT INTO HOADONBAN(MaHD,MaNV,MaKH,NgayBan,TongTien,GhiChu,TrangThai) VALUES('{0}','{1}','{2}','{3}','{4}',N'{5}',{6}) ", dtDTO.MaHD, dtDTO.MaNV,dtDTO.MaKH, dtDTO.NgayBan.ToString("MM/dd/yyyy h:mm:ss tt"),dtDTO.TongTien,"",1);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                cmd.ExecuteNonQuery();

            }
            finally
            {
                // 5. đóng kết nối
                conn.Close();

            }
        }
        public void XoaHDB(string maHDB)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("DELETE FROM HOADONBAN WHERE MaHD = '{0}'", maHDB);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                cmd.ExecuteNonQuery();

            }
            finally
            {
                // 5. đóng kết nối
                conn.Close();

            }
        }
        public bool CheckMaHDB(string maHDB)
        {
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MaHD FROM HOADONBAN WHERE MaHD ='{0}'", maHDB);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maHDB == reader.GetString(0).Trim()))
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
