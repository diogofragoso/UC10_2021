using System;
using enumPedido_ex3.Entities.Enums;
using enumPedido_ex3.Entities;
using System.Collections.Generic;

namespace enumPedido_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente : ");

            Console.Write("Nome.:");
            string nome = Console.ReadLine();

            Console.Write("Digite o email do cliente.: ");
            string email = Console.ReadLine();

            Console.Write("Digite a data de aniversário.: ");
            DateTime dataNiver = DateTime.Parse(Console.ReadLine());
             
            Console.WriteLine("Entre com os Dados do pedido.: ");
            Console.Write("Digite o status (AguardandoPagamento | Processando | Enviando | Entregue) .: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Console.WriteLine("Quantos itens existe no pedido");
            int qtdItens = int.Parse(Console.ReadLine());



            // criando o objeto cliente
            Cliente cliente = new Cliente();

            cliente.Nome = nome;
            cliente.email = email;
            cliente.DataAniversario = dataNiver;

            // Criando lista de objeto produto
            List<Produto> prod = new List<Produto>();

            Produto prod1 = new Produto();
          
       

            // Cliando objeto Pedido
            Pedido pedidos = new Pedido();
            pedidos.cliente = cliente;
            pedidos.Status = status;

            ItemPedido itens = new ItemPedido();

            for (int i = 0; i < qtdItens; i++)
            {
                               

                Console.WriteLine("Digite o nome do produto .: " + i);
                prod1.Nome = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto .: " + i);
                prod1.Preco = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de itens .: " );
                itens.Qtd = int.Parse(Console.ReadLine());

                itens.AddProd(prod1);
                
                itens.Preco = prod1.Preco;

                pedidos.AddItens(itens);
               

            }


            Console.WriteLine(pedidos);

            

            
       


          


        }
    }
}
