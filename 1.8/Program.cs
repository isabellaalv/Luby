// <!-- // 1.8 Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
// // string[] vetor = new string[] {
// //     "John Doe",
// //     "Jane Doe",
// //     "Alice Jones",
// //     "Bobby Louis",
// //     "Lisa Romero"
// // };

// // BuscarPessoa(vetor, "Doe") == new string[] { "John Doe", "Jane Doe" };//true
// // BuscarPessoa(vetor, "Alice") == new string[] { "Alice Jones" };//true
// // BuscarPessoa(vetor, "James") == new string[] { };//true -->

using System;
using System.Collections;

namespace Elements
{
    class Program
    {
        public static void BuscarPessoa(string[] vetor, string pessoa)
        {

            ArrayList Resul = new ArrayList();


            for (int i = 0; i < vetor.Length; i++)
            {

                if (vetor[i].Contains(pessoa))
                    Resul.Add(vetor[i]);
            }

            foreach (var name in Resul)
            {
                Console.WriteLine(name);
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
