using _3_Formas_MetodosAbstratos.Entities;
using _3_Formas_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _3_Formas_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de lista que armazenará objetos da classe Forma
            List<Forma> list = new List<Forma>();

            //input do usuário para a quantidade de objetos para n
            Console.Write("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            //loop que repetirá n vezes 
            for (int i = 1; i <= n; i++)
            {
                //input do usuário para o tipo da forma e para a cor
                Console.WriteLine($"\nForma #{i}: ");

                Console.Write("Retângulo ou Círculo (R/C)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                //se o tipo for retangulo (R), input para a altura e largura
                if (ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //criação e adição de objeto da classe Retangulo na lista por meio de upcasting
                    list.Add(new Retangulo(largura, altura, color));
                }

                //se o tipo for retangulo (R), input para o raio
                else if (ch == 'C')
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //criação e adição de objeto da classe Circulo na lista por meio de upcasting
                    list.Add(new Circulo(raio, color));
                }

            }

            //output para a área de cada objeto. o método Area utilizado dependerá das subclasses, poir na classe principal ele é abstrato
            Console.WriteLine();
            Console.WriteLine("Área de cada forma: ");

            //para cada objeto Forma na lista, mostrar a área dele
            foreach(Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
