using System;
using System.Text;

namespace Composicao2.Entities
{
    public class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {

        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionarComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentarios(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes + " Likes ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine(" ");

            sb.AppendLine("Comentários: ");
            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            sb.AppendLine(" ");

            return sb.ToString();
        }
    }
}