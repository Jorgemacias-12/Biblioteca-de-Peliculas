using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_de_Peliculas.src.Categoria
{
    public partial class DlgCategoria : Form
    {

        // Template para categorias
        
        public DlgCategoria(string categoryName, string theme)
        {
            InitializeComponent();
            initCategory(categoryName, theme);
        }

        // Inicializa, y carga datos hacía los componentes
        private void initCategory(string categoryName, string theme)
        {

            if (categoryName.Equals(""))
            {
                LblCategory.Text = "Fallo al inicializar texto";
            }

            // Establecer el texto
            LblCategory.Text = categoryName;

            // Cargar tema ui dependiendo del tema

        }

        // Cerrar el componente  
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
