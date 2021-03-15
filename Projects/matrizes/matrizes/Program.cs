using System;
using System.Collections.Generic;

namespace matrizes { 
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            List<int> coluna = new List<int>();
            int contador = 0;
            for (int i=0; i < n; i++){
                string[] valores = Console.ReadLine().Split(' ');
                for (int y=0; y<n; y++){
                    mat[i,y] = int.Parse(valores[y]);
                    if (i == y){
                        coluna.Add(mat[i, y]);
                    }
                    if( mat[i,y] < 0){
                        contador++;
                    }
                }
            }
            Console.WriteLine("Diagonal principal");
            foreach(int num in coluna){
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de numeros negativos: "+ contador);
        }
    }
}