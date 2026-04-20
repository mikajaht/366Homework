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
            Console.WriteLine("Homework 8");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();

            return Console.ReadLine();
        }

        private static bool Run(string exeArg)
        {
            switch (exeArg.ToLower())
            {
                case "1":
                    DoExe1();
                    Pause();
                    return true;

                case "2":
                    DoExe2();
                    Pause();
                    return true;

                case "3":
                    DoExe3();
                    Pause();
                    return true;

                case "4":
                    DoExe4();
                    Pause();
                    return true;

                case "e":
                    Console.WriteLine("Exiting the Program!");
                    return false;

                default:
                    Console.WriteLine("Invalid selection.");
                    Pause();
                    return true;
            }
        }

        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");
            Console.WriteLine();

            Job job1 = new Job(111, "Smith", "exterior paint", 20);
            Job job2 = new Job(222, "Vega", "gutter clean", 4);
            Job job3 = new Job(111, "Land", "blacktop drive", 10);

            Console.WriteLine(job1);
            Console.WriteLine(job2);
            Console.WriteLine(job3);
            Console.WriteLine();

            CompareJobs(job1, job2);
            CompareJobs(job1, job3);
        }

        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");
            Console.WriteLine();

            Job[] jobs = new Job[5];
            int count = 0;
            double total = 0;

            while (count < jobs.Length)
            {
                Console.Write("Enter job number: ");
                int jobNumber = int.Parse(Console.ReadLine());

                if (DuplicateJobNumber(jobs, count, jobNumber))
                {
                    Console.WriteLine($"Sorry, the job number {jobNumber} is a duplicate.");
                    Console.WriteLine("Please reenter the job.");
                    Console.WriteLine();
                    continue;
                }

                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();

                Console.Write("Enter job description: ");
                string desc = Console.ReadLine();

                Console.Write("Enter estimated hours for job: ");
                double hours = double.Parse(Console.ReadLine());

                jobs[count] = new Job(jobNumber, name, desc, hours);
                count++;
                Console.WriteLine();
            }

            Console.WriteLine("Summary:");
            Console.WriteLine();

            foreach (var job in jobs)
            {
                Console.WriteLine(job);
                total += job.Price;
            }

            Console.WriteLine();
            Console.WriteLine($"Total for all jobs is {total:C2}");
        }

        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");
            Console.WriteLine();

            RushJob[] jobs = new RushJob[5];
            int count = 0;
            double total = 0;

            while (count < jobs.Length)
            {
                Console.Write("Enter job number: ");
                int jobNumber = int.Parse(Console.ReadLine());

                if (DuplicateRushJobNumber(jobs, count, jobNumber))
                {
                    Console.WriteLine($"Sorry, the job number {jobNumber} is a duplicate.");
                    Console.WriteLine("Please reenter the job.");
                    Console.WriteLine();
                    continue;
                }

                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();

                Console.Write("Enter job description: ");
                string desc = Console.ReadLine();

                Console.Write("Enter estimated hours for job: ");
                double hours = double.Parse(Console.ReadLine());

                jobs[count] = new RushJob(jobNumber, name, desc, hours);
                count++;
                Console.WriteLine();
            }

            Console.WriteLine("Summary:");
            Console.WriteLine();

            foreach (var job in jobs)
            {
                Console.WriteLine(job);
                total += job.Price;
            }

            Console.WriteLine();
            Console.WriteLine($"Total for all jobs is {total:C2}");
        }

        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");
            Console.WriteLine();

            Customer c = new Customer();
            FrequentCustomer fc = new FrequentCustomer();

            c.CustNum = 2514;
            c.CustBalance = 765.00;

            fc.CustNum = 5719;
            fc.CustBalance = 2500.00;
            fc.DiscountRate = 0.15;

            Console.WriteLine("A regular customer #{0} owes {1}",
                c.CustNum,
                c.CustBalance.ToString("C2"));

            Console.WriteLine("A frequent customer #{0} would owe {1} without the discount",
                fc.CustNum,
                fc.CustBalance.ToString("C2"));

            double newBal = (1 - fc.DiscountRate) * fc.CustBalance;

            Console.WriteLine("...with {0} discount, customer owes {1}",
                fc.DiscountRate.ToString("P"),
                newBal.ToString("C2"));
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }

        private static void CompareJobs(Job a, Job b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine($"{a.JobNumber} for {a.CustomerName} has the same job number as {b.JobNumber} for {b.CustomerName}");
            }
            else
            {
                Console.WriteLine($"{a.JobNumber} for {a.CustomerName} does NOT have the same job number as {b.JobNumber} for {b.CustomerName}");
            }
        }

        private static bool DuplicateJobNumber(Job[] jobs, int count, int num)
        {
            for (int i = 0; i < count; i++)
            {
                if (jobs[i].JobNumber == num)
                    return true;
            }
            return false;
        }

        private static bool DuplicateRushJobNumber(RushJob[] jobs, int count, int num)
        {
            for (int i = 0; i < count; i++)
            {
                if (jobs[i].JobNumber == num)
                    return true;
            }
            return false;
        }
    }
}