using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Peliculas.src.Reproductor;

namespace Biblioteca_de_Peliculas.src.Categoria
{
    public partial class DlgCategoria : Form
    {

        // Variables globales
        string category;
        string actualTheme;
        int movieQuantity = 20;
        DlgReproductor reproductor;

        // Template para categorias
        public DlgCategoria(string categoryName, string theme)
        {
            InitializeComponent();
            InitTheme(theme);
            // Asignar la propiedad de la categoría de pelicula(s)
            category = categoryName;
            actualTheme = theme;
        }

        // Inicializa, y carga datos hacía los componentes
        public void InitTheme(string theme)
        {
            switch (theme) 
            {
                case "light":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("#E0E0E0");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#000");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#E0E0E0");

                    break;

                case "dark":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("#353535");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#FFF");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#353535");

                    break;
            }
        }

        // Actualiza el formulario con el tema seleccionado
        public void UpdateTheme(string theme)
        {
            switch (theme)
            {
                case "light":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("#E0E0E0");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#000");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#E0E0E0");

                    break;

                case "dark":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("#353535");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#FFF");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#353535");

                    break;
            }
        }

        // Cerrar el componente  
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void GoToMovie(object sender, EventArgs e)
        {
            reproductor = new DlgReproductor(actualTheme);
            PictureBox movieViewRef = (PictureBox)sender;
            int Index = 0;
            string name = movieViewRef.Name;

            // Obtener nombre del componente, y reemplazar texto por nada
            // obteniendo así el número de componente, pero debemos restarle
            // uno, para obtener su índice.
            Index = Int32.Parse(Regex.Replace(name, @"(?!\d)([A-z]|\s)", "")) - 1;

            reproductor.Show();
        }

        // Inicializar componentes, y cargar caratulas, si categoría esta vaciá carga placeholder
        private void DlgCategoria_Load(object sender, EventArgs e)
        {

            // Cargar caratulas de películas dependiendo de la categoría

            switch(category)
            {
                case "inicio":
                    break;

                case "accion":
                    break;

                case "animadas":
                    break;

                case "comedias":
                    break;

                case "terror":
                    break;

                default:
                    Utils.GenerateMoviePreview(movieQuantity, FlpMoviesContainer, GoToMovie, true, category);
                    break;

            }
        }
    }
}
