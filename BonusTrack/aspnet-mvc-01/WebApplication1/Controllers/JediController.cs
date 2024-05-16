using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class JediController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var jedi = new Jedi { 
                JediId = id,
                Name = $"Jedi <br /> {id}"
            };

            return View("DetailsInternal", jedi);
        }
    }
}
