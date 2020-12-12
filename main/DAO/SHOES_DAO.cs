using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class SHOES_DAO
    {
        public List<SHOES_DTO> LayDSShoes()
        {
            List<SHOES_DTO> dsshoes = new List<SHOES_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select MaShoes ,TenShoes, cl.MaChatLieu ,cl.TenChatLieu ,ncc.MaNCC,ncc.TenNCC,DonGia,sh.GhiChu  From SHOES sh ,NHACUNGCAP ncc,CHATLIEU cl  WHERE sh.TRANGTHAI = 1 and sh.MaNCC = ncc.MaNCC and sh.MaChatLieu=cl.MaChatLieu ";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SHOES_DTO sh = new SHOES_DTO();
                    if (!dr.IsDBNull(0))
                        sh.MaShoes = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        sh.TenShoes = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        sh.MaChatLieu = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        sh.TenChatLieu = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        sh.MaNhaCungCap = (string)dr[4];
                    if (!dr.IsDBNull(5))
                        sh.TenNhaCungCap= (string)dr[5];
                    if (!dr.IsDBNull(6))
                        sh.DonGia = long.Parse(dr[6].ToString());
                    if (!dr.IsDBNull(7))    
                        sh.GhiChu = (string)dr[7];
                    dsshoes.Add(sh);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dsshoes;
        }
       
        public void ThemShoes(SHOES_DTO dtDTO)
        {
            List<SHOES_DTO> ListShoes = new List<SHOES_DTO>();
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT INTO SHOES(MaShoes,TenShoes,MaChatLieu,MaNCC,DonGia,GhiChu,TrangThai) VALUES('{0}', N'{1}', '{2}', '{3}', {4}, N'{5}','{6}')",
            dtDTO.MaShoes ,dtDTO.TenShoes,dtDTO.MaChatLieu, dtDTO.MaNhaCungCap,dtDTO.DonGia,dtDTO.GhiChu, 1);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void XoaShoes(string maShoes)
        {
            List<SHOES_DTO> ListShoes = new List<SHOES_DTO>();
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("EXEC sp_XoaShoes '{0}'", maShoes);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void SuaShoes(SHOES_DTO dtDTO)
        {
            List<SHOES_DTO> ListShoes = new List<SHOES_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("UPDATE SHOES set MaShoes='{0}',TenShoes = N'{1}', MaChatLieu= '{2}', MaNCC ='{3}', DonGia= '{4}' ,GhiChu=N'{5}' WHERE MaShoes = '{6}' ", dtDTO.MaShoes, dtDTO.TenShoes, dtDTO.MaChatLieu, dtDTO.MaNhaCungCap,dtDTO.DonGia,dtDTO.GhiChu, dtDTO.MaShoes);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
        public void timkiemsp(string masp)
        {
           // List<SHOES_DTO> dtDTO = new List<SHOES_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("SELECT * FROM SHOES WHERE MaShoes = '{0}' ", masp);

            cmd.Connection = conn; 
            cmd.ExecuteReader();
            Provider.NgatKetNoi(conn);
        }
        public bool CheckMaShoes(string maShoes)
        {
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MaShoes FROM SHOES WHERE MaShoes ='{0}'", maShoes);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maShoes== reader.GetString(0).Trim()))
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

        public List<SHOES_DTO> Timkiemtheoten(string tenShoes)
        {
            List<SHOES_DTO> dsshoes = new List<SHOES_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select MaShoes ,TenShoes, cl.MaChatLieu ,cl.TenChatLieu ,ncc.MaNCC,ncc.TenNCC,DonGia,sh.GhiChu  From SHOES sh ,NHACUNGCAP ncc,CHATLIEU cl  WHERE sh.TRANGTHAI = 1 and sh.MaNCC = ncc.MaNCC and sh.MaChatLieu=cl.MaChatLieu and TenShoes like N'%"+tenShoes+"%'";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SHOES_DTO sh = new SHOES_DTO();
                    if (!dr.IsDBNull(0))
                        sh.MaShoes = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        sh.TenShoes = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        sh.MaChatLieu = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        sh.TenChatLieu = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        sh.MaNhaCungCap = (string)dr[4];
                    if (!dr.IsDBNull(5))
                        sh.TenNhaCungCap = (string)dr[5];
                    if (!dr.IsDBNull(6))
                        sh.DonGia = long.Parse(dr[6].ToString());
                    if (!dr.IsDBNull(7))
                        sh.GhiChu = (string)dr[7];
                    dsshoes.Add(sh);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dsshoes;
        }
    }
}
