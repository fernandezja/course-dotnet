
using Starwars.Core.Data;
using Starwars.Core.Entities;

namespace Starwars.Core.Business
{
    public class JediBusiness
    {
        private Starwars.Core.Data.JediRepository _jediRepository;
        private Starwars.Core.DataEF.JediRepository _jediRepository2;

        public JediBusiness()
        {
            _jediRepository = new Starwars.Core.Data.JediRepository();
            _jediRepository2 = new Starwars.Core.DataEF.JediRepository();
        }

        public JediResult GetAll()
        {
            return GetAllv2();
        }

        public JediResult GetAllv1()
        {
            return _jediRepository.GetAll();
        }

        public JediResult GetAllv2()
        {
            return _jediRepository2.GetAll();
        }
    }
}
