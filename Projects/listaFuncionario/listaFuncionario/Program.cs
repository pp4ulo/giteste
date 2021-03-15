using System;
using System.Collections.Generic;
using System.Globalization;

namespace listaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string nome;
            double salario, porcentagem;
            List<Empregado> lista = new List<Empregado>();
            Console.Write("Quantos empregados serão serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Empregado #"+(i+1));
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Empregado(id, nome, salario));
                Console.WriteLine("");
            }

            Console.Write("Informe o numero do ID do funcionário: ");
            id = int.Parse(Console.ReadLine());
            Empregado emp = lista.Find(x => x.ID == id);
            if (emp != null)
            {
                Console.Write("Informe a porcentagem de aumento: ");
                porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentarSalario(porcentagem);
            } else
            {
                Console.WriteLine("Funcionário não localizado trouxa ");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de empregados");
            foreach (Empregado item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
