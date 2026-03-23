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
            Console.WriteLine("Homework 6");
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

            Console.WriteLine("1");
            Console.Write("Enter miles >> ");
            double miles = Convert.ToDouble(Console.ReadLine());

            double kilometers = ConvertMilesToKilometers(miles);

            Console.WriteLine("{0} miles is {1} kilometers", miles, kilometers);
            Pause();
        }

        private static double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.60934;
        }

        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("2");
            Console.Write("Enter number of books that are overdue >> ");
            int books = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of days that the {0} books are overdue >> ", books);
            int days = Convert.ToInt32(Console.ReadLine());

            DisplayLibraryFine(books, days);
            Pause();
        }

        private static void DisplayLibraryFine(int books, int days)
        {
            double fine;

            if (days <= 7)
            {
                fine = books * days * 0.10;
            }
            else
            {
                fine = (books * 7 * 0.10) + (books * (days - 7) * 0.20);
            }

            Console.WriteLine("The fine for {0} book(s) for {1} day(s) is {2}",
                books, days, fine.ToString("C"));
        }

        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("3");

            DisplayMealTip(30.00, 0.20);
            Console.WriteLine();
            DisplayMealTip(30.00, 5);

            Pause();
        }

        private static void DisplayMealTip(double mealPrice, double tipPercent)
        {
            double tipDollars = mealPrice * tipPercent;
            double totalBill = mealPrice + tipDollars;

            Console.WriteLine("Meal price: {0}. Tip percent: {1}",
                mealPrice.ToString("C"), tipPercent.ToString("F2"));
            Console.WriteLine("Tip in dollars: {0}. Total bill {1}",
                tipDollars.ToString("C"), totalBill.ToString("C"));
        }

        private static void DisplayMealTip(double mealPrice, int tipDollars)
        {
            double tipPercent = tipDollars / mealPrice;
            double totalBill = mealPrice + tipDollars;

            Console.WriteLine("Meal price: {0}. Tip percent: {1}",
                mealPrice.ToString("C"), tipPercent.ToString("F2"));
            Console.WriteLine("Tip in dollars: {0}. Total bill {1}",
                tipDollars.ToString("C"), totalBill.ToString("C"));
        }

        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("4");

            int firstInt = 23;
            int middleInt = 45;
            int lastInt = 67;

            Console.WriteLine("The numbers are {0}, {1}, {2}", firstInt, middleInt, lastInt);

            ReverseEnds(ref firstInt, ref middleInt, ref lastInt);

            Console.WriteLine("The numbers are {0}, {1}, {2}", firstInt, middleInt, lastInt);

            Pause();
        }

        private static void ReverseEnds(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            int temp = firstInt;
            firstInt = lastInt;
            lastInt = temp;
        }

        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("5");

            FancyDisplay(33);
            FancyDisplay(44, '@');
            FancyDisplay(55.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');

            Pause();
        }

        private static void FancyDisplay(int num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num);
        }

        private static void FancyDisplay(double num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num.ToString("C"));
        }

        private static void FancyDisplay(string word, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, word);
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}