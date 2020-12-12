using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class TAIKHOAN_DAO
    {
        public List<TAIKHOAN_DTO> LayDSTK()
        {
            List<TAIKHOAN_DTO> dtDTO = new List<TAIKHOAN_DTO>();
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT UserName, Pasword, HoTen, Quyen FROM TAIKHOAN WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TAIKHOAN_DTO tk = new TAIKHOAN_DTO();
                    if (!dr.IsDBNull(0))
                        tk.UserName = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        tk.PassWord = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        tk.HoTen = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        tk.Quyen = (int)dr[3];                  
                    dtDTO.Add(tk);
                }
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return dtDTO;
        }

        public void themtk(string taikhoan, string matkhau, string hoten)
        {
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT TAIKHOAN(UserName, Pasword, HoTen, TRANGTHAI) VALUES('{0}', '{1}', '{2}', '{3}')", taikhoan, matkhau, hoten, 1);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }

        public bool DangNhap(string taikhoan, string matkhau)
        {
            SqlConnection conn = Provider.KetNoi();
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("SELECT UserName, Pasword FROM TAIKHOAN  WHERE TRANGTHAI = 1 and UserName = '{0}'", taikhoan);
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                int value = 0;
                if (dr.Read())
                {
                    if ((taikhoan == dr.GetString(0).Trim()) && (matkhau == dr.GetString(1).Trim()))
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
                dr.Close();
                conn.Close();
            }

        }

        public void DoiMK(string taikhoan, string matkhau, string matkhaumoi)
        {
            SqlConnection conn = Provider.KetNoi();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("UPDATE TAIKHOAN set Pasword = '{0}' WHERE UserName = '{1}' AND Pasword = '{2}'", matkhaumoi, taikhoan, matkhau);
            cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            Provider.NgatKetNoi(conn);
        }
    }
}
