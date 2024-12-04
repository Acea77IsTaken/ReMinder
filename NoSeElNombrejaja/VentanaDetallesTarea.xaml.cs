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
    /// Lógica de interacción para VentanaDetallesTarea.xaml
    /// </summary>
    public partial class VentanaDetallesTarea : Window
    {
        TareaClase tarea;
        BD bd = new BD();
        public event Action Entregada;
        public VentanaDetallesTarea(TareaClase tarea)
        {
            InitializeComponent();
            this.tarea = tarea;
            CargarDetalles();
        }

        public void CargarDetalles()
        {
            TbTitulo.Text = tarea.TituloTarea;
            TbDetalles.Text = tarea.DetallesTarea;
            TbAdmin.Text = "Por " + bd.NombreAdminTarea(tarea.JefeAsignador);
        }

        private void BtnEntregar(object sender, MouseButtonEventArgs e)
        {
            bd.EntregarTarea(tarea.TituloTarea);
            Entregada?.Invoke();
            this.Close();
        }
    }
}
