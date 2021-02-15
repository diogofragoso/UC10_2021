using System;

namespace Operacoes_Times_Span_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TimeSpan t1 = TimeSpan.MaxValue; // Valor máximo de um TimeSpan
            TimeSpan t2 = TimeSpan.MinValue; // Valor mínimo
            TimeSpan t3 = TimeSpan.Zero;
            TimeSpan t4 = new TimeSpan(2, 12, 40, 20);
            System.Console.WriteLine(t4);

            System.Console.WriteLine(t4.Days); // obter a quantidade de dias
            System.Console.WriteLine(t4.Hours); // obter as horas do timeSpan
            System.Console.WriteLine(t4.Minutes); // obter os minutos do timeSpan

            System.Console.WriteLine(t4.TotalDays); // obter a quantidade de dias quebrado no caso 2 dias e meio 



            ////////////// OPERACOES ///////////////////////

            TimeSpan t5 = new TimeSpan(12, 40, 20);
            TimeSpan t6 = new TimeSpan(12, 20,40);

            TimeSpan t7 = t5 + t6; // soma de tempos ou
            TimeSpan t8 = t5.Add(t6);
            System.Console.WriteLine(t7);
            System.Console.WriteLine(t8);

            TimeSpan t9 = t5.Subtract(t6); // subtrair 
            System.Console.WriteLine(t9);

            TimeSpan t10 = t8.Multiply(2.0); // devemos usar o double aqui
            System.Console.WriteLine(t10);

            TimeSpan t11 = t10.Divide(2.0);
            System.Console.WriteLine(t11);

        }
    }
}
