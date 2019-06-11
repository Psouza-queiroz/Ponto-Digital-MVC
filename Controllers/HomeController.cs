using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.MVC.Repositorios;

namespace ProjetoFinal.MVC.Controllers
{

    public class HomeController : Controller
    {   
         private  const string SESSION_EMAIL = "_EMAIL";

        [HttpGet]
        public IActionResult Index()
        {
             ViewData["User"] = HttpContext.Session.GetString(SESSION_EMAIL);
            
            ViewData["NomeView"] = "Home";
            return View();
        }    
    }
}