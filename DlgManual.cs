using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_de_Peliculas
{
    public partial class DlgManual : Form
    {
        public DlgManual()
        {
            InitializeComponent();
        }
        
        string[] ImgReproducir = new string[7];
        string[] ImgModos = new string[3];
        int indexR, indexM = 0;

        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void PnlArribaManual_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void PtbCerrarManual_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DlgManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void PtbMinimizarManual_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void AdelantarReproducir(PictureBox img)
        {
            switch (indexR)
            {
                case 0:
                    LblInfoReproducir.Text = "Ingresar usuario y contraseña";
                    ImgReproducir[0] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso1.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR++;
                    break;
                case 1:
                    LblInfoReproducir.Text = "Visualiza el panel desplegable";
                    ImgReproducir[1] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso2.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR++;
                    break;
                case 2:
                    LblInfoReproducir.Text = "Selecciona en el panel desplegable 'Categorias'";
                    ImgReproducir[2] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso3.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR++;
                    break;
                case 3:
                    LblInfoReproducir.Text = "Selecciona la categoria de 'Inicio'";
                    ImgReproducir[3] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso4.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR++;
                    break;
                case 4:
                    LblInfoReproducir.Text = "Visualiza el panel panel de películas disponibles";
                    ImgReproducir[4] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso5.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR++;
                    break;
                case 5:
                    LblInfoReproducir.Text = "Selecciona la película deseada";
                    ImgReproducir[5] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso6.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR++;
                    break;
                case 6:
                    LblInfoReproducir.Text = "Ajustar el reproductor a preferencia propia";
                    ImgReproducir[6] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\reproducir\Paso7.png";
                    img.ImageLocation = ImgReproducir[indexR];
                    indexR = 0;
                    break;
            }
        }

        private void TimerReproducir_Tick(object sender, EventArgs e)
        {
            AdelantarReproducir(PtbImagenReproducir);
            AdelantarModos(PtbImagenModos);
        }

        private void BtnAutomaticoReproducir_Click(object sender, EventArgs e)
        {
            indexR = 0;
            TimerReproducir.Enabled = true;
        }

        private void BtnPausarReproducir_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = false;

        }

        private void BtnContinuarReproducir_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = true;
        }

        private void AdelantarModos(PictureBox img)
        {
            switch (indexM)
            {
                case 0:
                    LblInfoReproducir.Text = "Ingresar usuario y contraseña";
                    ImgModos[0] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\modos\Paso1.png";
                    img.ImageLocation = ImgModos[indexM];
                    indexM++;
                    break;
                case 1:
                    LblInfoReproducir.Text = "Visualiza el panel desplegable";
                    ImgModos[1] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\modos\Paso2.png";
                    img.ImageLocation = ImgModos[indexM];
                    indexM++;
                    break;
                case 2:
                    LblInfoReproducir.Text = "Selecciona en el panel desplegable 'Categorias'";
                    ImgModos[2] = @"C:\Users\aaron\source\repos\Biblioteca de Peliculas\src\manual\modos\Paso3.png";
                    img.ImageLocation = ImgModos[indexM];
                    indexM = 0;
                    break;

            }
        }

        private void BtnAutomaticoModos_Click(object sender, EventArgs e)
        {
            indexM = 0;
            TimerReproducir.Enabled = true;
        }

        private void BtnPausarModos_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = false;

        }

        private void BtnContinuarModos_Click(object sender, EventArgs e)
        {
            TimerReproducir.Enabled = true;
        }
    }
}
