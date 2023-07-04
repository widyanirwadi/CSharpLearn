using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace ControlFlowExrecise
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

        // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        public static void ExerciseOne()
        {
            Console.WriteLine("Please Enter a To Range Value: ");

            int inputToRange   = Convert.ToInt32(Console.ReadLine());
            int numberOfValues = 0;

            for (var i = 1; i <= inputToRange; i++)
            {
                if (i % 3 == 0)
                {
                    numberOfValues = numberOfValues + 1;
                    Console.WriteLine("{0} % 3 = 0", i);
                }
            }

            Console.WriteLine("Number of Values: " + numberOfValues);
        }

        // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered 
        // numbers and display it on the console.
        public static void ExerciseTwo()
        {

            Console.WriteLine("Please Enter a Number or \"ok\" to Exit.");
            int grandTotals = 0;
            while (true) 
            {
                string inputNumber = Console.ReadLine();
                
                if (inputNumber == "ok")
                {
                    break;
                } else
                {
                    grandTotals = grandTotals + Convert.ToInt32(inputNumber);
                }
            }
            Console.WriteLine("Sum of total number is: {0}", grandTotals);
        }

        // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
        // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void ExerciseThree()
        {
            Console.WriteLine("Please enter a valid number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int grandTotals = 1;
            
            for (var i = 1; i <= inputNumber; i++)
            {
                grandTotals = grandTotals * i;
            }
            Console.WriteLine("{0}! = {1}", inputNumber, grandTotals);
        }

        // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        // If the user guesses the number, display “You won"; otherwise, display “You lost".
        // (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void ExerciseFour()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10);
            Console.WriteLine(randomNumber);

            for (var i = 1; i <= randomNumber; i++)
            {
                Console.WriteLine("Please enter your guess number between 1 to 10: ");
                string inputNumber = Console.ReadLine();
                
                if (Convert.ToInt32 (inputNumber) == randomNumber)
                {
                    Console.WriteLine("Your guess is correct, used only {0} chance", randomNumber - i);
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    if (i == randomNumber)
                    {
                        Console.WriteLine("You lose");
                    } else
                    {
                        Console.WriteLine("Your guess is incorrect, you only have {0} chance", randomNumber - i);
                    }
                }
            }
        }

        // Write a program and ask the user to enter a series of numbers separated by comma.
        // Find the maximum of the numbers and display it on the console.
        // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void ExerciseFive()
        {
            Console.WriteLine("Please enter lists of number: ");
            string inputValue = Console.ReadLine();
            string[] listOfNumber = inputValue.Split(',');
            int max = int.MinValue;

            foreach (string number in listOfNumber)
            {
                int currentNumber = int.Parse(number.Trim());
                Console.WriteLine(currentNumber);
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine("Nilai maksimum adalah: " + max);
        }
    }
}