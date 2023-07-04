namespace WorkingWithTextExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
        }

        public static void ExerciseOne()
        {
            Console.WriteLine("Please enter a list of number separated by Hypen: ");
            string inputNumber = Console.ReadLine();
            string[] listOfNumber = inputNumber.Split('-');
            int[] numbers = new int[listOfNumber.Length];
            numbers[0] = Convert.ToInt32(listOfNumber[0]);
            bool isConsecutive = true;

            for (var i = 1; i < listOfNumber.Length; i++)
            {
                if (numbers[i - 1] > Convert.ToInt32(listOfNumber[i]))
                {
                    isConsecutive = false;
                    break;
                }
                else
                {
                    isConsecutive = true;
                    numbers[i] = Convert.ToInt32(listOfNumber[i]);
                }  
            }
            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }
    }
}