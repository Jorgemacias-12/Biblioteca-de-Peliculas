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
    public partial class DlgAcercaDe : Form
    {
        public DlgAcercaDe()
        {
            InitializeComponent();
        }

        private void PtbCerrarMenu_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DlgAcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void PtbMinimizarMenu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LnkLblAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LnkLblAutor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/AaronF11");
        }

        private void LnkLblRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LnkLblRepositorio.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/AaronF11/Biblioteca-de-Peliculas");
        }
    }
}
