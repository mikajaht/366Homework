using _366Homework;
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
            Console.WriteLine("Homework 7");
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

            Console.WriteLine("1");

            SalesTransaction s1 = new SalesTransaction("Abbott", 2000, 0.20);
            SalesTransaction s2 = new SalesTransaction("Bender", 4000);
            SalesTransaction s3 = new SalesTransaction("Carter");
            SalesTransaction total = s1 + s2 + s3;

            Display(s1);
            Display(s2);
            Display(s3);
            DisplayTotal(total);

            Pause();
        }
        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("2");

            Room[] rooms = new Room[8];
            int x;
            int len = 8;
            int wid = 8;
            int high = 8;

            for (x = 0; x < rooms.Length; ++x)
            {
                rooms[x] = new Room(len, wid, high);
                len += 2;
                wid += 1;

                if (x % 2 == 1)
                {
                    high += 1;
                }
            }

            for (x = 0; x < rooms.Length; ++x)
            {
                Console.WriteLine("For a {0} X {1} X {2} foot room", rooms[x].Length, rooms[x].Width, rooms[x].Height);
                Console.WriteLine("    Two walls are {0} long and {1} high", rooms[x].Length, rooms[x].Height);
                Console.WriteLine("    and the other two walls are {0} long and {1} high", rooms[x].Width, rooms[x].Height);
                Console.WriteLine("    Total wall area is {0}, so you need {1} gallon(s) of paint.", rooms[x].Area, rooms[x].Gallons);
                Console.WriteLine();
            }

            Pause();
        }
        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("3");

            Sale[] sales = new Sale[10];

            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = new Sale();

                Console.Write("Enter inventory number #{0} >> ", i + 1);
                sales[i].InventoryNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter amount of sale >> ");
                sales[i].Amount = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Sale # {0} Amount: {1} Sale {2:C}", i + 1, sales[i].InventoryNumber, sales[i].Amount);
                Console.WriteLine("    Tax is {0:C}", sales[i].TaxOwed);
            }

            Pause();
        }
        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("4");

            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000);
            Car theirCar = new Car();

            Console.WriteLine("My {0} car cost {1}", myCar.Color, myCar.Price.ToString("C2"));
            Console.WriteLine("Your {0} car cost {1}", yourCar.Color, yourCar.Price.ToString("C2"));
            Console.WriteLine("Their {0} car cost {1}", theirCar.Color, theirCar.Price.ToString("C2"));

            Pause();
        }
        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("5");

            const int STARTINGNUM = 201601;
            BoatLicense[] license = new BoatLicense[3];
            int x;

            for (x = 0; x < license.Length; ++x)
            {
                license[x] = new BoatLicense();
                license[x].LicenseNum = "#" + x + STARTINGNUM;
            }

            license[0].State = "WI";
            license[1].State = "MI";
            license[2].State = "MN";

            license[0].MotorSizeInHP = 30;
            license[1].MotorSizeInHP = 50;
            license[2].MotorSizeInHP = 100;

            for (x = 0; x < license.Length; ++x)
            {
                Display(license[x]);
            }

            Pause();
        }

        public static void Display(SalesTransaction s)
        {
            Console.WriteLine("{0} had sales totaling {1}. Commission rate is {2}; commission value is {3}.",
                s.Name, s.SalesAmount, s.CommissionRate, s.Commission);
        }

        public static void DisplayTotal(SalesTransaction s)
        {
            Console.WriteLine("Total sales: {0:C}", s.SalesAmount);
        }

        public static void Display(BoatLicense b)
        {
            Console.WriteLine("Boat {0} from {1} has a {2} HP motor.", b.LicenseNum, b.State, b.MotorSizeInHP);
            Console.WriteLine("    The price for the license is {0:C}", b.Price);
            Console.WriteLine();
        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}