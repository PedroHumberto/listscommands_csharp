using System;
using System.Collections.Generic;

namespace ListsCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //add por padrão adiciona ao final da lista
            list.Add("Axeli");
            list.Add("Jose");
            list.Add("Jão");
            list.Add("Murilo");
            list.Add("Alex");
            list.Add("Ana");

            //Insert adiciona elementos na posição que você quiser, empurrando o proximo da posição para baixo
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            
            }
            Console.WriteLine("List Count: " + list.Count);

            //Recebe uma função declarada, podendo usar tambem uma expressão LAMBDA
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            //mostrar a posição do elemento na lista
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position A: " + pos2);

            //filtrar a lista
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------Find [5] Caracteres---------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);

            }

            //remove o elemento pela posição
            list.RemoveAt(2);//remove o marco

            Console.WriteLine("----------------Remove [M]-----------");
            //remove todos os elementos determinados
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }
            //remove elementos de uma faixa
            list.RemoveRange(2, 2); //a partir da segunda linha vai remover o segundo e o seguinte
            Console.WriteLine("----------------Remove [2,2]-----------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }


            //remover da lista
            list.Remove("Alex");

        }
    }
}
