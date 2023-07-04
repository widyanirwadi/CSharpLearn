using Microsoft.VisualBasic;
using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;

namespace ArrayAndListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExerciseOne();
            // ExerciseTwo();
            // ExerciseThree();
            // ExerciseFour();
            // ExerciseFive();
        }

        // When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        // 1. If no one likes your post, it doesn't display anything.
        // 2. If only one person likes your post, it displays: [Friend's Name] likes your post.
        // 3. If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        // 4. If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        // Depending on the number of names provided, display a message based on the above pattern.
        public static void ExerciseOne()
        {
            Console.WriteLine("Please enter a valid name: ");
            List<string> personName = new List<string>();
            
            while (true)
            {
                string inputName = Console.ReadLine();

                if (string.IsNullOrEmpty(inputName))
                    break;

                personName.Add(inputName);
            }

            if (personName.Count > 2)
                Console.WriteLine("{0}, {1}, and {2} others like your post", personName[0], personName[1], personName.Count - 2);
            else if (personName.Count == 2)
                Console.WriteLine("{0} and {1} like your post", personName[0], personName[1]);
            else if (personName.Count == 1)
                Console.WriteLine("{0} like your post", personName[0]);
            else
                Console.WriteLine();
        }

        // Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
        // Display the reversed name on the console.
        public static void ExerciseTwo()
        {
            Console.WriteLine("Please enter your full name: ");
            string fullName = Console.ReadLine();
            char[] splitFullName = fullName.ToCharArray();            
            Array.Reverse(splitFullName);
            string reversed = new (splitFullName);

            Console.WriteLine(reversed);
        }

        // Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
        // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void ExerciseThree()
        {
            List <int>listOfNumber = new List<int>();

            while(listOfNumber.Count < 5)
            {
                Console.WriteLine("Please enter a different 5 numbers: ");
                int inputOfNumber = Convert.ToInt32(Console.ReadLine());
                
                if(listOfNumber.Contains(inputOfNumber))
                {
                    Console.WriteLine("You've enter this number");
                    continue;
                }
                listOfNumber.Add(inputOfNumber);
            }

            listOfNumber.Sort();

            foreach(int number in listOfNumber)
                Console.WriteLine(number);
        }

        // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
        // Display the unique numbers that the user has entered.
        public static void ExerciseFour()
        {
            List<int> numbers = new List<int>();

            while(true)
            {
                Console.WriteLine("Please enter a valid number or type Quit to exit.");
                string listOfNumber = Console.ReadLine();

                if (listOfNumber == "Quit")
                    break;
                
                numbers.Add(Convert.ToInt32(listOfNumber));
            }

            numbers.Sort();

            IEnumerable <int> uniqueNumber = numbers.Distinct();
            string myNumbers = "";

            foreach (int number in uniqueNumber)
                myNumbers = myNumbers + " " + number;
            
            Console.Write("Your List of number: {0}", myNumbers);
        }

        // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
        // display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        public static void ExerciseFive()
        {
            string[] elements;

            while(true)
            {
                Console.WriteLine("Please enter a list of number separated by comma: ");
                string listOfNumber = Console.ReadLine();
                
                if(!string.IsNullOrWhiteSpace(listOfNumber))
                {
                    elements = listOfNumber.Split(',');
                    if (elements.Length > 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}