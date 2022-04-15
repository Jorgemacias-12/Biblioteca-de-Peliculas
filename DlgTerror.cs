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
    public partial class DlgTerror : Form
    {
        public DlgTerror()
        {
            InitializeComponent();
        }

        private void PtbCerrarDlgCategoriaTerror_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PtbPeli4_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(4);
            dlgReproductor.Show();
        }

        private void PtbPeli6_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(6);
            dlgReproductor.Show();
        }

        private void PtbPeli9_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(9);
            dlgReproductor.Show();
        }

        private void PtbPeli11_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(11);
            dlgReproductor.Show();
        }

        private void PtbPeli18_Click(object sender, EventArgs e)
        {
            this.Close();
            DlgReproductor dlgReproductor = new DlgReproductor(18);
            dlgReproductor.Show();
        }
    }
}
