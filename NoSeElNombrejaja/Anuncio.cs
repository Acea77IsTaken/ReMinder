using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace NoSeElNombrejaja
{
    public class Anuncio
    {
        public string Titulo;
        public string Cuerpo;
        public StackPanel MiAnuncio;
        public Border BordeAnuncio;
        public TextBlock TituloAnuncio;
        public TextBlock DescripcionAnuncio;

        public Anuncio(string titulo, string cuerpo)
        {
            Titulo = titulo;
            Cuerpo = cuerpo;
        }
    }
}
