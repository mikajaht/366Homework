using System;
using System.Numerics;

namespace Homework_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            // Add code for Exercise 1 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            const double CENTIMETERS_PER_INCH = 2.54;
            double inches = 3;
            double centimeters = inches * CENTIMETERS_PER_INCH;

            Console.WriteLine("Exercise 1");
            Console.WriteLine($"{inches} inches is {centimeters:F2} centimeters");
        }
        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            const double CENTIMETERS_PER_INCH = 2.54;

            Console.WriteLine("Exercise 2");
            Console.Write("Enter a value in inches >> ");
            double inches = Convert.ToDouble(Console.ReadLine());

            double centimeters = inches * CENTIMETERS_PER_INCH;
            Console.WriteLine($"{inches} inches is {centimeters:F2} centimeters");
        }
        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            Console.WriteLine("Exercise 3");
            Console.Write("Enter Fahrenheit degrees >> ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit:F1} F is {celsius:F1} C");
        }
        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            Console.Write("Enter a number to see the planet at that position >> ");
            int position = Convert.ToInt32(Console.ReadLine());

            Planet selectedPlanet = (Planet)position;

            Console.WriteLine($"You entered {position}");
            Console.WriteLine($"{selectedPlanet} is {position} planet(s) from the sun");
        }
        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            string name;
            string firstString, secondString;
            int first, second, product;

            Console.Write("Enter your name >> ");
            name = Console.ReadLine();

            Console.Write("Hello, {0}! Enter an integer >> ", name);
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);

            Console.Write("Enter another integer >> ");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);

            product = first * second;

            Console.WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
                name, first, second, product);
        }
    }
}
