using System;
using System.Collections.Generic;
using System.Text;

namespace EnumTrabalhador_ex2.Entities
{
    class Departamento
    {
        public string Nome { get; set; }
        public Departamento() { }

        public Departamento(string nome) {

            Nome = nome;
        }
    }
}
