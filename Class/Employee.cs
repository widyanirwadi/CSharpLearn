using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Employee
    {
        public string Name { get; set; }    
        public string Position { get; set; }

        public double Salary { get; set; }

        public static double UpSalary(double Salary, int Percentage)
        {
            return (Salary * Percentage) / 100;
        }

        public static void NewSalary(double Salary, int Percentage)
        {
            double newSalary = Salary + Employee.UpSalary(Salary, Percentage);
            Console.WriteLine("The new salary is {0}", newSalary);
        }
    }
}
