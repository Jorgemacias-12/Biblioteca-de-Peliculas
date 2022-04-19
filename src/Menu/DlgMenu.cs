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
using Biblioteca_de_Peliculas.src;
using Biblioteca_de_Peliculas.src.Categoria;

namespace Biblioteca_de_Peliculas
{
    public partial class DlgMenu : Form
    {
        public DlgMenu()
        {
            InitializeComponent();
            AjustarDiseño();
        }


        //  ╔════════════════════╗
        //  ║ Variables globales ║
        //  ╚════════════════════╝
        private Utils util = new Utils();

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

            // No se puede simplificar :C

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
            DlgCategoria terror = new DlgCategoria("Películas de terror", "dark");
            AbrirDgvHijo(terror);
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
            // Sidebar
            PnlMenuSideBar.BackColor = util.getColor("#E0E0E0");

            // Cambiar icono del boton para minimizar
            BtnMinimize.Image = global::Biblioteca_de_Peliculas.Properties.Resources.minimize_black;

            // Iterar en todos los hijos y modificar el foreground color a black

            foreach (Control control in PnlMenuSideBar.Controls)
            {
                control.ForeColor = util.getColor("#000");

                if (control is Button)
                {
                    control.BackColor = util.getColor("#C5C5C5");
                }

            }

            // Modificar el aspecto de la barra de estado (top)
            FlpMenuStatusBar.BackColor = util.getColor("#FFFFFF");
            LblProgramTitle.ForeColor = util.getColor("#000");

            OcultarSubMenu();
        }

        //╔═══════════════════════════════╗
        //║ Cambia ventana a color oscuro ║
        //╚═══════════════════════════════╝
        private void BtnHerramientaColorOscuroMenu_Click(object sender, EventArgs e)
        {
            // Sidebar
            PnlMenuSideBar.BackColor = util.getColor("#222222");

            // Cambiar icono del boton para minimizar
            BtnMinimize.Image = global::Biblioteca_de_Peliculas.Properties.Resources.minimize;

            // Iterar en todos los hijos y modificar el foreground color a black

            foreach (Control control in PnlMenuSideBar.Controls)
            {
                control.ForeColor = util.getColor("#fff");

                if (control is Button)
                {
                    control.BackColor = util.getColor("#3C3C3C");
                }

            }

            // Modificar el aspecto de la barra de estado (top)
            FlpMenuStatusBar.BackColor = util.getColor("#191919");
            LblProgramTitle.ForeColor = util.getColor("#fff");

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
