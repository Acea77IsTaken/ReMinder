﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para TareasAdmin.xaml
    /// </summary>
    public partial class TareasAdmin : UserControl
    {
        BD bd = new BD();
        List<TareaClase> Tareas = new List<TareaClase>();
        public TareasAdmin()
        {
            InitializeComponent();
            
            MostrarTareas();
        }


        public void MostrarTareas()
        {
            PanelTareas.Children.Clear();
            Tareas = bd.DevolverTareasLista();

            foreach (TareaClase tarea in Tareas)
            {
                var bc = new BrushConverter();
                Border BordeMiTarea = new Border();
                StackPanel MiTarea = new StackPanel();
                System.Windows.Controls.Image image = new System.Windows.Controls.Image();
                Border Decorado = new Border();
                Label Asignada = new Label();


                BordeMiTarea.Height = 250;
                BordeMiTarea.Width = 200;
                BordeMiTarea.Margin = new Thickness(20, 20, 20, 20);
                BordeMiTarea.Background = (Brush)bc.ConvertFrom("#FF231F20");
                BordeMiTarea.Tag = tarea;

                Uri uriimagen = new Uri(@"..\ImagenesUsadas\Tareas.png", UriKind.Relative);
                BitmapImage bitmap = new BitmapImage(uriimagen);
                image.Source = bitmap;
                image.Height = 180;
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
                MiTarea.Children.Add(image);
                MiTarea.Children.Add(Decorado);
                MiTarea.Children.Add(Asignada);

                PanelTareas.Children.Add(BordeMiTarea);
            }
        }

        private void BtnAsignarTareas(object sender, MouseButtonEventArgs e)
        {
            VentanaCrearTarea ventanaCrearTarea = new VentanaCrearTarea();
            ventanaCrearTarea.Actualizar += MostrarTareas;
            ventanaCrearTarea.Show();

        }
    }
}
