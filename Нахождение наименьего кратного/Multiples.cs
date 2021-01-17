using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Нахождение_наименьего_кратного
{
     class Multiples
    {
      public  double NOK(double a, double b, double c)
        {
            double s = a * b * c;
            for (int i = 1; i <= s; i++)
            {
                if ((i % a == 0) && (i % b == 0) && (i % c == 0))
                {
                    return i;
                }
            }
            return s;
        }

    }
}
