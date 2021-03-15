using System.Globalization;

namespace controleProdutos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto()
        {
            Qtd = 1;
        }


        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Nome = nome;
            Preco = preco;
            Qtd = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AdicionarProdutos(int valor)
        {
            Qtd += valor;
        }

        public void RemoverProdutos(int valor)
        {
            Qtd -= valor;
        }

        public override string ToString()
        {
            return ("Dados Atualizados: " + Nome + ", $ " + Preco + ", " + Qtd + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
