using System;

namespace vetorHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inquilinato[] vetor = new Inquilinato[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Inquilinato(nome, email, quarto);
                Console.WriteLine();
            }
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    
                    Console.WriteLine(vetor[i]);
                }
            }

        }
    }
}
