using Starwars.Core.Entidades;

namespace Starwars.Core.Datos
{
    public class UsuarioRepository  
    {
        public List<Usuario> ListarSimple()
        {
            var usuarios = new List<Usuario>();

            for (int i = 0; i < 10; i++)
            {
                usuarios.Add(new Usuario
                {
                    UsuarioId = i,
                    Nombre = $"Nombre {i}",
                    Apellido = $"Apellido {i}",
                    FechaNacimiento = new DateTime(2000, 1, 1)
                });
            }
            return usuarios;
        }


        public List<Usuario> ListarDB()
        {
            const string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=Starwars;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
            var usuarios = new List<Usuario>();

            //Conexion
            var conexion = new Microsoft.Data.SqlClient.SqlConnection(CONNECTIONSTRING);

            //Comando
            var comando = new Microsoft.Data.SqlClient.SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "SELECT UsuarioId, Nombre, Apellido, FechaNacimiento FROM dbo.Usuario";
            comando.CommandType = System.Data.CommandType.Text;
            

            conexion.Open();

            //DataReader
            var reader = comando.ExecuteReader();

            while (reader.Read())
            {
                var usuario = new Usuario
                {
                    UsuarioId = reader.GetInt32(0),
                    //Nombre = reader.GetString(1),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                    Apellido = reader.GetString(2)
                    //FechaNacimiento = reader.GetDateTime(3)
                };
                usuarios.Add(usuario);
            }



            return usuarios;
        }
    }
}
