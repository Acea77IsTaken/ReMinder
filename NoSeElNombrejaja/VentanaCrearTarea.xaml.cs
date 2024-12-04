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
using System.Windows.Shapes;

namespace NoSeElNombrejaja
{
    /// <summary>
    /// Lógica de interacción para VentanaCrearTarea.xaml
    /// </summary>
    public partial class VentanaCrearTarea : Window
    {
        BD bd = new BD();
        public event Action Actualizar;
        public VentanaCrearTarea()
        {
            InitializeComponent();
        }


        private void BtnAsignarClick(object sender, MouseButtonEventArgs e)
        {
            string Hora;
            Hora = DateTime.Now.ToString("HH:mm");
            bd.InsetarTarea(TbxTitulo.Text, TbxDetalles.Text, DateTime.Now, Hora, bd.ObtenerIdParaTarea(TbxNombre.Text,TbxApellido.Text));
            Actualizar?.Invoke();
            this.Close();
        }

        private void CargarVentanaCrear(object sender, RoutedEventArgs e)
        {
            TbAdmin.Text = "Por " + bd.NombreAdminTarea(Globals.Id);
        }
    }
}
