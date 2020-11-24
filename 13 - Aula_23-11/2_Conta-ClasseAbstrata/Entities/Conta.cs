using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Conta_ClasseAbstrata.Entities
{
    //classe abstrata
    abstract class Conta
    {
        //declaração de variáveis encapsuladas
        //numero e titular serão alteradas somente nesta classe conta, enquanto que saldo utiliza protected set pois poderá ser alterado pelas subclasses
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        //construtor padrão
        public Conta() { }

        //construtor com parâmetros customizados
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //método de saque com atributo virtual para permitir sobreposição
        public virtual void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }

        //método de depósito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}
