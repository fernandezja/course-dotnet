using Starwars.Core.Configuration;
using Starwars.Core.Data;
using Starwars.Core.Entities;

namespace Starwars.Core.Business
{
    public class JediBusiness
    {

        private readonly JediRepository _jediRepository;

        public JediBusiness(JediRepository jediRepository)
        {
            _jediRepository = jediRepository;
        }

        public JediResult GetAll() {
            
            //var jediRepository = new JediRepository();

            return _jediRepository.GetAll();
        }
    }
}
