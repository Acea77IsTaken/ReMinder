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
using System.IO;

namespace NoSeElNombrejaja
{
    /// <summary>
    /// Lógica de interacción para VentanaCrearAnuncio.xaml
    /// </summary>
    public partial class VentanaCrearAnuncio : Window
    {
        BD tilin = new BD();
        public event Action actualizar;
        public VentanaCrearAnuncio()
        {
            InitializeComponent();
        }

        public void CrearAnuncio(string titulo, string cuerpo)
        {
            tilin.InsetarAnuncio(titulo, cuerpo);

        }

        private void BtnPublicarClick(object sender, MouseButtonEventArgs e)
        {
            CrearAnuncio(TbxTitulo.Text, TbxCuerpo.Text);
            actualizar?.Invoke();

            StreamWriter sw = new StreamWriter("AnunciosGuardados.txt", true);
            sw.WriteLine(TbxTitulo.Text);
            sw.WriteLine(TbxCuerpo.Text);
            sw.WriteLine();
            sw.Close();

            this.Close();

           
        }


    }
}
