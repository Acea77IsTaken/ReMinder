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
    /// Lógica de interacción para TareasUsuario.xaml
    /// </summary>
    public partial class TareasUsuario : UserControl
    {

        BD bd = new BD();
        List<TareaClase> Tareas = new List<TareaClase>();
        



        public TareasUsuario()
        {
            InitializeComponent();
            
        }


        public void MostrarTareas()
        {
            PanelTareas.Children.Clear();
            Tareas = bd.DevolverTareasLista();

            foreach (TareaClase tarea in Tareas)
            {
                
                if (Globals.Id == tarea.UsuarioAsignado)
                {
                    var bc = new BrushConverter();
                    tarea.Finalizada = bd.FinalizadoONo(tarea.TituloTarea);

                    Border BordeMiTarea = new Border();
                    StackPanel MiTarea = new StackPanel();
                    System.Windows.Controls.Image image = new System.Windows.Controls.Image();
                    Border Decorado = new Border();
                    Label Asignada = new Label();
                    Label Titulo = new Label();

                    BordeMiTarea.Height = 250;
                    BordeMiTarea.Margin = new Thickness(20, 20, 20, 20);
                    BordeMiTarea.Background = (Brush)bc.ConvertFrom("#FF231F20");
                    BordeMiTarea.MouseLeftButtonUp += BtnDetallesClick;
                    BordeMiTarea.Tag = tarea;

                    Titulo.FontFamily = new System.Windows.Media.FontFamily("Cambria");
                    Titulo.Foreground = (Brush)bc.ConvertFrom("#FFE2A02B");
                    Titulo.FontSize = 30;
                    Titulo.Margin = new Thickness(6, 3, 0, 0);
                    Titulo.Content = tarea.TituloTarea;
                    Titulo.FontWeight = FontWeights.Bold;
                    Titulo.HorizontalAlignment = HorizontalAlignment.Center;

                    image.Source = new BitmapImage(new Uri(@"ImagenesUsadas\Tareas.png", UriKind.Relative));
                    image.Height = 130;
                    image.Margin = new Thickness(0, 0, 0, 20);

                    Decorado.Background = (Brush)bc.ConvertFrom("#FFE2A02B");
                    Decorado.Height = 3;

                    Asignada.FontFamily = new System.Windows.Media.FontFamily("Cambria");
                    Asignada.Foreground = (Brush)bc.ConvertFrom("#FFE2A02B");
                    Asignada.FontSize = 30;
                    Asignada.Margin = new Thickness(6, 3, 0, 0);
                    Asignada.Content = "Asignada";
                    Asignada.FontWeight = FontWeights.Bold;
                    Asignada.HorizontalAlignment = HorizontalAlignment.Center;
                    Asignada.VerticalAlignment = VerticalAlignment.Center;

                    BordeMiTarea.Child = MiTarea;
                    MiTarea.Children.Add(Titulo);
                    MiTarea.Children.Add(image);
                    MiTarea.Children.Add(Decorado);
                    MiTarea.Children.Add(Asignada);



                    if (tarea.Finalizada == "Finalizada")
                    {
                        Titulo.Foreground = Brushes.Gray;
                        Decorado.Background = Brushes.Gray;
                        Asignada.Foreground = Brushes.Gray;
                        Asignada.Content = "Entregada";
                    }

                    PanelTareas.Children.Add(BordeMiTarea);

                }
            }

        }

        private void BtnDetallesClick(object sender, MouseButtonEventArgs e)
        {
            TareaClase tarea;
            Border border = sender as Border;
            tarea = (TareaClase)border.Tag;
            VentanaDetallesTarea Ventana = new VentanaDetallesTarea(tarea);
            Ventana.Show();
        }

        private void SeccionCargada(object sender, RoutedEventArgs e)
        {
            MostrarTareas();
        }


    }
}
