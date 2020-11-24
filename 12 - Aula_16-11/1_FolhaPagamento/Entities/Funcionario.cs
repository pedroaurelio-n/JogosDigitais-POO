using System;
using System.Collections.Generic;
using System.Text;

namespace _1_FolhaPagamento.Entities
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public int Horas { get; private set; }
        public double ValorHora { get; private set; }

        public Funcionario() { }

        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        public void Pagamento()
        {
            ValorHora * Horas
        }
    }
}
