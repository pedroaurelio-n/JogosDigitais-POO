using _3_Conta.Entities;
using System;

namespace _3_Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de objetos da superclasse e subclasse, respectivamente
            Conta acc = new Conta(1001, "Goku", 0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0, 500);

            //upcasting, criação de objetos da superclasse que possuem parâmetros de subclasses
            //criação de objeto conta que herda informações do objeto bacc, que é uma ContaJuridica
            Conta acc1 = bacc;
            //criação de objeto conta que herda parâmetros da subclasse ContaJuridica que são colocados
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0, 200);
            //criação de objeto conta que herda parâmetros da subclasse ContaJuridica que são colocados
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0, 0.01);

            //downcasting, criação de objetos das subclasses que herdam parâmetros da superclasse
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100);

            if (acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupanca)
            {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.AtualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}
