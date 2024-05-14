using Starwars.Core.Entities;

namespace Starwars.Core.DataEF
{
    public class JediRepository
    {

        public JediRepository()
        {
                
        }

        public JediResult GetAll() 
        {
            
            var result = new JediResult();

            using (var db = new StarwarsContext())
            {

                result.Items = db.Jedis.ToList();
            }

            return result;

        }
    }
}
