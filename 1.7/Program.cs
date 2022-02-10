// 1.7 Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
// int[] vetor = new int[] { 1,2,3,4,5 };
// ObterElementosPares(vetor) == new int { 2, 4 }; //true

using System;
using System.Collections;

namespace Program
{
    class Program
    {
        public static void ElementosPares(int[] vetor)
        {

            ArrayList pares = new ArrayList();

            for (int i = 0; i < vetor.Length; i++)
            {

                if (vetor[i] % 2 == 0)
                pares.Add(vetor[i]);

            }

            foreach (var number in pares)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5 };

            ElementosPares(vetor);

        }
    }
}
