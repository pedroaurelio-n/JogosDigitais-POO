using System;
using System.Collections.Generic;

namespace _1_ExemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de uma primeira lista de strings
            List<string> list = new List<string>();

            //adição dos elementos da lista
            list.Add("Fábio"); 
            list.Add("Wilson"); 
            list.Add("Angelina"); 
            list.Add("Eliney"); 
            list.Add("Andre");

            //adição de um elemento na posição especificada
            list.Insert(2, "Lucas");
            
            //loop que le todos os objetos string da lista e mostra cada um deles
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //contagem da quantidade de elementos na lista
            Console.WriteLine("Quantidade de elementos na lista: " + list.Count);


            //busca string primeiro elemento da lista que inicia com a letra A, com função lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);

            //busca string último elemento da lista que inicia com a letra A, com função lambda
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último elemento que começa com a letra A: " + s2);


            //busca posição primeiro elemento da lista que inicia com a letra A, com função lambda
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição de A: " + pos1);

            //busca posição último elemento da lista que inicia com a letra A, com função lambda
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição de A: " + pos2);


            //criação de uma segunda lista
            //busca todos os elementos da lista com tamanho igual a 5 caracteres e armazenar na segunda lista
            List<string> list2 = list.FindAll(x => x.Length == 5);
            //separador
            Console.WriteLine("---------------------------------------");
            //loop que le todos os objetos string da lista e mostra cada um deles
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }


            //remover elemento da lista por string
            list.Remove("Andre");
            //separador
            Console.WriteLine("=======================================");
            //loop que le todos os objetos string da lista e mostra cada um deles
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            //remover elemento da lista que satisfaça o predicado
            list.RemoveAll(x => x[0] == 'W');
            //separador
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            //loop que le todos os objetos string da lista e mostra cada um deles
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            //remover elemento da lista por posição
            list.RemoveAt(3);
            //separador
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //loop que le todos os objetos string da lista e mostra cada um deles
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            //remover quantidade específica de elementos da lista a partir da posição
            list.RemoveRange(1, 2);
            //separador
            Console.WriteLine(".......................................");
            //loop que le todos os objetos string da lista e mostra cada um deles
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
