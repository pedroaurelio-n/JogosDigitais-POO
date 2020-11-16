using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Conta.Entities
{
    class ContaJuridica : Conta
    {
        public double EmprestimoLimite { get; set; }

        public ContaJuridica() { }

        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite)
            : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }

        public void Emprestimo(double saldoTotal)
        {
            if (Saldo <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }
    }
}
