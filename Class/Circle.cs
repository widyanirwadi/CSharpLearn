using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
