using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NoSeElNombrejaja
{
    
    /// <summary>
    /// Lógica de interacción para InicioUserControl.xaml
    /// </summary>
    public partial class InicioUserControl : UserControl
    {
        BD BD = new BD();
        List<Anuncio> anuncios = new List<Anuncio>();
        public InicioUserControl()
        {
            InitializeComponent();
            MostrarAnuncios();
            

        }
        public void MostrarAnuncios()
        {
            anuncios = BD.DevolverAnunciosLista();
            ListaAnuncios.Children.Clear();

            foreach (Anuncio AnoDeRodrigo in anuncios)
            {
                StackPanel MiAnuncio = new StackPanel();
                Border BordeAnuncio = new Border();
                TextBlock TituloAnuncio = new TextBlock();
                TextBlock DescripcionAnuncio = new TextBlock();
                Border BorderCumDown = new Border();

                var bc = new BrushConverter();
                BordeAnuncio.Background = (Brush)bc.ConvertFrom("#FF36281F");
                BordeAnuncio.Child = MiAnuncio;
                MiAnuncio.Children.Add(TituloAnuncio);
                MiAnuncio.Children.Add(DescripcionAnuncio);
                TituloAnuncio.Text = AnoDeRodrigo.Titulo;
                DescripcionAnuncio.Text = AnoDeRodrigo.Cuerpo;

                TituloAnuncio.FontFamily = new FontFamily("Cambria");
                TituloAnuncio.Foreground = Brushes.AntiqueWhite;
                TituloAnuncio.FontWeight = FontWeights.Bold;
                TituloAnuncio.FontSize = 30;
                TituloAnuncio.Margin = new Thickness(6, 3, 0, 0);

                DescripcionAnuncio.FontFamily = new FontFamily("Cambria");
                DescripcionAnuncio.Foreground = Brushes.AntiqueWhite;
                DescripcionAnuncio.FontSize = 15;
                DescripcionAnuncio.Margin = new Thickness(10, 2, 0, 0);

                BordeAnuncio.Height = 150;
                BordeAnuncio.Margin = new Thickness(20, 20, 20, 0);

                BorderCumDown.Height = 15;
                BorderCumDown.Background = (Brush)bc.ConvertFrom("#FF231F20");
                BorderCumDown.Margin = new Thickness(20, 0, 20, 0);

                ListaAnuncios.Children.Add(BordeAnuncio);
                ListaAnuncios.Children.Add(BorderCumDown);
            }

        }
    }
}
