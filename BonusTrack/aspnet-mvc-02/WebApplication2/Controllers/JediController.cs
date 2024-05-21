using Microsoft.AspNetCore.Mvc;
using Starwars.Core.Business;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class JediController : Controller
    {
        private readonly ILogger<JediController> _logger;
        private readonly JediBusiness _jediBusiness;

        public JediController(JediBusiness jediBusiness,
                              ILogger<JediController> logger)
        {
            _logger = logger;
            _jediBusiness = jediBusiness;

            //TODO: DI
            //_jediBusiness = new JediBusiness();
        }   

        public IActionResult Index()
        {
            var jedis = _jediBusiness.GetAll();

            var model = new JediListViewModel()
            {
                Result = jedis,
                Title = $"Jedis count = {jedis.Items.Count}" 
            };

            //ViewBag

            return View(model);
        }


        //[Route("/details-internal")]
        //[Route("/details")]
        public IActionResult Details()
        {
            return View("DetailsInternal");
        }


    }
}
