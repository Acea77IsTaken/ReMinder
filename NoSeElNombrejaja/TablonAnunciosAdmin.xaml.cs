using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para TablonAnunciosAdmin.xaml
    /// </summary>
    public partial class TablonAnunciosAdmin : UserControl
    {
        BD BD = new BD();
        List<Anuncio> anuncios = new List<Anuncio>();
        public TablonAnunciosAdmin()
        {
            InitializeComponent();
            
            MostrarAnuncios();
        }

        private void ClickCrearAnuncio(object sender, MouseButtonEventArgs e)
        {
            VentanaCrearAnuncio Ventana = new VentanaCrearAnuncio();
            Ventana.actualizar += MostrarAnuncios;
            Ventana.Show();
        }

        public void MostrarAnuncios()
        {
            anuncios = BD.DevolverAnunciosLista();
            ListaAnunciosAdmin.Children.Clear();
            
            foreach (Anuncio AnoDeRodrigo in anuncios)
            {
                
                StackPanel MiAnuncio = new StackPanel();
                Border BordeAnuncio = new Border();
                TextBlock TituloAnuncio = new TextBlock();
                TextBlock DescripcionAnuncio = new TextBlock();
                Border BorderCumDown = new Border();

                //StackPanel Botones = new StackPanel();
                //Border BorderBotonGuardar = new Border();
                //Label LabelBotonGuardar = new Label();
                
                var bc = new BrushConverter();
                BordeAnuncio.Background = (Brush)bc.ConvertFrom("#FF36281F");
                BordeAnuncio.Child = MiAnuncio;
                MiAnuncio.Children.Add(TituloAnuncio);
                MiAnuncio.Children.Add(DescripcionAnuncio);
                TituloAnuncio.Text = AnoDeRodrigo.Titulo;
                DescripcionAnuncio.Text = AnoDeRodrigo.Cuerpo;
                //Botones.Children.Add(BorderBotonGuardar);
                //BorderBotonGuardar.Child = LabelBotonGuardar;
                //MiAnuncio.Children.Add(Botones);

                TituloAnuncio.FontFamily = new FontFamily("Cambria");
                TituloAnuncio.Foreground = Brushes.AntiqueWhite;
                TituloAnuncio.FontWeight = FontWeights.Bold;
                TituloAnuncio.FontSize = 30;
                TituloAnuncio.Margin = new Thickness(6,3,0,0);

                DescripcionAnuncio.FontFamily = new FontFamily("Cambria");
                DescripcionAnuncio.Foreground = Brushes.AntiqueWhite;
                DescripcionAnuncio.FontSize = 15;
                DescripcionAnuncio.Margin = new Thickness(10,2,0,0);

                BordeAnuncio.Height = 150;
                BordeAnuncio.Margin = new Thickness(20,20,20,0);

                BorderCumDown.Height = 15;
                BorderCumDown.Background = (Brush)bc.ConvertFrom("#FF231F20");
                BorderCumDown.Margin = new Thickness(20, 0, 20, 0);

                //Botones.Orientation = Orientation.Horizontal;
                //Botones.HorizontalAlignment = HorizontalAlignment.Right;

                //BorderBotonGuardar.HorizontalAlignment = HorizontalAlignment.Center;
                //BorderBotonGuardar.VerticalAlignment = VerticalAlignment.Center;
                //BorderBotonGuardar.Background = (Brush)bc.ConvertFrom("#FF36281F");
                //BorderBotonGuardar.BorderBrush = (Brush)bc.ConvertFrom("#FF231F20");
                //BorderBotonGuardar.BorderThickness = new Thickness(3, 3, 3, 3); 
                //BorderBotonGuardar.Margin = new Thickness(15, 15, 15, 15);
                

                //LabelBotonGuardar.FontFamily = new FontFamily("Cambria");
                //LabelBotonGuardar.Foreground = Brushes.AntiqueWhite;
                //LabelBotonGuardar.FontWeight = FontWeights.Bold;
                //LabelBotonGuardar.FontSize = 15;
                //LabelBotonGuardar.Content = "Guardar";

                ListaAnunciosAdmin.Children.Add(BordeAnuncio);
                ListaAnunciosAdmin.Children.Add(BorderCumDown);

                
            }
            
        }

        
    }
}
