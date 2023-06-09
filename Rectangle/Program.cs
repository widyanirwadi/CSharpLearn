namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rectangleRows = 0;
            Console.WriteLine("Please input rows of Rectangle: ");
            rectangleRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rectangleRows; i++)
            {
                for (int j = 1; j <= rectangleRows - i; j++)
                {
                    Console.Write(" ");
                }

                // Mencetak karakter pada setiap baris
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                // Pindah ke baris baru setelah mencetak karakter pada setiap baris
                Console.WriteLine();
            }
        }
    }
}