using System;
using System.Collections.Generic;
using System.Globalization;

// Desafio Maquina de vendas da Luby
namespace Program
{
    
    class Program
    {
        public static int vendas = 0;

        public static Produto[] estoque = new Produto[4];
        static void Main(string[] args)
        {
            InicializarMaquina();
            MenuInicial();
        }

        public static void MenuInicial()
        {
            Console.Clear();
            string bebidas = "    ", precos = " ", nomes = "";

            for (int i = 0; i < estoque.Length; i++)
            {
                bebidas += estoque[i].icone + "       ";
                nomes += estoque[i].nome + " | ";
                precos += TratarValor(estoque[i].preco)+ " - ";
            }

            Console.WriteLine(bebidas);
            Console.WriteLine(nomes);
            Console.WriteLine(precos);
            Console.WriteLine("");
            Console.WriteLine("Selecione uma tecla para escolher seu produto!");
            Console.WriteLine("");
            Console.WriteLine("Q - " + estoque[0].nome + " - " + estoque[0].icone);
            Console.WriteLine("W - " + estoque[1].nome + " - " + estoque[1].icone);
            Console.WriteLine("E - " + estoque[2].nome + " - " + estoque[2].icone);
            Console.WriteLine("R - " + estoque[3].nome + " - " + estoque[3].icone);
            Console.WriteLine("");
            Console.WriteLine("Caso queira ver o estoque ou sair." );
            Console.WriteLine("Aperte 'I' para ver o estoque, Z para sair.");
            SelecionarBebida(Console.ReadKey().KeyChar);

        }
    // escolha do produto desejado
        public static void SelecionarBebida(char selecaoUser)
        {
            Console.Clear();
            switch (selecaoUser)
            {
                case 'q':
                    ComprarBebida(0);
                    break;
                case 'w':
                    ComprarBebida(1);
                    break;
                case 'e':
                    ComprarBebida(2);
                    break;
                case 'r':
                    ComprarBebida(3);
                    break;
                case 'i':
                    ChecarEstoque();
                    break;
                case 'z':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Tecla Inválida! Por favor, digite novamente");
                    Console.ReadKey();
                    MenuInicial();
                    break;
            }
        }

        public static void ComprarBebida(int selecaoUser)
        {

            Console.WriteLine(estoque[selecaoUser].icone + " Custa: " + TratarValor(estoque[selecaoUser].preco));
            Console.WriteLine("Por favor, insira a quantidade de dinheiro que desejar.");

            string valorInserido = Console.ReadLine();

            if (Decimal.TryParse(valorInserido, out decimal valor))
            {
                Calcular(valor, estoque[selecaoUser].preco);
            }
            else
            {
                Console.WriteLine("Valor inválido, tente outra vez.");
                ComprarBebida(selecaoUser);
            }
        }

        // calcula valor recebe e retorna o troco
        public static void Calcular(decimal valorUser, decimal precoBebida)
        {
            decimal resultado = valorUser - precoBebida;
            if (resultado < 0M)
            {
                Console.WriteLine("Valor insulficiente, coloque o restante por favor!:" + TratarValor(resultado * -1));
                Calcular(decimal.Parse(Console.ReadLine()), resultado * -1);
            }
            else if (resultado > 0M)
            {
                vendas += 1;
                Console.WriteLine("Ok, seu troco: " + TratarValor(resultado));
                Console.WriteLine("Agora iremos retorna para o menu");
                Console.ReadKey();
                MenuInicial();
            }
            else
            {
                vendas += 1;
                Console.WriteLine("Pegue seu pedido. Voltaremos ao menu");
                Console.ReadKey();
                MenuInicial();
            }
        }
        // estoque
        public static void ChecarEstoque()
        {
            Console.WriteLine("Temos os seguintes produtos no estoque: ");
            for (int i = 0; i < estoque.Length; i++)
            {
                Console.WriteLine(estoque[i].icone + " " + estoque[i].nome + " - Preço: " + TratarValor(estoque[i].preco) + ", Em Estoque: " + estoque[i].qtd);
            }
            Console.WriteLine();
            Console.WriteLine("Realizamos " + vendas + " vendas.");
            Console.ReadKey();
            MenuInicial();
        }


        public static void InicializarMaquina()
        {
            estoque[0] = new Produto("Coca-Cola", 5.50m, 5, "_");
            estoque[1] = new Produto("Dolly", 7.50m, 6, "_");
            estoque[2] = new Produto("Itubaina", 6.50m, 4, "_");
            estoque[3] = new Produto("Fanta uva", 5.00m, 7, "_");
        }
        public static string TratarValor(decimal valorUser)
        {
            
            string formato = "C", valorTratado;
            var moeda = new System.Globalization.CultureInfo("pt-BR");

            valorTratado = valorUser.ToString(formato, moeda);

            return valorTratado;
        }


        public class Produto
        {
            public string nome;
            public decimal preco;
            public int qtd;
            public string icone;
            
            public Produto(string marca, decimal valor, int estoque, string icon)
            {
                nome = marca;
                preco = valor;
                qtd = estoque;
                icone = icon;
            }
        }
    }
}