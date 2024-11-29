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
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public event EventHandler CambioVentanaAnuncio;
        public event EventHandler CambioVentanaResumen;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void ClickTareas(object sender, MouseButtonEventArgs e)
        {

        }

        private void ClickAnuncios(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaAnuncio?.Invoke(this, e);
        }

        private void ClickResumen(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaResumen?.Invoke(this, e);
        }
    }
}
