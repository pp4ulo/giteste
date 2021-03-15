using System;
using System.Globalization;

namespace Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {

            int conta;
            string nome;
            double valor;
            ContaCorrente cc1;

            Console.Write("Entre o numero da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());

            if (op == 's')
            {
                Console.Write("Enter o valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cc1 = new ContaCorrente(conta, nome, valor);
            } else
            {
                cc1 = new ContaCorrente(conta, nome);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(cc1);

            Console.WriteLine("");
            Console.Write("Entre um valor para deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc1.Deposito(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cc1);

            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc1.Saque(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cc1);
        }
    }
}
