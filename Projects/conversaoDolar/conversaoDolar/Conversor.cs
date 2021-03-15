using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversaoDolar
{
    class Conversor
    {
        public static double CalcConversor(double cot, double dol)
        {
            return (cot * dol) * 1.06; 
        }

    }
}
