using System;

namespace _3_Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            //input para a quantidade de hóspedes que será armazenada em n
            Console.Write("Quantos quartos estão alugados? ");
            int n = int.Parse(Console.ReadLine());

            //criação de um vetor vazio de tamanho 10 que armazenará objetos do tipo Quarto
            Quarto[] vect = new Quarto[10];

            //loop que repete n vezes
            for (int i = 0; i < n; i++)
            {
                //input para o nome, email e número do quarto deste hóspede
                Console.WriteLine("\nHóspede #" + (i+1) + ";");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int q = int.Parse(Console.ReadLine());

                //criação de um objeto Quarto com o nome e email inseridos que será posicionado no quarto do número inserido
                //quartos de 0 a 9, assim como os índices do vetor
                //classe Quarto ficou meio estranho, talvez Hospede fosse melhor
                vect[q] = new Quarto { Nome = nome, Email = email };

                Console.WriteLine();
                Console.WriteLine("------------------------------");
            }

            //output dos quartos ocupados
            Console.WriteLine("\nQUARTOS OCUPADOS");

            //loop que repete (tamanho do vetor) vezes, no caso 10
            for (int i = 0; i < vect.Length; i++)
            {
                //se a posição atual do vetor tiver um objeto, realizar o output das informações do objeto nessa posição atual
                //se estiver vazio, não mostrar nada
                if (vect[i] != null)
                {
                    Console.WriteLine((i) + ": " + vect[i].Nome + ", " + vect[i].Email);
                }
            }

            Console.ReadKey();
        }
    }
}
