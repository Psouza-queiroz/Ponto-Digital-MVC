using System;
using Microsoft.Extensions.Primitives;

namespace Ponto_Digital_MVC.Models {
    public class CadastroModels {
        
        public int Id {get;set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public ulong Telefone {get; set;}
        public DateTime DatadeNascimento { get; set; }
       
    public CadastroModels ( int Id, string nome, string email, string senha, ulong telefone, DateTime datadeNascimento ) {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Telefone = telefone;
            this.DatadeNascimento = datadeNascimento;

        }

        public CadastroModels(StringValues nome, StringValues email, StringValues senha, ulong telefone, DateTime datadeNascimento)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            DatadeNascimento = datadeNascimento;
        }
    }
}