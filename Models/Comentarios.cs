namespace Ponto_Digital_MVC.Models {
    public class Comentarios {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Comentario { get; set; }

        public Comentarios (string nome, string comentario) {
            Nome = nome;
            Comentario = comentario;
        }

        public Comentarios () { }
    }
}