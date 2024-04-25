using Starwars.Core.Entities;

namespace Starwars.Core.Business
{
    public class JedisBusiness
    {
        public List<Jedi> GetAll() {

            var jedis = new List<Jedi>();

            for (int i = 1; i <= 100; i++)
            {
                jedis.Add(new Jedi() { 
                    Name = $"Jedi {i.ToString()}"
                });
            }

            return jedis;
        }
    }
}
