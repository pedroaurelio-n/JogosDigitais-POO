using _2_Conta_ClasseAbstrata.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _2_Conta_ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de objetos da classe Conta, mas que não podem ser instanciados diretamente pois Conta é uma classe abstrata
            List<Conta> list = new List<Conta>();

            //criação e adição de objetos das subclasses derivadas de Conta na lista
            list.Add(new ContaPoupanca(1001, "Terry", 500, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500, 400));
            list.Add(new ContaPoupanca(1003, "Joe", 500, 0.01));
            list.Add(new ContaJuridica(1004, "Mae", 500, 400));

            //variável para a soma total dos saldos
            double soma = 0;

            //para cada conta na lista, adicionar seu saldo na variável de soma total
            foreach(Conta acc in list)
            {
                soma += acc.Saldo;
            }

            //output do saldo total
            Console.WriteLine("Total do saldo de todas as contas: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            //para cada conta na lista, realizar o método Saque com o parâmetro 10
            //ContaPoupanca possui um Saque que sobrepõe o original. ContaJuridica utiliza o Saque padrão da superclasse
            foreach (Conta acc in list)
            {
                acc.Saque(10);
            }

            //para cada conta na lista, mostrar seu saldo atualizado
            foreach (Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo da conta " + acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
