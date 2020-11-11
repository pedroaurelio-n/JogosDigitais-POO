using System;
using System.Collections.Generic;
using System.Globalization;

namespace _2_Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nFuncionário #" + (i + 1) + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Insert(i, new Funcionario(id, nome));
                lista[i].Salario = salario;
            }

            Console.Write("\nId do funcionário que receberá aumento: ");
            string idAumento = Console.ReadLine();


            List<Funcionario> lista2 = lista.FindAll(x => x.Id.ToString("000") == idAumento);


            if (lista2 == null)
            {
                Console.WriteLine("O funcionário de ID " + lista2[0].Id.ToString("000") + " não existe!");
                //Console.WriteLine("Este funcionário não existe!");
                Console.ReadKey();
            }

            else
            {
                Console.Write("Porcentagem de aumento de salário: ");
                lista2[0].AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("\nLista atualizada de funcionários da Bravo: ");
                foreach (Funcionario obj in lista)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}
