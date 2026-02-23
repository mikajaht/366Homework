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
            Console.WriteLine("Homework 4");
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

            while (true)
            {
                Console.Write("Enter an uppercase letter or ! to quit ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    continue;

                char ch = input[0];

                if (ch == '!')
                    break;

                if (char.IsUpper(ch))
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("Sorry - that was not an uppercase letter.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.Write("Enter a phrase >> ");
            string phrase = Console.ReadLine() ?? "";

            int vowelCount = 0;

            foreach (char c in phrase)
            {
                char lower = char.ToLower(c);
                if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
                    vowelCount++;
            }

            Console.WriteLine("There are {0} vowels in {1}", vowelCount, phrase);

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            int sum = 0;

            for (int i = 1; i <= 200; i++)
            {
                sum += i;

                if (i == 100)
                {
                    Console.WriteLine("Halfway through....");
                    Console.WriteLine("    after 100 numbers, sum is {0}", sum);
                }
            }

            Console.WriteLine("The sum of the integers 1 through 200 is {0}", sum);

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;

            double price = 0;
            string stockNum;

            Console.Write("Please enter the stock number of the item you want ");
            stockNum = Console.ReadLine();

            while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();
            }

            if (stockNum == ITEM209)
                price = PRICE209;
            else if (stockNum == ITEM312)
                price = PRICE312;
            else
                price = PRICE414;

            Console.WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C"));

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            const double LIMIT = 1000000.00;
            const double START = 0.01;

            string inputString;
            double total;
            int howMany;
            int count;

            Console.Write("How many days do you think ");
            Console.WriteLine("it will take you to reach");
            Console.WriteLine("{0} starting with {1}",
                LIMIT.ToString("C"), START.ToString("C"));
            Console.WriteLine("and doubling it every day?");

            inputString = Console.ReadLine();
            howMany = Convert.ToInt32(inputString);

            count = 0;
            total = START;

            while (total < LIMIT)
            {
                total = total * 2;
                count = count + 1;
            }

            if (howMany > count)
                Console.WriteLine("Your guess was too high.");
            else if (howMany < count)
                Console.WriteLine("Your guess was too low.");
            else
                Console.WriteLine("Your guess was correct.");

            Console.WriteLine("It takes {0} days to reach {1}",
                count, LIMIT.ToString("C"));
            Console.WriteLine("when you double {0} every day",
                START.ToString("C"));

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}