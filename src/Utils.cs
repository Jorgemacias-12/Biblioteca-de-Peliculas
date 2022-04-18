using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Peliculas.src
{
    internal class Utils
    {
        public Color getColor(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
    }
}
