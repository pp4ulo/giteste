using System;
using System.Globalization;

namespace vetorAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma=0;
            double[] vetor = new double[n];

            for (int i=0;i<n;i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vetor[i];
            }

            soma = soma / n;
            Console.WriteLine("A média é :"+ soma.ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
