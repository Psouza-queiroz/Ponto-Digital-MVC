using Microsoft.AspNetCore.Mvc;
using Ponto_Digital_MVC.Repositorios;
using ProjetoFinal.MVC.Repositorios;

namespace Ponto_Digital_MVC.Controllers {
    public class AdminController : Controller {

        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio ();
        ComentariosRepositorio comentarioRepositorio = new ComentariosRepositorio ();

        public IActionResult Index () {
            return View ();
        }
        public IActionResult ListarUsuarios () {
            var lista = cadastroRepositorio.Listar ();
            ViewData["cadastros"] = lista;
            return View ();
        }

        public IActionResult ListarComentarios () {
            var lista = comentarioRepositorio.Listar ();
            ViewData["comentarios"] = lista;
            return View ();
        }

        public IActionResult AprovarComentario(int id){
            comentarioRepositorio.AprovarComentario(id);
            return RedirectToAction("ListarComentarios");
        }
         public IActionResult ReprovarComentario(int id){
            comentarioRepositorio.ReprovarComentario(id);
            return RedirectToAction("ListarComentarios");
        }
    }
}