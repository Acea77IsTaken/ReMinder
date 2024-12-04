using System;
using System.Collections;
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
    /// Lógica de interacción para VentanaTrabajadores.xaml
    /// </summary>
    public partial class VentanaTrabajadores : UserControl
    {
        BD bd = new BD();
        public VentanaTrabajadores()
        {
            InitializeComponent();
            actualizarLista();
        }

        public void actualizarLista()
        {
            Lista.ItemsSource = null;
            Lista.ItemsSource = bd.TrabajadoresLNC().DefaultView;
        }

        private void Lista_Loaded(object sender, RoutedEventArgs e)
        {
            actualizarLista();
        }
    }
}
