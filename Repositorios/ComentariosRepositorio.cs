using System;
using System.Collections.Generic;
using System.IO;
using Ponto_Digital_MVC.Models;

namespace Ponto_Digital_MVC.Repositorios
{
    public class ComentariosRepositorio
    {

        private  const string PATH_COMENTARIO = "Database/Comentarios.csv";
        

        public void Comentarios (Comentarios comentarios){

                if (!File.Exists(PATH_COMENTARIO)){
                    comentarios.Id = File.ReadAllLines (PATH_COMENTARIO).Length + 1;
                }else{
                    comentarios.Id = 1;
                }
                StreamWriter sw = new StreamWriter(PATH_COMENTARIO, true);

                sw.WriteLine ($"{comentarios.Id};{comentarios.Nome};{comentarios.Comentario};{DateTime.Now}");
                sw.Close();
        }
       
        public List<Comentarios> listaDeComentario = new List<Comentarios>();
    }
}