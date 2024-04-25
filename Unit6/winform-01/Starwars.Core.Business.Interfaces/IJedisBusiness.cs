using Starwars.Core.Entities;

namespace Starwars.Core.Business.Interfaces
{
    public interface IJedisBusiness
    {
        List<Jedi> GetAll();
    }
}
