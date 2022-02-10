// 1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
// Lembre-se que as entradas e saídas dos dados são strings que devem ser tratadas.
// CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"; //true

using System;

namespace Program
{
    class Program
    {
        public static String CalcularValorComDescontoFormatado(String Valor,String Desconto)
        {
            Valor = Valor.Remove(0, 3);
            Desconto = Desconto.Remove(Desconto.Length - 1);
            double PorcentagemDes = Convert.ToDouble(Desconto)/100;
            double Total = Convert.ToDouble(Valor)-(Convert.ToDouble(Valor) * PorcentagemDes);
            String ValorComDesconto = Total.ToString("C");
            Console.WriteLine(ValorComDesconto);
            return ValorComDesconto;
        }
        static void Main(string[] args)
        {

            CalcularValorComDescontoFormatado("R$ 6.800,00", "30%");   
        }
    }
}