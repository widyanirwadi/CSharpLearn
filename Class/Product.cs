using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public static double ExtendedPrice(double Price, int Quantity)
        {
            double extendedPrice = Price * Quantity;
            return extendedPrice;
        }
    }
}
