using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  num1, num2;
            Console.Write("Digite aqui o primeiro numero : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite aqui o segundo numero : ");
            num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Parça o primeiro numero que foi digitado é "+ num1 +" e o segundo foi "+ num2 +" falou e valeu.");

            Console.ReadLine();
        }
    }
}
