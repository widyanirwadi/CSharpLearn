using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class MyClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public static void SayMyName(string FirstName, string LastName, int Age)
        {
            Console.WriteLine("Hello my name is {0} {1} and my Age is {2}", FirstName, LastName, Age);
        }
    }
}
