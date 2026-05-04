using System;
using System.IO;

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
            Console.WriteLine("Homework 10");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit");
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

                case "e":
                    return true;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    Pause();
                    return true;
            }
        }

        private static void DoExe1()
        {
            // Add code for Exercise 1 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            string directory;

            Console.WriteLine("1");

            Console.Write("Enter a directory >> ");
            directory = Console.ReadLine();

            while (directory.ToLower() != "end")
            {
                if (Directory.Exists(directory))
                {
                    string[] files = Directory.GetFiles(directory);

                    Console.WriteLine(directory + " contains the following files");

                    if (files.Length == 0)
                    {
                        Console.WriteLine("There are no files in this directory.");
                    }
                    else
                    {
                        foreach (string file in files)
                        {
                            Console.WriteLine("   " + file);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Directory " + directory + " does not exist");
                }

                Console.WriteLine();
                Console.Write("Enter another directory or type end to quit >> ");
                directory = Console.ReadLine();
            }

            Pause();
        }

        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            Console.WriteLine("2");

            Console.Write("Enter the full path of the Word file >> ");
            string wordFileName = Console.ReadLine();

            Console.Write("Enter the full path of the Notepad file >> ");
            string notepadFileName = Console.ReadLine();

            if (File.Exists(wordFileName) && File.Exists(notepadFileName))
            {
                FileInfo wordFileInfo = new FileInfo(wordFileName);
                FileInfo notepadFileInfo = new FileInfo(notepadFileName);

                long wordFileSize = wordFileInfo.Length;
                long notepadFileSize = notepadFileInfo.Length;

                double ratio = (double)notepadFileSize / wordFileSize * 100;

                Console.WriteLine();
                Console.WriteLine("The size of the Word file is " + wordFileSize);
                Console.WriteLine("and the size of the Notepad file is " + notepadFileSize);
                Console.WriteLine("The Notepad file is " + ratio.ToString("F2") + "% of the size of the Word file");
            }
            else
            {
                Console.WriteLine();

                if (!File.Exists(wordFileName))
                {
                    Console.WriteLine("The Word file does not exist.");
                }

                if (!File.Exists(notepadFileName))
                {
                    Console.WriteLine("The Notepad file does not exist.");
                }
            }

            Pause();
        }

        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.

            string fileName;
            string directory;
            string path;
            string[] files;
            int x;

            Console.WriteLine("3");

            Console.Write("Enter a directory: ");
            directory = Console.ReadLine();

            if (Directory.Exists(directory))
            {
                files = Directory.GetFiles(directory);

                if (files.Length == 0)
                {
                    Console.WriteLine("There are no files in " + directory);
                }
                else
                {
                    Console.WriteLine(directory + " contains the following files");

                    for (x = 0; x < files.Length; ++x)
                    {
                        Console.WriteLine(" " + files[x]);
                    }

                    Console.Write("\nEnter a file name: ");
                    fileName = Console.ReadLine();

                    path = Path.Combine(directory, fileName);

                    if (File.Exists(path))
                    {
                        Console.WriteLine("File exists and was created " + File.GetCreationTime(path));
                    }
                    else
                    {
                        Console.WriteLine(fileName + " does not exist in the " + directory + " directory");
                    }
                }
            }
            else
            {
                Console.WriteLine("Directory " + directory + " does not exist");
            }

            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}