using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class HOADONNHAP_DAO
    {
        public List<HOADONNHAP_DTO> LayDSNhanVien()
        {
            List<HOADONNHAP_DTO> dshdn = new List<HOADONNHAP_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM HOADONNHAP WHERE TrangThai=1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HOADONNHAP_DTO hdn = new HOADONNHAP_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        hdn.MaHD = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        hdn.MaShoes = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        hdn.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        hdn.NgayNhap = (DateTime)dr[3];
                    if (!dr.IsDBNull(4))
                        hdn.MaNCC = (string)dr[4];
                    if (!dr.IsDBNull(5))
                        hdn.MaNV = (string)dr[5];
                    if (!dr.IsDBNull(6))
                        hdn.GiaNhap = (double)dr[6];
                    if (!dr.IsDBNull(7))
                        hdn.ThanhTien = (double)dr[7];
                    dshdn.Add(hdn);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dshdn;
        }
    }
}
