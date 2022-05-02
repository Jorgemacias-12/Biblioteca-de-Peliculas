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
    public partial class DlgAnimadas : Form
    {
        public DlgAnimadas()
        {
            InitializeComponent();
        }

        private void PtbCerrarDlgCategoriaAnimada_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PtbPeli4_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(4);
            dlgReproductor.Show();
        }

        private void PtbPeli9_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(9);
            dlgReproductor.Show();
        }

        private void PtbPeli10_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(10);
            dlgReproductor.Show();
        }

        private void PtbPeli12_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(12);
            dlgReproductor.Show();
        }

        private void PtbPeli15_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(15);
            dlgReproductor.Show();
        }

        private void PtbPeli19_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(19);
            dlgReproductor.Show();
        }
    }
}
