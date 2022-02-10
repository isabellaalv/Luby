// 1.6 Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
// CalcularDiferencaData("10122020", "25122020") == 15; //true 

using System;

namespace Program
{
    class Program
    {
        public static int CalcularDiferencaData(String data1,String data2)
        {
            int anos = (Convert.ToInt32(data2.Substring(4, 4)) - Convert.ToInt32(data1.Substring(4, 4)))*365;
            int meses = (Convert.ToInt32(data2.Substring(2, 2)) - Convert.ToInt32(data1.Substring(2, 2)))*30;
            int dias = Convert.ToInt32(data2.Substring(0, 2))- Convert.ToInt32(data1.Substring(0, 2));
            dias = anos + meses + dias;

            if(dias < 0){
                dias = dias * -1;
            }
            Console.WriteLine(dias);
            return dias;
        }
        static void Main(string[] args)
        {

            CalcularDiferencaData("10122020", "25122020"); 
        }
    }
}