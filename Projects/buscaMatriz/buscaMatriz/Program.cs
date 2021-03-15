using System;

namespace buscaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] esboco = Console.ReadLine().Split(' ');
            int l = int.Parse(esboco[0]), c = int.Parse(esboco[1]);
            int[,] matriz = new int[l, c];

            for (int i =0; i < l; i++)
            {
                string[] valoreslinha = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    matriz[i,j] = int.Parse(valoreslinha[j]);
                }
            }

            int pesquisa = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matriz[i,j] == pesquisa)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Posição "+ i +", "+j);
                        if (i > 0){
                            Console.WriteLine("Cima: "+ matriz[i-1,j]);
                        }
                        if (i < (l - 1))
                        {
                            Console.WriteLine("Baixo: " + matriz[i + 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (j < c - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                    }
                }
            }
        }
    }
}