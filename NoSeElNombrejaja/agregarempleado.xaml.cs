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
    /// Lógica de interacción para agregarempleado.xaml
    /// </summary>
    public partial class agregarempleado : Window
    {
        public event Action actualizar;
        BD bd = new BD();
        public agregarempleado()
        {
            InitializeComponent();
        }

        private void BtnAgregarClick(object sender, MouseButtonEventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            decimal salario = decimal.Parse(txtSalario.Text);
            int telefono = int.Parse(txtTelefono.Text);

            bd.AñadirUsuario(nombre, apellidoPaterno, apellidoMaterno, usuario, clave, salario, telefono);
            actualizar?.Invoke();
            this.Close();
        }
    }
}
