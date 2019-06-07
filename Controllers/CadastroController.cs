using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital_MVC.Models;
using ProjetoFinal.MVC.Repositorios;

namespace Ponto_Digital_MVC.Controllers {
    public class CadastroController : Controller {
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            try{
                CadastroModels cadastro = new CadastroModels (
                    nome: form["nome"],
                    email: form["email"],
                    senha: form["senha"],
                    telefone: ulong.Parse(form["telefone"]),
                    datadeNascimento: DateTime.Parse(form["data-nascimento"])
                );
                CadastroRepositorio cadastroRepositorio = new CadastroRepositorio ();
                cadastroRepositorio.Cadastrar (cadastro);
            } catch (System.FormatException fe) {
                System.Console.WriteLine (fe.StackTrace);
            }

            return RedirectToAction ("Index","Home");
        }
    }
}