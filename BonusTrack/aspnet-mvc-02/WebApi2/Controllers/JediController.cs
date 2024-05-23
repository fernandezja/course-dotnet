using Microsoft.AspNetCore.Mvc;
using Starwars.Core.Business;
using Starwars.Core.Entities;

namespace WebApi2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JediController : ControllerBase
    {
        private readonly ILogger<JediController> _logger;
        private readonly JediBusiness _jediBusiness;

        public JediController(JediBusiness jediBusiness,
                              ILogger<JediController> logger)
        {
            _logger = logger;
            _jediBusiness = jediBusiness;
        }


        [HttpGet(Name = "GetJedis")]
        public IEnumerable<Jedi> Get()
        {
            var jedis = _jediBusiness.GetAll();

            return jedis.Items;

        }

        [HttpGet("{jediId:int}")]
        public Jedi GetDetail(int jediId)
        {
            var jedis = _jediBusiness.GetAll();

            //var jedi = _jediBusiness.GetById(jediId);

            var jedi = (from j in jedis.Items
                        where j.JediId == jediId
                        select j).FirstOrDefault();

            return jedi;

        }



        [HttpGet("{jediId:int}/demo")]
        public object GetDetailDemo(int jediId)
        {
            var jedis = _jediBusiness.GetAll();

            //var jedi = _jediBusiness.GetById(jediId);

            var jedi = (from j in jedis.Items
                        where j.JediId == jediId
                        select j).FirstOrDefault();

            var jediDummy = new
            {
                Name = jedi.Name
            };

            return jediDummy;

        }
    }
}
