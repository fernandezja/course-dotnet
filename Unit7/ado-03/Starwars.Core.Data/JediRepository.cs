using Microsoft.Data.SqlClient;
using Starwars.Core.Entities;

namespace Starwars.Core.Data
{
    public class JediRepository
    {
        public List<Jedi> GetAll()
        {

            var jedis = new List<Jedi>();

            //1 Connect to the database
            var conn = new SqlConnection("Data Source=.;Initial Catalog=Starwars;Integrated Security=True;TrustServerCertificate=True;");


            //2 Create the command
            var querySql = "SELECT J.JediId, J.Name FROM dbo.Jedi J WHERE(J.Name LIKE '%66%')";
            //var sqlCommand = new SqlCommand(querySql, conn);
            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = querySql;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            //sqlCommand.Parameters.AddWithValue("@JediId", 1);


            conn.Open();

            //3 Execute the command and get the data reader
            var reader = sqlCommand.ExecuteReader();

            while (reader.Read()) 
            { 
            
                //var name1 = reader["Name"].ToString();
                //var name2 = reader.GetValue(1);
                //var name3 = reader.GetString(1);
                //var name4 = reader.GetString(reader.GetOrdinal("Name"));

                var jediId = reader.GetInt32(reader.GetOrdinal("JediId"));
                var name = reader.GetString(reader.GetOrdinal("Name"));

                var jedi = new Jedi()
                {
                    JediId = jediId,
                    Name = name,
                };

                jedis.Add(jedi);
            }

            conn.Close();


            return jedis;
        }
    }
}
