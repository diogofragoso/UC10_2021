using System;
using System.Globalization;
using EnumTrabalhador_ex2.Entities.Enums;
using EnumTrabalhador_ex2.Entities;

namespace EnumTrabalhador_ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do departamento");
                string Depart = Console.ReadLine();
                Departamento depto = new Departamento(Depart);

            Console.WriteLine("Digite as informações do trabalhador");
            Console.WriteLine("Nome.:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o nível do Funcionário(Junior | NivelMedio | Senior)");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());

            Console.WriteLine("Digite o salário Base do funcionário");
            double salBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            Trabalhador trabalhador = new Trabalhador(nome, nivel, salBase, depto);

            Console.WriteLine("Quantos contratos para este trabalhador ?");
            int nContrato = int.Parse(Console.ReadLine());

            for (int i = 0; i < nContrato; i++)
            {
                Console.WriteLine("Entre com os dados do contrato .:" + i);
                Console.WriteLine("Data do contrato em (DD/MM/YYYY)");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor pago por hora neste contrato");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite a quantidade de horas");
                int qtdHoras = int.Parse(Console.ReadLine());

                // Após coletar os dados do contrato devemos entao instanciar os contratos
                HoraContrato contrato = new HoraContrato(data, valorHora, qtdHoras);

                // Adicionar os contratos ao trabalhador
                trabalhador.AddContrato(contrato);

            }

            Console.WriteLine("Entre com o mês e ano para calcular o valor recebido do trabalhador no período  (MM/YYYY) )");
            string mesAno = Console.ReadLine();
            //string[] mesAnoAux = mesAno.Split("/");
            int mes = int.Parse(mesAno.Substring(0, 2)); // pegar a string mesAno recortar a partir da posição 0 dois caracteres
            int ano = int.Parse(mesAno.Substring(3));

            // Imprimir os dados do trbalhador

            Console.WriteLine("Nome .: " + trabalhador.Nome);
            Console.WriteLine("Departamento.:" + trabalhador.Departamento.Nome);
            Console.WriteLine("Valor recebido.: " + mesAno  + " : "  + trabalhador.Ganho(ano,mes).ToString("F2"), CultureInfo.InvariantCulture);







        }
    }
}
