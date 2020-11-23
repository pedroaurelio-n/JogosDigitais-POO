using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Conta.Entities
{
    //classe selada utilizando sealed. não é possível criar subclasses dessa classe
    sealed class ContaPoupanca : Conta
    {
        //declaração de variável encapsulada
        public double TaxaJuros { get; set; }

        //construtor padrão
        public ContaPoupanca() { }

        //construtor com parâmetros utilizados da classe principal
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        //método para atualizar o saldo depois de aplicar os juros
        public void AtualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        //método de saque com override, pois sobrepõe o método padrão da classe principal
        //método também com sealed para impedir a criação de métodos utilizando este como base
        public sealed override void Saque(double saldoTotal)
        {
            //primeiro é realizado o saque normal da superclasse, e depois tem a modificação da classe ContaPoupanca que seria o desconto de 2 reais
            base.Saque(saldoTotal);
            Saldo -= 2;
        }
    }
}
