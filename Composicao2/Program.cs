using System;
using Composicao2.Entities;

namespace Composicao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Comentario c1 = new Comentario("Tenha uma boa viagem!");
            Comentario c2 = new Comentario("Uau, incrível.");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para a Nova Zelândia",
                "Vou visitar esse país maravilhoso",
                12
            );
            p1.AdicionarComentario(c1);
            p1.AdicionarComentario(c2);

            Comentario c3 = new Comentario("Boa noite.");
            Comentario c4 = new Comentario("Que a força esteja com você.");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa noite pessoal.",
                "Até amanhã",
                5
            );
            p2.AdicionarComentario(c3);
            p2.AdicionarComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}