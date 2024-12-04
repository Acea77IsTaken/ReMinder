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
    
    public partial class Menu_inicioUserControl : UserControl
    {
        BD bd = new BD();
        public event EventHandler Hola;
        public Menu_inicioUserControl()
        {
            InitializeComponent();
            
        }

        private void InicioSesionClick(object sender, MouseButtonEventArgs e)
        {
            if (bd.AutenticacionUsuario(TBUsuario.Text,PBClave.Password))
            {
                Globals.Logueado = true;
                Hola?.Invoke(this, EventArgs.Empty);
                
                
            } else if (bd.AutenticacionAdmin(TBUsuario.Text, PBClave.Password))
            {
                Globals.Administrador = true;
                Globals.Logueado = true;
                Hola?.Invoke(this, EventArgs.Empty);
            }
            
        }

        
    }
}
