using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ArrayAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExerciseOne();
            // ExerciseTwo();
            ExerciseThree();
        }

        public static void ExerciseOne()
        {
            var names = new List<string>();
            
            while(true)
            {
                Console.Write("Please input a name: ");
                var inputName = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputName))
                {
                    break;
                }

                names.Add(inputName);
            }

            if (names.Count == 1)
            {
                Console.WriteLine(names[0] + " " + "likes your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine(names[0] + " " + "and" + " " + names[1] + " " + "likes your post");
            } else if (names.Count > 2)
            {
                Console.WriteLine(names[0] + ", " + names[1] + " " + "and" + " " + (names.Count - 2) + " " + "others like your post" );
            }
        }

        public static void ExerciseTwo()
        {
            string names;
            Console.Write("Please enter your name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine(inputName.Length);
            Console.WriteLine(inputName[1]);

            char[] inputNameArray = new char[inputName.Length];
            for (var i = 0; i < inputName.Length; i++)
            {
                inputNameArray[i] = inputName[i];
            }

            Array.Reverse(inputNameArray);

            string newName = "";

            for (var i = 0; i < inputNameArray.Length; i++)
            {
                newName = newName + inputNameArray[i];
            }

            Console.WriteLine(newName);
            /*
            foreach (var inputNameArray2 in inputNameArray)
            {
                Console.WriteLine(inputNameArray2);
            } */
        }

        public static void ExerciseThree()
        {
            var listOfNumber = new List<int>();

            while (listOfNumber.Count < 5)
            {
                Console.Write("Please enter 5 unique number: ");
                var inputOfListNumber = Convert.ToInt32(Console.ReadLine());

                if (listOfNumber.Contains(inputOfListNumber))
                {
                    Console.WriteLine("You've previously entered " + inputOfListNumber);
                    continue;
                }

                listOfNumber.Add(inputOfListNumber);
            }

            listOfNumber.Sort();

            foreach (var listOfNumberx in listOfNumber)
            {
                Console.WriteLine(listOfNumberx);
            }
        }
    }
}