using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TAIKHOAN_DTO
    {
        public string username;
        public string password;
        public int quyen;
        public string hoten;

       
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
       

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }

        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        
    
    }
}
