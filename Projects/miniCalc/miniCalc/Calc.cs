using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCalc
{
    class Calc
    {

        public int Num;

        public int Retorno(int num)
        {
            Num = num + 1;
            return Num;
        }


        public static int Triple(int num)
        {
            num = 3 * num;
            return num;
        }
    }
}
