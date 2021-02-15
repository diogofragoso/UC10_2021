using System;
using System.Collections.Generic;
using System.Text;
using enumPedido_ex3.Entities.Enums;

namespace enumPedido_ex3.Entities.Enums
{
    class Pedido
    {

        DateTime data = DateTime.Now;

        public StatusPedido Status { get; set; }

        public Cliente cliente  { get; set; }




        List<ItemPedido> itensPedidos = new List<ItemPedido>();



        // Metodos

        //Add Itens no Pedido

        public void AddItens(ItemPedido itens) {
            itensPedidos.Add(itens);

        }

        public void RemoveItensPedido(ItemPedido itens) {

            itensPedidos.Remove(itens);
        }

        public double TotalPedido() {
            double total = 0;

            foreach (ItemPedido pedidos in itensPedidos)
            {
                total += pedidos.Total();
            }

            return total;
        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("Data do Pedido.: ");
            sb.Append(data);
            sb.Append(" | Status do pedido");
            sb.Append(Status);
            sb.Append(" | ");
            sb.Append(cliente);
            sb.Append(" | ");
            sb.Append("Itens no Pedido");

            foreach (ItemPedido item in itensPedidos)
            {
                sb.Append(" | ");
                sb.Append(item);
            }
            sb.Append(itensPedidos);
            sb.Append(" | Total do pedido R$ ");
            sb.Append(TotalPedido());


            return sb.ToString();
        }

    }
}
