using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital_MVC.Models;

namespace Ponto_Digital_MVC.Repositorios {
    public class ComentariosRepositorio {

        private const string PATH_COMENTARIO = "Database/Comentarios.csv";

        public void Comentarios (Comentarios comentarios) {

            if (!File.Exists (PATH_COMENTARIO)) {
                comentarios.Id = File.ReadAllLines (PATH_COMENTARIO).Length + 1;
            } else {
                comentarios.Id = 1;
            }
            comentarios.Estado = 'e';
            StreamWriter sw = new StreamWriter (PATH_COMENTARIO, true);

            sw.WriteLine ($"{comentarios.Id};{comentarios.Nome};{comentarios.Comentario};{DateTime.Now};{comentarios.Estado}");
            sw.Close ();
        }

        public List<Comentarios> Listar () {
            List<Comentarios> listaDeComentario = new List<Comentarios> ();
            string[] linhas = File.ReadAllLines (PATH_COMENTARIO);

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    continue;
                }
                string[] dados = item.Split (";");
                Comentarios comentario = new Comentarios ();
                comentario.Id = int.Parse (dados[0]);
                comentario.Nome = dados[1];
                comentario.Comentario = dados[2];
                comentario.DataComentario = DateTime.Parse (dados[3]);
                comentario.Estado = char.Parse (dados[4]);

                listaDeComentario.Add (comentario);
            }
            return listaDeComentario;
        }

        public void AprovarComentario (int id) {
            string[] linhas = File.ReadAllLines (PATH_COMENTARIO);
            for (int i = 0; i < linhas.Length; i++) {
                string[] dados = linhas[i].Split (";");
                if (char.Parse (dados[4]) == 'e' && int.Parse (dados[0]) == id) {
                    linhas[i] = $"{dados[0]};{dados[1]};{dados[2]};{dados[3]};a";
                }
            }
            File.WriteAllLines (PATH_COMENTARIO, linhas);
        }

        public void ReprovarComentario (int id) {
            string[] linhas = File.ReadAllLines (PATH_COMENTARIO);
            for (int i = 0; i < linhas.Length; i++) {
                string[] dados = linhas[i].Split (";");
                if (char.Parse (dados[4]) == 'e' && int.Parse (dados[0]) == id) {
                    linhas[i] = $"{dados[0]};{dados[1]};{dados[2]};{dados[3]};r";
                }
            }
            File.WriteAllLines (PATH_COMENTARIO, linhas);
        }

    }
}