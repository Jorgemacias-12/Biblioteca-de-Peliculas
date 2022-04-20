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
        private DlgCategoria categoria;


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

        //  ╔════════════════════════╗
        //  ║ Categoria de Terror    ║
        //  ╚════════════════════════╝
        private void BtnCategoriaTerrorMenu_Click(object sender, EventArgs e)
        {
            categoria = new DlgCategoria("", "dark");
            AbrirDgvHijo(categoria);
            OcultarSubMenu();
        }
        #endregion

        #region ConfiguracionesMenu
        //  ╔════════════════════════╗
        //  ║ Abrir configuraciones  ║
        //  ╚════════════════════════╝
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
            Utils.StyleUIComponent(PnlMenuSideBar, "#F5F5F5", "");

            // Cambiar icono del boton para minimizar
            BtnMinimize.Image = global::Biblioteca_de_Peliculas.Properties.Resources.minimize_black;

            // Iterar en todos los hijos y modificar el foreground color a black
            Utils.StyleUIComponents(PnlMenuSideBar.Controls, "#F5F5F5", "#000");
            Utils.StyleUIComponents(PnlCategoriasMenu.Controls, "#E0E0E0", "#000");
            Utils.StyleUIComponents(PnlHerramientasMenu.Controls, "#E0E0E0", "#000");
            Utils.StyleUIComponents(PnlAyudaMenu.Controls, "#E0E0E0", "#000");

            // Modificar el aspecto de la barra de estado (top)
            Utils.StyleUIComponent(FlpMenuStatusBar, "#FFF", "");
            Utils.StyleUIComponent(LblProgramTitle, "#FFF", "#000");

            // Actualizar tema de la sección de categoría
            if (categoria != null) categoria.updateTheme("light");

            OcultarSubMenu();
        }

        //╔═══════════════════════════════╗
        //║ Cambia ventana a color oscuro ║
        //╚═══════════════════════════════╝
        private void BtnHerramientaColorOscuroMenu_Click(object sender, EventArgs e)
        {
            // Sidebar
            Utils.StyleUIComponent(PnlMenuSideBar, "#222222", "");
            // PnlMenuSideBar.BackColor = Utils.GetColor("#222222");

            // Cambiar icono del boton para minimizar
            BtnMinimize.Image = global::Biblioteca_de_Peliculas.Properties.Resources.minimize;

            // Iterar en todos los hijos y modificar el foreground color a black

            Utils.StyleUIComponents(PnlMenuSideBar.Controls,"#222222","#FFFFFF");
            Utils.StyleUIComponents(PnlCategoriasMenu.Controls, "#3C3C3C", "#FFFFFF");
            Utils.StyleUIComponents(PnlHerramientasMenu.Controls, "#3C3C3C", "#FFFFFF");
            Utils.StyleUIComponents(PnlAyudaMenu.Controls, "#3C3C3C", "#FFFFFF");


            // Modificar el aspecto de la barra de estado (top)
            Utils.StyleUIComponent(FlpMenuStatusBar, "#191919", "");
            Utils.StyleUIComponent(LblProgramTitle, "#191919", "#FFF");

            // Actualizar tema de la seccion de categoría
            if (categoria != null) categoria.updateTheme("dark");

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
            // VentanaHijo.FormBorderStyle = FormBorderStyle.None;
            VentanaHijo.Dock = DockStyle.Fill;
            PnlFormulariosHijosMenu.Controls.Add(VentanaHijo);
            PnlFormulariosHijosMenu.Tag = VentanaHijo;
            VentanaHijo.BringToFront();
            VentanaHijo.Show();
        }
        
    }
}
