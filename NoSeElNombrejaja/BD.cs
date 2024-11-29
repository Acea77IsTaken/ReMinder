using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach(DataRow row in Lista.Rows)
            {
                Anuncio anuncio = new Anuncio(row["Titulo"].ToString(), row["cuerpo"].ToString());
                ListaLlena.Add(anuncio);
            }
            return ListaLlena;
        }

    }

}


       
