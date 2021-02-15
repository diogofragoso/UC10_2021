using System;
using System.Collections.Generic;
using System.Text;
using EnumTrabalhador_ex2.Entities.Enums;


namespace EnumTrabalhador_ex2.Entities
{
    class Trabalhador
    {

        public string Nome { get; set; }

        public NivelTrabalhador Nivel { get; set; }

        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }

        // Neste caso usamos um lista pois um trabalhador poderá ter vários contratos 
        public List<HoraContrato> Contratos { get; set; } = new List<HoraContrato>();

        // Construtores

        public Trabalhador() { }

        // Não passaremos os contratos do tipo lista para o contrutor não é usual fazer desta forma
        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }


        // implementando os métodos

        // método para add contrato ao trabalhador
        public void AddContrato(HoraContrato contrato) {

            Contratos.Add(contrato);
        }

        // metodo para remover contrato do trabalhador

        public void RemContrato(HoraContrato contrato) {

            Contratos.Remove(contrato);
        }

        // implemntar um método para retornar quanto um trabalhador ganhou em um determinado ano ou mes

        public double Ganho(int ano, int mes) {

            double total = SalarioBase;

            foreach (HoraContrato item in Contratos)
            {
                if (item.DataContrato.Year == ano && item.DataContrato.Month == mes) {

                    total += item.ValorTotal();
                
                
                }

             
            }

            return total;

        }

        
    }
}
