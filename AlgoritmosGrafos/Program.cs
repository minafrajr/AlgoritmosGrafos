using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmosGrafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Algoritmos alg = new Algoritmos();
            Console.WriteLine("Digite o numero de vertices:");
            int[,] matriz  = alg.GetMatrizAdjacencia(Console.ReadLine());

            alg.imprimematriz(matriz);

            Console.ReadKey();

            alg.Wharshal(matriz);

            Console.WriteLine("matriz de alcançabilidade/n");
            alg.imprimematriz(matriz);

            Console.ReadKey();

        }
    }
}
