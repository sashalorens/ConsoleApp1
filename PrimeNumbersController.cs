using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PrimeNumbersController
    {
        private bool isPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2) {
                return true;
            }

            double root = Math.Sqrt(number);
            // a prime number can't have an integer square root
            if (root % 1 == 0)
            {
                return false;
            }
            int boundary = (int)root;

            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public int sumOfNPrimes(int amount)
        {
            int sum = 0;
            int counter = 0;
            int number = 2;

            while (counter < amount)
            {
                if (isPrime(number))
                {
                    sum += number;
                    counter++;
                }
                number++;
            }
            return sum;
        }
    }
}
