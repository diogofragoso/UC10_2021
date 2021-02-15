using System;

namespace OperacoesDateTime_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DateTime data = new DateTime(2021,02,11,18,38,30);
            System.Console.WriteLine(data);

            System.Console.WriteLine(data.Year); // extrai apenas o ano
            System.Console.WriteLine(data.Day); // extrai apenas o dia 
            System.Console.WriteLine(data.Month); //  extrai apenas o mes
            System.Console.WriteLine(data.Hour); // extrai apenas a hora
            System.Console.WriteLine(data.Minute); // Minuto
            System.Console.WriteLine(data.TimeOfDay); // quanto tempo se passou do dia 

            // Formatação de data

            System.Console.WriteLine(data.ToLongDateString()); // converte um date time para string
            System.Console.WriteLine(data.ToLongTimeString()); // Obtem apenas a hora em formato de string
            System.Console.WriteLine(data.ToShortDateString()); // data curta
            System.Console.WriteLine(data.ToShortTimeString()); // hora curta sem os segundos
            System.Console.WriteLine(data.ToString()); // Formato padrão
            System.Console.WriteLine(data.ToString("yyyy/MM/dd")); // Formato personalizado
            System.Console.WriteLine(data.ToString("dd-MM-yyyy")); // Formato personalizado
            System.Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm:ss")); // Formato personalizado

            ///////////// OPERAÇÕES ///////////////////////////////////////

            DateTime d2 = data.AddDays(2); // adicionar 2 dias a data
            System.Console.WriteLine(d2);
            d2 = data.AddYears(4); // adicionar 4 anos a data
            System.Console.WriteLine(d2);

            d2 = data.AddMinutes(10);
            System.Console.WriteLine();
            

            // Subtração de datas
            DateTime d3 = DateTime.Now;
            DateTime d4 = new DateTime(2021,01,10,19,05,30); // dias de atraso de uma conta 
            TimeSpan t2 = d3 - d4; // ou 
            TimeSpan t3 = d3.Subtract(d4);

        System.Console.WriteLine(t2.TotalDays.ToString("F0") + " Dias em atraso"); // Formatando para pegar apenas o dia
        
        System.Console.WriteLine(t3.TotalDays.ToString("F0") + " Dias em atraso"); // Formatando para pegar apenas o dia

        // Sugestao de atividade locação de automóveis



        }
    }
}
