using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Lab_2
{
    class Factorial
    {
        public int Facto(int numfacto)
        {
            int fact = 1;
            for (int i = 1; i <= numfacto; i++)
                fact = fact * i;
            return fact;
        }
    }
}
