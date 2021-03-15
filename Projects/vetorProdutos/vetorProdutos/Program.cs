using System;
using System.Globalization;

namespace vetorProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Produtos[] vetor = new Produtos[n];
            double average = 0;
            for(int i = 0; i < n; i++)
            {
                vetor[i] = new Produtos();
                vetor[i].Nome = Console.ReadLine();
                vetor[i].Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                average += vetor[i].Valor;
            }

            average = average / n;
            Console.WriteLine("Average Price = "+ average.ToString("f2", CultureInfo.InvariantCulture));
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i].Nome);
            }
        }
    }
}
