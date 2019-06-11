using System;
using Microsoft.Extensions.Primitives;

namespace Ponto_Digital_MVC.Models {
    public class CadastroModels {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DatadeNascimento { get; set; }

        public CadastroModels (StringValues nome, StringValues email, StringValues senha, string telefone, DateTime datadeNascimento) {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            DatadeNascimento = datadeNascimento;
        }

        public CadastroModels () { }
    }
}