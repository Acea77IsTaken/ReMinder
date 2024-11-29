using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;

namespace NoSeElNombrejaja
{
    /// <summary>
    /// Lógica de interacción para Menu_inicioUserControl.xaml
    /// </summary>
    public partial class Menu_inicioUserControl : UserControl
    {
        public event EventHandler Hola;
        public Menu_inicioUserControl()
        {
            InitializeComponent();
            
        }

        private void InicioSesionClick(object sender, MouseButtonEventArgs e)
        {
            if (TBUsuario.Text == "a" && PBClave.Password == "a")
            {
                Globals.Logueado = true;
                Hola?.Invoke(this, EventArgs.Empty);
                
            } else if (TBUsuario.Text =="Admin123" &&  PBClave.Password =="Clave123")
            {
                Globals.Administrador = true;
                Globals.Logueado = true;
                Hola?.Invoke(this, EventArgs.Empty);
            }
            
        }

        
    }
}
