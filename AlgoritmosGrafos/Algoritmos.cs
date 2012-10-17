using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmosGrafos
{
    public class Algoritmos
    {

        int linha, coluna, Vertices;
        int[,] M;

        /// <summary>
        /// Calcula a matriz de alcancibilidade de um grafo
        /// </summary>
        /// <param name="linhas">O número de linhas da matriz de adjacência</param>
        /// <param name="colunas">O número de colunas da matriz de adjacência</param>
        /// <param name="vertices">O número de vértices do grafo</param>
        /// <returns></returns>
        public int[,] Wharshal(int linhas, int colunas, int vertices)
        {
            this.linha = linhas;
            this.coluna = colunas;
            this.Vertices = vertices;

            if (linha == coluna)
            {
                M = new int[linha, coluna];

                for (int k = 0; k < Vertices - 1; k++)
                {
                    for (int i = 1; i < Vertices; i++)
                    {
                        for (int j = 1; j < Vertices; j++)
                        {
                            M[i, j] = M[i, j] + (M[i, k + 1] * M[k + 1, j]);
                        }
                    }
                }
                return M;
            }
            else
                return null;

        }

        public int[,] Wharshal(int[,] M)
        {
            for (int k = 0; k < Math.Sqrt(M.Length) - 1; k++)
            {
                for (int i = 0; i < Math.Sqrt(M.Length) - 1; i++)
                {
                    for (int j = 0; j < Math.Sqrt(M.Length) - 1; j++)
                    {
                        M[i, j] = M[i, j] + (M[i, (k + 1)] * M[(k + 1), j]);
                    }
                }
            }
                return M;
        }
        /// <summary>
        /// Verifica se o grafo possui um caminho euleriano
        /// </summary>
        /// <param name="M">A matriz de adjacência do grafo</param>
        /// <param name="vertices">O número de vértices do grafo</param>
        /// <returns>true ou false</returns>
        public bool CaminhoEuler(int[,] M, int vertices)
        {
            this.Vertices = vertices;
            bool caminho = false;

            if (Vertices % 2 == 0)
            {
                int total = 0;
                int i = 1;

                while (total <= 2 && i <= Vertices)
                {
                    int grau = 0;

                    for (int j = 0; j < Vertices; j++)
                        grau = grau + M[i, j];

                    if (grau % 2 == 1)
                        total = total + 1;

                    i = i + 1;
                }
                if (total > 2)
                    caminho = true;
                else
                    caminho = false;
            }
            return caminho;
        }

        /// <summary>
        /// Entrada de dados para uma matriz de adjacência
        /// </summary>
        /// <param name="numvertices">O número de vértices do grafo</param>
        /// <returns></returns>
        public int[,] GetMatrizAdjacencia(string numvertices)
        {
            int vertices = int.Parse(numvertices);
            int[,] M = new int[vertices, vertices];

            //linha
            for (int i = 0; i <= vertices - 1; i++)
            {
                //coluna
                for (int j = 0; j <= vertices - 1; j++)
                {
                    Console.Write("Digite o valor do posição A[" + (i+1) + "," + (j+1) + "]: ");
                    M[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return M;
        }

        public void imprimematriz(int[,]m)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i <= Math.Sqrt(m.Length) - 1; i++)
            {
                for (int j = 0; j <= Math.Sqrt(m.Length) - 1; j++)
                {
                    Console.Write("\t{0}  ", m[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
