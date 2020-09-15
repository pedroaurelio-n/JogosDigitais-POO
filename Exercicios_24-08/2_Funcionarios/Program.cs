using System;

namespace POO___Aula_1___Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.Write("Digite o nome do primeiro funcionário: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite a salário do primeiro funcionário: ");
            a.salario = float.Parse(Console.ReadLine());

            Console.Write("Digite o nome do segundo funcionário: ");
            b.nome = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            b.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("\n\nDados do primeiro funcionário:\nNome: " + a.nome + "\nSalário: R$" + a.salario.ToString("F2") + "\n");
            Console.WriteLine("Dados do segundo funcionário:\nNome: " + b.nome + "\nSalário: R$" + b.salario.ToString("F2") + "\n");

            //float salario_media = (a.salario + b.salario) / 2;

            float c = a.salario + b.salario;

            Console.WriteLine("Salário médio: R$" + salario_media.ToString("F2"));
        }
    }
}
