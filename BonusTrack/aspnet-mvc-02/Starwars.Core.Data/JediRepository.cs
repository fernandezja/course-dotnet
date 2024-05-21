using Starwars.Core.Configuration;
using Starwars.Core.Entities;

namespace Starwars.Core.Data
{
    public class JediRepository
    {
        private readonly Config _config;

        public JediRepository(Config config)
        {
            _config = config;
        }

        public List<Jedi> GetAllDummy() {
            var jedis = new List<Jedi>();

            for (int i = 0; i < 1000; i++)
            {
                jedis.Add(new Jedi()
                {
                    JediId = i,
                    Name = $"Jedi {i}",
                });
            }

            return jedis;
        }



        public JediResult GetAll()
        {

            var result = new JediResult();

            using (var db = new StarwarsContext(_config))
            {

                result.Items = db.Jedis.ToList();
            }

            return result;

        }

    }
}
