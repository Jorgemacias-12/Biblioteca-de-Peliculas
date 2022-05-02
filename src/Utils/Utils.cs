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

        public static async Task<Image> GetImageFromUrl(int imageNumber)
        {
            // Variables
            string url = $"https://via.placeholder.com/150x200.png/F5F5F5/000?text={imageNumber}";
            TaskCompletionSource<Image> Tsc = new TaskCompletionSource<Image>();
            HttpWebRequest request;
            HttpWebResponse response;
            Stream stream;
            Image image;

            // Asignación de valores
            request = (HttpWebRequest) WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            // Convertir la respuesta en async
            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                .ContinueWith( task =>
                {
                    response = (HttpWebResponse)task.Result;
                    stream = response.GetResponseStream();
                    image = Image.FromStream(stream);

                    Tsc.TrySetResult(image);
                    response.Close();
                    stream.Close();

                });
            return Tsc.Task.Result;
        }

        public static async Task<Image> GetMovieImage(string category)
        {
            return null;
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

        public static void PaintBorder(object sender, EventArgs e)
        {

            // Propiedades del borde
            Color BorderColor = GetColor("#2667FF");
            int BorderSize = 4;
            ButtonBorderStyle BorderStyle = ButtonBorderStyle.Solid;

            // Obtener componente
            PictureBox component = sender as PictureBox;
            // Crear un rectángulo
            Rectangle componentRec = new Rectangle(new Point(0, 0), component.Size);
            // Dibujar el borde con los gráficos
            ControlPaint.DrawBorder(component.CreateGraphics(),
                                    componentRec,
                                    BorderColor,
                                    BorderSize,
                                    BorderStyle,
                                    BorderColor,
                                    BorderSize,
                                    BorderStyle,
                                    BorderColor,
                                    BorderSize,
                                    BorderStyle,
                                    BorderColor,
                                    BorderSize,
                                    BorderStyle);
        }

        private static void RemoveBorder(object sender, EventArgs e)
        {
            PictureBox component = sender as PictureBox;
            Rectangle componentRec = new Rectangle(new Point(0, 0), component.Size);
            ControlPaint.DrawBorder(component.CreateGraphics(), componentRec, GetColor("#fff"), ButtonBorderStyle.None);
            component.Refresh();
        }

        public static async void GenerateMoviePreview(int QuantityOfView, 
                                                      FlowLayoutPanel Container,
                                                      EventHandler GoToMovie, 
                                                      bool IsCategoryNull, 
                                                      string movieCategory)
        {
            // Inicializar componentes
            PictureBox pictureBox;

            pictureBox = null;

            // Generar la caratula de imagenes 
            for (int i = 0; i < QuantityOfView; i++)
            {
                // Inicializar componentes
                pictureBox = new PictureBox();

                // Propiedades del componente
                pictureBox.Size = new Size(150, 200);
                pictureBox.Name = $"view {i + 1}";
                pictureBox.Image = IsCategoryNull ? await GetImageFromUrl(i + 1) : await GetMovieImage(movieCategory);
                pictureBox.Margin = new Padding(10, 10, 10, 10);
                pictureBox.Anchor = AnchorStyles.None;
                pictureBox.Click += GoToMovie;
                pictureBox.MouseEnter += PaintBorder;
                pictureBox.MouseLeave += RemoveBorder;
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.Update();

                // Añadir al contenedor los componentes
                Container.Controls.Add(pictureBox);
                Container.Update();

            }
        }

        public static void ErrorDialog(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
