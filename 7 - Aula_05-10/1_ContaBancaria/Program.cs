using System;

namespace _1_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de um objeto contabancaria vazio
            ContaBancaria a = new ContaBancaria();

            //condição para o número do objeto ser definido só na primeira vez
            if (a.Numero == default)
            {
                //input do usuário para o numero da conta que será setado na variável Numero
                Console.Write("Entre com o número da conta: ");
                a.Numero = int.Parse(Console.ReadLine());
            }

            //input do usuário para o nome do titular da conta que será setado na variável Titular
            Console.Write("Entre com o titular da conta: ");
            a.Titular = Console.ReadLine();

            //checagem para a realização do depósito inicial
            Console.Write("Haverá depósito inicial? (S/N): ");
            string depositoInicial = Console.ReadLine();

            //se o usuário digitar S, ele poderá realizar o depósito inicial da conta
            if (depositoInicial == "S")
            {
                //como só é possível alterar o saldo dentro da classe contabancaria, o valor digitado pelo usuário será aplicado no método realizardeposito
                Console.Write("Entre com o depósito inicial: ");
                a.RealizarDeposito(double.Parse(Console.ReadLine()));
            }

            //se o usuário digitar algo além de S, não haverá depósito inicial e o programa realiza um depósito com valor 0 para aplicar um valor ao saldo
            else
                a.RealizarDeposito(0);

            //output dos dados da conta
            Console.WriteLine("\nDados da conta:" + a);


            //demonstração de depósito e saque utilizando os métodos da classe contabancaria e outputs atualizados dos dados da conta
            Console.Write("\nEntre com um valor para depósito: ");
            a.RealizarDeposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados:" + a);

            Console.Write("\nEntre com um valor para saque: ");
            a.RealizarSaque(double.Parse(Console.ReadLine()));

            Console.WriteLine("\nDados da conta atualizados: " + a);

            Console.ReadKey();
        }
    }
}
