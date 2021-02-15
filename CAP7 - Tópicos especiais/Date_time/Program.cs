using System;
using System.Globalization;

namespace Date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime data = DateTime.Now;
            System.Console.WriteLine(data);
            System.Console.WriteLine(data.Ticks); // segundo desde 1 de janeira da era comum
            
            ///////////////////////
            DateTime data1 = new DateTime(2021, 02 , 11); // ano mes e dia 
            System.Console.WriteLine(data1);

            /////

            DateTime data2 = new DateTime(2021, 02 , 11, 16,10,30); // ano mes dia hora minutos segundos
            System.Console.WriteLine(data2);

            DateTime d0 = DateTime.Now;
            DateTime d1 = DateTime.Today;
            DateTime d2 = DateTime.UtcNow;

            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);

            // Convertendo string para DateTIme

            DateTime d4 = DateTime.Parse("2021-02-11");
            System.Console.WriteLine(d4 + " Teste");

            DateTime d5 = DateTime.Parse("2021-02-01 16:21:00");
            System.Console.WriteLine(d5);


            DateTime d6 =  DateTime.Parse("11-02-2021 16:10:00"); // formato brasileiro
            System.Console.WriteLine(d6);

        //  Personlaizando a Data 
        DateTime d7 = DateTime.ParseExact("2021-02-11" , "yyyy-MM-dd", CultureInfo.InvariantCulture); // A exibição continua seguindo o padrão
        System.Console.WriteLine(d7 + " Teste 2");

        DateTime d8 = DateTime.ParseExact("11/02/2021 16:32:00" , "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        System.Console.WriteLine(d8);
        

        }
    }
}
