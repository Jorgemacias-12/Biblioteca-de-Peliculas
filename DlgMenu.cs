using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Biblioteca_de_Peliculas
{
    public partial class DlgMenu : Form
    {
        public DlgMenu()
        {
            InitializeComponent();
            AjustarDiseño();
        }

        #region posicionVentana
        //╔═════════════════════════════════╗
        //║ Mover la posición de la ventana ║
        //╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapure();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        private void DlgMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnlMenuSideBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PtbVideoMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FlpMenuStatusBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion


        //  ╔════════════════╗
        //  ║ Cerrar ventana ║
        //  ╚════════════════╝
        private void BtnClose_Click(object sender, EventArgs e)
        {
            DlgMensajeCerrarMenu dlgMensajeCerrarMenu = new DlgMensajeCerrarMenu();
            dlgMensajeCerrarMenu.Show();
        }

        private void DlgMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //  ╔═══════════════════╗
        //  ║ Minimizar ventana ║
        //  ╚═══════════════════╝
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        


        //  ╔═══════════════════╗
        //  ║ Ajustar paneles   ║
        //  ╚═══════════════════╝
        private void AjustarDiseño()
        {
            PnlCategoriasMenu.Visible = false;
            PnlHerramientasMenu.Visible = false;
            PnlAyudaMenu.Visible = false;

        }

        //  ╔═══════════════════╗
        //  ║ Minimizar paneles ║
        //  ╚═══════════════════╝
        private void OcultarSubMenu()
        {

            // Simplificar utilizando expresion ternaria

            if (PnlCategoriasMenu.Visible == true)
            {
                PnlCategoriasMenu.Visible = false;
            }

            if (PnlHerramientasMenu.Visible == true)
            {
                PnlHerramientasMenu.Visible = false;
            }

            if (PnlAyudaMenu.Visible == true)
            {
                PnlAyudaMenu.Visible = false;
            }
        }

        //╔═══════════════════╗
        //║ Maximizar paneles ║
        //╚═══════════════════╝
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }

            else
            {
                SubMenu.Visible = false;
            }
        }

        #region CategoriasMenu
        //╔════════════════════════╗
        //║ Abrir panel categorias ║
        //╚════════════════════════╝
        private void BtnCategoriasMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlCategoriasMenu);
        }

        //╔════════════════════════╗
        //║ Categoria de Inicio    ║
        //╚════════════════════════╝
        private void BtnCategoriaInicioMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaInicio());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Acción    ║
        //╚════════════════════════╝
        private void BtnCategoriaAccionMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgCategoriaAccion());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Animadas  ║
        //╚════════════════════════╝
        private void BtnCategoriaAnimadasMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgAnimadas());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Comedias  ║
        //╚════════════════════════╝
        private void BtnCategoriaComediasMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgComedias());
            OcultarSubMenu();
        }

        //╔════════════════════════╗
        //║ Categoria de Terror    ║
        //╚════════════════════════╝
        private void BtnCategoriaTerrorMenu_Click(object sender, EventArgs e)
        {
            AbrirDgvHijo(new DlgTerror());
            OcultarSubMenu();
        }
        #endregion

        #region ConfiguracionesMenu
        //╔════════════════════════╗
        //║ Abrir configuraciones  ║
        //╚════════════════════════╝
        private void BtnConfiguracionesMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlHerramientasMenu);
        }

        //╔══════════════════════════════╗
        //║ Cambia ventana a color claro ║
        //╚══════════════════════════════╝
        private void BtnHerramientaColorClaroMenu_Click(object sender, EventArgs e)
        {
            //Componentes
            PnlFormulariosHijosMenu.BackColor = Color.FromArgb(248,230,229);
            PnlDlgContainer.BackColor = Color.FromArgb(248, 230, 200);

            //Bloque 1. Categorias
            BtnCategoriasMenu.BackColor = Color.FromArgb(248, 230, 200);
            BtnCategoriasMenu.ForeColor = Color.FromArgb(11, 7, 30);
            //1.1 Inicio
            BtnCategoriaInicioMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaInicioMenu.ForeColor = Color.White;
            //1.2 Animadas
            BtnCategoriaAnimadasMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaAnimadasMenu.ForeColor = Color.White;
            //1.3 Comedias
            BtnCategoriaComediasMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaComediasMenu.ForeColor = Color.White;
            //1.4 Terror
            BtnCategoriaTerrorMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaTerrorMenu.ForeColor = Color.White;
            //1.5 Acción
            BtnCategoriaAccionMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaAccionMenu.ForeColor = Color.White;

            //Bloque 2. Configuraciones
            BtnConfiguracionesMenu.BackColor = Color.FromArgb(248, 230, 200);
            BtnConfiguracionesMenu.ForeColor = Color.FromArgb(11, 7, 30);

            //Bloque 3. Ayuda
            BtnAyudaMenu.BackColor = Color.FromArgb(248, 230, 200);
            BtnAyudaMenu.ForeColor = Color.FromArgb(11, 7, 30);
            BtnAcercaDeMenu.BackColor = Color.FromArgb(248, 230, 200);
            BtnAcercaDeMenu.ForeColor = Color.FromArgb(11, 7, 30);

            OcultarSubMenu();
        }

        //╔═══════════════════════════════╗
        //║ Cambia ventana a color oscuro ║
        //╚═══════════════════════════════╝
        private void BtnHerramientaColorOscuroMenu_Click(object sender, EventArgs e)
        {
            //Componentes
            PnlFormulariosHijosMenu.BackColor = Color.FromArgb(11, 7, 30);
            PnlDlgContainer.BackColor = Color.FromArgb(11, 7, 19);

            //Bloque 1. Categorias
            BtnCategoriasMenu.BackColor = Color.FromArgb(11, 7, 19);
            BtnCategoriasMenu.ForeColor = Color.White;
            //1.1 Inicio
            BtnCategoriaInicioMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaInicioMenu.ForeColor = Color.White;
            //1.2 Animada
            BtnCategoriaAnimadasMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaAnimadasMenu.ForeColor = Color.White;
            //1.3 Comedia
            BtnCategoriaComediasMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaComediasMenu.ForeColor = Color.White;
            //1.4 Terror
            BtnCategoriaTerrorMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaTerrorMenu.ForeColor = Color.White;

            BtnCategoriaAccionMenu.BackColor = Color.FromArgb(164, 0, 82);
            BtnCategoriaAccionMenu.ForeColor = Color.White;

            //Bloque 2. Configuraciones
            BtnConfiguracionesMenu.BackColor = Color.FromArgb(11, 7, 19);
            BtnConfiguracionesMenu.ForeColor = Color.White;

            //Bloque 3. Ayuda
            BtnAyudaMenu.BackColor = Color.FromArgb(11, 7, 19);
            BtnAyudaMenu.ForeColor = Color.White;
            BtnAcercaDeMenu.BackColor = Color.FromArgb(11, 7, 19);
            BtnAcercaDeMenu.ForeColor = Color.White;
            OcultarSubMenu();
        }
        #endregion

        #region AyudaMenu
        //╔════════════════════════╗
        //║ Abrir ayuda de menu    ║
        //╚════════════════════════╝
        private void BtnAyudaMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlAyudaMenu);
        }

        //╔════════════════════════╗
        //║ Abre un manual de uso  ║
        //╚════════════════════════╝
        private void BtnManualMenu_Click(object sender, EventArgs e)
        {
            DlgManual dlgManual = new DlgManual();
            dlgManual.Show();
            OcultarSubMenu();
        }

        //╔══════════════════════════════════╗
        //║ Brinda información del programa  ║
        //╚══════════════════════════════════╝
        private void BtnAcercaDeMenu_Click(object sender, EventArgs e)
        {
            DlgAcercaDe dlgAcercaDe = new DlgAcercaDe();
            dlgAcercaDe.Show();
            OcultarSubMenu();
        }
        #endregion

        private Form VentanaActiva = null;
        private void AbrirDgvHijo(Form VentanaHijo)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Close();
            }
            VentanaActiva = VentanaHijo;
            VentanaHijo.TopLevel = false;
            VentanaHijo.FormBorderStyle = FormBorderStyle.None;
            VentanaHijo.Dock = DockStyle.Fill;
            PnlFormulariosHijosMenu.Controls.Add(VentanaHijo);
            PnlFormulariosHijosMenu.Tag = VentanaHijo;
            VentanaHijo.BringToFront();
            VentanaHijo.Show();
        }
        
    }
}
