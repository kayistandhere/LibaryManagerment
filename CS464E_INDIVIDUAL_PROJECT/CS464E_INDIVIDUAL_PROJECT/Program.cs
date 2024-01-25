using CS464E_INDIVIDUAL_PROJECT.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464E_INDIVIDUAL_PROJECT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MUONSACH());
            //Application.Run(new SACH());
            //Application.Run(new DOCGIA());
            //Application.Run(new THELOAI());
            //Application.Run(new DANGNHAP());
            Application.Run(new TRANGCHU());
        }
    }
}
