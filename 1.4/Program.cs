// <!-- 
// 1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
// CalcularVogais("Luby Software") == 4//true -->

using System;
using System.Linq;

namespace Vogais
{
    class Vogais
    {
        public static int CalcularVogais(string caracteres)
        {
            int contador = 0;

            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            contador = caracteres.Count(x => vogais.Contains(x));

            return contador;
        }

        static void Main(string[] args)
        {

            string caracteres = "Luby Software";
            caracteres.ToLower();

            Console.WriteLine($"A frase : {caracteres}, tem {CalcularVogais(caracteres)} vogais");

        }
    }
}
