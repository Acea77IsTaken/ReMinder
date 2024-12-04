using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Brush = System.Windows.Media.Brush;

namespace NoSeElNombrejaja
{
    public class TareaClase
    {

        public int id;
        public DateTime FechaDeAsignacion;
        public DateTime FechaDeFinalizacion;
        
        public string TituloTarea;
        public string DetallesTarea;
        public string Finalizada;
        public int JefeAsignador;
        public int UsuarioAsignado;

        public TareaClase( string tituloTarea, string detallesTarea, int usuarioAsignado)
        {
            TituloTarea = tituloTarea;
            DetallesTarea = detallesTarea;
            FechaDeAsignacion = DateTime.Now;
            JefeAsignador = Globals.Id;
            UsuarioAsignado = usuarioAsignado;

        }






    }
}
