﻿using System;
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
    public partial class DlgCategoriaAccion : Form
    {
        public DlgCategoriaAccion()
        {
            InitializeComponent();
        }

        private void PtbCerrarDlgCategoriaAccion_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void PtbPeli1_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(1);
            dlgReproductor.Show();
        }

        private void PtbPeli2_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(2);
            dlgReproductor.Show();
        }

        private void PtbPeli3_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(3);
            dlgReproductor.Show();
        }

        private void PtbPeli4_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(4);
            dlgReproductor.Show();
        }

        private void PtbPeli7_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(7);
            dlgReproductor.Show();
        }

        private void PtbPeli8_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(8);
            dlgReproductor.Show();
        }

        private void PtbPeli9_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(9);
            dlgReproductor.Show();
        }

        private void PtbPeli12_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(12);
            dlgReproductor.Show();
        }

        private void PtbPeli13_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(13);
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

        private void PtbPeli16_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(16);
            dlgReproductor.Show();
        }

        private void PtbPeli17_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(17);
            dlgReproductor.Show();
        }

        private void PtbPeli18_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor dlgReproductor = new Reproductor(18);
            dlgReproductor.Show();
        }
    }
}
