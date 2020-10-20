using System;

namespace _1_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria a = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            a.Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            a.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (S/N): ");
            string depositoInicial = Console.ReadLine();

            if (depositoInicial == "S")
            {
                Console.Write("Entre com o depósito inicial: ");
                a.RealizarDeposito(double.Parse(Console.ReadLine()));
            }

            else
                a.RealizarDeposito(0);

            Console.WriteLine("\nDados da conta:" + a);



            Console.Write("\nEntre com um valor para depósito: ");
            a.RealizarDeposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados:" + a);

            Console.Write("\nEntre com um valor para saque: ");
            a.RealizarSaque(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados: " + a);
        }
    }
}
