using _3_Conta.Entities;
using System;

namespace _3_Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica conta = new ContaJuridica(8010, "Lara", 100, 500);

            Console.WriteLine(conta.Saldo);
        }
    }
}
