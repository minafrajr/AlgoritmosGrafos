using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlgoritmosGrafos
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Grafos());
            /*Algoritmos alg = new Algoritmos();
            Console.WriteLine("Digite o numero de vertices:");
            int[,] matriz  = alg.GetMatrizAdjacencia(Console.ReadLine());

            alg.imprimematriz(matriz);

            Console.ReadKey();

            alg.Wharshal(matriz);

            Console.WriteLine("matriz de alcançabilidade/n");
            alg.imprimematriz(matriz);

            Console.ReadKey();*/

        }
    }
}
