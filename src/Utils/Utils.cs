using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Peliculas.src
{
    internal class Utils
    {
        // Obtener color 
        public Color getColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        #region MoverVentana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wsmg, int wparam, int lparam);
        #endregion

    }
}
