using System;

namespace DateTimeKind_ISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime d1 = new DateTime(2021,02,11, 20, 24,0, DateTimeKind.Local);
            DateTime d2 = new DateTime(2021,02,11, 20, 24,0, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2021,02,11, 20, 24,0);

            System.Console.WriteLine(d1);

            System.Console.WriteLine(d2.Kind);
            System.Console.WriteLine(d2.ToLocalTime()); // converte hora utp para locall -3
             System.Console.WriteLine(d1.ToUniversalTime()); // converte hora local para utc +3

            System.Console.WriteLine(d3);

            ////////Padrao Iso 8601
            // yyyy-MM-ddTHH:mm:ssZ  Z siginifica utc
            //exemplo 

            DateTime  d4 =  DateTime.Parse("2021-02-11T18:00:00Z"); //armazena no formato UTC mas o sistema exibe no horario local 
            System.Console.WriteLine(d4);





        }

    }
}
