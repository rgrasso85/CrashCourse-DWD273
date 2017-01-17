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
                } while (userInput != "E");

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

                for (int i = 1; i <= 100; i++)
                {
                    if (i % 15 == 0)
                        Console.WriteLine("Fizz Buzz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else Console.WriteLine(i);
                }
            DoStuff("Robert");
            string greeting = Greeting("Robert");
            Console.WriteLine(greeting);

            Car car1 = new Car("Black");
            string description = car1.Describe();
            Console.WriteLine(description);
            string action = car1.Drive();
            Console.WriteLine(action);

            List<Car> cars = new List<Car>();
            cars.Add(new Car("Red"));
            cars.Add(new Car("Blue"));
            cars.Add(new Car("Grey"));
            cars.Add(new Car("White"));
            cars.Add(new Car("Black"));

            foreach (Car car in cars)
            {
                string description = car.Describe();
                Console.WriteLine(description);
            }*/

            /*List<Cat> cats = new List<Cat>();
             cats.Add(new Cat(2, "Kitty"));
             cats.Add(new Cat(5, "Fluffy"));
             cats.Add(new Cat(1, "Jack"));
             cats.Add(new Cat(3, "Bubba"));
             cats.Add(new Cat(4, "Shadow"));

             foreach (Cat cat in cats)
             {
                 string description = cat.Describe();
                 Console.WriteLine(description);
             }

             List<Dog> dogs = new List<Dog>();
             dogs.Add(new Dog(5, "Doge"));
             dogs.Add(new Dog(2, "Gunnar"));
             dogs.Add(new Dog(1, "Ace"));
             dogs.Add(new Dog(3, "Sassy"));
             dogs.Add(new Dog(4, "Lacy"));

             foreach (Dog dog in dogs)
             {
                 string description = dog.Describe();
                 Console.WriteLine(description);
             }*/

            var cat = new Cat();
            var dog = new Dog();
            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);
            Console.Read();





        }
        /*
        public static void DoStuff()
        {
            Console.WriteLine("Hello from DoStuff()");
        }

        public static void DoStuff(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        public static string Greeting(string name)
        {
            return "Hello, " + name;
        }
        */


    }
}
