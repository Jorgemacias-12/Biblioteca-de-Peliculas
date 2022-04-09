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
        }

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

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void PtbCerrar_Click(object sender, EventArgs e)
        {
            DlgLogin dlgLogin = new DlgLogin();
            dlgLogin.Show();
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
