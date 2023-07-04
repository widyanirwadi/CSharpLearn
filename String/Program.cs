namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReferenceType();
        }

        static void ExerciseOne()
        {
            string userValue;

            while(true)
            {
                Console.Write("Please enter a value: ");
                string inputValue = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputValue))
                {
                    break;
                }
            }
        }

        public static void ReferenceType()
        {
            string myFirstName = "Widyan";
            string myFirstNameCopy = myFirstName;
            myFirstNameCopy = "";
            Console.WriteLine(myFirstName);
            Console.WriteLine(myFirstNameCopy);
        }
    }
}