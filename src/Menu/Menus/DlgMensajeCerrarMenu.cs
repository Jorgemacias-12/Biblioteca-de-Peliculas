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
    public partial class DlgMensajeCerrarMenu : Form
    {
        
        public DlgMensajeCerrarMenu()
        {
            InitializeComponent();
        }

        private void DlgMensajeCerrarMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
