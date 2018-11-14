using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", primeFactor(10000)));
            
            Console.ReadLine(); 
        }

        private static List<int> primeFactor(int v)
        {
            List<int> primeFactors = new List<int>();

            int i = 1;

            while (v != 1)
            {
                int divisor = generatePrimeNumber(i)[generatePrimeNumber(i).Count-1];

                if (v%divisor == 0)
                {
                    primeFactors.Add(divisor);
                    v /= divisor;
                }

                else
                    i++;
            }

            return primeFactors;
        }

        private static List<int> generatePrimeNumber(int v)
        {
            List<int> numList = new List<int>();

            for (int i = 2; true; i++)
            {
                if (checkPrime(i))
                {
                    if (numList.Count < v)
                        numList.Add(i);
                    else
                        break;
                }
            }

            return numList;
        }

        private static bool checkPrime(int v)
        {
            for (int i = 2; i < v; i++)
            {
                if (v % i == 0)
                    return false;
            }

            return true;
        }
    }
}
