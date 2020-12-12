using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO
{
    public class Provider
    {
        private static string strChuoiKetNoi = @"Data Source=LAPTOP-BCOJ4C5R\SQLEXPRESS;Initial Catalog=QuanLyCuaHangGiay;Integrated Security=True";

        public static SqlConnection KetNoi()
        {
            string a = Environment.CurrentDirectory;

            //1. Tạo đối tượng connection
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);//Dùng Access
            //SqlConnection conn = new SqlConnection(chuoiKetNoi);//Dùng SQL Server

            SqlDataReader rdr = null;
            try
            {
                // 2. Mở kết nối
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void NgatKetNoi(SqlConnection conn)
        {
            conn.Close();
        }

        


    }
}
