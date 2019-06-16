using System;

namespace Ponto_Digital_MVC.Models {
    public class Comentarios {
        public Comentarios (int id, string nome, string comentario, DateTime dataComentario) {
            this.Id = id;
            this.Nome = nome;
            this.Comentario = comentario;
            this.DataComentario = dataComentario;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Comentario { get; set; }
        public DateTime DataComentario { get; set; }
        public char Estado { get; set; }

        public Comentarios (string nome, string comentario) {
            Nome = nome;
            Comentario = comentario;
        }

        public Comentarios () { }
    }
}