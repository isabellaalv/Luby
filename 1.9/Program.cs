// // 1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um
//  array de array de inteiros com no máximo dois elementos.
// // TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, 
// new int[] { 5, 6  } }; //true 

using System;

namespace Program
{
    class Program
    {
        public static void TransformarEmMatriz(string name)
        {
            int contador = 0;

            string[] names = name.Split(',');
            int[][] matriz = new int[names.Length / 2][];
            int[] totalidade = Array.ConvertAll(names, int.Parse);

            for (int h = 0; h < names.Length / 2; h++)
            {
                matriz[h] = new int[2];
            }

            for (int i = 0; i < names.Length / 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    matriz[i].SetValue(totalidade[contador], j);
                    j++;
                    contador++;
                    matriz[i].SetValue(totalidade[contador], j);
                    contador++;

                    if (contador > totalidade.Length)
                        break;
                }
            }

            for (int m = 0; m < names.Length / 2; m++)
            {
                Console.Write(matriz[m] + "= { ");
                foreach (var elements in matriz[m])
                {
                    Console.Write(elements + ",");

                }
                Console.Write("}");
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            TransformarEmMatriz("1,2,3,4,5,6");
            Console.WriteLine();
            TransformarEmMatriz("1,2,3,4,5,6,7,8");

        }
    }
}
