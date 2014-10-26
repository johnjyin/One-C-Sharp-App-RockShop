using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;
/// <summary>
/// Required designer variable.
/// author: john yin
/// version: version: V0.1
/// create date: 5/5/2014
/// last update data: 5/5/2014
/// </summary>
/// 

namespace Rockshop
{
    static class Program
    {
        /// <summary>
        /// to force Windows to display accelerator keys constantly
        /// </summary>
        /// <param name="uAction"></param>
        /// <param name="uParam"></param>
        /// <param name="lpvParam"></param>
        /// <param name="fuWinIni"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SystemParametersInfo(int uAction, int uParam, int lpvParam, int fuWinIni);

        private const int SPI_SETKEYBOARDCUES = 4107; //100B
        private const int SPIF_SENDWININICHANGE = 2;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // to force Windows to display accelerator keys constantly
            SystemParametersInfo(SPI_SETKEYBOARDCUES, 0, 1, 0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMedia());
        }
    }
}
