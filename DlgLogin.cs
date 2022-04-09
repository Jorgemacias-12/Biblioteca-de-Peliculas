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
    public partial class DlgLogin : Form
    {
        //╔═══════════╗
        //║ Variables ║
        //╚═══════════╝
        string Usuario = "";
        string Contraseña = "";
        DlgMenu dlgmenu = new DlgMenu();

        public DlgLogin()
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
        private void DlgLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //╔════════════════╗
        //║ Cerrar ventana ║
        //╚════════════════╝
        private void PtbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //╔═══════════════════╗
        //║ Minimizar ventana ║
        //╚═══════════════════╝
        private void PtbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //╔══════════════════════════════════╗
        //║ Inicialización de cajas de texto ║
        //╚══════════════════════════════════╝
        private void DlgLogin_Load(object sender, EventArgs e)
        {
            TxtUsuario.Text = "USUARIO";
            TxtUsuario.ForeColor = Color.DimGray;
            TxtContraseña.Text = "CONTRASEÑA";
            TxtContraseña.ForeColor = Color.DimGray;
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al entrar a la caja de texto se borra su predefinido ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            Usuario = TxtUsuario.Text;
            if (Usuario.Equals("USUARIO"))
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al entrar a la caja de texto se borra su predefinido ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            Contraseña = TxtContraseña.Text;
            if (Contraseña.Equals("CONTRASEÑA"))
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al dejar la caja de texto se hace hacen validaciones ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            Usuario = TxtUsuario.Text;
            if (Usuario.Equals("USUARIO"))
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = Color.DimGray;
            }
            else
            {
                if (Usuario.Equals(""))
                {
                    TxtUsuario.Text = "USUARIO";
                    TxtUsuario.ForeColor = Color.DimGray;
                }
                else
                {
                    TxtUsuario.Text = Usuario;
                    TxtUsuario.ForeColor = Color.Black;
                }
            }
        }

        //╔══════════════════════════════════════════════════════╗
        //║ Al dejar la caja de texto se hace hacen validaciones ║
        //╚══════════════════════════════════════════════════════╝
        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            Contraseña = TxtContraseña.Text;
            if (Contraseña.Equals("CONTRASEÑA"))
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.ForeColor = Color.DimGray;
                TxtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                if (Contraseña.Equals(""))
                {
                    TxtContraseña.Text = "CONTRASEÑA";
                    TxtContraseña.ForeColor = Color.DimGray;
                    TxtContraseña.UseSystemPasswordChar = false;
                }
                else
                {
                    TxtContraseña.Text = Contraseña;
                    TxtContraseña.ForeColor = Color.Black;
                }
            }
        }

        //╔════════════════════════════════════════════════╗
        //║ Validar solo texto en la caja de texto Usuario ║
        //╚════════════════════════════════════════════════╝
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("El nombre solo debe contener letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //╔═══════════════════════════════════════════╗
        //║ Muestra la contraseña de la caja de texto ║
        //╚═══════════════════════════════════════════╝
        private void CkbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            TxtContraseña.UseSystemPasswordChar = !CkbMostrarContraseña.Checked;
        }

        //╔════════════════════════════════════════════════════════════╗
        //║ Función para mandar un mensaje si la contraseña es erronea ║
        //╚════════════════════════════════════════════════════════════╝
        private void ContraseñaIncorrecta()
        {
            MessageBox.Show("Contraseña incorrecta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //╔═══════════════════════════════════════════════╗
        //║ Sí el perfil existe se despliega otra ventana ║
        //╚═══════════════════════════════════════════════╝
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Usuario = TxtUsuario.Text;
            string UsuarioFinal = Usuario.ToLower();
            Contraseña = TxtContraseña.Text;

            switch (UsuarioFinal)
            {
                case "aaron":
                    if (Contraseña == "110803")
                    {
                        dlgmenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        ContraseñaIncorrecta();
                    }
                    break;

                default:
                    MessageBox.Show("Usuario y/o Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

    }
}
