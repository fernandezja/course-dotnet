using Starwars.Core.Entities;
using Microsoft.Data.SqlClient;
using System.Security;

namespace Starwars.Core.Data
{

    public class JediRepository
    {

        private readonly string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=StarwarsBorrar2;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

        private readonly string QUERY_DEMO = "SELECT \r\n\tJediId = C.column_id,\r\n\t[Name] = C.[Name]\r\nFROM sys.all_columns C\r\nWHERE \r\n\tC.name LIKE 'star%'";

        public JediRepository()
        {

        }

        public JediResult GetAll()
        {
            var result = new JediResult();
            result.Items = new List<Jedi>();

            //Obtener datos desde la DB


            //var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            //sqlConnectionStringBuilder.DataSource = "StarwarBorrar2"
                

            var cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = QUERY_DEMO;

            //Parametros..


            //PASO 1: Conexion

            try
            {

                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(CONNECTIONSTRING))
                {

                    cmd.Connection= conn; 

                    conn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //var jediId = (int)reader.GetValue(0);
                        var jediId = reader.GetInt32(0);
                        var name = reader.GetString(1);

                        result.Items.Add(new Jedi
                        {
                            JediId = jediId,
                            Name = name
                        });
                    }
                    //conn.Close(); using llama al dispose
                }

            }
            catch (SqlException ex)
            {
                //Log
                //Mensajes...
                var mensaje = ex.Message;
                result.HasError = true;
                result.Message = ex.Message;
             
            }
            catch (Exception ex)
            {
                //Log
                //Mensajes...
                var mensaje = ex.Message;
                result.HasError = true;
                result.Message = ex.Message;
            }


            return result;

        }
    }
}
