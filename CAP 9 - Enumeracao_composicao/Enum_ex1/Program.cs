using Enum_ex1.Entities;
using Enum_ex1.Entities.Enums;
using System;

namespace Enum_ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 100,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,

            };

            
            Console.WriteLine(order);
            // Converter enum para string
            string pedido = order.Status.ToString();
            Console.WriteLine(pedido);

            //  Convertendo uma string para um tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // <<== este texto deve estar igual aquilo que foi definido no OrderStatus
        }
    }
}
