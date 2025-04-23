
using Starwars.Core.Data;
using Starwars.Core.Entities;

namespace Starwars.Core.Business
{
    public class JediBusiness
    {
        public List<Jedi> GetAll()
        {
            var jediRepository = new JediRepository();
            return jediRepository.GetAll();
        }
    }
}
