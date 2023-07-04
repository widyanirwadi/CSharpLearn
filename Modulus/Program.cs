using System.Runtime.ExceptionServices;

namespace Modulus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int modulus = 10;
            modulus %= 3;

            int nilai = 10;
            nilai-=10;

            //Console.WriteLine(modulus);

            int[] numbers = new int[5] {1, 2, 3, 4, 5};

            Array.Clear(numbers, 5, 1);
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}