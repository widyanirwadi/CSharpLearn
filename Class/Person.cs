using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Class
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public static void Hello(string Name, int Age)
        {
            Console.WriteLine("Hello my name is {0} and my age is {1}", Name, Age);
        }
    }
}
