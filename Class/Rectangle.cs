using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Rectangle
    {
        public int width {  get; set; }

        public int height { get; set; }

        public static void Area(int Width, int Height)
        {
            Console.WriteLine("The Area is {0}", Width * Height);
        }
    }
}
