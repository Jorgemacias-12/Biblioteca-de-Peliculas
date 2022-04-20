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

namespace Biblioteca_de_Peliculas.src.Categoria
{
    public partial class DlgCategoria : Form
    {

        // Variables globales
        string category;
        int movieQuantity = 500;

        // Template para categorias
        public DlgCategoria(string categoryName, string theme)
        {
            InitializeComponent();
            initTheme(theme);
            // Asignar la propiedad de la categoría de pelicula(s)
            category = categoryName;
        }

        #region Mover Ventana Padre

        #endregion

        // Inicializa, y carga datos hacía los componentes
        public void initTheme(string theme)
        {
            switch (theme) 
            {
                case "light":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("#FFFFFF");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#000");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#E0E0E0");

                    break;

                case "dark":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#FFF");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#353535");

                    break;
            }
        }

        // Actualiza el formulario con el tema seleccionado
        public void updateTheme(string theme)
        {
            switch (theme)
            {
                case "light":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("#FFFFFF");

                    // Cambiar color de letra del título de la categoría
                    LblCategory.ForeColor = Utils.GetColor("#000");

                    // Cambiar color de fondo del componente
                    FlpMoviesContainer.BackColor = Utils.GetColor("#E0E0E0");

                    break;

                case "dark":
                    // Manipular color de fondo del componente
                    FlpStatusBar.BackColor = Utils.GetColor("");

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

            PictureBox movieViewRef = (PictureBox) sender;
            int index = 0;
            string name = movieViewRef.Name;

            // Obtener nombre del componente, y reemplazar texto por nada
            // obteniendo así el número de componente, pero debemos restarle
            // uno, para obtener su índice.
            index = Int32.Parse(Regex.Replace(name, @"(?!\d)([A-z]|\s)", "")) - 1;

            // Only for debug mode
            MessageBox.Show($"Valor normal {index}");
        }

        // Inicializar componentes, y cargar caratulas, si categoría esta vaciá carga placeholder
        private async void DlgCategoria_Load(object sender, EventArgs e)
        {
            // Variables
            Stopwatch time = new Stopwatch();
            time.Start();

            // Cargar caratulas de películas dependiendo de la categoría

            switch(category)
            {

            }

            if (category.Equals(""))
            {

                for (int i = 0; i < movieQuantity; i++)
                {
                    // Inicializar componente
                    PictureBox view = new PictureBox();

                    // Propidades de componente
                    view.Size = new Size(150, 200);
                    view.Name = $"view {i+1}";
                    //view.Image = Utils.getDataFromRequest(i); // Obtener imagen
                    view.Image = await Utils.GetImageFromUrl(i + 1);
                    view.Margin = new Padding(10, 10, 10, 10);
                    view.Anchor = AnchorStyles.None;
                    view.Click += GoToMovie;
                    view.Update();

                    // Propiedades del contenedor
                    FlpMoviesContainer.Controls.Add(view);
                    FlpMoviesContainer.Update();
                }
            }
            time.Stop();
            MessageBox.Show($"Tiempo: {time.Elapsed.TotalSeconds}");
        }
    }
}
