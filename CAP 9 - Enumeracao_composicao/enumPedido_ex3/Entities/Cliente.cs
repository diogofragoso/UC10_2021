using System;
using System.Collections.Generic;
using System.Text;

namespace enumPedido_ex3.Entities
{
    class Cliente
    {


        public string  Nome { get; set; }
        public string  email { get; set; }

        public DateTime DataAniversario { get; set; }


        public override string ToString()
        {
            return 
                " Nome.:  "
                + Nome
                + " | "
                + " email.: "
                + email
                + "Data de aniversário"
                + " | "
                + DataAniversario;
        }
    }
}
