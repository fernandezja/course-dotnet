
using Starwars.Core.Data;
using Starwars.Core.Entities;

namespace Starwars.Core.Business
{
    public class JediBusiness
    {
        private JediRepository _jediRepository;

        public JediBusiness()
        {
            _jediRepository = new JediRepository();
        }

        public JediResult GetAll()
        {
            return _jediRepository.GetAll();
        }
    }
}
