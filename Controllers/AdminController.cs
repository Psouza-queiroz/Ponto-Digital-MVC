using Microsoft.AspNetCore.Mvc;

namespace Ponto_Digital_MVC.Controllers {
    public class AdminController : Controller {
        public IActionResult Index () {
            return View ();
        }
    }
}