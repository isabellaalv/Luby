// <!-- 1.1 Implemente a função abaixo para calcular fatorial de um número.
// // 5! = 5 · 4 · 3 · 2 · 1 = 120
// CalcularFatorial(5) == 120//true -->

using System;

namespace Program
{
    class Fatorial
    {
         public static void Main(string[] args)
        {
            CalcularFat(5);
        }
        //Forma recursiva
        public static int CalcularFat(int num)
            {
                int Fato = 0;
                
            if(num == 1)
                {
                    Fato = 1;
                }else{
                    Fato = num * CalcularFat(num - 1);
                }

            Console.WriteLine(Fato);
            return Fato;
            }


    }
}



   