using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double[] Grades { get; set; }

        public static void AverageGrades(double firstValue, double secondValue, double thirdValue)
        {
            Console.WriteLine("The Average is {0}", (firstValue + secondValue + thirdValue) / 3);
        }
    }
}
