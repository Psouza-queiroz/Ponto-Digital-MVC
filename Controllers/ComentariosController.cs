using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital_MVC.Models;
using Ponto_Digital_MVC.Repositorios;

namespace Ponto_Digital_MVC.Controllers {
    public class ComentariosController : Controller {
        private const string SESSION_EMAIL = "_EMAIL";

    [HttpGet]
    public IActionResult Index(){
        return View();
    }
        [HttpPost]
        public IActionResult Comentarios (IFormCollection form) {
            Comentarios comentarios = new Comentarios ();
            comentarios.Nome = form["nome"];
            comentarios.Comentario = form["comentario"];

            HttpContext.Session.GetString (SESSION_EMAIL);

            ComentariosRepositorio comentariosRepositorio = new ComentariosRepositorio ();
            comentariosRepositorio.Comentarios (comentarios);

            return RedirectToAction("Index","Home");
        }

    }
}