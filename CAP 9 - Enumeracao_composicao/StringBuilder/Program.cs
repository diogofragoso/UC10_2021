using System;
using StringBuilder1.Entities;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Comentarios c1 = new Comentarios("tenha uma boa viagem");
            Comentarios c2 = new Comentarios("Isso é muito legal");

            Post p1 = new Post(DateTime.Parse("14/02/2021 18:34"), "Viagem para NY"," Viajarei esta semana",  20 );
            p1.AddComentarios(c1);
            p1.AddComentarios(c2);


            Comentarios c3 = new Comentarios("Bora churras");
            Comentarios c4 = new Comentarios("Demorou é nois");

            Post p2 = new Post(DateTime.Parse("14/02/2021 18:38"), "Festa", " Churrasco", 20);
            p2.AddComentarios(c3);
            p2.AddComentarios(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}
