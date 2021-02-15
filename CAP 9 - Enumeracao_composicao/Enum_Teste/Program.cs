using Enum_Teste.Entities;
using Enum_Teste.Entities.StatusP;
using System;

namespace Enum_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1020,
                Data = DateTime.Now,
                Status = StatusPedido.PendenteDePagamento,                
               

            };

            

            Console.WriteLine(pedido.Status.ToString());

            StatusPedido verEntrega = Enum.Parse<StatusPedido>("Entregue");
            
            pedido.Status = verEntrega;
            Console.WriteLine(pedido);

        }
    }
}
