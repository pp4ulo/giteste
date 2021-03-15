using System;

using System.Globalization;

namespace controleProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int Qtd = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(Nome, Preco, Qtd);

            Console.WriteLine("");
            Console.WriteLine("Dados do Produto: " + p1.Nome + ", $ " + p1.Preco + ", " + p1.Qtd + " unidades, " + p1.ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            p1.AdicionarProdutos(valor);
            Console.WriteLine(p1);
            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            p1.RemoverProdutos(valor);
            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
