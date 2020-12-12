using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
             Application.Run(new Form1());
            //Application.Run(new dangnhap());
            //Application.Run(new timnhanvien());
            //Application.Run(new dangky());
          //  Application.Run(new NHACUNGCAP());
            //Application.Run(new doimk());
          // Application.Run(new HOADONBAN());
          //Application.Run(new SHOES());
            //Application.Run(new CHITIETHOADONBAN());
        //Application.Run(new PHIEUHOADONBAN());
       // Application.Run(new dangnhap());
            
        }
    }
}
