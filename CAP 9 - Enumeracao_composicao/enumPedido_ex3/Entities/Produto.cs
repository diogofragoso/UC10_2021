using System;
using System.Collections.Generic;
using System.Text;

namespace enumPedido_ex3.Entities
{
    class Produto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return "Nome Produto "
                + Nome
                + "Preço do Produto "
                + Preco;
        }
    }

    
}
