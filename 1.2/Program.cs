// <!-- 1.2 Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
// Tipo: "basic" fator multiplicação do prêmio: 1
// Tipo: "vip" fator multiplicação do prêmio: 1.2
// Tipo: "premium" fator multiplicação do prêmio: 1.5
// Tipo: "deluxe" fator multiplicação do prêmio: 1.8
// Tipo: "special" fator multiplicação do prêmio: 2
// Regras
// A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
// Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
// O prêmio nunca deve ter um valor negativo ou igual a zero.
// CalcularPremio(100, "vip", null) == 120.00;//true
// CalcularPremio(100, "basic", 3) == 300.00;//true -->

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaPremio(100, "vip", null);
            CalculaPremio(100, "basic", 3);
        }
        public static double CalculaPremio(double Premio, String Tipo, int? Fator)
        {
           
            int tipo = 0;
            // Dava para usar switch tambem.
            String[,] premio = { { "basic", "1"},
                                 { "vip", "1,2"},
                                 { "premium", "1,5"},
                                 { "deluxe", "1,8"},
                                 { "special","2"} };

            for (int i = 0; i < 5; i++){
                if (Tipo == premio[i, 0]){
                    tipo = i;
                }
            }

            if(Fator <= 0){
     
                Console.WriteLine("Fator esta errado");
                return 0;
            }

            if (Fator != null){
                Premio = ((Convert.ToDouble(premio[tipo, 1]) * Premio) * Convert.ToDouble(Fator));
            }else{
                Premio = Convert.ToDouble(premio[tipo, 1])* Premio;
            }

            if(Premio > 0){
                Console.WriteLine(Premio.ToString("N2"));
                return Premio;
            }else{

                Console.WriteLine("Valor do premio esta invalido");
                return 0;
            }

        }
        
    }
}