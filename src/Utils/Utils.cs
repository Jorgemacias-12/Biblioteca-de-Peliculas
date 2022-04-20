using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Biblioteca_de_Peliculas.src
{
    internal class Utils
    {
        // Obtener color 
        public static Color GetColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }

        #region MoverVentana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wsmg, int wparam, int lparam);
        #endregion

        // Obtener datos desde api para hablar de placeholder
        public static Image getDataFromRequest(int imageNumber)
        {
            // Variables
            string url;
            HttpWebRequest req;

            // Asignación de valores
            url = $"https://via.placeholder.com/150x200.png?text=Movie+{imageNumber}";
            req = (HttpWebRequest) WebRequest.Create(url);

            // Opciones de req
            req.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                return (Image) Bitmap.FromStream(stream);
            }
        }

        // Obtener datos desde api para hablar de placeholder
        public static async Task<Image> GetImageFromURL(int imageNumber)
        {
            // Variables
            string apiURL;
            HttpWebRequest request;
            HttpWebResponse response;
            Stream imageStream;
            Image tempImg;

            // Asignación de valores
            apiURL = $"https://via.placeholder.com/150x200.png?text=Movie+{imageNumber}";
            request = (HttpWebRequest) WebRequest.Create(apiURL);
            
            // Opciones de request
            request.AutomaticDecompression = DecompressionMethods.GZip;

            // Recibir la respuesta y meterla en un stream
            response = (HttpWebResponse) request.GetResponse();
            imageStream = response.GetResponseStream();

            // Retornar imagen

            tempImg = (Image) Bitmap.FromStream(imageStream);

            return  tempImg;

        }

        public static void StyleUIComponents(ControlCollection controls, string bgColorHex, string fgColorHex)
        {

            // Iterar en todos los controles

            foreach(Control component in controls)
            {
                component.ForeColor = Utils.GetColor(fgColorHex);

                if (component is Button)
                {
                    component.BackColor = Utils.GetColor(bgColorHex);
                }

            }

        }

        public static void StyleUIComponent(Control component, string bgColorHex, string fgColorHex)
        {

            // Validar parametros

            if (bgColorHex.Equals("")) component.BackColor = Utils.GetColor("#FFFFFF");
            if (fgColorHex.Equals("")) component.ForeColor = Utils.GetColor("#000000");

            // Aplicar propiedades de color
            component.BackColor = Utils.GetColor(bgColorHex);
            component.ForeColor = Utils.GetColor(fgColorHex);

        }


    }
}
