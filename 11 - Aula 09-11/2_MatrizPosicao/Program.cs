using System;

namespace _2_MatrizPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int l = 0; l < m; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    mat[l, c] = int.Parse(Console.ReadLine());
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int l = 0; l < m; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (mat[l, c] == x)
                    {
                        Console.WriteLine("Posição: " + l + "," + c);

                        if (c > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[l, c - 1]);
                        }

                        if (c < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[l, c + 1]);
                        }

                        if (l > 0)
                        {
                            Console.WriteLine("Cima: " + mat[l - 1, c]);
                        }

                        if (l < m - 1)
                        {
                            Console.WriteLine("Baixo: " + mat[l + 1, c]);
                        }
                    }
                }
            }
        }
    }
}
