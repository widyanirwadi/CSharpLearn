namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heightValue;
            double widthValue;
            double lengthValue;

            Console.WriteLine("Please enter of Height value: ");
            heightValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter of Width value: ");
            widthValue = double.Parse(Console.ReadLine());

            lengthValue = heightValue * widthValue;
            Console.WriteLine(heightValue + " * " + widthValue + " is " + lengthValue);

        }
    }
}