using System;
using System.Collections.Generic;
using System.Text;

namespace enumPedido_ex3.Entities
{
    class ItemPedido
    {
        public  int Qtd { get; set; }

        public double Preco { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();


        // construtores

        public ItemPedido() { }

        public ItemPedido(int qtd, double preco)
        {
            Qtd = qtd;
            Preco = preco;
        }


        // metodos 

        public void AddProd(Produto produto) {
            Produtos.Add(produto);
        
        }

        public void RemoveProd(Produto produto) {

            Produtos.Remove(produto);
        }

        public double Total() {


            return Qtd * Preco;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Qtd);
            sb.Append(Preco);

            foreach (Produto item in Produtos)
            {

                sb.Append(item);
            }
            sb.Append(Total());

            return sb.ToString();

        }
    }
}
