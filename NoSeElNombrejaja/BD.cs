using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NoSeElNombrejaja
{

    public class BD
    {

        private SqlConnection conn;

        public BD()
        {
            string xd = "Data Source=DESKTOP-N4P3019\\SQLEXPRESS;Initial Catalog=ProyectoReMinder;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(xd);
            conn.Open();
        }

        //anuncios
        public void InsetarAnuncio(string Titulo, string Cuerpo)
        {
            string query = "INSERT INTO anuncios (Titulo, Cuerpo) VALUES (@titulo,@cuerpo);";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@titulo", Titulo);
            command.Parameters.AddWithValue("@cuerpo", Cuerpo);
            command.ExecuteNonQuery();
        }

        public List<Anuncio> DevolverAnunciosLista()
        {
            List<Anuncio> ListaLlena = new List<Anuncio>();
            string query = "SELECT * FROM anuncios ";
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);

            foreach (DataRow row in Lista.Rows)
            {
                Anuncio anuncio = new Anuncio(row["Titulo"].ToString(), row["cuerpo"].ToString());
                ListaLlena.Add(anuncio);
            }
            return ListaLlena;
        }

        //tareas
        public void InsetarTarea(string Titulo, string Cuerpo, DateTime Fecha, string Hora, int trabajador)
        {
            try
            {
                string query = "INSERT INTO Tareas (Titulo, Cuerpo, FechaAsignacion, HoraAsignacion, JefeAsignadorTarea, TrabajadorAsignadoTarea, Finalizada) VALUES (@titulo,@cuerpo,@FAsignacion,@HAsignacion,@Jefe,@trabajador,'No Completada');";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@titulo", Titulo);
                command.Parameters.AddWithValue("@cuerpo", Cuerpo);
                command.Parameters.AddWithValue("@FAsignacion", Fecha);
                command.Parameters.AddWithValue("@HAsignacion", Hora);
                command.Parameters.AddWithValue("@Jefe", Globals.Id);
                command.Parameters.AddWithValue("@trabajador", trabajador);
                command.ExecuteNonQuery();
            } catch (System.Data.SqlClient.SqlException holi)
            {
                MessageBox.Show("Error al subir el la tarea, revice que todos los detalles esten bien", "error");
            }
        }

        public List<TareaClase> DevolverTareasLista()
        {
            List<TareaClase> ListaLlena = new List<TareaClase>();
            string query = "SELECT * FROM Tareas ";
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);

            foreach (DataRow row in Lista.Rows)
            {
                TareaClase Tarea = new TareaClase(row["Titulo"].ToString(), row["cuerpo"].ToString(), int.Parse(row["TrabajadorAsignadoTarea"].ToString()));
                ListaLlena.Add(Tarea);
            }
            return ListaLlena;
        }

        public void EntregarTarea(string titulo)
        {

            string query = "UPDATE Tareas SET Finalizada = 'Finalizada' where Titulo = @titulo";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@titulo", titulo);
            command.ExecuteNonQuery();

            string Hora = DateTime.Now.ToString("HH:mm");
            string Fecha = DateTime.Now.ToString("dd/MM/yyyy");
           

            string query2 = "UPDATE Tareas SET FechaFinalizacion = @Fecha where Titulo = @titulo";
            SqlCommand command2 = new SqlCommand(query2, conn);
            command2.Parameters.AddWithValue("@titulo", titulo);
            command2.Parameters.AddWithValue("@Fecha", Fecha.ToString());
            command2.ExecuteNonQuery();

            string query3 = "UPDATE Tareas SET HoraFinalizacion = @Hora where Titulo = @titulo";
            SqlCommand command3 = new SqlCommand(query3, conn);
            command3.Parameters.AddWithValue("@titulo", titulo);
            command3.Parameters.AddWithValue("@Hora", Hora);
            command3.ExecuteNonQuery();
        }

        public string FinalizadoONo(string titulo)
        {
            string query = "SELECT * FROM Tareas WHERE Titulo = @titulo";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@titulo", titulo);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);

            string estadoTarea = "a";

            foreach (DataRow row in Lista.Rows)
            {
                estadoTarea = row["Finalizada"].ToString();

            }
            return estadoTarea;
        }

        public int ObtenerIdParaTarea(string nombre, string ApellidoP)
        {
            try
            {
                string query = "SELECT * FROM Usuarios WHERE Nombre = @nombre AND ApellidoP = @apellido";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", ApellidoP);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable Lista = new DataTable();
                adapter.Fill(Lista);

                int id = Lista.Rows[0].Field<int>(0);
                return id;
        } catch (System.IndexOutOfRangeException error)
            {
                MessageBox.Show("Nombre Invalido, por favor revice que haya sido escrito correctamente","Error al encontrar usuario",MessageBoxButton.OK,MessageBoxImage.Error);
                return 0;
            }
        }

        public String NombreAdminTarea(int id)
        {
            id = Globals.Id;
            string nombre = "pepe";
            string query = "SELECT * FROM Jefes WHERE Id = @id";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);

            foreach (DataRow row in Lista.Rows)
            {
                nombre = row["Nombre"].ToString() +" "+ row["ApellidoP"].ToString();

            }
            return nombre;
        }


        //autenticacion de usuarios
        public bool AutenticacionUsuario(string Usuario, string Clave)
        {

            string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario and Clave = @Clave";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Usuario", Usuario);
            command.Parameters.AddWithValue("@Clave", Clave);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);

            if (Lista.Rows.Count > 0)
            {
                Globals.Id = Lista.Rows[0].Field<int>(0);
                return true;
            }
            else
                return false;

        }

        //Autenticacion de Admins
        public bool AutenticacionAdmin(string Usuario, string Clave)
        {

            string query = "SELECT * FROM Jefes WHERE Usuario = @Usuario and Clave = @Clave";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@Usuario", Usuario);
            command.Parameters.AddWithValue("@Clave", Clave);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);

            if (Lista.Rows.Count > 0)
            {
                Globals.Id = Lista.Rows[0].Field<int>(0);
                return true;
            }
            else
                return false;

        }

        //trabajadores
        public DataTable TrabajadoresLC()
        {
            List<UsuarioClase> ListaLlena = new List<UsuarioClase>();
            string query = "SELECT * FROM Usuarios";
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);
            return Lista;

        }

        public DataTable TrabajadoresLNC()
        {
            List<UsuarioClase> ListaLlena = new List<UsuarioClase>();
            string query = "Select Nombre, ApellidoP, ApellidoM, Telefono from usuarios";
            SqlCommand command = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable Lista = new DataTable();
            adapter.Fill(Lista);
            return Lista;

        }

        public void AñadirUsuario(string nombre, string apellidoP, string apellidoM, string Usuario, string Clave, decimal salario, int telefono)
        {
            try
            {
                string query = "insert into Usuarios (Nombre,ApellidoP,ApellidoM,Usuario,Clave,Salario,Telefono,FechaContrato) values " +
                    "(@nombre,@apellidoP,@apellidoM,@usuario,@clave,@salario,@telefono,@fechaContrato)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellidoP", apellidoP);
                command.Parameters.AddWithValue("@apellidoM", apellidoM);
                command.Parameters.AddWithValue("@usuario", Usuario);
                command.Parameters.AddWithValue("@clave", Clave);
                command.Parameters.AddWithValue("@salario", salario);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@fechaContrato", DateTime.Now.ToString("dd/MM/yyyy"));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ta mal mijo, revisalo");
            }
        }
    }
}


       
