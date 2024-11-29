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
using System.Windows.Media.Animation;

namespace NoSeElNombrejaja
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Administrador = false;
        InicioUserControl AnunciosUsuario = new InicioUserControl();
        TablonAnunciosAdmin TablonAnunciosAdmin = new TablonAnunciosAdmin(); 
        

        public MainWindow()
        {
            InitializeComponent();

            Menu_inicioUserControl Ventanalogueo = new Menu_inicioUserControl();
            Ventanalogueo.Hola += hola;
            AreaContenido.Content = Ventanalogueo;
            

        }
        public void hola(object sender, EventArgs elpepe)
        {
            if (Globals.Administrador)
            {
                UserControl1 UsuarioInicio = new UserControl1();
                AreaContenido.Content = UsuarioInicio;
                UsuarioInicio.CambioVentanaAnuncio += CambioVentanaAnuncios;
                UsuarioInicio.CambioVentanaResumen += CambioVentanaResumen;
            }
            else
            {
                UserControl1 UsuarioInicio = new UserControl1();
                AreaContenido.Content = UsuarioInicio;
                UsuarioInicio.CambioVentanaAnuncio += CambioVentanaAnuncios;
            }
        }

        public void CambioVentanaAnuncios(object sender, EventArgs e)
        {
            if (Globals.Logueado && !Globals.Administrador)
            {
                AreaContenido.Content = AnunciosUsuario;
            }
            else if (Globals.Logueado && Globals.Administrador)
            {
                AreaContenido.Content = TablonAnunciosAdmin;
            }
        }
        
        public void CambioVentanaResumen(object sender, EventArgs e)
        {
            
        }
    }
}
