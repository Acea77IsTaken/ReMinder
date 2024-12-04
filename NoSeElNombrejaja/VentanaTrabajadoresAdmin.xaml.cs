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
    /// Lógica de interacción para VentanaTrabajadoresAdmin.xaml
    /// </summary>
    public partial class VentanaTrabajadoresAdmin : UserControl
    {
        BD bd = new BD();
        public VentanaTrabajadoresAdmin()
        {
            InitializeComponent();
            Lista.ItemsSource = bd.TrabajadoresLC().DefaultView;
        }

        private void BtnAñadirUsuario(object sender, MouseButtonEventArgs e)
        {
            agregarempleado agregarempleado = new agregarempleado();
            agregarempleado.actualizar += actualizarLista;
            agregarempleado.Show();
        }

        public void actualizarLista()
        {
            Lista.ItemsSource = null;
            Lista.ItemsSource = bd.TrabajadoresLC().DefaultView;
        }
    }
}
