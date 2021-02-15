using System;

namespace EnumTrabalhador_ex2.Entities
{
    class HoraContrato
    {

        public DateTime DataContrato { get; set; }

        public double ValorPorHora { get; set; }

        public int Horas { get; set; }

        public HoraContrato() { }

        public HoraContrato(DateTime dataContrato, double valorPorHora, int horas)
        {
            DataContrato = dataContrato;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal() {

            return Horas * ValorPorHora;
        }
    }
}
