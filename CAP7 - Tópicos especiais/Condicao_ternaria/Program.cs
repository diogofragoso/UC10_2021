using System;
using System.Globalization;

namespace Condicao_ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //expressão condicional ternária
            //sintaxe
            // (condição) ? valor_se_verdadeiro : valor_se_falso
    // exemplo
    //(2 > 4) ? 50 : 80;
    //(10 != 3) ? "JOAO" : "ALICE";

            Console.WriteLine("Digite o valor da compra para descobrir o desconto");

            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Desconto = (Preco > 20 ? Preco * 0.1 : Preco *  0.05);

            System.Console.WriteLine("Valor com desconto .: " + (Preco - Desconto));




            

        }
    }
}
