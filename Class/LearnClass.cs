using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class LearnClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Introduce()
        {
            Console.WriteLine("Hello my name is {0} {1}", FirstName, LastName);
        }

    }
}
