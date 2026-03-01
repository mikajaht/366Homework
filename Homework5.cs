using System;

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
            Console.WriteLine("Homework 5");
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

                case "e":
                    return false;

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

            Console.Clear();
            Console.WriteLine("1");

            int[] scores = new int[8];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = ReadInt($"Please enter score for test number {i + 1} >> ");
            }

            double total = 0;
            for (int i = 0; i < scores.Length; i++)
                total += scores[i];

            double average = total / scores.Length;

            Console.WriteLine();
            Console.WriteLine("Scores for the tests are:");
            Console.WriteLine();

            for (int i = 0; i < scores.Length; i++)
            {
                double diff = scores[i] - average;
                Console.WriteLine($"Test # {i}: {scores[i],5} From average: {diff,8:0.000}");
            }

            Console.WriteLine();
            Console.WriteLine($"    Total is {total:0}");
            Console.WriteLine($"Average is {average:0.000}");

            Pause();
        }

        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.Clear();
            Console.WriteLine("2");

            int[] temps = new int[5];

            for (int i = 0; i < temps.Length; i++)
            {
                temps[i] = ReadIntInRange($"Enter temperature {i + 1} >> ", -30, 130);
            }

            bool gettingWarmer = true;
            bool gettingCooler = true;

            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] < temps[i - 1])
                    gettingWarmer = false;

                if (temps[i] >= temps[i - 1])
                    gettingCooler = false;
            }

            Console.WriteLine();

            if (gettingWarmer)
                Console.Write("Getting warmer: ");
            else if (gettingCooler)
                Console.Write("Getting cooler: ");
            else
                Console.Write("It's a mixed bag: ");

            for (int i = 0; i < temps.Length; i++)
                Console.Write($"{temps[i],4}");

            double total = 0;
            for (int i = 0; i < temps.Length; i++)
                total += temps[i];

            double average = total / temps.Length;

            Console.WriteLine();
            Console.WriteLine($"Average is {average:0.00}");

            Pause();
        }

        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.Clear();
            Console.WriteLine("3");

            int nights = ReadIntInRange("How many nights is your stay? ", 1, 365);

            double rate;

            if (nights <= 2)
                rate = 200.00;
            else if (nights <= 4)
                rate = 180.00;
            else if (nights <= 7)
                rate = 160.00;
            else
                rate = 145.00;

            double total = rate * nights;

            Console.WriteLine($"Price per night is {rate:C2}");
            Console.WriteLine($"Total for {nights} night(s) is {total:C2}");

            Pause();
        }

        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.Clear();
            Console.WriteLine("4");
            Console.WriteLine();

            int[] numbers = { 12, 15, 22, 88 };
            double total = 0;

            Console.Write("The numbers are...");
            for (int x = 0; x < numbers.Length; ++x)
                Console.Write("{0,6}", numbers[x]);

            Console.WriteLine();

            for (int x = 0; x < numbers.Length; ++x)
                total += numbers[x];

            double average = total / numbers.Length;

            Console.WriteLine("The average is {0}", average);

            Pause();
        }

        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.Clear();
            Console.WriteLine("5");

            const int QUIT = 999;
            int[] numbers = new int[100];
            int x = 0;
            double total = 0;

            Console.Write("Please enter a number or " + QUIT + " to quit...");
            string inString = Console.ReadLine();
            int num = Convert.ToInt32(inString);

            while (x < numbers.Length && num != QUIT)
            {
                numbers[x] = num;
                total += numbers[x];
                ++x;

                Console.Write("Please enter a number or " + QUIT + " to quit...");
                inString = Console.ReadLine();
                num = Convert.ToInt32(inString);
            }

            Console.WriteLine("The numbers are:");

            for (int y = 0; y < x; ++y)
                Console.Write("{0,6}", numbers[y]);

            Console.WriteLine();

            if (x > 0)
            {
                double average = total / x;
                Console.WriteLine("The average is {0}", average.ToString("0.##"));
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }

            Pause();
        }

        // ---------------- Helper Methods ----------------

        private static int ReadInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a whole number.");
            }
        }

        private static int ReadIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                int value = ReadInt(prompt);
                if (value >= min && value <= max)
                    return value;

                Console.WriteLine($"Out of range. Enter a value from {min} to {max}.");
            }
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}