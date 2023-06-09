namespace StringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringValue;
            int stringLength;

            Console.WriteLine("Please enter any text");
            stringValue = Console.ReadLine();
            stringLength = stringValue.Length;

            Console.WriteLine("Length of {0} is {1}", stringValue, stringLength);

        }
    }
}