using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_de_Peliculas
{
    public partial class DlgComedias : Form
    {
        public DlgComedias()
        {
            InitializeComponent();
        }

        private void PtbCerrarDlgCategoriaComedias_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PtbPeli2_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(2);
            dlgReproductor.Show();
        }

        private void PtbPeli7_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(7);
            dlgReproductor.Show();
        }

        private void PtbPeli10_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(10);
            dlgReproductor.Show();
        }

        private void PtbPeli14_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(14);
            dlgReproductor.Show();
        }

        private void PtbPeli15_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(15);
            dlgReproductor.Show();
        }

        private void PtbPeli17_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(17);
            dlgReproductor.Show();
        }
    }
}
