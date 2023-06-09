using System;

namespace FindPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int rangeNumber = int.Parse(Console.ReadLine());
            IsPrimeNumber(rangeNumber);
        }

        public static void IsPrimeNumber(int rangeNumber)
        {
            bool[] isPrimeNumber = new bool[rangeNumber + 1];

            for (int i = 2; i <= rangeNumber; i++)
            {
                isPrimeNumber[i] = true;
            }

            for (int p = 2; p * p <= rangeNumber; p++)
            {
                if (isPrimeNumber[p] == true)
                {
                    for (int i = p * p; i <= rangeNumber; i += p)
                    {
                        isPrimeNumber[i] = false;
                    }
                }
            }

            if (isPrimeNumber[rangeNumber] == true)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}