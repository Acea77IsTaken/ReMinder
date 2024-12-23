﻿using System;
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
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public event Action CambioVentanaAnuncio;
        public event Action CambioVentanaResumen;
        public event Action CambioVentanaTareas;
        public event Action CambioVentanaTrabajadores;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void ClickTareas(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaTareas?.Invoke();
        }

        private void ClickAnuncios(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaAnuncio?.Invoke();
        }

        private void ClickResumen(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaResumen?.Invoke();
        }

        private void ClickTrabajadores(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaTrabajadores?.Invoke();
        }
    }
}
