using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _1_FolhaPagamento.Entities
{
    class Funcionario
    {
        //declaração de variáveis com autoproperties
        public string Nome { get; private set; }
        public int Horas { get; private set; }
        public double ValorHora { get; private set; }

        //construtor padrão
        public Funcionario() { }

        //construtor com parâmetros customizados
        public Funcionario(string nome, int horas, double valorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorHora = valorHora;
        }

        //método de pagamento que calcula o total pago para um funcionário comum por meio da multiplicação do valor por hora x horas
        //possui modificador virtual para permitir o override de métodos na subclasse
        public virtual double Pagamento()
        {
            return ValorHora * Horas;
        }

        //método tostring pra definir a formatação que o objeto terá no output. o cálculo está direto dentro deste método de classe, então ele não é chamado no programa principal
        public override string ToString()
        {
            return Nome + " - R$ " + Pagamento().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
