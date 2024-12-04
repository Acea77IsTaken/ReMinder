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
        TareasAdmin TareasAdmin = new TareasAdmin();
        TareasUsuario tareasUsuario = new TareasUsuario();
        VentanaTrabajadores trabajadores = new VentanaTrabajadores();
        VentanaTrabajadoresAdmin trabajadoresAdmin = new VentanaTrabajadoresAdmin();
        

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
                UsuarioInicio.CambioVentanaTareas += CambioVentanaTareas;
                UsuarioInicio.CambioVentanaTrabajadores += CambioVentanaTrabajadores;
            }
            else
            {
                UserControl1 UsuarioInicio = new UserControl1();
                AreaContenido.Content = UsuarioInicio;
                UsuarioInicio.CambioVentanaAnuncio += CambioVentanaAnuncios;
                UsuarioInicio.CambioVentanaTareas += CambioVentanaTareas;
                UsuarioInicio.CambioVentanaTrabajadores += CambioVentanaTrabajadores;
            }
        }

        public void CambioVentanaAnuncios()
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

        private void BtnIcono(object sender, MouseButtonEventArgs e)
        {
            UserControl1 UsuarioInicio = new UserControl1();
            AreaContenido.Content = UsuarioInicio;
            UsuarioInicio.CambioVentanaAnuncio += CambioVentanaAnuncios;
            UsuarioInicio.CambioVentanaTareas += CambioVentanaTareas;

        }

        private void ClickBtnAnuncios(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaAnuncios();
        }

        private void ClickBtnTareas(object sender, MouseButtonEventArgs e)
        {
            if (Globals.Logueado && !Globals.Administrador)
            {
                AreaContenido.Content = tareasUsuario;
                
            }
            else if (Globals.Logueado && Globals.Administrador)
            {
                AreaContenido.Content = TareasAdmin;
                ;
            }
        }

        private void BtnSoporteClick(object sender, MouseButtonEventArgs e)
        {
            
            if (Globals.Logueado && !Globals.Administrador)
            {
                System.Diagnostics.Process.Start("http://kathleen.free.nf/reminder/index.html?i=1");
            }
            else if (Globals.Logueado && Globals.Administrador)
            {
                System.Diagnostics.Process.Start("http://kathleen.free.nf/reminder/index.html?i=1");
            }
        }

        public void CambioVentanaTareas()
        {
            if (Globals.Logueado && !Globals.Administrador)
            {
                AreaContenido.Content = tareasUsuario;
                
            }
            else if (Globals.Logueado && Globals.Administrador)
            {
                AreaContenido.Content = TareasAdmin;
                
            }
        }

        public void CambioVentanaTrabajadores()
        {
            if (Globals.Logueado && !Globals.Administrador)
            {
                AreaContenido.Content = trabajadores;

            }
            else if (Globals.Logueado && Globals.Administrador)
            {
                AreaContenido.Content = trabajadoresAdmin;

            }
        }

        private void BtnClickTrabajadores(object sender, MouseButtonEventArgs e)
        {
            CambioVentanaTrabajadores();
        }
    }
}
