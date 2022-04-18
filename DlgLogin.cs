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
using System.Resources;

namespace Biblioteca_de_Peliculas
{
    public partial class DlgLogin : Form
    {
        //  ╔════════════════════╗
        //  ║ Variables globales ║
        //  ╚════════════════════╝
        string Usuario = "";
        string Contraseña = "";
        bool showingPassword = false;
        DlgMenu dlgmenu = new DlgMenu();

        public DlgLogin()
        {
            InitializeComponent();
        }

        //  ╔═════════════════════════════════╗
        //  ║ Mover la posición de la ventana ║
        //  ╚═════════════════════════════════╝
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")] // Importar user32.dll,y un punto de entrada
        private extern static void ReleaseCapure(); // Definición del método  para capturar cuando se suelta la ventana
        [DllImport("user32.dll", EntryPoint = "SendMessage")] // "", y como punto de entrada SendMessage
        // Definición del método para enviar un mensaje  (referente al puntero del ratón(? no tengo ni idea)
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        //  ╔═══════════════════════════════════════╗
        //  ║ Evento - Mover posición de la ventana ║ - implementar en varias localizaciones para evitar que el usuario no pueda mover el form
        //  ╚═══════════════════════════════════════╝

        private void DlgLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            // Llama al método sendMessage enviando el manejador de la ventana, y algunas constantes numéricas
            // En resumen, visita los enlaces y trata de encontrar estos valores :u
            // Para entender mejor esta parte visita: https://docs.microsoft.com/es-mx/windows/win32/api/winuser/nf-winuser-sendmessage?redirectedfrom=MSDN
            // tipos de mensajes https://docs.microsoft.com/en-us/windows/win32/winmsg/about-messages-and-message-queues
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }
        private void LblTituloLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnlLoginStatusBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PtbIzquierdoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Aquí se encuentrán los eventos que permiten mover al formulario ^

        //╔═════════════════════════╗
        //║ Evento - Cerrar ventana ║
        //╚═════════════════════════╝
        private void PtbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DlgLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //  ╔════════════════════════════╗
        //  ║ Evento - Minimizar ventana ║
        //  ╚════════════════════════════╝
        private void PtbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //  ╔══════════════════════════════════╗
        //  ║ Inicialización de cajas de texto ║
        //  ╚══════════════════════════════════╝
        private void DlgLogin_Load(object sender, EventArgs e)
        {
            TxtUsuarioLogin.Text = "USUARIO";
            TxtContraseñaLogin.Text = "CONTRASEÑA";
        }

        //  ╔══════════════════════════════════════════════════════╗
        //  ║ Al entrar a la caja de texto se borra su predefinido ║
        //  ╚══════════════════════════════════════════════════════╝
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            Usuario = TxtUsuarioLogin.Text;
            if (Usuario.Equals("USUARIO"))
            {
                TxtUsuarioLogin.Text = "";
            }
        }

        //  ╔══════════════════════════════════════════════════════╗
        //  ║ Al entrar a la caja de texto se borra su predefinido ║
        //  ╚══════════════════════════════════════════════════════╝
        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            Contraseña = TxtContraseñaLogin.Text;
            if (Contraseña.Equals("CONTRASEÑA"))
            {
                TxtContraseñaLogin.Text = "";
            }
        }

        //  ╔══════════════════════════════════════════════════════╗
        //  ║ Al dejar la caja de texto se hace hacen validaciones ║
        //  ╚══════════════════════════════════════════════════════╝
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            Usuario = TxtUsuarioLogin.Text;
            if (Usuario.Equals("USUARIO"))
            {
                TxtUsuarioLogin.Text = "USUARIO";
            }
            else
            {
                if (Usuario.Equals(""))
                {
                    TxtUsuarioLogin.Text = "USUARIO";
                }
                else
                {
                    TxtUsuarioLogin.Text = Usuario;
                }
            }
        }

        //  ╔══════════════════════════════════════════════════════╗
        //  ║ Al dejar la caja de texto se hace hacen validaciones ║
        //  ╚══════════════════════════════════════════════════════╝
        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            Contraseña = TxtContraseñaLogin.Text;
            if (Contraseña.Equals("CONTRASEÑA"))
            {
                TxtContraseñaLogin.Text = "CONTRASEÑA";
            }
            else
            {
                if (Contraseña.Equals(""))
                {
                    TxtContraseñaLogin.Text = "CONTRASEÑA";
                }
                else
                {
                    TxtContraseñaLogin.Text = Contraseña;
                    TxtContraseñaLogin.ForeColor = Color.Black;
                }
            }
        }

        //  ╔════════════════════════════════════════════════╗
        //  ║ Validar solo texto en la caja de texto Usuario ║
        //  ╚════════════════════════════════════════════════╝
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || 
                (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("El nombre solo debe contener letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //  ╔════════════════════════════════════════════════════════════╗
        //  ║ Función para mandar un mensaje si la contraseña es erronea ║ sin utilizar
        //  ╚════════════════════════════════════════════════════════════╝
        private void ContraseñaIncorrecta()
        {
            MessageBox.Show("Contraseña incorrecta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //  ╔═══════════════════════════════════════════════╗
        //  ║ Sí el perfil existe se despliega otra ventana ║
        //  ╚═══════════════════════════════════════════════╝
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Usuario = TxtUsuarioLogin.Text;
            string UsuarioFinal = Usuario.ToLower();
            Contraseña = TxtContraseñaLogin.Text;

            //switch (UsuarioFinal)
            //{
            //    case "aaron":
            //        if (Contraseña == "110803")
            //        {
            //            dlgmenu.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            ContraseñaIncorrecta();
            //        }
            //        break;

            //    default:
            //        MessageBox.Show("Usuario y/o Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //}

            dlgmenu.Show();
            this.Hide();
        }
            
        //  ╔════════════════════════════════════════════════════╗
        //  ║ Muestra y oculta la contraseña de la caja de texto ║
        //  ╚════════════════════════════════════════════════════╝
        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            // Obtener imagenes de forma manual
            Image blindImg = global::Biblioteca_de_Peliculas.Properties.Resources.blind;
            Image eyeImg = global::Biblioteca_de_Peliculas.Properties.Resources.eye;

            // Negar el valor actual de la variable, por defecto en falso.
            showingPassword = !showingPassword;

            // Utilizando expresión ternaria en vez de    if      caso true                    caso falso
            BtnShowPassword.Image = showingPassword ? eyeImg : blindImg;

            // Mostrar o ocultar los caracteres de contraseña dependiendo de showingPassword
            TxtContraseñaLogin.UseSystemPasswordChar = showingPassword;
        }

    }
}
