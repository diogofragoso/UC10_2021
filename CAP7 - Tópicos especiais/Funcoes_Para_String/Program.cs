using System;
using System.Globalization;

namespace Funcoes_Para_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string palavra = "AaaBB pPkl Jiql dd d -    ";

            string p1 = palavra.ToUpper();
            Console.WriteLine(p1);

            p1 = palavra.ToLower();
            Console.WriteLine(p1);

            // remover espaços em branco
           string  p2 = palavra.Trim();
            Console.WriteLine(p2);

            int posicao = palavra.IndexOf("d");
            System.Console.WriteLine("Posição de A.: " + posicao); 

             int posicao2 = palavra.LastIndexOf("d");
            System.Console.WriteLine("Posição de A.: " + posicao2); 

            string p3 = palavra.Substring(3,5); // a partir da terceira posição vamos pegar 5 letras
            System.Console.WriteLine(p3);
    
    // Substituir caracteres
            p3 = palavra.Replace("a", "XX");
            System.Console.WriteLine(p3);

            // verificar se a string é vazia 

            bool b1 = String.IsNullOrEmpty(p3);
            System.Console.WriteLine(b1);

            // Verificar se é nulla ou um monte de espaço em branco

            bool b2 = String.IsNullOrWhiteSpace(p3);
            System.Console.WriteLine(b2);

            //// convertendo double em string

            double d1 = 225.1216546;

            string x  = d1.ToString("F2", CultureInfo.InvariantCulture);
            System.Console.WriteLine(x);

        }
    }
}
