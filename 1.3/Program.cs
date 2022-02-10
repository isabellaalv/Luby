// 1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.
// //Número primo: 2
// //Número primo: 3
// //Número primo: 5
// //Número primo: 7
// //Total de números primos: 4
// ContarNumerosPrimos(10) == 4//true

using System;

namespace Program
{
    class Program
    {
         void prime_num(long num) {
            bool Primos = true;
            for (int i = 0; i <= num; i++) {
                for (int j = 2; j <= num; j++) {
                    if (i != j && i % j == 0) {
                        Primos = false;
                        break;
                    }
                }
                if (Primos) {
                    Console.WriteLine("Primos:" + i);
                }
                Primos = true;
            }
        }
        
        static void Main(string[] args) {

        Program p = new Program();
        p.prime_num(10L); //Aqui colocar o valor limite do for
        Console.ReadLine();

    }
    }

}
     
     
