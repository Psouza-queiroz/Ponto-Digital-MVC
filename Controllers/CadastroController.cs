using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto_Digital_MVC.Models;
using ProjetoFinal.MVC.Repositorios;

namespace Ponto_Digital_MVC.Controllers {

    public class CadastroController : Controller {

        [HttpGet]
        public IActionResult Index () {
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            // try{
            CadastroModels cadastro = new CadastroModels ();
                cadastro.Nome= form["nome"];
                cadastro.Email= form["email"];
                cadastro.Senha= form["senha"];
                cadastro.Telefone= form["telefone"];
                cadastro.DatadeNascimento= DateTime.Parse (form["data-nascimento"]);
            
            CadastroRepositorio cadastroRepositorio = new CadastroRepositorio ();
            cadastroRepositorio.Cadastrar (cadastro);
            // } catch (System.FormatException fe) {
            //     for(int i = 0; i <10; i++){
            //     System.Console.WriteLine ("das");
            //     }
            return RedirectToAction ("Index", "Home");
        }

      
    }
}
