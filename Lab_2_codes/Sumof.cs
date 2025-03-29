using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Lab_2
{
    class Sumof
    {
        public int SumofNatural(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                 sum = sum + i;
            }
            return sum;
        }

        public int SumofArray(int[] a, int n)
        {
            int sum1 = 0;
            for (int i = 0; i < n;i++)
            {
                sum1 = sum1 + a[i];
            }
            return sum1;
        }
    }
}
