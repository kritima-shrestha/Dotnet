using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Lab_2
{
    class CheckNumber
    {
        public bool Checkoddeven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CheckLargest(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public bool isPrime(int num_prime)
        {
            int count = 0;
            for (int i = 1; i <= num_prime; i++)
            {
                if (num_prime % i == 0)
                {
                    count++;
                }
            }
            if (count <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
