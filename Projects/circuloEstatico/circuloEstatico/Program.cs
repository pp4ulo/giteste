using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace circuloEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.Write("Entre o valor do raio :");
            double raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio)
;
            Console.WriteLine("Circunferencia: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI :" + Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
