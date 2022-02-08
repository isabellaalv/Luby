# Luby Logica de Programaca Luby


<!-- 1.1 Implemente a função abaixo para calcular fatorial de um número.
// 5! = 5 · 4 · 3 · 2 · 1 = 120
CalcularFatorial(5) == 120//true -->


1.1


```c#

using System;

public class Premio
{

    public static String CalcularPremio(double valor, string tipo, int quant)
    {

        public static int CalcularFatorial(int num)
        {
            int fat = 1, numFatorar;
            numFatorar = num;

            for (int i = 1; i <= numFatorar; i++)
            {
                fat = fat * i;
            }

            return fat;
        }
```

<!-- 1.2 Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
Tipo: "basic" fator multiplicação do prêmio: 1
Tipo: "vip" fator multiplicação do prêmio: 1.2
Tipo: "premium" fator multiplicação do prêmio: 1.5
Tipo: "deluxe" fator multiplicação do prêmio: 1.8
Tipo: "special" fator multiplicação do prêmio: 2
Regras
A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
O prêmio nunca deve ter um valor negativo ou igual a zero.
CalcularPremio(100, "vip", null) == 120.00;//true
CalcularPremio(100, "basic", 3) == 300.00;//true -->

1.2

```c#

using System;

public class Premio
{

    public static String CalcularPremio(double valor, string tipo, int quant)
    {

        switch (tipo)
        {

            case "basic":
                valor *= 1;
                break;

            case "vip":
                valor *= 1.2;
                break;

            case "premium":
                valor *= 1.5;
                break;

            case "deluxe":
                valor *= 1.8;
                break;

            case "special":
                valor *= 2;
                break;

        }
        valor *= quant;


        return $"{valor:0.00}";
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Digite o valor do premio:");
        double valor = Double.Parse(Console.ReadLine());

        while (valor <= 0)
        {
            Console.WriteLine("Valor digitado deu erro, tente novamente:");
            valor = Double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o tipo do premio");
        string tipo = Console.ReadLine();

        Console.WriteLine("Digite a quantidade:");

        int quant = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CalcularPremio(valor, tipo, quant));

    }
}


// 1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.
// //Número primo: 2
// //Número primo: 3
// //Número primo: 5
// //Número primo: 7
// //Total de números primos: 4
// ContarNumerosPrimos(10) == 4//true

1.3

```c#
      void prime_num(long num) {
            bool isPrime = true;
            for (int i = 0; i <= num; i++) {
                for (int j = 2; j <= num; j++) {
                    if (i != j && i % j == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) {
                    Console.WriteLine("Prime:" + i);
                }
                isPrime = true;
            }
        }
        
        static void Main(string[] args) {

        Program p = new Program();
        p.prime_num(10L); //Aqui colocar o valor limite do for
        Console.ReadLine();

    }
```
<!-- 
1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
CalcularVogais("Luby Software") == 4//true -->

1.4

```c#
using System;
using System.Linq;

namespace Vogais
{

    class Vogais
    {
        public static int CalcularVogais(string caractere)
        {
            int contador = 0;

            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            contador = caractere.Count(x => vogais.Contains(x));

            return contador;
        }


        static void Main(string[] args)
        {

            string caractere = "Luby Software";
            caractere.ToLower();

            Console.WriteLine($"A fase : {caractere}, tem {CalcularVogais(caractere)} vogais");

        }
    }
}
```


<!-- 1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
Lembre-se que as entradas e saídas dos dados são strings que devem ser tratadas.
CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"; //true  -->

1.5

```c#
using System.Globalization; 
  
       string entrada, desconto, saida;
       double calculo, entradaTratada, descontoTratado, calculoFinal;
       string resultadoTratado;
    
       Console.WriteLine("Digite o valor de entrada!");
       entrada = Console.ReadLine();
       entradaTratada = Convert.ToInt32(entrada);

       Console.WriteLine("Digite o desconto!");
       desconto = Console.ReadLine();
       descontoTratado = Convert.ToInt32(desconto);

       calculo = (entradaTratada * descontoTratado) /100;
       calculoFinal = entradaTratada - calculo;

       resultadoTratado = calculoFinal.ToString("C", CultureInfo.CurrentCulture);

       Console.WriteLine(resultadoTratado);

       Console.Read();
       Console.ReadKey();
```


<!-- 1.6 Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
CalcularDiferencaData("10122020", "25122020") == 15; //true  -->

1.6


```c#
       DateTime data1, data2;
       string data01, data02;
       Console.WriteLine("Digite a primeira data");
       data01 = Console.ReadLine();
       data1 = Convert.ToDateTime(data01);

       Console.WriteLine("Digite a segunda data");
       data02 = Console.ReadLine();
       data2 = Convert.ToDateTime(data02);

       Console.WriteLine("Diferença entre dias da primeira e a segunda data: " + (data2 - data1).Days);

       Console.Read();
       Console.ReadKey();
```


<!-- 1.7 Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
int[] vetor = new int[] { 1,2,3,4,5 };
ObterElementosPares(vetor) == new int { 2, 4 }; //true  -->

1.7

```c#
       int[] atividade = new int[6];
       string numeros = "", tipo = "";
                for (int i = 1; i < 6; i++) {
                Console.WriteLine($"Insira o {i}° numero: ");
                atividade[i] = int.Parse(Console.ReadLine());
                tipo += atividade[i] % 2 == 1 ? "impar, " : "par, ";
                numeros += atividade[i] + ", ";
            }
       Console.Clear();
       Console.Write($"Os seguintes números foram digitados: \n{numeros}\n{tipo}");
       Console.Read();
       Console.ReadKey();



// 1.8 Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
// string[] vetor = new string[] {
//     "John Doe",
//     "Jane Doe",
//     "Alice Jones",
//     "Bobby Louis",
//     "Lisa Romero"
// };

// BuscarPessoa(vetor, "Doe") == new string[] { "John Doe", "Jane Doe" };//true
// BuscarPessoa(vetor, "Alice") == new string[] { "Alice Jones" };//true
// BuscarPessoa(vetor, "James") == new string[] { };//true

1.8

```c#
using System;
using System.Collections;

namespace Elements
{
    class Program
    {
        public static void BuscarPessoa(string[] vetor, string pessoa)
        {

            ArrayList Resultado = new ArrayList();


            for (int i = 0; i < vetor.Length; i++)
            {

                if (vetor[i].Contains(pessoa))
                    Resultado.Add(vetor[i]);
            }

            foreach (var names in Resultado)
            {
                Console.WriteLine(names);
            }
        }

        static void Main(string[] args)
        {
            string[] vetor = new string[] {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero" };

            BuscarPessoa(vetor, "Doe");
            BuscarPessoa(vetor, "Alice");
            BuscarPessoa(vetor, "Louis");

        }
    }
}


// 1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de inteiros com no máximo dois elementos.
// TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6  } }; //true 

1.9


```c# 

using System;

namespace Matriz
{
    class Transformar
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


// 1.10 Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
// // faltam elementos no vetor2
// int[] vetor1 = new int[] { 1,2,3,4,5 };
// int[] vetor2 = new int[] { 1,2,5 };
// ObterElementosFaltantes(vetor1, vetor2) == new int[] { 3, 4 }; //true 

// // faltam elementos no vetor3
// int[] vetor3 = new int[] { 1,4,5 };
// int[] vetor4 = new int[] { 1,2,3,4,5 };
// ObterElementosFaltantes(vetor3, vetor4) == new int[] { 2, 3 }; //true

// // faltam elementos em ambos vetores
// int[] vetor5 = new int[] { 1,2,3,4 };
// int[] vetor6 = new int[] { 2,3,4,5 };
// ObterElementosFaltantes(vetor5, vetor6) == new int[] { 1, 5 }; //true

// // não faltam items
// int[] vetor7 = new int[] { 1,3,4,5 };
// int[] vetor8 = new int[] { 1,3,4,5 };
// ObterElementosFaltantes(vetor7, vetor8) == new int[] { }; //true

1.10

public static Array ObterElementosFaltantes(int[] vetorA, int[] vetorB)
        {
            int[] vetorFaltantes = new int[5];
            int[] arrayAux = new int[5] { 1, 2, 3, 4, 5 };
            if (vetorA.Length != 5 || vetorB.Length != 5)
            {
                for (int i = 0; i <= 5; i++)
                {
                    if (vetorA[i] != arrayAux[i] || vetorB[i] != arrayAux[i])
                        vetorFaltantes[i] = i;
                }
            }
            return vetorFaltantes;
        }
    }
}