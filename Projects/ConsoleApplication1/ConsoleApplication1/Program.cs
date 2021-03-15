using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, peso;
            float altura, calculo;
            string resp1, resp2;
            Console.Write("Bom Dia digite seu peso: ");
            peso = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            Console.Write("Agora Digite sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());
            calculo = peso / (altura * altura);
            if (calculo >= 25)
                resp2 = "você está com sobrepeso";
            else
                resp2 = "você está com o peso normal";
            if (idade >= 18)
                resp1 = "você é maior de idade e possui "+ idade+" anos";
            else
                resp1 = "você ainda é menor de idade";
            Console.WriteLine(resp1);
            Console.WriteLine(resp2);
            Console.WriteLine(calculo);
            Console.WriteLine(altura);
            Console.ReadKey();
        }
    }
}
