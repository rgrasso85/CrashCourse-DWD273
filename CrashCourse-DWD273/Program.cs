using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_DWD273
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            int intTest = 1;
            double doubleTest = 1.1;
            bool booleanTest = true;
            char charTest = 'A';
            string stringTest = "This is a String.";
            Console.WriteLine("intTest = " + intTest + "\ndoubleTest = " + doubleTest + "\nbooleanTest = " + booleanTest + "\ncharTest = " + charTest + "\nstringTest = " + stringTest);
            */
            /*
            Random random = new Random();
            string userInput = "";
            int userNumber;
            do
            {
                Console.WriteLine("Please select a number between 1 and 3! or 'E' to Exit!");
                userInput = Console.ReadLine();
                if (userInput != "E")
                {
                    int.TryParse(userInput, out userNumber);
                    int computerNumber = random.Next(1, 4);
                    if (userNumber == computerNumber)
                    {
                        Console.WriteLine("Your guess of " +userNumber+ " was the Computers Number! YOU WIN!");
                    }
                    else {
                        Console.WriteLine("You Guessed Incorrectly! The Computers Number was " +computerNumber+ ". YOU LOSE!");
                    }
                }
            } while (userInput != "E");*/

            for (int i = 1; i <= 100; i++) {

                if (i % 3 == 0)
                {
                    if (i % 15 == 0)
                        {
                            Console.WriteLine("Fizz Buzz");
                    }else
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
