using System;

namespace _2_MatrizPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //array line que terá 2 valores digitados pelo usuário separados por espaço que serão os tamanhos da linha e coluna da matriz, respectivamente
            string[] line = Console.ReadLine().Split(' ');

            //declaração de m para as linhas e n para as colunas da matriz que receberão os valores digitados pelo usuário
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            //criação de uma matriz com os tamanhos digitados
            int[,] mat = new int[m, n];

            //loop que repete enquanto a quantidade de linhas for menor que o valor de n
            for (int l = 0; l < n; l++)
            {
                //array de strings values que armazenará os números digitados pelo usuário separados por espaço
                string[] values = Console.ReadLine().Split(' ');

                //loop que repete enquanto a quantidade de colunas for menos que o valor de n
                for (int c = 0; c < n; c++)
                {
                    //no objeto localizado na linha l e coluna c, atribuir os valores digitados pelo usuário
                    //como tem o split pra determinar o espaçamento, todo array values terá a mesma quantidade de objetos que o valor de n
                    //(supondo que o usuário não digite errado)
                    //então os valores de cada índice no array entrará na matriz na linha atual e na coluna de mesmo índice dos valores
                    mat[l, c] = int.Parse(values[c]);
                }
            }

            //declaração de x que receberá um valor digitado pelo usuário
            int x = int.Parse(Console.ReadLine());

            //loops para as linhas e colunas (nessa ordem) que percorrerão a matriz inteira
            for (int l = 0; l < m; l++)
            {
                for (int c = 0; c < n; c++)
                {
                    //se o elemento atual desse percorrimento for igual a x, realizar uma série de condições
                    if (mat[l, c] == x)
                    {
                        //mostrar a posição do elemento na matriz
                        Console.WriteLine("Posição: " + l + "," + c);

                        //mostrar qual elemento está em sua esquerda (se houver)
                        if (c > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[l, c - 1]);
                        }

                        //mostrar qual elemento está em sua direita (se houver)
                        if (c < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[l, c + 1]);
                        }

                        //mostrar qual elemento está em sua cima (se houver)
                        if (l > 0)
                        {
                            Console.WriteLine("Cima: " + mat[l - 1, c]);
                        }

                        //mostrar qual elemento está em sua baixo (se houver)
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
