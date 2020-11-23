using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Conta.Entities
{
    //subclasse que herda de uma classe principal
    class ContaJuridica : Conta
    {
        //declaração de variável encapsulada
        public double EmprestimoLimite { get; set; }

        //construtor padrão
        public ContaJuridica() { }

        //construtor com parâmetros utilizados da classe principal
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite)
            : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        //método de empréstimo
        public void Emprestimo(double saldoTotal)
        {
            if (Saldo <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
