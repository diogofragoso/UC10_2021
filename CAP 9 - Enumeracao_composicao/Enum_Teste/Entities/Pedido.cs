using Enum_Teste.Entities.StatusP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Teste.Entities
{
    class Pedido
    {

        public int Id { get; set; }
        public DateTime Data  { get; set; }

        public StatusPedido Status { get; set; }

        public override string ToString()
        {
            return Id
                + " | "
                + Data
                + " | "
                + Status;
        }

    }
}
