using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1, t2;
            t1 = new Triangulo();
            t2 = new Triangulo();

            Console.WriteLine("Digite os lados do primeiro triangulo");
            Console.Write("Lado A: ");
            t1.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            t1.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            t1.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite os lados do segundo triangulo");
            Console.Write("Lado A: ");
            t2.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            t2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            t2.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           // double areat1 = ;
           // double areat2 = t2.area();

            Console.WriteLine("A area do 1 triangulo é :" + t1.area());
            Console.WriteLine("A area do 2 triangulo é :" + t2.area().ToString("f4", CultureInfo.InvariantCulture));
            if(t1.area() > t2.area())
            {
                Console.WriteLine("O primeiro triangulo e maior");
            } else
            {
                Console.WriteLine("O segundo triangulo é maior");
            }

            Console.ReadLine();


        }
    }
}
