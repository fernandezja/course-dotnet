using Starwars.Core.Entities;
using Microsoft.Data.SqlClient;

namespace Starwars.Core.Data
{
    public class EmpleadoRepository
    {
        private readonly string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=StarwarsBorrar;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

        public EmpleadoRepository() { 
        
        }

        public List<Empleado> ObtenerTodos() 
        {
            var empleados = new List<Empleado>();
            
            var cmd = new SqlCommand();
            //cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT Id, NombreCompleto FROM dbo.Empleados";

            //cmd.Parameters.Add

            using (var conn = new SqlConnection(CONNECTIONSTRING))
            {
                cmd.Connection = conn;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    var empleado = new Empleado();

                    //empleado.Id = (int)reader[0];
                    empleado.Id = reader.GetInt32(0);
                    empleado.NombreCompleto = reader.GetString(1);
                    empleado.DNI = reader.GetString(2);

                    empleados.Add(empleado);
                }

                //accion...

            }//conn.Close();


            return empleados;




        }

    }
}
