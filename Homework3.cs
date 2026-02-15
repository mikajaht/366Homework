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
            Console.Clear();
            Console.WriteLine("Homework 3 - Making Decisions");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (140-char message check).");
            Console.WriteLine("Hit [2] to run Exercise 2 (Admissions).");
            Console.WriteLine("Hit [3] to run Exercise 3 (Rock Paper Scissors).");
            Console.WriteLine("Hit [4] to run Exercise 4 (Debug Tuition).");
            Console.WriteLine("Hit [5] to run Exercise 5 (Debug Hot Dog Order).");
            Console.WriteLine();
            Console.WriteLine("Hit [E] to Exit.");
            Console.WriteLine();
            Console.Write("Choice: ");

            return Console.ReadLine();
        }

        public static void Run(string choice)
        {
            Console.Clear();

            switch (choice.ToUpper())
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
                case "E":
                    // exit handled by loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Pause();
                    break;
            }
        }

        // --------------------------
        // Exercise 1
        // --------------------------
        // Accept a user's message and determine if it's <= 140 characters.
        public static void Exercise1()
        {
            Console.WriteLine("Exercise 1 - Social Message Length Checker");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter your message: ");
            string message = Console.ReadLine() ?? "";

            int length = message.Length;
            Console.WriteLine();
            Console.WriteLine($"Message length: {length} characters");

            if (length <= 140)
                Console.WriteLine("Status: OK (Message fits within 140 characters)");
            else
                Console.WriteLine($"Status: TOO LONG (Over by {length - 140} characters)");

            Pause();
        }

        // --------------------------
        // Exercise 2
        // --------------------------
        // Admission: Accept/Reject based on GPA and test score rules.
        public static void Exercise2()
        {
            Console.WriteLine("Exercise 2 - College Admissions");
            Console.WriteLine("-------------------------------");

            double gpa = ReadDouble("Enter GPA (example 3.2): ");
            int score = ReadInt("Enter admission test score: ");

            Console.WriteLine();

            bool accept =
                (gpa >= 3.0 && score >= 60) ||
                (gpa < 3.0 && score >= 80);

            if (accept)
                Console.WriteLine("Decision: Accept");
            else
                Console.WriteLine("Decision: Reject");

            Pause();
        }

        // --------------------------
        // Exercise 3
        // --------------------------
        // Rock Paper Scissors (user vs computer).
        public static void Exercise3()
        {
            Console.WriteLine("Exercise 3 - Rock Paper Scissors");
            Console.WriteLine("--------------------------------");

            Console.Write("Choose Rock, Paper, or Scissors: ");
            string userChoice = (Console.ReadLine() ?? "").Trim().ToUpper();

            // Validate input
            while (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS")
            {
                Console.Write("Invalid choice. Type Rock, Paper, or Scissors: ");
                userChoice = (Console.ReadLine() ?? "").Trim().ToUpper();
            }

            // Computer choice
            string[] options = { "ROCK", "PAPER", "SCISSORS" };
            Random rng = new Random();
            string computerChoice = options[rng.Next(options.Length)];

            Console.WriteLine();
            Console.WriteLine($"You chose: {userChoice}");
            Console.WriteLine($"Computer chose: {computerChoice}");
            Console.WriteLine();

            // Determine winner
            if (userChoice == computerChoice)
            {
                Console.WriteLine("Result: Tie!");
            }
            else if (
                (userChoice == "ROCK" && computerChoice == "SCISSORS") ||
                (userChoice == "SCISSORS" && computerChoice == "PAPER") ||
                (userChoice == "PAPER" && computerChoice == "ROCK"))
            {
                Console.WriteLine("Result: You win!");
            }
            else
            {
                Console.WriteLine("Result: Computer wins!");
            }

            Pause();
        }

        // --------------------------
        // Exercise 4
        // --------------------------
        // Debugged tuition program.
        public static void Exercise4()
        {
            Console.WriteLine("Exercise 4 - Debugged Tuition Program");
            Console.WriteLine("-------------------------------------");

            // Program decides tuition based on several criteria:
            // 1 - 12 credit hours @ $150 per credit hour
            // 13 - 18 credit hours, flat fee $1900
            // over 18 hours, $1900 plus $100 per credit hour over 18
            // If year in school is 4, there is a 15% discount

            int credits, year;
            string inputString;
            double tuition;

            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 150.00;     // fixed (was 15000)
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;

            Console.Write("How many credits? ");
            inputString = Console.ReadLine() ?? "0";
            credits = Convert.ToInt32(inputString);

            Console.Write("Year in school? ");
            inputString = Console.ReadLine() ?? "0"; // fixed Readline -> ReadLine
            year = Convert.ToInt32(inputString);

            // fixed logic:
            // If credits <= 12 -> per credit
            // If 13-18 -> flat
            // If >18 -> flat + extra
            if (credits <= LOWCREDITS)
                tuition = HOURFEE * credits;
            else if (credits <= HIGHCREDITS)
                tuition = FLAT;
            else
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;

            // fixed senior discount condition:
            // discount if year == 4
            if (year == SENIORYEAR)
                tuition = tuition - (tuition * DISCOUNT);

            Console.WriteLine();
            Console.WriteLine("For year {0}, with {1} credits", year, credits);
            Console.WriteLine("Tuition is {0}", tuition.ToString("C"));

            Pause();
        }

        // --------------------------
        // Exercise 5
        // --------------------------
        // Debugged hot dog order program.
        public static void Exercise5()
        {
            Console.WriteLine("Exercise 5 - Debugged Hot Dog Order");
            Console.WriteLine("-----------------------------------");

            // Program takes a hot dog order and determines price

            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;

            string wantChili, wantCheese;
            double price = BASIC_DOG_PRICE; // start with base price

            Console.Write("Do you want chili on your dog? (Y/N): ");
            wantChili = (Console.ReadLine() ?? "").Trim().ToUpper();

            Console.Write("Do you want cheese on your dog? (Y/N): ");
            wantCheese = (Console.ReadLine() ?? "").Trim().ToUpper();

            // fixed comparisons (== not =), fixed variable spelling, fixed math assignment (= not ==)
            if (wantChili == "Y")
                price += CHILI_PRICE;

            if (wantCheese == "Y")
                price += CHEESE_PRICE;

            Console.WriteLine();
            Console.WriteLine("Your total is {0}", price.ToString("C"));

            Pause();
        }

        // --------------------------
        // Helper Methods
        // --------------------------
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public static int ReadInt(string prompt)
        {
            int value;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number. Try again: ");
            }
            return value;
        }

        public static double ReadDouble(string prompt)
        {
            double value;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid number. Try again: ");
            }
            return value;
        }
    }
}
