using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_de_Peliculas.src.Reproductor
{
    public partial class DlgReproductor : Form
    {

        #region Variables globales
        bool IsPlaying = false;
        bool IsMuted = false;
        bool IsResized = false;
        FolderBrowserDialog FolderBrowser;
        DialogResult DResult;
        string SelectedPath;
        List<string> Files;
        #endregion

        public DlgReproductor(string theme)
        {
            InitializeComponent();
            ApplyTheme(theme);
        }

        private void ApplyTheme(string actualTheme)
        {
            switch (actualTheme)
            {
                case "light":
                    break;
                case "dark":
                    break;
            }
        }

        private void DlgReproductor_Load(object sender, EventArgs e)
        {
            // Eliminar controles embebidos 
            wmpPlayer.uiMode = "none";

            // Centrar controles de reproducción
            CenterControls(50);

        }

        private void CenterControls(int Gap)
        {
            // Centrar controles de reproducción
            PnlControlContainer.Location = new Point(
                (PnlControls.Width - PnlControlContainer.Width) / 2,
                (PnlControls.Height - PnlControlContainer.Height) / 2
            );

            // Centrar control de volumen (a un lado del de reproducción)
            Point ReproContainerLoc = PnlControlContainer.Location;
            ReproContainerLoc.X = (ReproContainerLoc.X + PnlVolumeControls.Width + Gap); // 50
            PnlVolumeControls.Location = new Point(ReproContainerLoc.X, ReproContainerLoc.Y);
        }

        #region Reproductor Controls

        private void BtnTimeIncrease_Click(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Imagenes

            Image Resume = global::Biblioteca_de_Peliculas.Properties.Resources.resume;
            Image Pause = global::Biblioteca_de_Peliculas.Properties.Resources.stop;

            // Actualziar estado
            IsPlaying = !IsPlaying;

            // Cambiar imagen dependiendo del estado
            BtnStart.Image = IsPlaying ? Resume : Pause;

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void BtnTimeDecrease_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Audio Controls
        #endregion
        private void BtnAudio_Click(object sender, EventArgs e)
        {
            // Imagenes 
            Image Audio = global::Biblioteca_de_Peliculas.Properties.Resources.audio; 
            Image No_Audio = global::Biblioteca_de_Peliculas.Properties.Resources.no_audio;

            // Actualizar estado
            IsMuted = !IsMuted;

            // Cambiar imagen dependiendo del estado 
            BtnAudio.Image = IsMuted ? Audio : No_Audio;
        }

        private void Counter_Tick(object sender, EventArgs e)
        {
            try
            {
                MtbTimeLine.Value = (int)wmpPlayer.Ctlcontrols.currentPosition;
                LblTimeStart.Text = wmpPlayer.Ctlcontrols.currentPositionString;
                LblTimeEnd.Text = wmpPlayer.currentMedia.durationString;
            }
            catch (Exception)
            {
                Utils.ErrorDialog("Fallo al cargar el archivo","Error");
                throw;
            }
        }

        private void AbrirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia del selector de imagenes 
            FolderBrowser = new FolderBrowserDialog();

            // Abrir el diálogo, y guardar estado de salida
            DResult = FolderBrowser.ShowDialog();

            // Validación del estado al salir
            if (DResult == DialogResult.No ||
                DResult == DialogResult.Retry ||
                DResult == DialogResult.Cancel ||
                DResult == DialogResult.Abort)
            {
                return;
            }

            if (DResult == DialogResult.OK)
            {
                SelectedPath = FolderBrowser.SelectedPath;
                MessageBox.Show($"{Directory.GetFiles(SelectedPath)}");
            }
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DlgReproductor_Resize(object sender, EventArgs e)
        {
            // Redimensionar controles de navegación
            IsResized = !IsResized;
            if (IsResized)
            {
                CenterControls(350);
            }

            if (!IsResized)
            {
                CenterControls(50);
            }

        }
    }
}
