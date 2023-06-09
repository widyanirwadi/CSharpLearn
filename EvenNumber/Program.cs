namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            List<int> numbers = new List<int>();
            int evenNumber = 0;

            Console.WriteLine("Please enter two number.");
            Console.WriteLine("First Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)  {
                numbers.Add(i);
            }

            foreach (int j in numbers)
            {
                if (j % 2 == 0)
                {
                    evenNumber = evenNumber + 1;
                }
            }

            Console.WriteLine("Count of even number from range is {0}", evenNumber);
        }
    }
}