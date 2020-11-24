using System;

namespace _1_MatrizQuadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //input do usuário para o tamanho da matriz quadrada que será armazenado em n
            int n = int.Parse(Console.ReadLine());

            //declaração do contador de negativos
            int counter = 0;

            //criação de uma matriz de n linhas e n colunas
            int[,] mat = new int[n, n];

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

                    //condição que checa se o elemento atual é negativo e que repete pra cada novo valor inserido na matriz
                    if (mat[l, c] < 0)
                    {
                        //se for negativo, +1 no contador
                        counter++;
                    }
                }
            }

            //exibição da diagonal principal da matriz
            Console.WriteLine("\nDiagonal principal:");
            //loop que declara um número i = 0 e adiciona +1 enquanto i for menos que n
            for (int i = 0; i < n; i++)
            {
                //exibir para o usuário o elemento de na linha i e coluna i da matriz
                //como o comando repete para cada valor inteiro de i menor que n, sempre mostrará a diagonal principal
                //que é o conjunto de elementos que possuem o mesmo índice de linha e coluna
                Console.Write(mat[i, i] + "  ");
            }

            //exibição da quantidade de elementos negativos armazenada no contador
            Console.WriteLine("\nElementos negativos: " + counter);
        }
    }
}
