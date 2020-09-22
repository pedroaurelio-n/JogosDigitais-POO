using System;
using System.Globalization;

namespace _2_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o salário bruto do funcionario: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor total dos impostos a serem pagos: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("\nDados do funcionário: \n" + f + "\n\n");


            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados atualizados do funcionário: \n" + f);

            Console.ReadKey();
        }
    }
}
