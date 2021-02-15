using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder1.Entities
{
    class Post
    {

        public DateTime Momento { get; set; }
        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public int Likes { get; set; }

        public List<Comentarios> Comentarios { get; set; } = new List<Comentarios>();

        public Post() { }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }


        // métodos
        public void AddComentarios(Comentarios comentario) {

            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentarios comentario) {

            Comentarios.Remove(comentario);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários");
            foreach (Comentarios item in Comentarios)
            {
                sb.AppendLine(item.Texto);
            }
            return sb.ToString();

        }
    }
}
