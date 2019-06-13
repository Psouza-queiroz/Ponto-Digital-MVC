using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital_MVC.Models;

namespace ProjetoFinal.MVC.Repositorios {
    public class CadastroRepositorio {
        private const string PATH = "Database/Cadastros.csv";

        public void Cadastrar (CadastroModels cadastro) {

            if (File.Exists (PATH)) {
                cadastro.Id = File.ReadAllLines (PATH).Length + 1;
            } else {
                cadastro.Id = 1;
            }
            StreamWriter sw = new StreamWriter (PATH, true);

            sw.WriteLine ($"{cadastro.Id};{cadastro.Nome};{cadastro.Email};{cadastro.Senha};{cadastro.Telefone};{cadastro.DatadeNascimento.ToShortDateString()};{cadastro.ehAdmin}");
            sw.Close ();
        }
        public List<CadastroModels> Listar () {
            List<CadastroModels> listadeCadastro = new List<CadastroModels> ();
            string[] linhas = File.ReadAllLines (PATH);

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    continue;
                }
                string[] dados = item.Split (";");
                CadastroModels cadastro = new CadastroModels ();
                cadastro.Id = int.Parse (dados[0]);
                cadastro.Nome = dados[1];
                cadastro.Email = dados[2];
                cadastro.Senha = dados[3];
                cadastro.Telefone = dados[4];
                cadastro.DatadeNascimento = DateTime.Parse (dados[5]);
                cadastro.ehAdmin = bool.Parse (dados[6]);

                listadeCadastro.Add (cadastro);
            }
            return listadeCadastro;

        }

    }
}