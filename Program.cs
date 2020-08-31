using System;

namespace POO___Aula_1___Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            b.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            b.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDados da primeira pessoa:\nNome:" + a.nome + "\nIdade: " + a.idade + "\n");
            Console.WriteLine("Dados da segunda pessoa:\nNome:" + b.nome + "\nIdade: " + b.idade + "\n");

            if (a.idade > b.idade)
                Console.WriteLine("Pessoa mais velha: " + a.nome);

            else
                Console.WriteLine("Pessoa mais velha: " + b.nome);
        }
    }
}
