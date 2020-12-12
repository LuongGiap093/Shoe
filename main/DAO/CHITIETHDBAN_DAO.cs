using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class CHITIETHDBAN_DAO
    {
        public List<CHITIETHDBAN_DTO> LayDSChiTietHD()
        {
            List<CHITIETHDBAN_DTO> ListCTHD = new List<CHITIETHDBAN_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("SELECT cthdb.MaHD,cthdb.MaShoes,sh.TenShoes,cthdb.SoLuong,sh.DonGia,cthdb.ThanhTien FROM  CHITIETHOADONBAN cthdb , SHOES sh WHERE cthdb.MaShoes =sh.MaShoes AND cthdb.TRANGTHAI=1");
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CHITIETHDBAN_DTO ct = new CHITIETHDBAN_DTO();
                    if (!dr.IsDBNull(0))
                        ct.MaHD = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        ct.MaShoes = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        ct.TenShoes = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        ct.SoLuong= (int)dr[3];
                    if (!dr.IsDBNull(4))
                        ct.DonGia = (double)dr[4];
                    if (!dr.IsDBNull(5))
                        ct.ThanhTien = (double)dr[5];
                
                    ListCTHD.Add(ct);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return ListCTHD;
        }


        public List<CHITIETHDBAN_DTO> LayDanhSachTheoMa(string maHDB)
        {
            List<CHITIETHDBAN_DTO> dsCTHDB = new List<CHITIETHDBAN_DTO>();
            List<SHOES_DTO> dsHH = new List<SHOES_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT cthdb.MaShoes,TenShoes,cthdb.SoLuong,sh.DonGia,cthdb.ThanhTien FROM CHITIETHOADONBAN cthdb ,SHOES sh WHERE cthdb.MaShoes=sh.MaShoes AND cthdb.TRANGTHAI = 1 AND cthdb.MaHD='" + maHDB + "'";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CHITIETHDBAN_DTO cTHDB = new CHITIETHDBAN_DTO();
                    if (!dr.IsDBNull(0))
                        cTHDB.MaShoes = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cTHDB.TenShoes = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        cTHDB.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        cTHDB.DonGia = (double)dr[3];
                    if (!dr.IsDBNull(4))
                        cTHDB.ThanhTien = (double)dr[4];
                    dsCTHDB.Add(cTHDB);
                }
            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsCTHDB;

        }
        public void XoaCTHDB(string maHDB)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("DELETE FROM CHITIETHOADONBAN WHERE MaHD = '{0}'", maHDB);
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
        public string TongTienHoaDon(string maHDB)
        {
            string tongTien = "0";
            List<CHITIETHDBAN_DTO> List = new List<CHITIETHDBAN_DTO>();
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT SUM(ThanhTien) From CHITIETHOADONBAN Where MaHD='{0}'", maHDB);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    tongTien = reader.GetDouble(0).ToString();
                }
                return tongTien;

            }

            finally
            {
                // 5. đóng kết nối
                conn.Close();
            }
        }
        public void ThemCTHDB(CHITIETHDBAN_DTO dtDTO)
        {
            // 1. Tạo đối tượng kết nối
            //SqlConnection conn = Provider.KetNoi();
            //try
            //{
            //    // 3. tạo đối tượng command
            //    SqlCommand cmd = new SqlCommand();
            //    //"DELETE FROM FC WHERE FCName = 'Chelsea'"

            //    cmd.CommandText = string.Format("INSERT CHITIETHOADONBAN(MaHD,MaShoes,SoLuong,DonGia,ThanhTien,GiamGia,TrangThai) VALUES('{0}','{1}',{2},{3},{4},{5},{6}", dtDTO.MaHD, dtDTO.MaShoes, dtDTO.SoLuong, dtDTO.DonGia, dtDTO.ThanhTien,0,1);
            //    cmd.Connection = conn;
            //    // 4. thực thi cmd và xử lý kết quả
            //    cmd.ExecuteNonQuery();
                
            //}
            //finally
            //{
            //    // 5. đóng kết nối
            //    conn.Close();

            //}
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT INTO CHITIETHOADONBAN(MaHD,MaShoes,SoLuong,ThanhTien,GiamGia,TrangThai) VALUES('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", dtDTO.MaHD,
            dtDTO.MaShoes,dtDTO.SoLuong, dtDTO.ThanhTien,0,1);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }

        public void CapNhatCTHDB(CHITIETHDBAN_DTO dtDTO)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = Provider.KetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("UPDATE CHITIETHOADONBAN set SoLuong={0}, DonGia={1},ThanhTien={2},GiamGia={3}  WHERE MaHD='{4}' AND MaShoes='{5}'", dtDTO.SoLuong,dtDTO.DonGia,dtDTO.ThanhTien, dtDTO.GiamGia,dtDTO.MaHD,dtDTO.MaShoes);
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
       

    }
}
