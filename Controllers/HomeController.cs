using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.MVC.Controllers
{
    public class HomeController : Controller
    {   
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}