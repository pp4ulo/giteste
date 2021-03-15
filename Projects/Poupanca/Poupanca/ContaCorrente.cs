using System.Globalization;

namespace Poupanca
{
    class ContaCorrente
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public ContaCorrente(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaCorrente(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }


        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo -valor - 5;
        }



        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: R$" + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}
