using Starwars.Core.Entities;
using Microsoft.Data.SqlClient;
using System.Security;
using Starwars.Core.Entities.Filters;

namespace Starwars.Core.Data
{

    public class JediRepository
    {

        private readonly string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=Starwars;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

        //private readonly string QUERY_DEMO = "SELECT \r\n\tJediId = C.column_id,\r\n\t[Name] = C.[Name]\r\nFROM sys.all_columns C\r\nWHERE \r\n\tC.name LIKE 'star%'";
        private readonly string QUERY_JEDI_SELECT = "SELECT JediId,Name,Birthday FROM dbo.Jedi";

        public JediRepository()
        {

        }

        public JediResult GetAll()
        {
            var result = new JediResult();

            result.Items = new List<Jedi>();

            //Obtener datos desde la DB
            //var conn2 = new SqlConnection(CONNECTIONSTRING)

            //var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            //sqlConnectionStringBuilder.DataSource = "StarwarBorrar2"
                

            var cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = QUERY_JEDI_SELECT;


            //Parametros..
            //cmd.Parameters

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

                        //var firstName = reader.GetString(1);
                        var firstName = reader.GetString(reader.GetOrdinal("Name"));

                        var birthday = reader.GetDateTime(2);

                        result.Items.Add(new Jedi
                        {
                            JediId = jediId,
                            Name = firstName
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
            finally
            {
                //conn.Close();
            }



            return result;

        }


        public async Task<JediResult> SearchAsync(JediFilter filter)
        {
            var result = new JediResult();
            result.Items = new List<Jedi>();

            //Obtener datos desde la DB


            //var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            //sqlConnectionStringBuilder.DataSource = "StarwarBorrar2"


            var cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.JediSearch";

            //Parametros..
            cmd.Parameters.Add(new SqlParameter("@TextToSearch", filter.TextToSearch));
            cmd.Parameters.Add(new SqlParameter("@PageIndex", filter.PageIndex));
            cmd.Parameters.Add(new SqlParameter("@PageSize", filter.PageSize));


            //PASO 1: Conexion

            try
            {

                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(CONNECTIONSTRING))
                {

                    cmd.Connection = conn;

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
