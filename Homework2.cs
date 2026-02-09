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

            Console.WriteLine("Good Bye...");
        }

        public static string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Homework 2");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");
            Console.WriteLine();
            Console.WriteLine("Hit [E] to Exit.");
            Console.WriteLine();

            return Console.ReadLine();
        }

        public static void Run(string choice)
        {
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Exercise1();
                    break;
                case "2":
                    Exercise2();
                    break;
                case "3":
                    Exercise3();
                    break;
                case "4":
                    Exercise4();
                    break;
                case "5":
                    Exercise5();
                    break;
            }
        }

        // ---------------- Exercise 1 ----------------
        static void Exercise1()
        {
            Console.WriteLine("Exercise 1");

            string school = "Missouri State University College of Business";

            int firstSpace = school.IndexOf(" ");
            int secondSpace = school.IndexOf(" ", firstSpace + 1);

            string secondWord = school.Substring(firstSpace + 1, secondSpace - firstSpace - 1);

            Console.WriteLine("Second word: " + secondWord);

            Pause();
        }

        // ---------------- Exercise 2 ----------------
        static void Exercise2()
        {
            Console.WriteLine("Exercise 2");

            string name = "Mikajah Tomlinson";
            DateTime now = DateTime.Now;

            Console.WriteLine("Composite Formatting");
            Console.WriteLine(
                "Hello, {0}! Today is {1}, it's {2} now.",
                name,
                now.DayOfWeek,
                now.ToString("MM/dd/yyyy h:mm tt")
            );

            Console.WriteLine();
            Console.WriteLine("String Interpolation");
            Console.WriteLine(
                $"Hello, {name}! Today is {now.DayOfWeek}, it's {now:MM/dd/yyyy h:mm tt} now."
            );

            Pause();
        }

        // ---------------- Exercise 3 ----------------
        static void Exercise3()
        {
            Console.WriteLine("Exercise 3");

            // Escaped string
            Console.WriteLine("The path is C:\\Windows\\System32");

            // Verbatim string
            Console.WriteLine(@"The path is C:\Windows\System32");

            Pause();
        }

        // ---------------- Exercise 4 ----------------
        static void Exercise4()
        {
            Console.WriteLine("Exercise 4");

            const double WITHHOLDING_RATE = 0.15;

            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;

            Console.Write("Enter the number of hours you worked this week >> ");
            hoursAsString = Console.ReadLine();

            Console.Write("Enter your hourly rate >> ");
            rateAsString = Console.ReadLine();

            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);

            gross = hours * rate;
            withholding = gross * WITHHOLDING_RATE;
            net = gross - withholding;

            Console.WriteLine("You worked {0} hours at {1} per hour", hours, rate.ToString("C"));
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Withholding is {0}", withholding.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C"));

            Pause();
        }

        // ---------------- Exercise 5 ----------------
        static void Exercise5()
        {
            Console.WriteLine("Exercise 5");

            string name, bossName;
            bool areNamesTheSame;

            Console.Write("Enter your name >> ");
            name = Console.ReadLine();

            Console.Write("Hello {0}! Enter the name of your boss >> ", name);
            bossName = Console.ReadLine();

            areNamesTheSame = String.Equals(name, bossName);

            Console.WriteLine(
                "It is {0} that you are your own boss",
                areNamesTheSame
            );

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
