using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            

            TimeSpan t1 = new TimeSpan(1,50,30); // hora minuto segundo
            TimeSpan t2 = new TimeSpan(66300000000L); // Ticks segundos
            TimeSpan t3 = new TimeSpan(1, 2 , 30 , 15 ); // dia hora minutos segundos
             TimeSpan t4 = new TimeSpan(1, 2 , 30 , 15 , 320 ); // dia hora minutos segundos milesegundos
            Console.WriteLine(t1);
            System.Console.WriteLine(t1.Ticks);

            System.Console.WriteLine(t2);

            System.Console.WriteLine(t3);
             System.Console.WriteLine(t4);


             // Criar um timeSpan equivalente a um dia e meio 
            TimeSpan t5 = TimeSpan.FromDays(1.5); 
            System.Console.WriteLine(t5);
            // Criar um temeSpan equivalente a uma hora e 30 minutos 

            TimeSpan t6 = TimeSpan.FromHours(1.5); // .5 % percentual da fracao de hora
            System.Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromTicks(66300000000);

        }
    }
}
