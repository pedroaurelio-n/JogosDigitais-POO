using System;

namespace _1_MatrizQuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int counter = 0;

            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    mat[l, c] = int.Parse(Console.ReadLine()); 

                    if (mat[l, c] < 0)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine("\nDiagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + "  ");
            }

            Console.WriteLine("\nElementos negativos: " + counter);
        }
    }
}
