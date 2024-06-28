
using Starwars.Core.Data;
using Starwars.Core.Entities;
using Starwars.Core.Entities.Filters;

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
            return GetAllv1();
        }

        public JediResult GetAllv1()
        {
            return _jediRepository.GetAll();
        }

        public JediResult GetAllv2()
        {
            return _jediRepository2.GetAll();
        }


        public JediResult Search(JediFilter filter)
        {
            return _jediRepository2.SearchAsync(filter).GetAwaiter().GetResult();
        }

        public async Task<JediResult> SearchAsync(JediFilter filter)
        {
            return await _jediRepository2.SearchAsync(filter);
        }

        public GenericResult DeleteAsync(int jediId)
        {
            return _jediRepository2.DeleteAsync(jediId);
        }

        public Jedi GetAsync(int jediId)
        {
            return _jediRepository2.GetAsync(jediId);
        }

        public GenericResult UpdateAsync(Jedi jedi)
        {
            return _jediRepository2.UpdateAsync(jedi);
        }

    }
}
