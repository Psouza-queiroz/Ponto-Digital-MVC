using System;
using System.IO;
using Ponto_Digital_MVC.Models;

namespace ProjetoFinal.MVC.Repositorios {
    public class CadastroRepositorio {
        private const string PATH = "Database/Cadastros.csv";

        public void Cadastrar (CadastroModels cadastro) {
            
            if (File.Exists  (PATH)) {
                cadastro.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                cadastro.Id = 1;
            }
            StreamWriter sw = new StreamWriter (PATH, true);

            sw.WriteLine ($"{cadastro.Id};{cadastro.Nome};{cadastro.Email};{cadastro.Senha};{cadastro.Telefone};{cadastro.DatadeNascimento.ToShortDateString()}");
            sw.Close ();

        }

    }
}