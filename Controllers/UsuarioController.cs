using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital_MVC.Models;
using Ponto_Digital_MVC.Repositorios;
using ProjetoFinal.MVC.Repositorios;

namespace Ponto_Digital_MVC.Controllers {
    public class UsuarioController : Controller {
        // private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";

        // public static List<CadastroModels> listaDeUsuario = new List<CadastroModels> ();
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio ();
        [HttpGet]
        public IActionResult Login () {

            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            var email = form["email"];
            var senha = form["senha"];
            var listaDeUsuario = cadastroRepositorio.Listar ();

            foreach (var item in listaDeUsuario) {

                if (email.Equals (item.Email) && senha.Equals (item.Senha)) {
                    HttpContext.Session.SetString (SESSION_EMAIL, email);
                    // HttpContext.Session.SetString(SESSION_USUARIO, );
                    if (item.ehAdmin) {
                        return RedirectToAction ("Index", "Admin");
                    }
                    System.Console.WriteLine ("ta logado");
                    return RedirectToAction ("Index", "Home");
                }
            }
            return RedirectToAction ("Index", "Home");
        }
        public IActionResult Logout () {
            HttpContext.Session.Remove (SESSION_EMAIL);

            HttpContext.Session.Clear ();

            return RedirectToAction ("Index", "Home");
        }

    }
}