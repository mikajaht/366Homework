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
            Console.WriteLine("Homework 9");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");

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

                case "e":
                    return true;

                default:
                    Console.WriteLine("Invalid selection.");
                    Pause();
                    return true;
            }
        }

        private static void DoExe1()
        {
            // Exercise 1: SubscriptExceptionTest
            double[] array = { 20.3, 44.6, 32.5, 46.7, 89.6, 67.5, 12.3, 14.6, 22.1, 13.6 };

            int subscript = 0;

            while (subscript != 99)
            {
                try
                {
                    Console.Write("Enter a subscript value or 99 to quit >> ");
                    subscript = Convert.ToInt32(Console.ReadLine());

                    if (subscript != 99)
                    {
                        Console.WriteLine("The value is {0}", array[subscript]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index was outside the bounds of the array.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a whole number.");
                }
            }

            Pause();
        }

        private static void DoExe2()
        {
            // Exercise 2: FindSquareRoot
            double number;
            double squareRoot = 0;

            try
            {
                Console.Write("Enter a number ");
                number = Convert.ToDouble(Console.ReadLine());

                if (number < 0)
                {
                    throw new ApplicationException("Number can't be negative.");
                }

                squareRoot = Math.Sqrt(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input could not be converted to a number.");
                squareRoot = 0;
            }
            catch (ApplicationException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                squareRoot = 0;
            }

            Console.WriteLine("Square root is {0}", squareRoot);

            Pause();
        }

        private static void DoExe3()
        {
            // Exercise 3: StudentGradeDemo
            try
            {
                ReportCard card1 = new ReportCard("Adams", 80, 85);
                card1.Display();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} {1}", "card1", e.Message);
            }

            try
            {
                ReportCard card2 = new ReportCard("Brown", 20, 75);
                card2.Display();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} {1}", "card2", e.Message);
            }

            try
            {
                ReportCard card3 = new ReportCard("Cook", 100, 99);
                card3.Display();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} {1}", "card3", e.Message);
            }

            try
            {
                ReportCard card4 = new ReportCard("Dee", -1, 85);
                card4.Display();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} {1}", "card4", e.Message);
            }

            try
            {
                ReportCard card5 = new ReportCard("Edwards", 80, 101);
                card5.Display();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} {1}", "card5", e.Message);
            }

            Pause();
        }

        private static void DoExe4()
        {
            // Exercise 4: Debugged salary validation code
            double salary = 0;
            string salVal;
            bool isValidSalary = false;

            while (!isValidSalary)
            {
                try
                {
                    Console.Write("Enter an employee's salary ");
                    salVal = Console.ReadLine();
                    salary = Convert.ToDouble(salVal);
                    isValidSalary = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a number for the salary.");
                }
            }

            Console.WriteLine("The salary {0} is valid", salary.ToString("C2"));

            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    class ReportCard
    {
        private string studentName;
        private double midtermGrade;
        private double finalExamGrade;
        private double average;
        private char letterGrade;

        public ReportCard(string name, double midterm, double finalExam)
        {
            if (midterm < 0 || midterm > 100 || finalExam < 0 || finalExam > 100)
            {
                throw new ArgumentException("Value does not fall within the expected range.");
            }

            studentName = name;
            midtermGrade = midterm;
            finalExamGrade = finalExam;

            average = (midtermGrade + finalExamGrade) / 2;
            letterGrade = DetermineLetterGrade();
        }

        private char DetermineLetterGrade()
        {
            if (average >= 90)
                return 'A';
            else if (average >= 80)
                return 'B';
            else if (average >= 70)
                return 'C';
            else if (average >= 60)
                return 'D';
            else
                return 'F';
        }

        public void Display()
        {
            Console.WriteLine("{0} report card created.", studentName);
            Console.WriteLine("   Midterm: {0}   Final: {1}", midtermGrade, finalExamGrade);
            Console.WriteLine("   Average: {0}   Grade: {1}", average, letterGrade);
        }
    }
}